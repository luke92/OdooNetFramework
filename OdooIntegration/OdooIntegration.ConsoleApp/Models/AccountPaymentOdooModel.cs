using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("account.payment")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class AccountPaymentOdooModel : IOdooModel
    {

        // account.move
        // required
        [JsonProperty("move_id")]
        public long MoveId { get; set; }

        [JsonProperty("is_reconciled")]
        public bool? IsReconciled { get; set; }

        [JsonProperty("is_matched")]
        public bool? IsMatched { get; set; }

        // res.partner.bank
        [JsonProperty("partner_bank_id")]
        public long? PartnerBankId { get; set; }

        [JsonProperty("is_internal_transfer")]
        public bool? IsInternalTransfer { get; set; }

        [JsonProperty("qr_code")]
        public string QrCode { get; set; }

        // account.payment.method
        [JsonProperty("payment_method_id")]
        public long? PaymentMethodId { get; set; }

        // account.payment.method
        [JsonProperty("available_payment_method_ids")]
        public long[] AvailablePaymentMethodIds { get; set; }

        [JsonProperty("hide_payment_method")]
        public bool? HidePaymentMethod { get; set; }

        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        // required
        [JsonProperty("payment_type")]
        public PaymentTypeAccountPaymentOdooEnum PaymentType { get; set; }

        // required
        [JsonProperty("partner_type")]
        public PartnerTypeAccountPaymentOdooEnum PartnerType { get; set; }

        [JsonProperty("payment_reference")]
        public string PaymentReference { get; set; }

        // res.currency
        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        // res.partner
        [JsonProperty("partner_id")]
        public long? PartnerId { get; set; }

        // account.account
        [JsonProperty("destination_account_id")]
        public long? DestinationAccountId { get; set; }

        // account.move
        [JsonProperty("reconciled_invoice_ids")]
        public long[] ReconciledInvoiceIds { get; set; }

        [JsonProperty("reconciled_invoices_count")]
        public int? ReconciledInvoicesCount { get; set; }

        // account.move
        [JsonProperty("reconciled_bill_ids")]
        public long[] ReconciledBillIds { get; set; }

        [JsonProperty("reconciled_bills_count")]
        public int? ReconciledBillsCount { get; set; }

        // account.bank.statement
        [JsonProperty("reconciled_statement_ids")]
        public long[] ReconciledStatementIds { get; set; }

        [JsonProperty("reconciled_statements_count")]
        public int? ReconciledStatementsCount { get; set; }

        [JsonProperty("payment_method_code")]
        public string PaymentMethodCode { get; set; }

        [JsonProperty("show_partner_bank_account")]
        public bool? ShowPartnerBankAccount { get; set; }

        [JsonProperty("require_partner_bank_account")]
        public bool? RequirePartnerBankAccount { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        // payment.transaction
        [JsonProperty("payment_transaction_id")]
        public long? PaymentTransactionId { get; set; }

        // payment.token
        [JsonProperty("payment_token_id")]
        public long? PaymentTokenId { get; set; }

        // res.partner
        [JsonProperty("related_partner_ids")]
        public long[] RelatedPartnerIds { get; set; }

        // mail.activity
        [JsonProperty("activity_ids")]
        public long[] ActivityIds { get; set; }

        [JsonProperty("activity_state")]
        public ActivityStateAccountPaymentOdooEnum? ActivityState { get; set; }

        // res.users
        [JsonProperty("activity_user_id")]
        public long? ActivityUserId { get; set; }

        // mail.activity.type
        [JsonProperty("activity_type_id")]
        public long? ActivityTypeId { get; set; }

        [JsonProperty("activity_type_icon")]
        public string ActivityTypeIcon { get; set; }

        [JsonProperty("activity_date_deadline")]
        public DateTime? ActivityDateDeadline { get; set; }

        [JsonProperty("my_activity_date_deadline")]
        public DateTime? MyActivityDateDeadline { get; set; }

        [JsonProperty("activity_summary")]
        public string ActivitySummary { get; set; }

        [JsonProperty("activity_exception_decoration")]
        public ActivityExceptionDecorationAccountPaymentOdooEnum? ActivityExceptionDecoration { get; set; }

        [JsonProperty("activity_exception_icon")]
        public string ActivityExceptionIcon { get; set; }

        [JsonProperty("message_is_follower")]
        public bool? MessageIsFollower { get; set; }

        // mail.followers
        [JsonProperty("message_follower_ids")]
        public long[] MessageFollowerIds { get; set; }

        // res.partner
        [JsonProperty("message_partner_ids")]
        public long[] MessagePartnerIds { get; set; }

        // mail.channel
        [JsonProperty("message_channel_ids")]
        public long[] MessageChannelIds { get; set; }

        // mail.message
        [JsonProperty("message_ids")]
        public long[] MessageIds { get; set; }

        [JsonProperty("message_unread")]
        public bool? MessageUnread { get; set; }

        [JsonProperty("message_unread_counter")]
        public int? MessageUnreadCounter { get; set; }

        [JsonProperty("message_needaction")]
        public bool? MessageNeedaction { get; set; }

        [JsonProperty("message_needaction_counter")]
        public int? MessageNeedactionCounter { get; set; }

        [JsonProperty("message_has_error")]
        public bool? MessageHasError { get; set; }

        [JsonProperty("message_has_error_counter")]
        public int? MessageHasErrorCounter { get; set; }

        [JsonProperty("message_attachment_count")]
        public int? MessageAttachmentCount { get; set; }

        // ir.attachment
        [JsonProperty("message_main_attachment_id")]
        public long? MessageMainAttachmentId { get; set; }

        // mail.message
        [JsonProperty("website_message_ids")]
        public long[] WebsiteMessageIds { get; set; }

        [JsonProperty("message_has_sms_error")]
        public bool? MessageHasSmsError { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        // res.users
        [JsonProperty("create_uid")]
        public long? CreateUid { get; set; }

        [JsonProperty("create_date")]
        public DateTime? CreateDate { get; set; }

        // res.users
        [JsonProperty("write_uid")]
        public long? WriteUid { get; set; }

        [JsonProperty("write_date")]
        public DateTime? WriteDate { get; set; }

        [JsonProperty("__last_update")]
        public DateTime? LastUpdate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("highest_name")]
        public string HighestName { get; set; }

        [JsonProperty("show_name_warning")]
        public bool? ShowNameWarning { get; set; }

        // required
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("narration")]
        public string Narration { get; set; }

        // required
        [JsonProperty("state")]
        public StatusAccountPaymentOdooEnum State { get; set; }

        [JsonProperty("posted_before")]
        public bool? PostedBefore { get; set; }

        // required
        [JsonProperty("move_type")]
        public TypeAccountPaymentOdooEnum MoveType { get; set; }

        [JsonProperty("type_name")]
        public string TypeName { get; set; }

        [JsonProperty("to_check")]
        public bool? ToCheck { get; set; }

        // account.journal
        // required
        [JsonProperty("journal_id")]
        public long JournalId { get; set; }

        // account.journal
        [JsonProperty("suitable_journal_ids")]
        public long[] SuitableJournalIds { get; set; }

        // res.company
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        // res.currency
        [JsonProperty("company_currency_id")]
        public long? CompanyCurrencyId { get; set; }

        // account.move.line
        [JsonProperty("line_ids")]
        public long[] LineIds { get; set; }

        // res.partner
        [JsonProperty("commercial_partner_id")]
        public long? CommercialPartnerId { get; set; }

        // res.users
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        [JsonProperty("is_move_sent")]
        public bool? IsMoveSent { get; set; }

        // account.payment
        [JsonProperty("payment_id")]
        public long? PaymentId { get; set; }

        // account.bank.statement.line
        [JsonProperty("statement_line_id")]
        public long? StatementLineId { get; set; }

        [JsonProperty("amount_untaxed")]
        public decimal? AmountUntaxed { get; set; }

        [JsonProperty("amount_tax")]
        public decimal? AmountTax { get; set; }

        [JsonProperty("amount_total")]
        public decimal? AmountTotal { get; set; }

        [JsonProperty("amount_residual")]
        public decimal? AmountResidual { get; set; }

        [JsonProperty("amount_untaxed_signed")]
        public decimal? AmountUntaxedSigned { get; set; }

        [JsonProperty("amount_tax_signed")]
        public decimal? AmountTaxSigned { get; set; }

        [JsonProperty("amount_total_signed")]
        public decimal? AmountTotalSigned { get; set; }

        [JsonProperty("amount_residual_signed")]
        public decimal? AmountResidualSigned { get; set; }

        [JsonProperty("amount_by_group")]
        public string AmountByGroup { get; set; }

        [JsonProperty("payment_state")]
        public PaymentStatusAccountPaymentOdooEnum? PaymentState { get; set; }

        // account.partial.reconcile
        [JsonProperty("tax_cash_basis_rec_id")]
        public long? TaxCashBasisRecId { get; set; }

        // account.move
        [JsonProperty("tax_cash_basis_move_id")]
        public long? TaxCashBasisMoveId { get; set; }

        [JsonProperty("auto_post")]
        public bool? AutoPost { get; set; }

        // account.move
        [JsonProperty("reversed_entry_id")]
        public long? ReversedEntryId { get; set; }

        // account.move
        [JsonProperty("reversal_move_id")]
        public long[] ReversalMoveId { get; set; }

        // account.fiscal.position
        [JsonProperty("fiscal_position_id")]
        public long? FiscalPositionId { get; set; }

        // res.users
        [JsonProperty("invoice_user_id")]
        public long? InvoiceUserId { get; set; }

        [JsonProperty("invoice_date")]
        public DateTime? InvoiceDate { get; set; }

        [JsonProperty("invoice_date_due")]
        public DateTime? InvoiceDateDue { get; set; }

        [JsonProperty("invoice_origin")]
        public string InvoiceOrigin { get; set; }

        // account.payment.term
        [JsonProperty("invoice_payment_term_id")]
        public long? InvoicePaymentTermId { get; set; }

        // account.move.line
        [JsonProperty("invoice_line_ids")]
        public long[] InvoiceLineIds { get; set; }

        // account.incoterms
        [JsonProperty("invoice_incoterm_id")]
        public long? InvoiceIncotermId { get; set; }

        [JsonProperty("display_qr_code")]
        public bool? DisplayQrCode { get; set; }

        [JsonProperty("qr_code_method")]
        public PaymentQRCodeAccountPaymentOdooEnum? QrCodeMethod { get; set; }

        [JsonProperty("invoice_outstanding_credits_debits_widget")]
        public string InvoiceOutstandingCreditsDebitsWidget { get; set; }

        [JsonProperty("invoice_has_outstanding")]
        public bool? InvoiceHasOutstanding { get; set; }

        [JsonProperty("invoice_payments_widget")]
        public string InvoicePaymentsWidget { get; set; }

        // account.move
        [JsonProperty("invoice_vendor_bill_id")]
        public long? InvoiceVendorBillId { get; set; }

        [JsonProperty("invoice_source_email")]
        public string InvoiceSourceEmail { get; set; }

        [JsonProperty("invoice_partner_display_name")]
        public string InvoicePartnerDisplayName { get; set; }

        // account.cash.rounding
        [JsonProperty("invoice_cash_rounding_id")]
        public long? InvoiceCashRoundingId { get; set; }

        [JsonProperty("invoice_filter_type_domain")]
        public string InvoiceFilterTypeDomain { get; set; }

        // res.partner
        [JsonProperty("bank_partner_id")]
        public long? BankPartnerId { get; set; }

        [JsonProperty("invoice_has_matching_suspense_amount")]
        public bool? InvoiceHasMatchingSuspenseAmount { get; set; }

        [JsonProperty("tax_lock_date_message")]
        public string TaxLockDateMessage { get; set; }

        [JsonProperty("has_reconciled_entries")]
        public bool? HasReconciledEntries { get; set; }

        [JsonProperty("show_reset_to_draft_button")]
        public bool? ShowResetToDraftButton { get; set; }

        [JsonProperty("restrict_mode_hash_table")]
        public bool? RestrictModeHashTable { get; set; }

        [JsonProperty("secure_sequence_number")]
        public int? SecureSequenceNumber { get; set; }

        [JsonProperty("inalterable_hash")]
        public string InalterableHash { get; set; }

        [JsonProperty("string_to_hash")]
        public string StringToHash { get; set; }

        // account.edi.document
        [JsonProperty("edi_document_ids")]
        public long[] EdiDocumentIds { get; set; }

        [JsonProperty("edi_state")]
        public ElectronicInvoicingAccountPaymentOdooEnum? EdiState { get; set; }

        [JsonProperty("edi_error_count")]
        public int? EdiErrorCount { get; set; }

        [JsonProperty("edi_web_services_to_process")]
        public string EdiWebServicesToProcess { get; set; }

        [JsonProperty("edi_show_cancel_button")]
        public bool? EdiShowCancelButton { get; set; }

        [JsonProperty("duplicated_vendor_ref")]
        public string DuplicatedVendorRef { get; set; }

        // required
        [JsonProperty("extract_state")]
        public ExtractStateAccountPaymentOdooEnum ExtractState { get; set; }

        [JsonProperty("extract_status_code")]
        public int? ExtractStatusCode { get; set; }

        [JsonProperty("extract_error_message")]
        public string ExtractErrorMessage { get; set; }

        [JsonProperty("extract_remote_id")]
        public int? ExtractRemoteId { get; set; }

        // account.invoice_extract.words
        [JsonProperty("extract_word_ids")]
        public long[] ExtractWordIds { get; set; }

        [JsonProperty("extract_can_show_resend_button")]
        public bool? ExtractCanShowResendButton { get; set; }

        [JsonProperty("extract_can_show_send_button")]
        public bool? ExtractCanShowSendButton { get; set; }

        // payment.transaction
        [JsonProperty("transaction_ids")]
        public long[] TransactionIds { get; set; }

        // payment.transaction
        [JsonProperty("authorized_transaction_ids")]
        public long[] AuthorizedTransactionIds { get; set; }

        // account.move
        [JsonProperty("debit_origin_id")]
        public long? DebitOriginId { get; set; }

        // account.move
        [JsonProperty("debit_note_ids")]
        public long[] DebitNoteIds { get; set; }

        [JsonProperty("debit_note_count")]
        public int? DebitNoteCount { get; set; }

        [JsonProperty("l10n_latam_amount_untaxed")]
        public decimal? L10nLatamAmountUntaxed { get; set; }

        // account.move.line
        [JsonProperty("l10n_latam_tax_ids")]
        public long[] L10nLatamTaxIds { get; set; }

        // l10n_latam.document.type
        [JsonProperty("l10n_latam_available_document_type_ids")]
        public long[] L10nLatamAvailableDocumentTypeIds { get; set; }

        // l10n_latam.document.type
        [JsonProperty("l10n_latam_document_type_id")]
        public long? L10nLatamDocumentTypeId { get; set; }

        [JsonProperty("l10n_latam_document_number")]
        public string L10nLatamDocumentNumber { get; set; }

        [JsonProperty("l10n_latam_use_documents")]
        public bool? L10nLatamUseDocuments { get; set; }

        [JsonProperty("l10n_latam_manual_document_number")]
        public bool? L10nLatamManualDocumentNumber { get; set; }

        // l10n_ar.afip.responsibility.type
        [JsonProperty("l10n_ar_afip_responsibility_type_id")]
        public long? L10nArAfipResponsibilityTypeId { get; set; }

        [JsonProperty("l10n_ar_currency_rate")]
        public double? L10nArCurrencyRate { get; set; }

        [JsonProperty("l10n_ar_afip_concept")]
        public AFIPConceptAccountPaymentOdooEnum? L10nArAfipConcept { get; set; }

        [JsonProperty("l10n_ar_afip_service_start")]
        public DateTime? L10nArAfipServiceStart { get; set; }

        [JsonProperty("l10n_ar_afip_service_end")]
        public DateTime? L10nArAfipServiceEnd { get; set; }

        [JsonProperty("access_url")]
        public string AccessUrl { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("access_warning")]
        public string AccessWarning { get; set; }

        [JsonProperty("sequence_prefix")]
        public string SequencePrefix { get; set; }

        [JsonProperty("sequence_number")]
        public int? SequenceNumber { get; set; }

        #region ODOO V12 GECSA

        [JsonProperty("move_name")]
        public string MoveName { get; set; }

        // account.journal
        [JsonProperty("destination_journal_id")]
        public long? DestinationJournalId { get; set; }

        // account.invoice
        [JsonProperty("invoice_ids")]
        public long[] InvoiceIds { get; set; }

        [JsonProperty("has_invoices")]
        public bool? HasInvoices { get; set; }

        // account.move.line
        [JsonProperty("move_line_ids")]
        public long[] MoveLineIds { get; set; }

        [JsonProperty("move_reconciled")]
        public bool? MoveReconciled { get; set; }

        // account.batch.payment
        [JsonProperty("batch_payment_id")]
        public long? BatchPaymentId { get; set; }

        [JsonProperty("check_amount_in_words")]
        public string CheckAmountInWords { get; set; }

        [JsonProperty("check_manual_sequencing")]
        public bool? CheckManualSequencing { get; set; }

        [JsonProperty("check_number")]
        public int? CheckNumber { get; set; }

        // res.partner
        [JsonProperty("beneficiario")]
        public long? Beneficiario { get; set; }

        [JsonProperty("broker")]
        public bool? Broker { get; set; }

        [JsonProperty("x_studio_no_de_cheque")]
        public string XStudioNoDeCheque { get; set; }

        [JsonProperty("text_amount")]
        public string TextAmount { get; set; }

        [JsonProperty("type_currencychange")]
        public double? TypeCurrencychange { get; set; }

        [JsonProperty("norecb")]
        public string Norecb { get; set; }

        [JsonProperty("tds")]
        public bool? Tds { get; set; }

        // payment.way
        [JsonProperty("payment_way")]
        public long? PaymentWay { get; set; }

        // payment.tds
        [JsonProperty("withholdings")]
        public long[] Withholdings { get; set; }

        // required
        [JsonProperty("base")]
        public decimal? Base { get; set; }

        [JsonProperty("amount_payable")]
        public decimal? AmountPayable { get; set; }

        // account.tax
        [JsonProperty("accounttax")]
        public long[] Accounttax { get; set; }

        [JsonProperty("no_autorizado")]
        public string NoAutorizado { get; set; }

        [JsonProperty("no_contrato")]
        public string NoContrato { get; set; }

        // res.company
        [JsonProperty("company_actual")]
        public long? CompanyActual { get; set; }

        [JsonProperty("multi")]
        public bool? Multi { get; set; }

        // required
        [JsonProperty("payment_date")]
        public DateTime? PaymentDate { get; set; }

        [JsonProperty("communication")]
        public string Communication { get; set; }

        [JsonProperty("payment_difference")]
        public decimal? PaymentDifference { get; set; }

        [JsonProperty("payment_difference_handling")]
        public PaymentDifferenceHandlingAccountPaymentOdooEnum? PaymentDifferenceHandling { get; set; }

        // account.account
        [JsonProperty("writeoff_account_id")]
        public long? WriteoffAccountId { get; set; }

        [JsonProperty("writeoff_label")]
        public string WriteoffLabel { get; set; }

        // res.partner.bank
        [JsonProperty("partner_bank_account_id")]
        public long? PartnerBankAccountId { get; set; }

        [JsonProperty("x_studio_test")]
        public string XStudioTest { get; set; }

        #endregion

    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentTypeAccountPaymentOdooEnum
    {
        [EnumMember(Value = "outbound")]
        SendMoney = 1,

        [EnumMember(Value = "inbound")]
        ReceiveMoney = 2,
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PartnerTypeAccountPaymentOdooEnum
    {
        [EnumMember(Value = "customer")]
        Customer = 1,

        [EnumMember(Value = "supplier")]
        Vendor = 2,
    }


    // Status based on activities
    // Overdue: Due date is already passed
    // Today: Activity date is today
    // Planned: Future activities.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActivityStateAccountPaymentOdooEnum
    {
        [EnumMember(Value = "overdue")]
        Overdue = 1,

        [EnumMember(Value = "today")]
        Today = 2,

        [EnumMember(Value = "planned")]
        Planned = 3,
    }


    // Type of the exception activity on record.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActivityExceptionDecorationAccountPaymentOdooEnum
    {
        [EnumMember(Value = "warning")]
        Alert = 1,

        [EnumMember(Value = "danger")]
        Error = 2,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusAccountPaymentOdooEnum
    {
        [EnumMember(Value = "draft")]
        Draft = 1,

        [EnumMember(Value = "posted")]
        Posted = 2,

        [EnumMember(Value = "cancel")]
        Cancelled = 3,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeAccountPaymentOdooEnum
    {
        [EnumMember(Value = "entry")]
        JournalEntry = 1,

        [EnumMember(Value = "out_invoice")]
        CustomerInvoice = 2,

        [EnumMember(Value = "out_refund")]
        CustomerCreditNote = 3,

        [EnumMember(Value = "in_invoice")]
        VendorBill = 4,

        [EnumMember(Value = "in_refund")]
        VendorCreditNote = 5,

        [EnumMember(Value = "out_receipt")]
        SalesReceipt = 6,

        [EnumMember(Value = "in_receipt")]
        PurchaseReceipt = 7,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentStatusAccountPaymentOdooEnum
    {
        [EnumMember(Value = "not_paid")]
        NotPaid = 1,

        [EnumMember(Value = "in_payment")]
        InPayment = 2,

        [EnumMember(Value = "paid")]
        Paid = 3,

        [EnumMember(Value = "partial")]
        PartiallyPaid = 4,

        [EnumMember(Value = "reversed")]
        Reversed = 5,

        [EnumMember(Value = "invoicing_legacy")]
        InvoicingAppLegacy = 6,
    }


    // Type of QR-code to be generated for the payment of this invoice, when printing it. If left blank, the first available and usable method will be used.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentQRCodeAccountPaymentOdooEnum
    {
    }


    // The aggregated state of all the EDIs of this move
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ElectronicInvoicingAccountPaymentOdooEnum
    {
        [EnumMember(Value = "to_send")]
        ToSend = 1,

        [EnumMember(Value = "sent")]
        Sent = 2,

        [EnumMember(Value = "to_cancel")]
        ToCancel = 3,

        [EnumMember(Value = "cancelled")]
        Cancelled = 4,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExtractStateAccountPaymentOdooEnum
    {
        [EnumMember(Value = "no_extract_requested")]
        NoExtractRequested = 1,

        [EnumMember(Value = "not_enough_credit")]
        NotEnoughCredit = 2,

        [EnumMember(Value = "error_status")]
        AnErrorOccurred = 3,

        [EnumMember(Value = "waiting_extraction")]
        WaitingExtraction = 4,

        [EnumMember(Value = "extract_not_ready")]
        WaitingExtractionButItIsNotReady = 5,

        [EnumMember(Value = "waiting_validation")]
        WaitingValidation = 6,

        [EnumMember(Value = "done")]
        CompletedFlow = 7,
    }


    // A concept is suggested regarding the type of the products on the invoice but it is allowed to force a different type if required.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AFIPConceptAccountPaymentOdooEnum
    {
        [EnumMember(Value = "1")]
        ProductsDefinitiveExportOfGoods = 1,

        [EnumMember(Value = "2")]
        Services = 2,

        [EnumMember(Value = "3")]
        ProductsAndServices = 3,

        [EnumMember(Value = "4")]
        OtherExport = 4,
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentDifferenceHandlingAccountPaymentOdooEnum
    {
        [EnumMember(Value = "open")]
        KeepOpen = 1,

        [EnumMember(Value = "reconcile")]
        MarkInvoiceAsFullyPaid = 2,
    }

}
