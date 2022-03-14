using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("account.invoice.line")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class AccountInvoiceLineOdooModel : IOdooModel
    {

        // required
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        // account.invoice
        [JsonProperty("invoice_id")]
        public long? InvoiceId { get; set; }

        [JsonProperty("invoice_type")]
        public TypeAccountInvoiceLineOdooEnum? InvoiceType { get; set; }

        // uom.uom
        [JsonProperty("uom_id")]
        public long? UomId { get; set; }

        // product.product
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }

        [JsonProperty("product_image")]
        public string ProductImage { get; set; }

        // account.account
        [JsonProperty("account_id")]
        public long? AccountId { get; set; }

        // required
        [JsonProperty("price_unit")]
        public double PriceUnit { get; set; }

        [JsonProperty("price_subtotal")]
        public decimal? PriceSubtotal { get; set; }

        [JsonProperty("price_total")]
        public decimal? PriceTotal { get; set; }

        [JsonProperty("price_subtotal_signed")]
        public decimal? PriceSubtotalSigned { get; set; }

        [JsonProperty("price_tax")]
        public decimal? PriceTax { get; set; }

        // required
        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("discount")]
        public double? Discount { get; set; }

        // account.tax
        [JsonProperty("invoice_line_tax_ids")]
        public long[] InvoiceLineTaxIds { get; set; }

        // account.analytic.account
        [JsonProperty("account_analytic_id")]
        public long? AccountAnalyticId { get; set; }

        // account.analytic.tag
        [JsonProperty("analytic_tag_ids")]
        public long[] AnalyticTagIds { get; set; }

        // res.company
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        // res.partner
        [JsonProperty("partner_id")]
        public long? PartnerId { get; set; }

        // res.currency
        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        // res.currency
        [JsonProperty("company_currency_id")]
        public long? CompanyCurrencyId { get; set; }

        [JsonProperty("is_rounding_line")]
        public bool? IsRoundingLine { get; set; }

        [JsonProperty("display_type")]
        public DisplayTypeAccountInvoiceLineOdooEnum? DisplayType { get; set; }

        // account.asset.category
        [JsonProperty("asset_category_id")]
        public long? AssetCategoryId { get; set; }

        [JsonProperty("asset_start_date")]
        public DateTime? AssetStartDate { get; set; }

        [JsonProperty("asset_end_date")]
        public DateTime? AssetEndDate { get; set; }

        [JsonProperty("asset_mrr")]
        public double? AssetMrr { get; set; }

        // purchase.order.line
        [JsonProperty("purchase_line_id")]
        public long? PurchaseLineId { get; set; }

        // purchase.order
        [JsonProperty("purchase_id")]
        public long? PurchaseId { get; set; }

        // sale.order.line
        [JsonProperty("sale_line_ids")]
        public long[] SaleLineIds { get; set; }

        // fleet.vehicle.cost
        [JsonProperty("fleet_vehicle_cost_ids")]
        public long[] FleetVehicleCostIds { get; set; }

        [JsonProperty("fleet_vehicle_costs_count")]
        public int? FleetVehicleCostsCount { get; set; }

        [JsonProperty("has_fleet_vehicle_cost")]
        public bool? HasFleetVehicleCost { get; set; }

        [JsonProperty("has_vehicle_cost")]
        public bool? HasVehicleCost { get; set; }

        // purchase.cost.distribution.expense
        [JsonProperty("expense_line_ids")]
        public long[] ExpenseLineIds { get; set; }

        // fleet.vehicle.revenue
        [JsonProperty("fleet_vehicle_revenue_ids")]
        public long[] FleetVehicleRevenueIds { get; set; }

        [JsonProperty("fleet_vehicle_revenues_count")]
        public int? FleetVehicleRevenuesCount { get; set; }

        [JsonProperty("has_fleet_vehicle_revenue")]
        public bool? HasFleetVehicleRevenue { get; set; }

        [JsonProperty("has_vehicle_revenue")]
        public bool? HasVehicleRevenue { get; set; }

        [JsonProperty("license_plate")]
        public string LicensePlate { get; set; }

        [JsonProperty("car_model")]
        public string CarModel { get; set; }

        // hr.employee
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

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
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeAccountInvoiceLineOdooEnum
    {
        [EnumMember(Value = "out_invoice")]
        CustomerInvoice = 1,

        [EnumMember(Value = "in_invoice")]
        VendorBill = 2,

        [EnumMember(Value = "out_refund")]
        CustomerCreditNote = 3,

        [EnumMember(Value = "in_refund")]
        VendorCreditNote = 4,
    }


    // Technical field for UX purpose.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DisplayTypeAccountInvoiceLineOdooEnum
    {
        [EnumMember(Value = "line_section")]
        Section = 1,

        [EnumMember(Value = "line_note")]
        Note = 2,
    }
}
