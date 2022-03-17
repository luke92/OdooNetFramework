using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("account.journal")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class AccountJournalOdooModel : IOdooModel
    {

        /// <summary>
        /// name - char  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// code - char  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The journal entries of this journal will be named using this prefix. <br />
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// active - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Set active to false to hide the Journal without removing it. <br />
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// type_control_ids - many2many - account.account.type <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("type_control_ids")]
        public long[] TypeControlIds { get; set; }

        /// <summary>
        /// account_control_ids - many2many - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("account_control_ids")]
        public long[] AccountControlIds { get; set; }

        /// <summary>
        /// default_credit_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: It acts as a default account for credit amount <br />
        /// </summary>
        [JsonProperty("default_credit_account_id")]
        public long? DefaultCreditAccountId { get; set; }

        /// <summary>
        /// default_debit_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: It acts as a default account for debit amount <br />
        /// </summary>
        [JsonProperty("default_debit_account_id")]
        public long? DefaultDebitAccountId { get; set; }

        /// <summary>
        /// update_posted - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Check this box if you want to allow the cancellation the entries related to this journal or of the invoice related to this journal <br />
        /// </summary>
        [JsonProperty("update_posted")]
        public bool? UpdatePosted { get; set; }

        /// <summary>
        /// group_invoice_lines - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: If this box is checked, the system will try to group the accounting lines when generating them from invoices. <br />
        /// </summary>
        [JsonProperty("group_invoice_lines")]
        public bool? GroupInvoiceLines { get; set; }

        /// <summary>
        /// sequence_id - many2one - ir.sequence <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: This field contains the information related to the numbering of the journal entries of this journal. <br />
        /// </summary>
        [JsonProperty("sequence_id")]
        public long SequenceId { get; set; }

        /// <summary>
        /// refund_sequence_id - many2one - ir.sequence <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: This field contains the information related to the numbering of the credit note entries of this journal. <br />
        /// </summary>
        [JsonProperty("refund_sequence_id")]
        public long? RefundSequenceId { get; set; }

        /// <summary>
        /// sequence - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Used to order Journals in the dashboard view <br />
        /// </summary>
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        /// <summary>
        /// sequence_number_next - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: The next sequence number will be used for the next invoice. <br />
        /// </summary>
        [JsonProperty("sequence_number_next")]
        public int? SequenceNumberNext { get; set; }

        /// <summary>
        /// refund_sequence_number_next - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: The next sequence number will be used for the next credit note. <br />
        /// </summary>
        [JsonProperty("refund_sequence_number_next")]
        public int? RefundSequenceNumberNext { get; set; }

        /// <summary>
        /// currency_id - many2one - res.currency <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The currency used to enter statement <br />
        /// </summary>
        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        /// <summary>
        /// company_id - many2one - res.company <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Company related to this journal <br />
        /// </summary>
        [JsonProperty("company_id")]
        public long CompanyId { get; set; }

        /// <summary>
        /// refund_sequence - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Check this box if you don't want to share the same sequence for invoices and credit notes made from this journal <br />
        /// </summary>
        [JsonProperty("refund_sequence")]
        public bool? RefundSequence { get; set; }

        /// <summary>
        /// inbound_payment_method_ids - many2many - account.payment.method <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Manual: Get paid by cash, check or any other method outside of Odoo.; Electronic: Get paid automatically through a payment acquirer by requesting a transaction on a card saved by the customer when buying or subscribing online (payment token).; Batch Deposit: Encase several customer checks at once by generating a batch deposit to submit to your bank. When encoding the bank statement in Odoo,you are suggested to reconcile the transaction with the batch deposit. Enable this option from the settings. <br />
        /// </summary>
        [JsonProperty("inbound_payment_method_ids")]
        public long[] InboundPaymentMethodIds { get; set; }

        /// <summary>
        /// outbound_payment_method_ids - many2many - account.payment.method <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Manual:Pay bill by cash or any other method outside of Odoo.; Check:Pay bill by check and print it from Odoo.; SEPA Credit Transfer: Pay bill from a SEPA Credit Transfer file you submit to your bank. Enable this option from the settings. <br />
        /// </summary>
        [JsonProperty("outbound_payment_method_ids")]
        public long[] OutboundPaymentMethodIds { get; set; }

        /// <summary>
        /// at_least_one_inbound - boolean  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("at_least_one_inbound")]
        public bool? AtLeastOneInbound { get; set; }

        /// <summary>
        /// at_least_one_outbound - boolean  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("at_least_one_outbound")]
        public bool? AtLeastOneOutbound { get; set; }

        /// <summary>
        /// profit_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Used to register a profit when the ending balance of a cash register differs from what the system computes <br />
        /// </summary>
        [JsonProperty("profit_account_id")]
        public long? ProfitAccountId { get; set; }

        /// <summary>
        /// loss_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Used to register a loss when the ending balance of a cash register differs from what the system computes <br />
        /// </summary>
        [JsonProperty("loss_account_id")]
        public long? LossAccountId { get; set; }

        /// <summary>
        /// belongs_to_company - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("belongs_to_company")]
        public bool? BelongsToCompany { get; set; }

        /// <summary>
        /// company_partner_id - many2one - res.partner <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("company_partner_id")]
        public long? CompanyPartnerId { get; set; }

        /// <summary>
        /// bank_account_id - many2one - res.partner.bank <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("bank_account_id")]
        public long? BankAccountId { get; set; }

        /// <summary>
        /// bank_statements_source - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Defines how the bank statements will be registered <br />
        /// </summary>
        [JsonProperty("bank_statements_source")]
        public BankFeedsAccountJournalOdooEnum? BankStatementsSource { get; set; }

        /// <summary>
        /// bank_acc_number - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("bank_acc_number")]
        public string BankAccNumber { get; set; }

        /// <summary>
        /// bank_id - many2one - res.bank <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("bank_id")]
        public long? BankId { get; set; }

        /// <summary>
        /// post_at_bank_rec - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Whether or not the payments made in this journal should be generated in draft state, so that the related journal entries are only posted when performing bank reconciliation. <br />
        /// </summary>
        [JsonProperty("post_at_bank_rec")]
        public bool? PostAtBankRec { get; set; }

        /// <summary>
        /// alias_id - many2one - mail.alias <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("alias_id")]
        public long? AliasId { get; set; }

        /// <summary>
        /// alias_domain - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("alias_domain")]
        public string AliasDomain { get; set; }

        /// <summary>
        /// alias_name - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: It creates draft vendor bill by sending an email. <br />
        /// </summary>
        [JsonProperty("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// kanban_dashboard - text  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("kanban_dashboard")]
        public string KanbanDashboard { get; set; }

        /// <summary>
        /// kanban_dashboard_graph - text  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("kanban_dashboard_graph")]
        public string KanbanDashboardGraph { get; set; }

        /// <summary>
        /// show_on_dashboard - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Whether this journal should be displayed on the dashboard or not <br />
        /// </summary>
        [JsonProperty("show_on_dashboard")]
        public bool? ShowOnDashboard { get; set; }

        /// <summary>
        /// color - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("color")]
        public int? Color { get; set; }

        /// <summary>
        /// check_manual_sequencing - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Check this option if your pre-printed checks are not numbered. <br />
        /// </summary>
        [JsonProperty("check_manual_sequencing")]
        public bool? CheckManualSequencing { get; set; }

        /// <summary>
        /// check_sequence_id - many2one - ir.sequence <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: Checks numbering sequence. <br />
        /// </summary>
        [JsonProperty("check_sequence_id")]
        public long? CheckSequenceId { get; set; }

        /// <summary>
        /// check_next_number - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Sequence number of the next printed check. <br />
        /// </summary>
        [JsonProperty("check_next_number")]
        public int? CheckNextNumber { get; set; }

        /// <summary>
        /// check_printing_payment_method_selected - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Technical feature used to know whether check printing was enabled as payment method. <br />
        /// </summary>
        [JsonProperty("check_printing_payment_method_selected")]
        public bool? CheckPrintingPaymentMethodSelected { get; set; }

        /// <summary>
        /// next_synchronization - datetime  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("next_synchronization")]
        public DateTime? NextSynchronization { get; set; }

        /// <summary>
        /// account_online_journal_id - many2one - account.online.journal <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("account_online_journal_id")]
        public long? AccountOnlineJournalId { get; set; }

        /// <summary>
        /// account_online_provider_id - many2one - account.online.provider <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("account_online_provider_id")]
        public long? AccountOnlineProviderId { get; set; }

        /// <summary>
        /// synchronization_status - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Update status of provider account <br />
        /// </summary>
        [JsonProperty("synchronization_status")]
        public string SynchronizationStatus { get; set; }

        /// <summary>
        /// bank_statement_creation - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Defines when a new bank statement;                                                will be created when fetching new transactions;                                                from your bank account. <br />
        /// </summary>
        [JsonProperty("bank_statement_creation")]
        public CreationOfBankStatementsAccountJournalOdooEnum? BankStatementCreation { get; set; }

        /// <summary>
        /// type - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Select 'Sale' for customer invoices journals.; Select 'Purchase' for vendor bills journals.; Select 'Cash' or 'Bank' for journals that are used in customer or vendor payments.; Select 'General' for miscellaneous operations journals. <br />
        /// </summary>
        [JsonProperty("type")]
        public TypeAccountJournalOdooEnum Type { get; set; }

        /// <summary>
        /// id - integer  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// display_name - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// create_uid - many2one - res.users <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("create_uid")]
        public long? CreateUid { get; set; }

        /// <summary>
        /// create_date - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("create_date")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// write_uid - many2one - res.users <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("write_uid")]
        public long? WriteUid { get; set; }

        /// <summary>
        /// write_date - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("write_date")]
        public DateTime? WriteDate { get; set; }

        /// <summary>
        /// __last_update - datetime  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("__last_update")]
        public DateTime? LastUpdate { get; set; }

        /// <summary>
        /// x_studio_field_RVCeI - char  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("x_studio_field_RVCeI")]
        public string XStudioFieldRvcei { get; set; }

        /// <summary>
        /// x_studio_cuenta_contable - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("x_studio_cuenta_contable")]
        public string XStudioCuentaContable { get; set; }
    }


    /// <summary>
    /// Help: Defines how the bank statements will be registered
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BankFeedsAccountJournalOdooEnum
    {
        [EnumMember(Value = "undefined")]
        UndefinedYet = 1,

        [EnumMember(Value = "file_import")]
        ImportCSVOFX = 2,

        [EnumMember(Value = "online_sync")]
        AutomatedBankSynchronization = 3,
    }


    /// <summary>
    /// Help: Defines when a new bank statement <br />
    ///                                                will be created when fetching new transactions <br />
    ///                                                from your bank account.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreationOfBankStatementsAccountJournalOdooEnum
    {
        [EnumMember(Value = "none")]
        CreateOneStatementPerSynchronization = 1,

        [EnumMember(Value = "day")]
        CreateDailyStatements = 2,

        [EnumMember(Value = "week")]
        CreateWeeklyStatements = 3,

        [EnumMember(Value = "bimonthly")]
        CreateBiMonthlyStatements = 4,

        [EnumMember(Value = "month")]
        CreateMonthlyStatements = 5,
    }


    /// <summary>
    /// Help: Select 'Sale' for customer invoices journals. <br />
    /// Select 'Purchase' for vendor bills journals. <br />
    /// Select 'Cash' or 'Bank' for journals that are used in customer or vendor payments. <br />
    /// Select 'General' for miscellaneous operations journals.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeAccountJournalOdooEnum
    {
        [EnumMember(Value = "sale")]
        Sale = 1,

        [EnumMember(Value = "purchase")]
        Purchase = 2,

        [EnumMember(Value = "sale_debit")]
        SaleDebitNote = 3,

        [EnumMember(Value = "purchase_debit")]
        PurchaseDebitNote = 4,

        [EnumMember(Value = "cash")]
        Cash = 5,

        [EnumMember(Value = "bank")]
        Bank = 6,

        [EnumMember(Value = "general")]
        Miscellaneous = 7,
    }
}
