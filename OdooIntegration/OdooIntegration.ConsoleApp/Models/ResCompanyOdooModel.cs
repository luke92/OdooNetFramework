using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("res.company")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ResCompanyOdooModel : IOdooModel
    {

        /// <summary>
        /// name - char  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// sequence - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Used to order Companies in the company switcher <br />
        /// </summary>
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        /// <summary>
        /// parent_id - many2one - res.company <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("parent_id")]
        public long? ParentId { get; set; }

        /// <summary>
        /// child_ids - one2many - res.company (parent_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("child_ids")]
        public long[] ChildIds { get; set; }

        /// <summary>
        /// partner_id - many2one - res.partner <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("partner_id")]
        public long PartnerId { get; set; }

        /// <summary>
        /// report_header - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Appears by default on the top right corner of your printed documents (report header). <br />
        /// </summary>
        [JsonProperty("report_header")]
        public string ReportHeader { get; set; }

        /// <summary>
        /// report_footer - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Footer text displayed at the bottom of all reports. <br />
        /// </summary>
        [JsonProperty("report_footer")]
        public string ReportFooter { get; set; }

        /*
        /// <summary>
        /// logo - binary  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: This field holds the image used as avatar for this contact, limited to 1024x1024px <br />
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// logo_web - binary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("logo_web")]
        public string LogoWeb { get; set; }
        */

        /// <summary>
        /// currency_id - many2one - res.currency <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("currency_id")]
        public long CurrencyId { get; set; }

        /// <summary>
        /// user_ids - many2many - res.users <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("user_ids")]
        public long[] UserIds { get; set; }

        /// <summary>
        /// account_no - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// street - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// street2 - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("street2")]
        public string Street2 { get; set; }

        /// <summary>
        /// zip - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// city - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// state_id - many2one - res.country.state <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("state_id")]
        public long? StateId { get; set; }

        /// <summary>
        /// bank_ids - one2many - res.partner.bank (company_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Bank accounts related to this company <br />
        /// </summary>
        [JsonProperty("bank_ids")]
        public long[] BankIds { get; set; }

        /// <summary>
        /// country_id - many2one - res.country <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("country_id")]
        public long? CountryId { get; set; }

        /// <summary>
        /// email - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// website - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("website")]
        public string Website { get; set; }

        /// <summary>
        /// vat - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: The Tax Identification Number. Complete it if the contact is subjected to government taxes. Used in some legal statements. <br />
        /// </summary>
        [JsonProperty("vat")]
        public string Vat { get; set; }

        /// <summary>
        /// paperformat_id - many2one - report.paperformat <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("paperformat_id")]
        public long? PaperformatId { get; set; }

        /// <summary>
        /// external_report_layout_id - many2one - ir.ui.view <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("external_report_layout_id")]
        public long? ExternalReportLayoutId { get; set; }

        /// <summary>
        /// base_onboarding_company_state - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("base_onboarding_company_state")]
        public StateOfTheOnboardingCompanyStepResCompanyOdooEnum? BaseOnboardingCompanyState { get; set; }

        /// <summary>
        /// asfc - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("asfc")]
        public string Asfc { get; set; }

        /// <summary>
        /// resource_calendar_ids - one2many - resource.calendar (company_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("resource_calendar_ids")]
        public long[] ResourceCalendarIds { get; set; }

        /// <summary>
        /// resource_calendar_id - many2one - resource.calendar <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("resource_calendar_id")]
        public long? ResourceCalendarId { get; set; }

        /// <summary>
        /// social_twitter - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("social_twitter")]
        public string SocialTwitter { get; set; }

        /// <summary>
        /// social_facebook - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("social_facebook")]
        public string SocialFacebook { get; set; }

        /// <summary>
        /// social_github - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("social_github")]
        public string SocialGithub { get; set; }

        /// <summary>
        /// social_linkedin - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("social_linkedin")]
        public string SocialLinkedin { get; set; }

        /// <summary>
        /// social_youtube - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("social_youtube")]
        public string SocialYoutube { get; set; }

        /// <summary>
        /// social_googleplus - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("social_googleplus")]
        public string SocialGoogleplus { get; set; }

        /// <summary>
        /// social_instagram - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("social_instagram")]
        public string SocialInstagram { get; set; }

        /// <summary>
        /// nomenclature_id - many2one - barcode.nomenclature <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("nomenclature_id")]
        public long? NomenclatureId { get; set; }

        /// <summary>
        /// catchall - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("catchall")]
        public string Catchall { get; set; }

        /// <summary>
        /// snailmail_color - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("snailmail_color")]
        public bool? SnailmailColor { get; set; }

        /// <summary>
        /// snailmail_duplex - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("snailmail_duplex")]
        public bool? SnailmailDuplex { get; set; }

        /// <summary>
        /// propagation_minimum_delta - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("propagation_minimum_delta")]
        public int? PropagationMinimumDelta { get; set; }

        /// <summary>
        /// internal_transit_location_id - many2one - stock.location <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Technical field used for resupply routes between warehouses that belong to this company <br />
        /// </summary>
        [JsonProperty("internal_transit_location_id")]
        public long? InternalTransitLocationId { get; set; }

        /*
        /// <summary>
        /// background_image - binary  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("background_image")]
        public string BackgroundImage { get; set; }
        */

        /// <summary>
        /// payment_acquirer_onboarding_state - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("payment_acquirer_onboarding_state")]
        public StateOfTheOnboardingPaymentAcquirerStepResCompanyOdooEnum? PaymentAcquirerOnboardingState { get; set; }

        /// <summary>
        /// payment_onboarding_payment_method - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("payment_onboarding_payment_method")]
        public SelectedOnboardingPaymentMethodResCompanyOdooEnum? PaymentOnboardingPaymentMethod { get; set; }

        /*
        /// <summary>
        /// fiscalyear_last_day - integer  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("fiscalyear_last_day")]
        public int FiscalyearLastDay { get; set; }

        
        /// <summary>
        /// fiscalyear_last_month - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("fiscalyear_last_month")]
        public FiscalyearLastMonthResCompanyOdooEnum FiscalyearLastMonth { get; set; }
        */

        /// <summary>
        /// period_lock_date - date  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Only users with the 'Adviser' role can edit accounts prior to and inclusive of this date. Use it for period locking inside an open fiscal year, for example. <br />
        /// </summary>
        [JsonProperty("period_lock_date")]
        public DateTime? PeriodLockDate { get; set; }

        /// <summary>
        /// fiscalyear_lock_date - date  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: No users, including Advisers, can edit accounts prior to and inclusive of this date. Use it for fiscal year locking for example. <br />
        /// </summary>
        [JsonProperty("fiscalyear_lock_date")]
        public DateTime? FiscalyearLockDate { get; set; }

        /// <summary>
        /// transfer_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Intermediary account used when moving money from a liquidity account to another <br />
        /// </summary>
        [JsonProperty("transfer_account_id")]
        public long? TransferAccountId { get; set; }

        /// <summary>
        /// expects_chart_of_accounts - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("expects_chart_of_accounts")]
        public bool? ExpectsChartOfAccounts { get; set; }

        /// <summary>
        /// chart_template_id - many2one - account.chart.template <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The chart template for the company (if any) <br />
        /// </summary>
        [JsonProperty("chart_template_id")]
        public long? ChartTemplateId { get; set; }

        /// <summary>
        /// bank_account_code_prefix - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("bank_account_code_prefix")]
        public string BankAccountCodePrefix { get; set; }

        /// <summary>
        /// cash_account_code_prefix - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("cash_account_code_prefix")]
        public string CashAccountCodePrefix { get; set; }

        /// <summary>
        /// transfer_account_code_prefix - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("transfer_account_code_prefix")]
        public string TransferAccountCodePrefix { get; set; }

        /// <summary>
        /// account_sale_tax_id - many2one - account.tax <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("account_sale_tax_id")]
        public long? AccountSaleTaxId { get; set; }

        /// <summary>
        /// account_purchase_tax_id - many2one - account.tax <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("account_purchase_tax_id")]
        public long? AccountPurchaseTaxId { get; set; }

        /// <summary>
        /// tax_cash_basis_journal_id - many2one - account.journal <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("tax_cash_basis_journal_id")]
        public long? TaxCashBasisJournalId { get; set; }

        /// <summary>
        /// tax_calculation_rounding_method - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("tax_calculation_rounding_method")]
        public TaxCalculationRoundingMethodResCompanyOdooEnum? TaxCalculationRoundingMethod { get; set; }

        /// <summary>
        /// currency_exchange_journal_id - many2one - account.journal <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("currency_exchange_journal_id")]
        public long? CurrencyExchangeJournalId { get; set; }

        /// <summary>
        /// income_currency_exchange_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: It acts as a default account for credit amount <br />
        /// </summary>
        [JsonProperty("income_currency_exchange_account_id")]
        public long? IncomeCurrencyExchangeAccountId { get; set; }

        /// <summary>
        /// expense_currency_exchange_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: It acts as a default account for debit amount <br />
        /// </summary>
        [JsonProperty("expense_currency_exchange_account_id")]
        public long? ExpenseCurrencyExchangeAccountId { get; set; }

        /// <summary>
        /// anglo_saxon_accounting - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("anglo_saxon_accounting")]
        public bool? AngloSaxonAccounting { get; set; }

        /// <summary>
        /// property_stock_account_input_categ_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("property_stock_account_input_categ_id")]
        public long? PropertyStockAccountInputCategId { get; set; }

        /// <summary>
        /// property_stock_account_output_categ_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("property_stock_account_output_categ_id")]
        public long? PropertyStockAccountOutputCategId { get; set; }

        /// <summary>
        /// property_stock_valuation_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("property_stock_valuation_account_id")]
        public long? PropertyStockValuationAccountId { get; set; }

        /// <summary>
        /// bank_journal_ids - one2many - account.journal (company_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("bank_journal_ids")]
        public long[] BankJournalIds { get; set; }

        /// <summary>
        /// overdue_msg - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("overdue_msg")]
        public string OverdueMsg { get; set; }

        /// <summary>
        /// tax_exigibility - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("tax_exigibility")]
        public bool? TaxExigibility { get; set; }

        /// <summary>
        /// account_bank_reconciliation_start - date  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The bank reconciliation widget won't ask to reconcile payments older than this date.;                                                                                                        This is useful if you install accounting after having used invoicing for some time and;                                                                                                        don't want to reconcile all the past payments with bank statements. <br />
        /// </summary>
        [JsonProperty("account_bank_reconciliation_start")]
        public DateTime? AccountBankReconciliationStart { get; set; }

        /// <summary>
        /// incoterm_id - many2one - account.incoterms <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: International Commercial Terms are a series of predefined commercial terms used in international transactions. <br />
        /// </summary>
        [JsonProperty("incoterm_id")]
        public long? IncotermId { get; set; }

        /// <summary>
        /// invoice_reference_type - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: You can set here the default communication that will appear on customer invoices, once validated, to help the customer to refer to that particular invoice when making the payment. <br />
        /// </summary>
        [JsonProperty("invoice_reference_type")]
        public DefaultCommunicationTypeResCompanyOdooEnum? InvoiceReferenceType { get; set; }

        /// <summary>
        /// qr_code - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("qr_code")]
        public bool? QrCode { get; set; }

        /// <summary>
        /// invoice_is_email - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("invoice_is_email")]
        public bool? InvoiceIsEmail { get; set; }

        /// <summary>
        /// invoice_is_print - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("invoice_is_print")]
        public bool? InvoiceIsPrint { get; set; }

        /// <summary>
        /// account_opening_move_id - many2one - account.move <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The journal entry containing the initial balance of all this company's accounts. <br />
        /// </summary>
        [JsonProperty("account_opening_move_id")]
        public long? AccountOpeningMoveId { get; set; }

        /// <summary>
        /// account_opening_journal_id - many2one - account.journal <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Journal where the opening entry of this company's accounting has been posted. <br />
        /// </summary>
        [JsonProperty("account_opening_journal_id")]
        public long? AccountOpeningJournalId { get; set; }

        /// <summary>
        /// account_opening_date - date  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Date at which the opening entry of this company's accounting has been posted. <br />
        /// </summary>
        [JsonProperty("account_opening_date")]
        public DateTime? AccountOpeningDate { get; set; }

        /// <summary>
        /// account_setup_bank_data_state - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("account_setup_bank_data_state")]
        public StateOfTheOnboardingBankDataStepResCompanyOdooEnum? AccountSetupBankDataState { get; set; }

        /// <summary>
        /// account_setup_fy_data_state - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("account_setup_fy_data_state")]
        public StateOfTheOnboardingFiscalYearStepResCompanyOdooEnum? AccountSetupFyDataState { get; set; }

        /// <summary>
        /// account_setup_coa_state - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("account_setup_coa_state")]
        public StateOfTheOnboardingChartsOfAccountStepResCompanyOdooEnum? AccountSetupCoaState { get; set; }

        /// <summary>
        /// account_onboarding_invoice_layout_state - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("account_onboarding_invoice_layout_state")]
        public StateOfTheOnboardingInvoiceLayoutStepResCompanyOdooEnum? AccountOnboardingInvoiceLayoutState { get; set; }

        /// <summary>
        /// account_onboarding_sample_invoice_state - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("account_onboarding_sample_invoice_state")]
        public StateOfTheOnboardingSampleInvoiceStepResCompanyOdooEnum? AccountOnboardingSampleInvoiceState { get; set; }

        /// <summary>
        /// account_onboarding_sale_tax_state - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("account_onboarding_sale_tax_state")]
        public StateOfTheOnboardingSaleTaxStepResCompanyOdooEnum? AccountOnboardingSaleTaxState { get; set; }

        /// <summary>
        /// account_invoice_onboarding_state - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("account_invoice_onboarding_state")]
        public StateOfTheAccountInvoiceOnboardingPanelResCompanyOdooEnum? AccountInvoiceOnboardingState { get; set; }

        /// <summary>
        /// account_dashboard_onboarding_state - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("account_dashboard_onboarding_state")]
        public StateOfTheAccountDashboardOnboardingPanelResCompanyOdooEnum? AccountDashboardOnboardingState { get; set; }

        /// <summary>
        /// account_check_printing_layout - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Select the format corresponding to the check paper you will be printing your checks on.; In order to disable the printing feature, select 'None'. <br />
        /// </summary>
        [JsonProperty("account_check_printing_layout")]
        public CheckLayoutResCompanyOdooEnum AccountCheckPrintingLayout { get; set; }

        /// <summary>
        /// account_check_printing_date_label - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: This option allows you to print the date label on the check as per CPA. Disable this if your pre-printed check includes the date label. <br />
        /// </summary>
        [JsonProperty("account_check_printing_date_label")]
        public bool? AccountCheckPrintingDateLabel { get; set; }

        /// <summary>
        /// account_check_printing_multi_stub - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: This option allows you to print check details (stub) on multiple pages if they don't fit on a single page. <br />
        /// </summary>
        [JsonProperty("account_check_printing_multi_stub")]
        public bool? AccountCheckPrintingMultiStub { get; set; }

        /// <summary>
        /// account_check_printing_margin_top - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Adjust the margins of generated checks to make it fit your printer's settings. <br />
        /// </summary>
        [JsonProperty("account_check_printing_margin_top")]
        public double? AccountCheckPrintingMarginTop { get; set; }

        /// <summary>
        /// account_check_printing_margin_left - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Adjust the margins of generated checks to make it fit your printer's settings. <br />
        /// </summary>
        [JsonProperty("account_check_printing_margin_left")]
        public double? AccountCheckPrintingMarginLeft { get; set; }

        /// <summary>
        /// account_check_printing_margin_right - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Adjust the margins of generated checks to make it fit your printer's settings. <br />
        /// </summary>
        [JsonProperty("account_check_printing_margin_right")]
        public double? AccountCheckPrintingMarginRight { get; set; }

        /// <summary>
        /// revaluation_loss_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("revaluation_loss_account_id")]
        public long? RevaluationLossAccountId { get; set; }

        /// <summary>
        /// revaluation_gain_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("revaluation_gain_account_id")]
        public long? RevaluationGainAccountId { get; set; }

        /// <summary>
        /// revaluation_analytic_account_id - many2one - account.analytic.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("revaluation_analytic_account_id")]
        public long? RevaluationAnalyticAccountId { get; set; }

        /// <summary>
        /// provision_bs_loss_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("provision_bs_loss_account_id")]
        public long? ProvisionBsLossAccountId { get; set; }

        /// <summary>
        /// provision_bs_gain_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("provision_bs_gain_account_id")]
        public long? ProvisionBsGainAccountId { get; set; }

        /// <summary>
        /// provision_pl_loss_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("provision_pl_loss_account_id")]
        public long? ProvisionPlLossAccountId { get; set; }

        /// <summary>
        /// provision_pl_gain_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("provision_pl_gain_account_id")]
        public long? ProvisionPlGainAccountId { get; set; }

        /// <summary>
        /// provision_pl_analytic_account_id - many2one - account.analytic.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("provision_pl_analytic_account_id")]
        public long? ProvisionPlAnalyticAccountId { get; set; }

        /// <summary>
        /// currency_reval_journal_id - many2one - account.journal <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("currency_reval_journal_id")]
        public long? CurrencyRevalJournalId { get; set; }

        /// <summary>
        /// reversable_revaluations - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Revaluations entries will be created as "To Be Reversed". <br />
        /// </summary>
        [JsonProperty("reversable_revaluations")]
        public bool? ReversableRevaluations { get; set; }

        /// <summary>
        /// text_amount_language_date - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("text_amount_language_date")]
        public TextDateResCompanyOdooEnum? TextAmountLanguageDate { get; set; }

        /// <summary>
        /// project_time_mode_id - many2one - uom.uom <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: This will set the unit of measure used in projects and tasks.; If you use the timesheet linked to projects, don't forget to setup the right unit of measure in your employees. <br />
        /// </summary>
        [JsonProperty("project_time_mode_id")]
        public long? ProjectTimeModeId { get; set; }

        /// <summary>
        /// timesheet_encode_uom_id - many2one - uom.uom <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: This will set the unit of measure used to encode timesheet. This will simply provide tools;         and widgets to help the encoding. All reporting will still be expressed in hours (default value). <br />
        /// </summary>
        [JsonProperty("timesheet_encode_uom_id")]
        public long TimesheetEncodeUomId { get; set; }

        /// <summary>
        /// text_amount_language_currency - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("text_amount_language_currency")]
        public TextAmountLanguageCurrencyResCompanyOdooEnum? TextAmountLanguageCurrency { get; set; }

        /// <summary>
        /// payment_sequence - many2one - ir.sequence <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("payment_sequence")]
        public long? PaymentSequence { get; set; }

        /// <summary>
        /// po_lead - float  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Margin of error for vendor lead times. When the system generates Purchase Orders for procuring products, they will be scheduled that many days earlier to cope with unexpected vendor delays. <br />
        /// </summary>
        [JsonProperty("po_lead")]
        public double PoLead { get; set; }

        /// <summary>
        /// po_lock - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Purchase Order Modification used when you want to purchase order editable after confirm <br />
        /// </summary>
        [JsonProperty("po_lock")]
        public PurchaseOrderModificationResCompanyOdooEnum? PoLock { get; set; }

        /// <summary>
        /// po_double_validation - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Provide a double validation mechanism for purchases <br />
        /// </summary>
        [JsonProperty("po_double_validation")]
        public LevelsOfApprovalsResCompanyOdooEnum? PoDoubleValidation { get; set; }

        /// <summary>
        /// po_double_validation_amount - monetary  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Minimum amount for which a double validation is required <br />
        /// </summary>
        [JsonProperty("po_double_validation_amount")]
        public decimal? PoDoubleValidationAmount { get; set; }

        /// <summary>
        /// invoice_is_snailmail - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("invoice_is_snailmail")]
        public bool? InvoiceIsSnailmail { get; set; }

        /// <summary>
        /// extract_show_ocr_option_selection - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("extract_show_ocr_option_selection")]
        public SendModeOnInvoicesAttachmentsResCompanyOdooEnum ExtractShowOcrOptionSelection { get; set; }

        /// <summary>
        /// days_between_two_followups - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("days_between_two_followups")]
        public int? DaysBetweenTwoFollowups { get; set; }

        /// <summary>
        /// totals_below_sections - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: When ticked, totals and subtotals appear below the sections of the report. <br />
        /// </summary>
        [JsonProperty("totals_below_sections")]
        public bool? TotalsBelowSections { get; set; }

        /// <summary>
        /// yodlee_access_token - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("yodlee_access_token")]
        public string YodleeAccessToken { get; set; }

        /// <summary>
        /// yodlee_user_login - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("yodlee_user_login")]
        public string YodleeUserLogin { get; set; }

        /// <summary>
        /// yodlee_user_password - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("yodlee_user_password")]
        public string YodleeUserPassword { get; set; }

        /// <summary>
        /// yodlee_user_access_token - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("yodlee_user_access_token")]
        public string YodleeUserAccessToken { get; set; }

        /// <summary>
        /// leave_timesheet_project_id - many2one - project.project <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Default project value for timesheet generated from leave type. <br />
        /// </summary>
        [JsonProperty("leave_timesheet_project_id")]
        public long? LeaveTimesheetProjectId { get; set; }

        /// <summary>
        /// leave_timesheet_task_id - many2one - project.task <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("leave_timesheet_task_id")]
        public long? LeaveTimesheetTaskId { get; set; }

        /// <summary>
        /// sale_note - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("sale_note")]
        public string SaleNote { get; set; }

        /// <summary>
        /// portal_confirmation_sign - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("portal_confirmation_sign")]
        public bool? PortalConfirmationSign { get; set; }

        /// <summary>
        /// portal_confirmation_pay - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("portal_confirmation_pay")]
        public bool? PortalConfirmationPay { get; set; }

        /// <summary>
        /// quotation_validity_days - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("quotation_validity_days")]
        public int? QuotationValidityDays { get; set; }

        /// <summary>
        /// sale_quotation_onboarding_state - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("sale_quotation_onboarding_state")]
        public StateOfTheSaleOnboardingPanelResCompanyOdooEnum? SaleQuotationOnboardingState { get; set; }

        /// <summary>
        /// sale_onboarding_order_confirmation_state - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("sale_onboarding_order_confirmation_state")]
        public StateOfTheOnboardingConfirmationOrderStepResCompanyOdooEnum? SaleOnboardingOrderConfirmationState { get; set; }

        /// <summary>
        /// sale_onboarding_sample_quotation_state - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("sale_onboarding_sample_quotation_state")]
        public StateOfTheOnboardingSampleQuotationStepResCompanyOdooEnum? SaleOnboardingSampleQuotationState { get; set; }

        /// <summary>
        /// sale_onboarding_payment_method - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("sale_onboarding_payment_method")]
        public SaleOnboardingSelectedPaymentMethodResCompanyOdooEnum? SaleOnboardingPaymentMethod { get; set; }

        /// <summary>
        /// timesheet_mail_employee_allow - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: If checked, send an email to all users who have not recorded their timesheet <br />
        /// </summary>
        [JsonProperty("timesheet_mail_employee_allow")]
        public bool? TimesheetMailEmployeeAllow { get; set; }

        /// <summary>
        /// timesheet_mail_employee_delay - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("timesheet_mail_employee_delay")]
        public int? TimesheetMailEmployeeDelay { get; set; }

        /// <summary>
        /// timesheet_mail_employee_interval - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("timesheet_mail_employee_interval")]
        public EmployeeFrequencyResCompanyOdooEnum TimesheetMailEmployeeInterval { get; set; }

        /// <summary>
        /// timesheet_mail_employee_nextdate - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("timesheet_mail_employee_nextdate")]
        public DateTime? TimesheetMailEmployeeNextdate { get; set; }

        /// <summary>
        /// timesheet_mail_manager_allow - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: If checked, send an email to all managers who have not validated their timesheet <br />
        /// </summary>
        [JsonProperty("timesheet_mail_manager_allow")]
        public bool? TimesheetMailManagerAllow { get; set; }

        /// <summary>
        /// timesheet_mail_manager_delay - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("timesheet_mail_manager_delay")]
        public int? TimesheetMailManagerDelay { get; set; }

        /// <summary>
        /// timesheet_mail_manager_interval - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("timesheet_mail_manager_interval")]
        public ManagerReminderFrequencyResCompanyOdooEnum TimesheetMailManagerInterval { get; set; }

        /// <summary>
        /// timesheet_mail_manager_nextdate - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("timesheet_mail_manager_nextdate")]
        public DateTime? TimesheetMailManagerNextdate { get; set; }

        /// <summary>
        /// province_id - many2one - province <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("province_id")]
        public long? ProvinceId { get; set; }

        /// <summary>
        /// canton_id - many2one - canton <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("canton_id")]
        public long? CantonId { get; set; }

        /// <summary>
        /// district_id - many2one - district <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("district_id")]
        public long? DistrictId { get; set; }

        /// <summary>
        /// locality_id - many2one - locality <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("locality_id")]
        public long? LocalityId { get; set; }

        /// <summary>
        /// fax_no - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("fax_no")]
        public string FaxNo { get; set; }

        /// <summary>
        /// registration_date - datetime  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("registration_date")]
        public DateTime? RegistrationDate { get; set; }

        /// <summary>
        /// phone - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// phone_code - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("phone_code")]
        public string PhoneCode { get; set; }

        /// <summary>
        /// fax_code - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("fax_code")]
        public string FaxCode { get; set; }

        /// <summary>
        /// company_registry - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("company_registry")]
        public string CompanyRegistry { get; set; }

        /// <summary>
        /// store_branch - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("store_branch")]
        public string StoreBranch { get; set; }

        /// <summary>
        /// access_token - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// url - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// electronic_invoice - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("electronic_invoice")]
        public bool? ElectronicInvoice { get; set; }

        /// <summary>
        /// economic_activity - many2many - activity <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("economic_activity")]
        public long[] EconomicActivity { get; set; }

        /*
        /// <summary>
        /// image_EASY_FUN_TOUR_TRAVEL - binary  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("image_EASY_FUN_TOUR_TRAVEL")]
        public string ImageEASYFUNTOURTRAVEL { get; set; }
        */

        /// <summary>
        /// security_lead - float  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Margin of error for dates promised to customers. Products will be scheduled for procurement and delivery that many days earlier than the actual promised date, to cope with unexpected delays in the supply chain. <br />
        /// </summary>
        [JsonProperty("security_lead")]
        public double SecurityLead { get; set; }

        /// <summary>
        /// no_autorizado - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("no_autorizado")]
        public string NoAutorizado { get; set; }

        /// <summary>
        /// rule_type - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Select the type to setup inter company rules in selected company. <br />
        /// </summary>
        [JsonProperty("rule_type")]
        public RuleTypeResCompanyOdooEnum? RuleType { get; set; }

        /// <summary>
        /// applicable_on - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("applicable_on")]
        public ApplicableOnResCompanyOdooEnum? ApplicableOn { get; set; }

        /// <summary>
        /// auto_validation - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("auto_validation")]
        public AutoValidationResCompanyOdooEnum? AutoValidation { get; set; }

        /// <summary>
        /// intercompany_user_id - many2one - res.users <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Responsible user for creation of documents triggered by intercompany rules. <br />
        /// </summary>
        [JsonProperty("intercompany_user_id")]
        public long? IntercompanyUserId { get; set; }

        /// <summary>
        /// warehouse_id - many2one - stock.warehouse <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Default value to set on Purchase(Sales) Orders that will be created based on Sale(Purchase) Orders made to this company <br />
        /// </summary>
        [JsonProperty("warehouse_id")]
        public long? WarehouseId { get; set; }

        /*
        /// <summary>
        /// image_MACHO_RATON - binary  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("image_MACHO_RATON")]
        public string ImageMACHORATON { get; set; }
        */

        /// <summary>
        /// low_stock_remind_user_ids - many2many - res.users <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("low_stock_remind_user_ids")]
        public long[] LowStockRemindUserIds { get; set; }

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

        /*
        /// <summary>
        /// x_studio_logo_rent_a_car - binary  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("x_studio_logo_rent_a_car")]
        public string XStudioLogoRentACar { get; set; }
        */
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateOfTheOnboardingCompanyStepResCompanyOdooEnum
    {
        [EnumMember(Value = "not_done")]
        NotDone = 1,

        [EnumMember(Value = "just_done")]
        JustDone = 2,

        [EnumMember(Value = "done")]
        Done = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateOfTheOnboardingPaymentAcquirerStepResCompanyOdooEnum
    {
        [EnumMember(Value = "not_done")]
        NotDone = 1,

        [EnumMember(Value = "just_done")]
        JustDone = 2,

        [EnumMember(Value = "done")]
        Done = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SelectedOnboardingPaymentMethodResCompanyOdooEnum
    {
        [EnumMember(Value = "paypal")]
        Paypal = 1,

        [EnumMember(Value = "stripe")]
        Stripe = 2,

        [EnumMember(Value = "manual")]
        Manual = 3,

        [EnumMember(Value = "other")]
        Other = 4,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FiscalyearLastMonthResCompanyOdooEnum
    {
        [EnumMember(Value = "1")]
        January = 1,

        [EnumMember(Value = "2")]
        February = 2,

        [EnumMember(Value = "3")]
        March = 3,

        [EnumMember(Value = "4")]
        April = 4,

        [EnumMember(Value = "5")]
        May = 5,

        [EnumMember(Value = "6")]
        June = 6,

        [EnumMember(Value = "7")]
        July = 7,

        [EnumMember(Value = "8")]
        August = 8,

        [EnumMember(Value = "9")]
        September = 9,

        [EnumMember(Value = "10")]
        October = 10,

        [EnumMember(Value = "11")]
        November = 11,

        [EnumMember(Value = "12")]
        December = 12,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaxCalculationRoundingMethodResCompanyOdooEnum
    {
        [EnumMember(Value = "round_per_line")]
        RoundPerLine = 1,

        [EnumMember(Value = "round_globally")]
        RoundGlobally = 2,
    }


    /// <summary>
    /// Help: You can set here the default communication that will appear on customer invoices, once validated, to help the customer to refer to that particular invoice when making the payment.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DefaultCommunicationTypeResCompanyOdooEnum
    {
        [EnumMember(Value = "invoice_number")]
        BasedOnInvoiceNumber = 1,

        [EnumMember(Value = "partner")]
        BasedOnCustomer = 2,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateOfTheOnboardingBankDataStepResCompanyOdooEnum
    {
        [EnumMember(Value = "not_done")]
        NotDone = 1,

        [EnumMember(Value = "just_done")]
        JustDone = 2,

        [EnumMember(Value = "done")]
        Done = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateOfTheOnboardingFiscalYearStepResCompanyOdooEnum
    {
        [EnumMember(Value = "not_done")]
        NotDone = 1,

        [EnumMember(Value = "just_done")]
        JustDone = 2,

        [EnumMember(Value = "done")]
        Done = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateOfTheOnboardingChartsOfAccountStepResCompanyOdooEnum
    {
        [EnumMember(Value = "not_done")]
        NotDone = 1,

        [EnumMember(Value = "just_done")]
        JustDone = 2,

        [EnumMember(Value = "done")]
        Done = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateOfTheOnboardingInvoiceLayoutStepResCompanyOdooEnum
    {
        [EnumMember(Value = "not_done")]
        NotDone = 1,

        [EnumMember(Value = "just_done")]
        JustDone = 2,

        [EnumMember(Value = "done")]
        Done = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateOfTheOnboardingSampleInvoiceStepResCompanyOdooEnum
    {
        [EnumMember(Value = "not_done")]
        NotDone = 1,

        [EnumMember(Value = "just_done")]
        JustDone = 2,

        [EnumMember(Value = "done")]
        Done = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateOfTheOnboardingSaleTaxStepResCompanyOdooEnum
    {
        [EnumMember(Value = "not_done")]
        NotDone = 1,

        [EnumMember(Value = "just_done")]
        JustDone = 2,

        [EnumMember(Value = "done")]
        Done = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateOfTheAccountInvoiceOnboardingPanelResCompanyOdooEnum
    {
        [EnumMember(Value = "not_done")]
        NotDone = 1,

        [EnumMember(Value = "just_done")]
        JustDone = 2,

        [EnumMember(Value = "done")]
        Done = 3,

        [EnumMember(Value = "closed")]
        Closed = 4,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateOfTheAccountDashboardOnboardingPanelResCompanyOdooEnum
    {
        [EnumMember(Value = "not_done")]
        NotDone = 1,

        [EnumMember(Value = "just_done")]
        JustDone = 2,

        [EnumMember(Value = "done")]
        Done = 3,

        [EnumMember(Value = "closed")]
        Closed = 4,
    }


    /// <summary>
    /// Help: Select the format corresponding to the check paper you will be printing your checks on. <br />
    /// In order to disable the printing feature, select 'None'.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CheckLayoutResCompanyOdooEnum
    {
        [EnumMember(Value = "disabled")]
        None = 1,

        [EnumMember(Value = "action_print_check_top")]
        CheckOnTop = 2,

        [EnumMember(Value = "action_print_check_middle")]
        CheckInMiddle = 3,

        [EnumMember(Value = "action_print_check_bottom")]
        CheckOnBottom = 4,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextDateResCompanyOdooEnum
    {
        [EnumMember(Value = "en")]
        English = 1,

        [EnumMember(Value = "ar")]
        Arabic = 2,

        [EnumMember(Value = "cz ")]
        Czech = 3,

        [EnumMember(Value = "de")]
        German = 4,

        [EnumMember(Value = "dk")]
        Danish = 5,

        [EnumMember(Value = "en_GB")]
        EnglishGreatBritain = 6,

        [EnumMember(Value = "en_IN")]
        EnglishIndia = 7,

        [EnumMember(Value = "es")]
        Spanish = 8,

        [EnumMember(Value = "es_CO")]
        SpanishColombia = 9,

        [EnumMember(Value = "es_VE")]
        SpanishVenezuela = 10,

        [EnumMember(Value = "eu")]
        EURO = 11,

        [EnumMember(Value = "fi")]
        Finnish = 12,

        [EnumMember(Value = "fr")]
        French = 13,

        [EnumMember(Value = "fr_CH")]
        FrenchSwitzerland = 14,

        [EnumMember(Value = "fr_BE")]
        FrenchBelgium = 15,

        [EnumMember(Value = "fr_DZ")]
        FrenchAlgeria = 16,

        [EnumMember(Value = "he")]
        Hebrew = 17,

        [EnumMember(Value = "id")]
        Indonesian = 18,

        [EnumMember(Value = "it")]
        Italian = 19,

        [EnumMember(Value = "ja")]
        Japanese = 20,

        [EnumMember(Value = "ko")]
        Korean = 21,

        [EnumMember(Value = "lt")]
        Lithuanian = 22,

        [EnumMember(Value = "lv")]
        Latvian = 23,

        [EnumMember(Value = "no")]
        Norwegian = 24,

        [EnumMember(Value = "pl")]
        Polish = 25,

        [EnumMember(Value = "pt")]
        Portuguese = 26,

        [EnumMember(Value = "pt_BR")]
        PortugueseBrazilian = 27,

        [EnumMember(Value = "sl")]
        Slovene = 28,

        [EnumMember(Value = "sr")]
        Serbian = 29,

        [EnumMember(Value = "ro")]
        Romanian = 30,

        [EnumMember(Value = "ru")]
        Russian = 31,

        [EnumMember(Value = "tr")]
        Turkish = 33,

        [EnumMember(Value = "th")]
        Thai = 34,

        [EnumMember(Value = "vi")]
        Vietnamese = 35,

        [EnumMember(Value = "nl")]
        Dutch = 36,

        [EnumMember(Value = "uk")]
        Ukrainian = 37,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextAmountLanguageCurrencyResCompanyOdooEnum
    {
        [EnumMember(Value = "en")]
        English = 1,

        [EnumMember(Value = "ar")]
        Arabic = 2,

        [EnumMember(Value = "cz ")]
        Czech = 3,

        [EnumMember(Value = "de")]
        German = 4,

        [EnumMember(Value = "dk")]
        Danish = 5,

        [EnumMember(Value = "en_GB")]
        EnglishGreatBritain = 6,

        [EnumMember(Value = "en_IN")]
        EnglishIndia = 7,

        [EnumMember(Value = "es")]
        Spanish = 8,

        [EnumMember(Value = "es_CO")]
        SpanishColombia = 9,

        [EnumMember(Value = "es_VE")]
        SpanishVenezuela = 10,

        [EnumMember(Value = "eu")]
        EURO = 11,

        [EnumMember(Value = "fi")]
        Finnish = 12,

        [EnumMember(Value = "fr")]
        French = 13,

        [EnumMember(Value = "fr_CH")]
        FrenchSwitzerland = 14,

        [EnumMember(Value = "fr_BE")]
        FrenchBelgium = 15,

        [EnumMember(Value = "fr_DZ")]
        FrenchAlgeria = 16,

        [EnumMember(Value = "he")]
        Hebrew = 17,

        [EnumMember(Value = "id")]
        Indonesian = 18,

        [EnumMember(Value = "it")]
        Italian = 19,

        [EnumMember(Value = "ja")]
        Japanese = 20,

        [EnumMember(Value = "ko")]
        Korean = 21,

        [EnumMember(Value = "lt")]
        Lithuanian = 22,

        [EnumMember(Value = "lv")]
        Latvian = 23,

        [EnumMember(Value = "no")]
        Norwegian = 24,

        [EnumMember(Value = "pl")]
        Polish = 25,

        [EnumMember(Value = "pt")]
        Portuguese = 26,

        [EnumMember(Value = "pt_BR")]
        PortugueseBrazilian = 27,

        [EnumMember(Value = "sl")]
        Slovene = 28,

        [EnumMember(Value = "sr")]
        Serbian = 29,

        [EnumMember(Value = "ro")]
        Romanian = 30,

        [EnumMember(Value = "ru")]
        Russian = 31,

        [EnumMember(Value = "tr")]
        Turkish = 33,

        [EnumMember(Value = "th")]
        Thai = 34,

        [EnumMember(Value = "vi")]
        Vietnamese = 35,

        [EnumMember(Value = "nl")]
        Dutch = 36,

        [EnumMember(Value = "uk")]
        Ukrainian = 37,
    }


    /// <summary>
    /// Help: Purchase Order Modification used when you want to purchase order editable after confirm
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PurchaseOrderModificationResCompanyOdooEnum
    {
        [EnumMember(Value = "edit")]
        AllowToEditPurchaseOrders = 1,

        [EnumMember(Value = "lock")]
        ConfirmedPurchaseOrdersAreNotEditable = 2,
    }


    /// <summary>
    /// Help: Provide a double validation mechanism for purchases
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LevelsOfApprovalsResCompanyOdooEnum
    {
        [EnumMember(Value = "one_step")]
        ConfirmPurchaseOrdersInOneStep = 1,

        [EnumMember(Value = "two_step")]
        Get2LevelsOfApprovalsToConfirmAPurchaseOrder = 2,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendModeOnInvoicesAttachmentsResCompanyOdooEnum
    {
        [EnumMember(Value = "no_send")]
        DoNotProcessBills = 1,

        [EnumMember(Value = "manual_send")]
        ProcessBillsOnDemandOnly = 2,

        [EnumMember(Value = "auto_send")]
        ProcessAllBillsAutomatically = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateOfTheSaleOnboardingPanelResCompanyOdooEnum
    {
        [EnumMember(Value = "not_done")]
        NotDone = 1,

        [EnumMember(Value = "just_done")]
        JustDone = 2,

        [EnumMember(Value = "done")]
        Done = 3,

        [EnumMember(Value = "closed")]
        Closed = 4,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateOfTheOnboardingConfirmationOrderStepResCompanyOdooEnum
    {
        [EnumMember(Value = "not_done")]
        NotDone = 1,

        [EnumMember(Value = "just_done")]
        JustDone = 2,

        [EnumMember(Value = "done")]
        Done = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateOfTheOnboardingSampleQuotationStepResCompanyOdooEnum
    {
        [EnumMember(Value = "not_done")]
        NotDone = 1,

        [EnumMember(Value = "just_done")]
        JustDone = 2,

        [EnumMember(Value = "done")]
        Done = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SaleOnboardingSelectedPaymentMethodResCompanyOdooEnum
    {
        [EnumMember(Value = "digital_signature")]
        SignOnline = 1,

        [EnumMember(Value = "paypal")]
        Paypal = 2,

        [EnumMember(Value = "stripe")]
        Stripe = 3,

        [EnumMember(Value = "other")]
        PayWithAnotherPaymentAcquirer = 4,

        [EnumMember(Value = "manual")]
        WireTransfer = 5,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EmployeeFrequencyResCompanyOdooEnum
    {
        [EnumMember(Value = "weeks")]
        AfterEndOfWeek = 1,

        [EnumMember(Value = "months")]
        AfterEndOfMonth = 2,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ManagerReminderFrequencyResCompanyOdooEnum
    {
        [EnumMember(Value = "weeks")]
        AfterEndOfWeek = 1,

        [EnumMember(Value = "months")]
        AfterEndOfMonth = 2,
    }


    /// <summary>
    /// Help: Select the type to setup inter company rules in selected company.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RuleTypeResCompanyOdooEnum
    {
        [EnumMember(Value = "so_and_po")]
        SynchronizeSalesPurchaseOrders = 1,

        [EnumMember(Value = "invoice_and_refund")]
        SynchronizeInvoicesBills = 2,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ApplicableOnResCompanyOdooEnum
    {
        [EnumMember(Value = "sale")]
        SaleOrder = 1,

        [EnumMember(Value = "purchase")]
        PurchaseOrder = 2,

        [EnumMember(Value = "sale_purchase")]
        SaleAndPurchaseOrder = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutoValidationResCompanyOdooEnum
    {
        [EnumMember(Value = "draft")]
        Draft = 1,

        [EnumMember(Value = "validated")]
        Validated = 2,
    }

}
