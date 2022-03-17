using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("account.tax")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class AccountTaxOdooModel : IOdooModel
    {

        /// <summary>
        /// name - char  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// type_tax_use - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Determines where the tax is selectable. Note : 'None' means a tax can't be used by itself, however it can still be used in a group. 'adjustment' is used to perform tax adjustment. <br />
        /// </summary>
        [JsonProperty("type_tax_use")]
        public TaxScopeAccountTaxOdooEnum TypeTaxUse { get; set; }

        /// <summary>
        /// active - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Set active to false to hide the tax without removing it. <br />
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// company_id - many2one - res.company <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("company_id")]
        public long CompanyId { get; set; }

        /// <summary>
        /// children_tax_ids - many2many - account.tax <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("children_tax_ids")]
        public long[] ChildrenTaxIds { get; set; }

        /// <summary>
        /// sequence - integer  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The sequence field is used to define order in which the tax lines are applied. <br />
        /// </summary>
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        /// <summary>
        /// amount - float  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Account that will be set on invoice tax lines for invoices. Leave empty to use the expense account. <br />
        /// </summary>
        [JsonProperty("account_id")]
        public long? AccountId { get; set; }

        /// <summary>
        /// refund_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Account that will be set on invoice tax lines for credit notes. Leave empty to use the expense account. <br />
        /// </summary>
        [JsonProperty("refund_account_id")]
        public long? RefundAccountId { get; set; }

        /// <summary>
        /// description - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// price_include - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Check this if the price you use on the product and invoices includes this tax. <br />
        /// </summary>
        [JsonProperty("price_include")]
        public bool? PriceInclude { get; set; }

        /// <summary>
        /// include_base_amount - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: If set, taxes which are computed after this one will be computed based on the price tax included. <br />
        /// </summary>
        [JsonProperty("include_base_amount")]
        public bool? IncludeBaseAmount { get; set; }

        /// <summary>
        /// analytic - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: If set, the amount computed by this tax will be assigned to the same analytic account as the invoice line (if any) <br />
        /// </summary>
        [JsonProperty("analytic")]
        public bool? Analytic { get; set; }

        /// <summary>
        /// tag_ids - many2many - account.account.tag <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Optional tags you may want to assign for custom reporting <br />
        /// </summary>
        [JsonProperty("tag_ids")]
        public long[] TagIds { get; set; }

        /// <summary>
        /// tax_group_id - many2one - account.tax.group <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("tax_group_id")]
        public long TaxGroupId { get; set; }

        /// <summary>
        /// hide_tax_exigibility - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("hide_tax_exigibility")]
        public bool? HideTaxExigibility { get; set; }

        /// <summary>
        /// tax_exigibility - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Based on Invoice: the tax is due as soon as the invoice is validated.; Based on Payment: the tax is due as soon as the payment of the invoice is received. <br />
        /// </summary>
        [JsonProperty("tax_exigibility")]
        public TaxDueAccountTaxOdooEnum? TaxExigibility { get; set; }

        /// <summary>
        /// cash_basis_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Account used as counterpart for the journal entry, for taxes eligible based on payments. <br />
        /// </summary>
        [JsonProperty("cash_basis_account_id")]
        public long? CashBasisAccountId { get; set; }

        /// <summary>
        /// cash_basis_base_account_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Account that will be set on lines created in cash basis journal entry and used to keep track of the tax base amount. <br />
        /// </summary>
        [JsonProperty("cash_basis_base_account_id")]
        public long? CashBasisBaseAccountId { get; set; }

        /// <summary>
        /// tds - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("tds")]
        public bool? Tds { get; set; }

        /// <summary>
        /// payment_excess - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("payment_excess")]
        public double? PaymentExcess { get; set; }

        /// <summary>
        /// amount_type - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("amount_type")]
        public TaxComputationAccountTaxOdooEnum AmountType { get; set; }

        /// <summary>
        /// tax_code - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("tax_code")]
        public CDigoDelImpuestoAccountTaxOdooEnum? TaxCode { get; set; }

        /// <summary>
        /// tax_base_impose - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("tax_base_impose")]
        public double? TaxBaseImpose { get; set; }

        /// <summary>
        /// tax_exemption_code - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("tax_exemption_code")]
        public TipoDeDocumentoDeExoneraciNAccountTaxOdooEnum? TaxExemptionCode { get; set; }

        /// <summary>
        /// tax_tariff - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("tax_tariff")]
        public TarifasAccountTaxOdooEnum? TaxTariff { get; set; }

        /// <summary>
        /// tax_exemption_number - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("tax_exemption_number")]
        public string TaxExemptionNumber { get; set; }

        /// <summary>
        /// tax_exemption_institution - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("tax_exemption_institution")]
        public string TaxExemptionInstitution { get; set; }

        /// <summary>
        /// tax_exemption_date_time - date  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("tax_exemption_date_time")]
        public DateTime? TaxExemptionDateTime { get; set; }

        /// <summary>
        /// tax_authorized_amount - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("tax_authorized_amount")]
        public double? TaxAuthorizedAmount { get; set; }

        /// <summary>
        /// tax_authorized_percentage - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("tax_authorized_percentage")]
        public int? TaxAuthorizedPercentage { get; set; }

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
    }


    /// <summary>
    /// Help: Determines where the tax is selectable. Note : 'None' means a tax can't be used by itself, however it can still be used in a group. 'adjustment' is used to perform tax adjustment.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaxScopeAccountTaxOdooEnum
    {
        [EnumMember(Value = "sale")]
        Sales = 1,

        [EnumMember(Value = "purchase")]
        Purchases = 2,

        [EnumMember(Value = "none")]
        None = 3,

        [EnumMember(Value = "adjustment")]
        Adjustment = 4,
    }


    /// <summary>
    /// Help: Based on Invoice: the tax is due as soon as the invoice is validated. <br />
    /// Based on Payment: the tax is due as soon as the payment of the invoice is received.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaxDueAccountTaxOdooEnum
    {
        [EnumMember(Value = "on_invoice")]
        BasedOnInvoice = 1,

        [EnumMember(Value = "on_payment")]
        BasedOnPayment = 2,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaxComputationAccountTaxOdooEnum
    {
        [EnumMember(Value = "group")]
        GroupOfTaxes = 1,

        [EnumMember(Value = "fixed")]
        Fixed = 2,

        [EnumMember(Value = "percent")]
        PercentageOfPrice = 3,

        [EnumMember(Value = "division")]
        PercentageOfPriceTaxIncluded = 4,

        [EnumMember(Value = "payable")]
        PorcentajeSobreElMontoAPagar = 5,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CDigoDelImpuestoAccountTaxOdooEnum
    {
        [EnumMember(Value = "01")]
        ImpuestoAlValorAgregado = 1,

        [EnumMember(Value = "02")]
        ImpuestoSelectivoDeConsumo = 2,

        [EnumMember(Value = "03")]
        ImpuestoUNicoALosCombustibles = 3,

        [EnumMember(Value = "04")]
        ImpuestoEspeciFicoDeBebidasAlcohoLicas = 4,

        [EnumMember(Value = "05")]
        ImpuestoEspeciFicoSobreLasBebidasEnvasadasSinContenidoAlcohoLicoYJabonesDeTocador = 5,

        [EnumMember(Value = "06")]
        ImpuestoALosProductosDeTabaco = 6,

        [EnumMember(Value = "07")]
        IVACaLculoEspecial = 7,

        [EnumMember(Value = "08")]
        IVAReGimenDeBienesUsadosFactor = 8,

        [EnumMember(Value = "12")]
        SpecificTaxCement = 9,

        [EnumMember(Value = "98")]
        Others = 10,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TipoDeDocumentoDeExoneraciNAccountTaxOdooEnum
    {
        [EnumMember(Value = "01")]
        ComprasAutorizadas = 1,

        [EnumMember(Value = "02")]
        VentasExentasADiplomaTicos = 2,

        [EnumMember(Value = "03")]
        AutorizadoPorLeyEspecial = 3,

        [EnumMember(Value = "04")]
        ExencionesDireccioNGeneralDeHacienda = 4,

        [EnumMember(Value = "05")]
        TransitorioV = 5,

        [EnumMember(Value = "06")]
        TransitorioIX = 6,

        [EnumMember(Value = "07")]
        TransitorioXVII = 7,

        [EnumMember(Value = "99")]
        Otros = 8,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TarifasAccountTaxOdooEnum
    {
        [EnumMember(Value = "01")]
        Tarifa0Exento = 1,

        [EnumMember(Value = "02")]
        TarifaReducida1 = 2,

        [EnumMember(Value = "03")]
        TarifaReducida2 = 3,

        [EnumMember(Value = "04")]
        TarifaReducida4 = 4,

        [EnumMember(Value = "05")]
        Transitorio0 = 5,

        [EnumMember(Value = "06")]
        Transitorio4 = 6,

        [EnumMember(Value = "07")]
        Transitorio8 = 7,

        [EnumMember(Value = "08")]
        TarifaGeneral13 = 8,
    }
}
