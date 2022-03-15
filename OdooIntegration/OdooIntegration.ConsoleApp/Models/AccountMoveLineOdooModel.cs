using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("account.move.line")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class AccountMoveLineOdooModel : IOdooModel
    {

        // account.move
        // required
        [JsonProperty("move_id")]
        public long MoveId { get; set; }

        [JsonProperty("move_name")]
        public string MoveName { get; set; }

        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("parent_state")]
        public StatusAccountMoveLineOdooEnum? ParentState { get; set; }

        // account.journal
        [JsonProperty("journal_id")]
        public long? JournalId { get; set; }

        // res.company
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        // res.currency
        [JsonProperty("company_currency_id")]
        public long? CompanyCurrencyId { get; set; }

        // res.country
        [JsonProperty("tax_fiscal_country_id")]
        public long? TaxFiscalCountryId { get; set; }

        // account.account
        [JsonProperty("account_id")]
        public long? AccountId { get; set; }

        [JsonProperty("account_internal_type")]
        public InternalTypeAccountMoveLineOdooEnum? AccountInternalType { get; set; }

        [JsonProperty("account_internal_group")]
        public InternalGroupAccountMoveLineOdooEnum? AccountInternalGroup { get; set; }

        // account.root
        [JsonProperty("account_root_id")]
        public long? AccountRootId { get; set; }

        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public double? Quantity { get; set; }

        [JsonProperty("price_unit")]
        public double? PriceUnit { get; set; }

        [JsonProperty("discount")]
        public double? Discount { get; set; }

        [JsonProperty("debit")]
        public decimal? Debit { get; set; }

        [JsonProperty("credit")]
        public decimal? Credit { get; set; }

        [JsonProperty("balance")]
        public decimal? Balance { get; set; }

        [JsonProperty("cumulated_balance")]
        public decimal? CumulatedBalance { get; set; }

        [JsonProperty("amount_currency")]
        public decimal? AmountCurrency { get; set; }

        [JsonProperty("price_subtotal")]
        public decimal? PriceSubtotal { get; set; }

        [JsonProperty("price_total")]
        public decimal? PriceTotal { get; set; }

        [JsonProperty("reconciled")]
        public bool? Reconciled { get; set; }

        [JsonProperty("blocked")]
        public bool? Blocked { get; set; }

        [JsonProperty("date_maturity")]
        public DateTime? DateMaturity { get; set; }

        // res.currency
        // required
        [JsonProperty("currency_id")]
        public long CurrencyId { get; set; }

        // res.partner
        [JsonProperty("partner_id")]
        public long? PartnerId { get; set; }

        // uom.uom
        [JsonProperty("product_uom_id")]
        public long? ProductUomId { get; set; }

        // product.product
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }

        // uom.category
        [JsonProperty("product_uom_category_id")]
        public long? ProductUomCategoryId { get; set; }

        // account.reconcile.model
        [JsonProperty("reconcile_model_id")]
        public long? ReconcileModelId { get; set; }

        // account.payment
        [JsonProperty("payment_id")]
        public long? PaymentId { get; set; }

        // account.bank.statement.line
        [JsonProperty("statement_line_id")]
        public long? StatementLineId { get; set; }

        // account.bank.statement
        [JsonProperty("statement_id")]
        public long? StatementId { get; set; }

        // account.tax
        [JsonProperty("tax_ids")]
        public long[] TaxIds { get; set; }

        // account.tax
        [JsonProperty("tax_line_id")]
        public long? TaxLineId { get; set; }

        // account.tax.group
        [JsonProperty("tax_group_id")]
        public long? TaxGroupId { get; set; }

        [JsonProperty("tax_base_amount")]
        public decimal? TaxBaseAmount { get; set; }

        [JsonProperty("tax_exigible")]
        public bool? TaxExigible { get; set; }

        // account.tax.repartition.line
        [JsonProperty("tax_repartition_line_id")]
        public long? TaxRepartitionLineId { get; set; }

        // account.account.tag
        [JsonProperty("tax_tag_ids")]
        public long[] TaxTagIds { get; set; }

        [JsonProperty("tax_audit")]
        public string TaxAudit { get; set; }

        [JsonProperty("amount_residual")]
        public decimal? AmountResidual { get; set; }

        [JsonProperty("amount_residual_currency")]
        public decimal? AmountResidualCurrency { get; set; }

        // account.full.reconcile
        [JsonProperty("full_reconcile_id")]
        public long? FullReconcileId { get; set; }

        // account.partial.reconcile
        [JsonProperty("matched_debit_ids")]
        public long[] MatchedDebitIds { get; set; }

        // account.partial.reconcile
        [JsonProperty("matched_credit_ids")]
        public long[] MatchedCreditIds { get; set; }

        [JsonProperty("matching_number")]
        public string MatchingNumber { get; set; }

        // account.analytic.line
        [JsonProperty("analytic_line_ids")]
        public long[] AnalyticLineIds { get; set; }

        // account.analytic.account
        [JsonProperty("analytic_account_id")]
        public long? AnalyticAccountId { get; set; }

        // account.analytic.tag
        [JsonProperty("analytic_tag_ids")]
        public long[] AnalyticTagIds { get; set; }

        [JsonProperty("recompute_tax_line")]
        public bool? RecomputeTaxLine { get; set; }

        [JsonProperty("display_type")]
        public DisplayTypeAccountMoveLineOdooEnum? DisplayType { get; set; }

        [JsonProperty("is_rounding_line")]
        public bool? IsRoundingLine { get; set; }

        [JsonProperty("exclude_from_invoice_tab")]
        public bool? ExcludeFromInvoiceTab { get; set; }

        // account.asset.profile
        [JsonProperty("asset_profile_id")]
        public long? AssetProfileId { get; set; }

        // account.asset
        [JsonProperty("asset_id")]
        public long? AssetId { get; set; }

        [JsonProperty("invoice_origin")]
        public string InvoiceOrigin { get; set; }

        [JsonProperty("invoice_date")]
        public DateTime? InvoiceDate { get; set; }

        [JsonProperty("partner_ref")]
        public string PartnerRef { get; set; }

        // account.payment.term
        [JsonProperty("payment_term_id")]
        public long? PaymentTermId { get; set; }

        // res.users
        [JsonProperty("invoice_user_id")]
        public long? InvoiceUserId { get; set; }

        // fleet.vehicle
        [JsonProperty("vehicle_id")]
        public long? VehicleId { get; set; }

        [JsonProperty("need_vehicle")]
        public bool? NeedVehicle { get; set; }

        // hr.expense
        [JsonProperty("expense_id")]
        public long? ExpenseId { get; set; }

        // purchase.order.line
        [JsonProperty("purchase_line_id")]
        public long? PurchaseLineId { get; set; }

        // purchase.order
        [JsonProperty("purchase_order_id")]
        public long? PurchaseOrderId { get; set; }

        [JsonProperty("is_anglo_saxon_line")]
        public bool? IsAngloSaxonLine { get; set; }

        // account.payment.mode
        [JsonProperty("payment_mode_id")]
        public long? PaymentModeId { get; set; }

        // sale.order.line
        [JsonProperty("sale_line_ids")]
        public long[] SaleLineIds { get; set; }

        // res.partner.bank
        [JsonProperty("partner_bank_id")]
        public long? PartnerBankId { get; set; }

        // bank.payment.line
        [JsonProperty("bank_payment_line_id")]
        public long? BankPaymentLineId { get; set; }

        // account.payment.line
        [JsonProperty("payment_line_ids")]
        public long[] PaymentLineIds { get; set; }

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

        //ARGENTINA

        /// <summary>
        /// l10n_latam_document_type_id - many2one - l10n_latam.document.type <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("l10n_latam_document_type_id")]
        public long? L10nLatamDocumentTypeId { get; set; }

        /// <summary>
        /// l10n_latam_price_unit - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("l10n_latam_price_unit")]
        public double? L10nLatamPriceUnit { get; set; }

        /// <summary>
        /// l10n_latam_price_subtotal - monetary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("l10n_latam_price_subtotal")]
        public decimal? L10nLatamPriceSubtotal { get; set; }

        /// <summary>
        /// l10n_latam_price_net - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("l10n_latam_price_net")]
        public double? L10nLatamPriceNet { get; set; }

        /// <summary>
        /// l10n_latam_tax_ids - one2many - account.tax <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("l10n_latam_tax_ids")]
        public long[] L10nLatamTaxIds { get; set; }
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusAccountMoveLineOdooEnum
    {
        [EnumMember(Value = "draft")]
        Draft = 1,

        [EnumMember(Value = "posted")]
        Posted = 2,

        [EnumMember(Value = "cancel")]
        Cancelled = 3,
    }


    // The 'Internal Type' is used for features available on different types of accounts: liquidity type is for cash or bank accounts, payable/receivable is for vendor/customer accounts.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InternalTypeAccountMoveLineOdooEnum
    {
        [EnumMember(Value = "other")]
        Regular = 1,

        [EnumMember(Value = "receivable")]
        Receivable = 2,

        [EnumMember(Value = "payable")]
        Payable = 3,

        [EnumMember(Value = "liquidity")]
        Liquidity = 4,
    }


    // The 'Internal Group' is used to filter accounts based on the internal group set on the account type.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InternalGroupAccountMoveLineOdooEnum
    {
        [EnumMember(Value = "equity")]
        Equity = 1,

        [EnumMember(Value = "asset")]
        Asset = 2,

        [EnumMember(Value = "liability")]
        Liability = 3,

        [EnumMember(Value = "income")]
        Income = 4,

        [EnumMember(Value = "expense")]
        Expense = 5,

        [EnumMember(Value = "off_balance")]
        OffBalance = 6,
    }


    // Technical field for UX purpose.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DisplayTypeAccountMoveLineOdooEnum
    {
        [EnumMember(Value = "line_section")]
        Section = 1,

        [EnumMember(Value = "line_note")]
        Note = 2,
    }



}
