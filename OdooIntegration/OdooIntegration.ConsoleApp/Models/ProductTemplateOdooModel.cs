using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("product.template")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ProductTemplateOdooModel : IOdooModel
    {

        // account.tax
        [JsonProperty("taxes_id")]
        public long[] TaxesId { get; set; }

        // account.tax
        [JsonProperty("supplier_taxes_id")]
        public long[] SupplierTaxesId { get; set; }

        // account.account
        [JsonProperty("property_account_income_id")]
        public long? PropertyAccountIncomeId { get; set; }

        // account.account
        [JsonProperty("property_account_expense_id")]
        public long? PropertyAccountExpenseId { get; set; }

        // required
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("description_purchase")]
        public string DescriptionPurchase { get; set; }

        [JsonProperty("description_sale")]
        public string DescriptionSale { get; set; }

        // required
        [JsonProperty("type")]
        public ProductTypeProductTemplateOdooEnum Type { get; set; }

        // product.category
        // required
        [JsonProperty("categ_id")]
        public long CategId { get; set; }

        // res.currency
        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        // res.currency
        [JsonProperty("cost_currency_id")]
        public long? CostCurrencyId { get; set; }

        [JsonProperty("price")]
        public double? Price { get; set; }

        [JsonProperty("list_price")]
        public double? ListPrice { get; set; }

        [JsonProperty("lst_price")]
        public double? LstPrice { get; set; }

        [JsonProperty("standard_price")]
        public double? StandardPrice { get; set; }

        [JsonProperty("volume")]
        public double? Volume { get; set; }

        [JsonProperty("volume_uom_name")]
        public string VolumeUomName { get; set; }

        [JsonProperty("weight")]
        public double? Weight { get; set; }

        [JsonProperty("weight_uom_name")]
        public string WeightUomName { get; set; }

        [JsonProperty("sale_ok")]
        public bool? SaleOk { get; set; }

        [JsonProperty("purchase_ok")]
        public bool? PurchaseOk { get; set; }

        // product.pricelist
        [JsonProperty("pricelist_id")]
        public long? PricelistId { get; set; }

        // uom.uom
        // required
        [JsonProperty("uom_id")]
        public long UomId { get; set; }

        [JsonProperty("uom_name")]
        public string UomName { get; set; }

        // uom.uom
        // required
        [JsonProperty("uom_po_id")]
        public long UomPoId { get; set; }

        // res.company
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        // product.packaging
        [JsonProperty("packaging_ids")]
        public long[] PackagingIds { get; set; }

        // product.supplierinfo
        [JsonProperty("seller_ids")]
        public long[] SellerIds { get; set; }

        // product.supplierinfo
        [JsonProperty("variant_seller_ids")]
        public long[] VariantSellerIds { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("color")]
        public int? Color { get; set; }

        [JsonProperty("is_product_variant")]
        public bool? IsProductVariant { get; set; }

        // product.template.attribute.line
        [JsonProperty("attribute_line_ids")]
        public long[] AttributeLineIds { get; set; }

        // product.template.attribute.line
        [JsonProperty("valid_product_template_attribute_line_ids")]
        public long[] ValidProductTemplateAttributeLineIds { get; set; }

        // product.product
        // required
        [JsonProperty("product_variant_ids")]
        public long[] ProductVariantIds { get; set; }

        // product.product
        [JsonProperty("product_variant_id")]
        public long? ProductVariantId { get; set; }

        [JsonProperty("product_variant_count")]
        public int? ProductVariantCount { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("default_code")]
        public string DefaultCode { get; set; }

        [JsonProperty("pricelist_item_count")]
        public int? PricelistItemCount { get; set; }

        [JsonProperty("can_image_1024_be_zoomed")]
        public bool? CanImage1024BeZoomed { get; set; }

        [JsonProperty("has_configurable_attributes")]
        public bool? HasConfigurableAttributes { get; set; }

        [JsonProperty("image_1920")]
        public string Image1920 { get; set; }

        [JsonProperty("image_1024")]
        public string Image1024 { get; set; }

        [JsonProperty("image_512")]
        public string Image512 { get; set; }

        [JsonProperty("image_256")]
        public string Image256 { get; set; }

        [JsonProperty("image_128")]
        public string Image128 { get; set; }

        // mail.activity
        [JsonProperty("activity_ids")]
        public long[] ActivityIds { get; set; }

        [JsonProperty("activity_state")]
        public ActivityStateProductTemplateOdooEnum? ActivityState { get; set; }

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
        public ActivityExceptionDecorationProductTemplateOdooEnum? ActivityExceptionDecoration { get; set; }

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
    }


    // A storable product is a product for which you manage stock. The Inventory app has to be installed.
    // A consumable product is a product for which stock is not managed.
    // A service is a non-material product you provide.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductTypeProductTemplateOdooEnum
    {
        [EnumMember(Value = "consu")]
        Consumable = 1,

        [EnumMember(Value = "service")]
        Service = 2,
    }


    // Status based on activities
    // Overdue: Due date is already passed
    // Today: Activity date is today
    // Planned: Future activities.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActivityStateProductTemplateOdooEnum
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
    public enum ActivityExceptionDecorationProductTemplateOdooEnum
    {
        [EnumMember(Value = "warning")]
        Alert = 1,

        [EnumMember(Value = "danger")]
        Error = 2,
    }

}
