using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("product.product")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ProductProductOdooModel : IOdooModel
    {
        /// <summary>
        /// price - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("price")]
        public double? Price { get; set; }

        /// <summary>
        /// price_extra - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: This is the sum of the extra price of all attributes <br />
        /// </summary>
        [JsonProperty("price_extra")]
        public double? PriceExtra { get; set; }

        /// <summary>
        /// lst_price - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: The sale price is managed from the product template. Click on the 'Configure Variants' button to set the extra attribute prices. <br />
        /// </summary>
        [JsonProperty("lst_price")]
        public double? LstPrice { get; set; }

        /// <summary>
        /// default_code - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("default_code")]
        public string DefaultCode { get; set; }

        /// <summary>
        /// code - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// partner_ref - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("partner_ref")]
        public string PartnerRef { get; set; }

        /// <summary>
        /// active - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: If unchecked, it will allow you to hide the product without removing it. <br />
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// product_tmpl_id - many2one - product.template <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_tmpl_id")]
        public long ProductTmplId { get; set; }

        /// <summary>
        /// barcode - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: International Article Number used for product identification. <br />
        /// </summary>
        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// attribute_value_ids - many2many - product.attribute.value <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("attribute_value_ids")]
        public long[] AttributeValueIds { get; set; }

        /// <summary>
        /// product_template_attribute_value_ids - many2many - product.template.attribute.value <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_template_attribute_value_ids")]
        public long[] ProductTemplateAttributeValueIds { get; set; }

        /// <summary>
        /// image_variant - binary  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: This field holds the image used as image for the product variant, limited to 1024x1024px. <br />
        /// </summary>
        [JsonProperty("image_variant")]
        public string ImageVariant { get; set; }

        /// <summary>
        /// image - binary  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Image of the product variant (Big-sized image of product template if false). It is automatically resized as a 1024x1024px image, with aspect ratio preserved. <br />
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// image_small - binary  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Image of the product variant (Small-sized image of product template if false). <br />
        /// </summary>
        [JsonProperty("image_small")]
        public string ImageSmall { get; set; }

        /// <summary>
        /// image_medium - binary  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Image of the product variant (Medium-sized image of product template if false). <br />
        /// </summary>
        [JsonProperty("image_medium")]
        public string ImageMedium { get; set; }

        /// <summary>
        /// is_product_variant - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("is_product_variant")]
        public bool? IsProductVariant { get; set; }

        /// <summary>
        /// standard_price - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Cost used for stock valuation in standard price and as a first price to set in average/fifo. Also used as a base price for pricelists. Expressed in the default unit of measure of the product. <br />
        /// </summary>
        [JsonProperty("standard_price")]
        public double? StandardPrice { get; set; }

        /// <summary>
        /// volume - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The volume in m3. <br />
        /// </summary>
        [JsonProperty("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// weight - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Weight of the product, packaging not included. The unit of measure can be changed in the general settings <br />
        /// </summary>
        [JsonProperty("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// pricelist_item_ids - many2many - product.pricelist.item <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("pricelist_item_ids")]
        public long[] PricelistItemIds { get; set; }

        /// <summary>
        /// packaging_ids - one2many - product.packaging (product_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Gives the different ways to package the same product. <br />
        /// </summary>
        [JsonProperty("packaging_ids")]
        public long[] PackagingIds { get; set; }

        /// <summary>
        /// stock_quant_ids - one2many - stock.quant (product_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Technical: used to compute quantities. <br />
        /// </summary>
        [JsonProperty("stock_quant_ids")]
        public long[] StockQuantIds { get; set; }

        /// <summary>
        /// stock_move_ids - one2many - stock.move (product_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Technical: used to compute quantities. <br />
        /// </summary>
        [JsonProperty("stock_move_ids")]
        public long[] StockMoveIds { get; set; }

        /// <summary>
        /// qty_available - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Current quantity of products.; In a context with a single Stock Location, this includes goods stored at this Location, or any of its children.; In a context with a single Warehouse, this includes goods stored in the Stock Location of this Warehouse, or any of its children.; stored in the Stock Location of the Warehouse of this Shop, or any of its children.; Otherwise, this includes goods stored in any Stock Location with 'internal' type. <br />
        /// </summary>
        [JsonProperty("qty_available")]
        public double? QtyAvailable { get; set; }

        /// <summary>
        /// virtual_available - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Forecast quantity (computed as Quantity On Hand - Outgoing + Incoming); In a context with a single Stock Location, this includes goods stored in this location, or any of its children.; In a context with a single Warehouse, this includes goods stored in the Stock Location of this Warehouse, or any of its children.; Otherwise, this includes goods stored in any Stock Location with 'internal' type. <br />
        /// </summary>
        [JsonProperty("virtual_available")]
        public double? VirtualAvailable { get; set; }

        /// <summary>
        /// incoming_qty - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Quantity of planned incoming products.; In a context with a single Stock Location, this includes goods arriving to this Location, or any of its children.; In a context with a single Warehouse, this includes goods arriving to the Stock Location of this Warehouse, or any of its children.; Otherwise, this includes goods arriving to any Stock Location with 'internal' type. <br />
        /// </summary>
        [JsonProperty("incoming_qty")]
        public double? IncomingQty { get; set; }

        /// <summary>
        /// outgoing_qty - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Quantity of planned outgoing products.; In a context with a single Stock Location, this includes goods leaving this Location, or any of its children.; In a context with a single Warehouse, this includes goods leaving the Stock Location of this Warehouse, or any of its children.; Otherwise, this includes goods leaving any Stock Location with 'internal' type. <br />
        /// </summary>
        [JsonProperty("outgoing_qty")]
        public double? OutgoingQty { get; set; }

        /// <summary>
        /// orderpoint_ids - one2many - stock.warehouse.orderpoint (product_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("orderpoint_ids")]
        public long[] OrderpointIds { get; set; }

        /// <summary>
        /// nbr_reordering_rules - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("nbr_reordering_rules")]
        public int? NbrReorderingRules { get; set; }

        /// <summary>
        /// reordering_min_qty - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("reordering_min_qty")]
        public double? ReorderingMinQty { get; set; }

        /// <summary>
        /// reordering_max_qty - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("reordering_max_qty")]
        public double? ReorderingMaxQty { get; set; }

        /// <summary>
        /// date_from - date  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("date_from")]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// date_to - date  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("date_to")]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// invoice_state - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("invoice_state")]
        public InvoiceStateProductProductOdooEnum? InvoiceState { get; set; }

        /// <summary>
        /// sale_avg_price - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Avg. Price in Customer Invoices. <br />
        /// </summary>
        [JsonProperty("sale_avg_price")]
        public double? SaleAvgPrice { get; set; }

        /// <summary>
        /// purchase_avg_price - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Avg. Price in Vendor Bills  <br />
        /// </summary>
        [JsonProperty("purchase_avg_price")]
        public double? PurchaseAvgPrice { get; set; }

        /// <summary>
        /// sale_num_invoiced - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Sum of Quantity in Customer Invoices <br />
        /// </summary>
        [JsonProperty("sale_num_invoiced")]
        public double? SaleNumInvoiced { get; set; }

        /// <summary>
        /// purchase_num_invoiced - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Sum of Quantity in Vendor Bills <br />
        /// </summary>
        [JsonProperty("purchase_num_invoiced")]
        public double? PurchaseNumInvoiced { get; set; }

        /// <summary>
        /// sales_gap - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Expected Sale - Turn Over <br />
        /// </summary>
        [JsonProperty("sales_gap")]
        public double? SalesGap { get; set; }

        /// <summary>
        /// purchase_gap - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Normal Cost - Total Cost <br />
        /// </summary>
        [JsonProperty("purchase_gap")]
        public double? PurchaseGap { get; set; }

        /// <summary>
        /// turnover - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Sum of Multiplication of Invoice price and quantity of Customer Invoices <br />
        /// </summary>
        [JsonProperty("turnover")]
        public double? Turnover { get; set; }

        /// <summary>
        /// total_cost - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Sum of Multiplication of Invoice price and quantity of Vendor Bills  <br />
        /// </summary>
        [JsonProperty("total_cost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// sale_expected - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Sum of Multiplication of Sale Catalog price and quantity of Customer Invoices <br />
        /// </summary>
        [JsonProperty("sale_expected")]
        public double? SaleExpected { get; set; }

        /// <summary>
        /// normal_cost - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Sum of Multiplication of Cost price and quantity of Vendor Bills <br />
        /// </summary>
        [JsonProperty("normal_cost")]
        public double? NormalCost { get; set; }

        /// <summary>
        /// total_margin - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Turnover - Standard price <br />
        /// </summary>
        [JsonProperty("total_margin")]
        public double? TotalMargin { get; set; }

        /// <summary>
        /// expected_margin - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Expected Sale - Normal Cost <br />
        /// </summary>
        [JsonProperty("expected_margin")]
        public double? ExpectedMargin { get; set; }

        /// <summary>
        /// total_margin_rate - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Total margin * 100 / Turnover <br />
        /// </summary>
        [JsonProperty("total_margin_rate")]
        public double? TotalMarginRate { get; set; }

        /// <summary>
        /// expected_margin_rate - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Expected margin * 100 / Expected Sale <br />
        /// </summary>
        [JsonProperty("expected_margin_rate")]
        public double? ExpectedMarginRate { get; set; }

        /// <summary>
        /// purchased_product_qty - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("purchased_product_qty")]
        public double? PurchasedProductQty { get; set; }

        /// <summary>
        /// stock_value_currency_id - many2one - res.currency <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("stock_value_currency_id")]
        public long? StockValueCurrencyId { get; set; }

        /// <summary>
        /// stock_value - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("stock_value")]
        public double? StockValue { get; set; }

        /// <summary>
        /// qty_at_date - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("qty_at_date")]
        public double? QtyAtDate { get; set; }

        /// <summary>
        /// stock_fifo_real_time_aml_ids - many2many - account.move.line <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("stock_fifo_real_time_aml_ids")]
        public long[] StockFifoRealTimeAmlIds { get; set; }

        /// <summary>
        /// stock_fifo_manual_move_ids - many2many - stock.move <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("stock_fifo_manual_move_ids")]
        public long[] StockFifoManualMoveIds { get; set; }

        /// <summary>
        /// sales_count - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("sales_count")]
        public double? SalesCount { get; set; }

        /// <summary>
        /// activity_ids - one2many - mail.activity (res_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_ids")]
        public long[] ActivityIds { get; set; }

        /// <summary>
        /// activity_state - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Status based on activities; Overdue: Due date is already passed; Today: Activity date is today; Planned: Future activities. <br />
        /// </summary>
        [JsonProperty("activity_state")]
        public ActivityStateProductProductOdooEnum? ActivityState { get; set; }

        /// <summary>
        /// activity_user_id - many2one - res.users <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_user_id")]
        public long? ActivityUserId { get; set; }

        /// <summary>
        /// activity_type_id - many2one - mail.activity.type <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_type_id")]
        public long? ActivityTypeId { get; set; }

        /// <summary>
        /// activity_date_deadline - date  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_date_deadline")]
        public DateTime? ActivityDateDeadline { get; set; }

        /// <summary>
        /// activity_summary - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_summary")]
        public string ActivitySummary { get; set; }

        /// <summary>
        /// message_is_follower - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_is_follower")]
        public bool? MessageIsFollower { get; set; }

        /// <summary>
        /// message_follower_ids - one2many - mail.followers (res_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_follower_ids")]
        public long[] MessageFollowerIds { get; set; }

        /// <summary>
        /// message_partner_ids - many2many - res.partner <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_partner_ids")]
        public long[] MessagePartnerIds { get; set; }

        /// <summary>
        /// message_channel_ids - many2many - mail.channel <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_channel_ids")]
        public long[] MessageChannelIds { get; set; }

        /// <summary>
        /// message_ids - one2many - mail.message (res_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_ids")]
        public long[] MessageIds { get; set; }

        /// <summary>
        /// message_unread - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: If checked new messages require your attention. <br />
        /// </summary>
        [JsonProperty("message_unread")]
        public bool? MessageUnread { get; set; }

        /// <summary>
        /// message_unread_counter - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of unread messages <br />
        /// </summary>
        [JsonProperty("message_unread_counter")]
        public int? MessageUnreadCounter { get; set; }

        /// <summary>
        /// message_needaction - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: If checked, new messages require your attention. <br />
        /// </summary>
        [JsonProperty("message_needaction")]
        public bool? MessageNeedaction { get; set; }

        /// <summary>
        /// message_needaction_counter - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of messages which requires an action <br />
        /// </summary>
        [JsonProperty("message_needaction_counter")]
        public int? MessageNeedactionCounter { get; set; }

        /// <summary>
        /// message_has_error - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: If checked, some messages have a delivery error. <br />
        /// </summary>
        [JsonProperty("message_has_error")]
        public bool? MessageHasError { get; set; }

        /// <summary>
        /// message_has_error_counter - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of messages with delivery error <br />
        /// </summary>
        [JsonProperty("message_has_error_counter")]
        public int? MessageHasErrorCounter { get; set; }

        /// <summary>
        /// message_attachment_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_attachment_count")]
        public int? MessageAttachmentCount { get; set; }

        /// <summary>
        /// message_main_attachment_id - many2one - ir.attachment <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("message_main_attachment_id")]
        public long? MessageMainAttachmentId { get; set; }

        /// <summary>
        /// website_message_ids - one2many - mail.message (res_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Website communication history <br />
        /// </summary>
        [JsonProperty("website_message_ids")]
        public long[] WebsiteMessageIds { get; set; }

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
        /// name - char  <br />
        /// Required: True, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// sequence - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Gives the sequence order when displaying a product list <br />
        /// </summary>
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        /// <summary>
        /// description - text  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// description_purchase - text  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("description_purchase")]
        public string DescriptionPurchase { get; set; }

        /// <summary>
        /// description_sale - text  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: A description of the Product that you want to communicate to your customers. This description will be copied to every Sales Order, Delivery Order and Customer Invoice/Credit Note <br />
        /// </summary>
        [JsonProperty("description_sale")]
        public string DescriptionSale { get; set; }

        /// <summary>
        /// rental - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("rental")]
        public bool? Rental { get; set; }

        /// <summary>
        /// categ_id - many2one - product.category <br />
        /// Required: True, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Select category for the current product <br />
        /// </summary>
        [JsonProperty("categ_id")]
        public long CategId { get; set; }

        /// <summary>
        /// currency_id - many2one - res.currency <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        /// <summary>
        /// cost_currency_id - many2one - res.currency <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("cost_currency_id")]
        public long? CostCurrencyId { get; set; }

        /// <summary>
        /// list_price - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Price at which the product is sold to customers. <br />
        /// </summary>
        [JsonProperty("list_price")]
        public double? ListPrice { get; set; }

        /// <summary>
        /// weight_uom_id - many2one - uom.uom <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("weight_uom_id")]
        public long? WeightUomId { get; set; }

        /// <summary>
        /// weight_uom_name - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("weight_uom_name")]
        public string WeightUomName { get; set; }

        /// <summary>
        /// sale_ok - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("sale_ok")]
        public bool? SaleOk { get; set; }

        /// <summary>
        /// purchase_ok - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("purchase_ok")]
        public bool? PurchaseOk { get; set; }

        /// <summary>
        /// pricelist_id - many2one - product.pricelist <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Technical field. Used for searching on pricelists, not stored in database. <br />
        /// </summary>
        [JsonProperty("pricelist_id")]
        public long? PricelistId { get; set; }

        /// <summary>
        /// uom_id - many2one - uom.uom <br />
        /// Required: True, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Default unit of measure used for all stock operations. <br />
        /// </summary>
        [JsonProperty("uom_id")]
        public long UomId { get; set; }

        /// <summary>
        /// uom_name - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("uom_name")]
        public string UomName { get; set; }

        /// <summary>
        /// uom_po_id - many2one - uom.uom <br />
        /// Required: True, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Default unit of measure used for purchase orders. It must be in the same category as the default unit of measure. <br />
        /// </summary>
        [JsonProperty("uom_po_id")]
        public long UomPoId { get; set; }

        /// <summary>
        /// company_id - many2one - res.company <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        /// <summary>
        /// seller_ids - one2many - product.supplierinfo <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Define vendor pricelists. <br />
        /// </summary>
        [JsonProperty("seller_ids")]
        public long[] SellerIds { get; set; }

        /// <summary>
        /// variant_seller_ids - one2many - product.supplierinfo <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("variant_seller_ids")]
        public long[] VariantSellerIds { get; set; }

        /// <summary>
        /// attribute_line_ids - one2many - product.template.attribute.line <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("attribute_line_ids")]
        public long[] AttributeLineIds { get; set; }

        /// <summary>
        /// valid_product_template_attribute_line_ids - many2many - product.template.attribute.line <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Technical compute <br />
        /// </summary>
        [JsonProperty("valid_product_template_attribute_line_ids")]
        public long[] ValidProductTemplateAttributeLineIds { get; set; }

        /// <summary>
        /// valid_product_attribute_value_ids - many2many - product.attribute.value <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Technical compute <br />
        /// </summary>
        [JsonProperty("valid_product_attribute_value_ids")]
        public long[] ValidProductAttributeValueIds { get; set; }

        /// <summary>
        /// valid_product_attribute_ids - many2many - product.attribute <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Technical compute <br />
        /// </summary>
        [JsonProperty("valid_product_attribute_ids")]
        public long[] ValidProductAttributeIds { get; set; }

        /// <summary>
        /// valid_product_template_attribute_line_wnva_ids - many2many - product.template.attribute.line <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Technical compute <br />
        /// </summary>
        [JsonProperty("valid_product_template_attribute_line_wnva_ids")]
        public long[] ValidProductTemplateAttributeLineWnvaIds { get; set; }

        /// <summary>
        /// valid_product_attribute_value_wnva_ids - many2many - product.attribute.value <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Technical compute <br />
        /// </summary>
        [JsonProperty("valid_product_attribute_value_wnva_ids")]
        public long[] ValidProductAttributeValueWnvaIds { get; set; }

        /// <summary>
        /// valid_product_attribute_wnva_ids - many2many - product.attribute <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Technical compute <br />
        /// </summary>
        [JsonProperty("valid_product_attribute_wnva_ids")]
        public long[] ValidProductAttributeWnvaIds { get; set; }

        /// <summary>
        /// valid_archived_variant_ids - many2many - product.product <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Technical compute <br />
        /// </summary>
        [JsonProperty("valid_archived_variant_ids")]
        public long[] ValidArchivedVariantIds { get; set; }

        /// <summary>
        /// valid_existing_variant_ids - many2many - product.product <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Technical compute <br />
        /// </summary>
        [JsonProperty("valid_existing_variant_ids")]
        public long[] ValidExistingVariantIds { get; set; }

        /// <summary>
        /// product_variant_ids - one2many - product.product <br />
        /// Required: True, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_variant_ids")]
        public long[] ProductVariantIds { get; set; }

        /// <summary>
        /// product_variant_id - many2one - product.product <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_variant_id")]
        public long? ProductVariantId { get; set; }

        /// <summary>
        /// product_variant_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_variant_count")]
        public int? ProductVariantCount { get; set; }

        /// <summary>
        /// item_ids - one2many - product.pricelist.item <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("item_ids")]
        public long[] ItemIds { get; set; }

        /// <summary>
        /// product_code - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// product_company - many2one - res.company <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_company")]
        public long? ProductCompany { get; set; }

        /// <summary>
        /// origin - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// ubicacion - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("ubicacion")]
        public string Ubicacion { get; set; }

        /// <summary>
        /// placa - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("placa")]
        public string Placa { get; set; }

        /// <summary>
        /// marca - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("marca")]
        public string Marca { get; set; }

        /// <summary>
        /// modelo - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("modelo")]
        public string Modelo { get; set; }

        /// <summary>
        /// anno - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("anno")]
        public int? Anno { get; set; }

        /// <summary>
        /// fecha_ingreso - datetime  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("fecha_ingreso")]
        public DateTime? FechaIngreso { get; set; }

        /// <summary>
        /// numer_dias - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("numer_dias")]
        public int? NumerDias { get; set; }

        /// <summary>
        /// km_millas - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("km_millas")]
        public KmMillasCompraProductProductOdooEnum? KmMillas { get; set; }

        /// <summary>
        /// km_millas_v - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("km_millas_v")]
        public string KmMillasV { get; set; }

        /// <summary>
        /// kms - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("kms")]
        public string Kms { get; set; }

        /// <summary>
        /// millaje - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("millaje")]
        public string Millaje { get; set; }

        /// <summary>
        /// color - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }

        /// <summary>
        /// color_interno - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("color_interno")]
        public string ColorInterno { get; set; }

        /// <summary>
        /// motor - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("motor")]
        public string Motor { get; set; }

        /// <summary>
        /// chasis - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("chasis")]
        public string Chasis { get; set; }

        /// <summary>
        /// vin - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("vin")]
        public string Vin { get; set; }

        /// <summary>
        /// circulacion - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("circulacion")]
        public string Circulacion { get; set; }

        /// <summary>
        /// pasajeros - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("pasajeros")]
        public int? Pasajeros { get; set; }

        /// <summary>
        /// cilindraje - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("cilindraje")]
        public int? Cilindraje { get; set; }

        /// <summary>
        /// combustible - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("combustible")]
        public string Combustible { get; set; }

        /// <summary>
        /// tipo - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("tipo")]
        public string Tipo { get; set; }

        /// <summary>
        /// puertas - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("puertas")]
        public int? Puertas { get; set; }

        /// <summary>
        /// motor_cc - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("motor_cc")]
        public string MotorCc { get; set; }

        /// <summary>
        /// nombre_circ - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("nombre_circ")]
        public string NombreCirc { get; set; }

        /// <summary>
        /// consumo_comb - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("consumo_comb")]
        public string ConsumoComb { get; set; }

        /// <summary>
        /// estado - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("estado")]
        public string Estado { get; set; }

        /// <summary>
        /// consignado_por - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("consignado_por")]
        public string ConsignadoPor { get; set; }

        /// <summary>
        /// trasmision - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("trasmision")]
        public string Trasmision { get; set; }

        /// <summary>
        /// direccion - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("direccion")]
        public string Direccion { get; set; }

        /// <summary>
        /// costo_vehiculo - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("costo_vehiculo")]
        public double? CostoVehiculo { get; set; }

        /// <summary>
        /// costo_inv - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("costo_inv")]
        public double? CostoInv { get; set; }

        /// <summary>
        /// costo_total - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("costo_total")]
        public double? CostoTotal { get; set; }

        /// <summary>
        /// precio_geren - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("precio_geren")]
        public double? PrecioGeren { get; set; }

        /// <summary>
        /// precio_min - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("precio_min")]
        public double? PrecioMin { get; set; }

        /// <summary>
        /// precio_list - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("precio_list")]
        public double? PrecioList { get; set; }

        /// <summary>
        /// precio_vendedor - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("precio_vendedor")]
        public double? PrecioVendedor { get; set; }

        /// <summary>
        /// precio_financiado - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("precio_financiado")]
        public double? PrecioFinanciado { get; set; }

        /// <summary>
        /// garantia - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("garantia")]
        public double? Garantia { get; set; }

        /// <summary>
        /// responsible_id - many2one - res.users <br />
        /// Required: True, Readonly: False, Store: False, Sortable: True <br />
        /// Help: This user will be responsible of the next activities related to logistic operations for this product. <br />
        /// </summary>
        [JsonProperty("responsible_id")]
        public long ResponsibleId { get; set; }

        /// <summary>
        /// type - selection  <br />
        /// Required: True, Readonly: False, Store: False, Sortable: True <br />
        /// Help: A storable product is a product for which you manage stock. The Inventory app has to be installed.; A consumable product is a product for which stock is not managed.; A service is a non-material product you provide. <br />
        /// </summary>
        [JsonProperty("type")]
        public ProductTypeProductProductOdooEnum Type { get; set; }

        /// <summary>
        /// property_stock_production - many2one - stock.location <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: This stock location will be used, instead of the default one, as the source location for stock moves generated by manufacturing orders. <br />
        /// </summary>
        [JsonProperty("property_stock_production")]
        public long? PropertyStockProduction { get; set; }

        /// <summary>
        /// property_stock_inventory - many2one - stock.location <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: This stock location will be used, instead of the default one, as the source location for stock moves generated when you do an inventory. <br />
        /// </summary>
        [JsonProperty("property_stock_inventory")]
        public long? PropertyStockInventory { get; set; }

        /// <summary>
        /// sale_delay - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Delivery lead time, in days. It's the number of days, promised to the customer, between the confirmation of the sales order and the delivery. <br />
        /// </summary>
        [JsonProperty("sale_delay")]
        public double? SaleDelay { get; set; }

        /// <summary>
        /// tracking - selection  <br />
        /// Required: True, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Ensure the traceability of a storable product in your warehouse. <br />
        /// </summary>
        [JsonProperty("tracking")]
        public TrackingProductProductOdooEnum Tracking { get; set; }

        /// <summary>
        /// description_picking - text  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("description_picking")]
        public string DescriptionPicking { get; set; }

        /// <summary>
        /// description_pickingout - text  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("description_pickingout")]
        public string DescriptionPickingout { get; set; }

        /// <summary>
        /// description_pickingin - text  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("description_pickingin")]
        public string DescriptionPickingin { get; set; }

        /// <summary>
        /// location_id - many2one - stock.location <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("location_id")]
        public long? LocationId { get; set; }

        /// <summary>
        /// warehouse_id - many2one - stock.warehouse <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("warehouse_id")]
        public long? WarehouseId { get; set; }

        /// <summary>
        /// route_from_categ_ids - many2many - stock.location.route <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("route_from_categ_ids")]
        public long[] RouteFromCategIds { get; set; }

        /// <summary>
        /// taxes_id - many2many - account.tax <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Default taxes used when selling the product. <br />
        /// </summary>
        [JsonProperty("taxes_id")]
        public long[] TaxesId { get; set; }

        /// <summary>
        /// supplier_taxes_id - many2many - account.tax <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Default taxes used when buying the product. <br />
        /// </summary>
        [JsonProperty("supplier_taxes_id")]
        public long[] SupplierTaxesId { get; set; }

        /// <summary>
        /// property_account_income_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Keep this field empty to use the default value from the product category. <br />
        /// </summary>
        [JsonProperty("property_account_income_id")]
        public long? PropertyAccountIncomeId { get; set; }

        /// <summary>
        /// property_account_expense_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Keep this field empty to use the default value from the product category. If anglo-saxon accounting with automated valuation method is configured, the expense account on the product category will be used. <br />
        /// </summary>
        [JsonProperty("property_account_expense_id")]
        public long? PropertyAccountExpenseId { get; set; }

        /// <summary>
        /// asset_category_id - many2one - account.asset.category <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("asset_category_id")]
        public long? AssetCategoryId { get; set; }

        /// <summary>
        /// deferred_revenue_category_id - many2one - account.asset.category <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("deferred_revenue_category_id")]
        public long? DeferredRevenueCategoryId { get; set; }

        /// <summary>
        /// email_template_id - many2one - mail.template <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: When validating an invoice, an email will be sent to the customer based on this template. The customer will receive an email for each product linked to an email template. <br />
        /// </summary>
        [JsonProperty("email_template_id")]
        public long? EmailTemplateId { get; set; }

        /// <summary>
        /// property_account_creditor_price_difference - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: This account is used in automated inventory valuation to record the price difference between a purchase order and its related vendor bill when validating this vendor bill. <br />
        /// </summary>
        [JsonProperty("property_account_creditor_price_difference")]
        public long? PropertyAccountCreditorPriceDifference { get; set; }

        /// <summary>
        /// purchase_method - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: On ordered quantities: Control bills based on ordered quantities.; On received quantities: Control bills based on received quantities. <br />
        /// </summary>
        [JsonProperty("purchase_method")]
        public ControlPolicyProductProductOdooEnum? PurchaseMethod { get; set; }

        /// <summary>
        /// purchase_line_warn - selection  <br />
        /// Required: True, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field. <br />
        /// </summary>
        [JsonProperty("purchase_line_warn")]
        public PurchaseOrderLineProductProductOdooEnum PurchaseLineWarn { get; set; }

        /// <summary>
        /// purchase_line_warn_msg - text  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("purchase_line_warn_msg")]
        public string PurchaseLineWarnMsg { get; set; }

        /// <summary>
        /// property_valuation - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Manual: The accounting entries to value the inventory are not posted automatically.;         Automated: An accounting entry is automatically created to value the inventory when a product enters or leaves the company. <br />
        /// </summary>
        [JsonProperty("property_valuation")]
        public InventoryValuationProductProductOdooEnum? PropertyValuation { get; set; }

        /// <summary>
        /// valuation - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("valuation")]
        public string Valuation { get; set; }

        /// <summary>
        /// property_cost_method - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Standard Price: The products are valued at their standard cost defined on the product.;         Average Cost (AVCO): The products are valued at weighted average cost.;         First In First Out (FIFO): The products are valued supposing those that enter the company first will also leave it first. <br />
        /// </summary>
        [JsonProperty("property_cost_method")]
        public CostingMethodProductProductOdooEnum? PropertyCostMethod { get; set; }

        /// <summary>
        /// cost_method - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("cost_method")]
        public string CostMethod { get; set; }

        /// <summary>
        /// property_stock_account_input - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: When doing real-time inventory valuation, counterpart journal items for all incoming stock moves will be posted in this account, unless there is a specific valuation account set on the source location. When not set on the product, the one from the product category is used. <br />
        /// </summary>
        [JsonProperty("property_stock_account_input")]
        public long? PropertyStockAccountInput { get; set; }

        /// <summary>
        /// property_stock_account_output - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: When doing real-time inventory valuation, counterpart journal items for all outgoing stock moves will be posted in this account, unless there is a specific valuation account set on the destination location. When not set on the product, the one from the product category is used. <br />
        /// </summary>
        [JsonProperty("property_stock_account_output")]
        public long? PropertyStockAccountOutput { get; set; }

        /// <summary>
        /// route_ids - many2many - stock.location.route <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Depending on the modules installed, this will allow you to define the route of the product: whether it will be bought, manufactured, MTO, etc. <br />
        /// </summary>
        [JsonProperty("route_ids")]
        public long[] RouteIds { get; set; }

        /// <summary>
        /// optional_product_ids - many2many - product.template <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Optional Products are suggested whenever the customer hits *Add to Cart* (cross-sell strategy, e.g. for computers: warranty, software, etc.). <br />
        /// </summary>
        [JsonProperty("optional_product_ids")]
        public long[] OptionalProductIds { get; set; }

        /// <summary>
        /// sale_line_warn - selection  <br />
        /// Required: True, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field. <br />
        /// </summary>
        [JsonProperty("sale_line_warn")]
        public SalesOrderLineProductProductOdooEnum SaleLineWarn { get; set; }

        /// <summary>
        /// sale_line_warn_msg - text  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("sale_line_warn_msg")]
        public string SaleLineWarnMsg { get; set; }

        /// <summary>
        /// expense_policy - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Expenses and vendor bills can be re-invoiced to a customer.With this option, a validated expense can be re-invoice to a customer at its cost or sales price. <br />
        /// </summary>
        [JsonProperty("expense_policy")]
        public ReInvoicePolicyProductProductOdooEnum? ExpensePolicy { get; set; }

        /// <summary>
        /// hide_expense_policy - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("hide_expense_policy")]
        public bool? HideExpensePolicy { get; set; }

        /// <summary>
        /// invoice_policy - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Ordered Quantity: Invoice quantities ordered by the customer.; Delivered Quantity: Invoice quantities delivered to the customer. <br />
        /// </summary>
        [JsonProperty("invoice_policy")]
        public InvoicingPolicyProductProductOdooEnum? InvoicePolicy { get; set; }

        /// <summary>
        /// partida_arancelaria - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("partida_arancelaria")]
        public string PartidaArancelaria { get; set; }

        /// <summary>
        /// cabys - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("cabys")]
        public string Cabys { get; set; }

        /// <summary>
        /// service_to_purchase - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: If ticked, each time you sell this product through a SO, a RfQ is automatically created to buy the product. Tip: don't forget to set a vendor on the product. <br />
        /// </summary>
        [JsonProperty("service_to_purchase")]
        public bool? ServiceToPurchase { get; set; }

        /// <summary>
        /// horas - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("horas")]
        public double? Horas { get; set; }

        /// <summary>
        /// quantity_range - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("quantity_range")]
        public double? QuantityRange { get; set; }

        /// <summary>
        /// service_policy - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("service_policy")]
        public ServiceInvoicingPolicyProductProductOdooEnum? ServicePolicy { get; set; }

        /// <summary>
        /// service_type - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Manually set quantities on order: Invoice based on the manually entered quantity, without creating an analytic account.; Timesheets on contract: Invoice based on the tracked hours on the related timesheet.; Create a task and track hours: Create a task on the sales order validation and track the work hours. <br />
        /// </summary>
        [JsonProperty("service_type")]
        public TrackServiceProductProductOdooEnum? ServiceType { get; set; }

        /// <summary>
        /// service_tracking - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: On Sales order confirmation, this product can generate a project and/or task. From those, you can track the service you are selling. <br />
        /// </summary>
        [JsonProperty("service_tracking")]
        public ServiceTrackingProductProductOdooEnum? ServiceTracking { get; set; }

        /// <summary>
        /// project_id - many2one - project.project <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Select a non billable project on which tasks can be created. This setting must be set for each company. <br />
        /// </summary>
        [JsonProperty("project_id")]
        public long? ProjectId { get; set; }

        /// <summary>
        /// project_template_id - many2one - project.project <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Select a non billable project to be the skeleton of the new created project when selling the current product. Its stages and tasks will be duplicated. <br />
        /// </summary>
        [JsonProperty("project_template_id")]
        public long? ProjectTemplateId { get; set; }

        /// <summary>
        /// x_studio_chasis - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("x_studio_chasis")]
        public string XStudioChasis { get; set; }

        /// <summary>
        /// x_product_tmpl_id__sale_report_count - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("x_product_tmpl_id__sale_report_count")]
        public int? XProductTmplIdSaleReportCount { get; set; }

        /// <summary>
        /// x_product_template_id__sale_product_configurator_count - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("x_product_template_id__sale_product_configurator_count")]
        public int? XProductTemplateIdSaleProductConfiguratorCount { get; set; }

        /// <summary>
        /// x_product_tmpl_id__report_all_channels_sales_count - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("x_product_tmpl_id__report_all_channels_sales_count")]
        public int? XProductTmplIdReportAllChannelsSalesCount { get; set; }

        /// <summary>
        /// x_product_tmpl_id__product_template_attribute_line_count - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("x_product_tmpl_id__product_template_attribute_line_count")]
        public int? XProductTmplIdProductTemplateAttributeLineCount { get; set; }

        /// <summary>
        /// x_product_tmpl_id__product_template_attribute_value_count - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("x_product_tmpl_id__product_template_attribute_value_count")]
        public int? XProductTmplIdProductTemplateAttributeValueCount { get; set; }

        /// <summary>
        /// x_product_tmpl_id__product_product_count - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("x_product_tmpl_id__product_product_count")]
        public int? XProductTmplIdProductProductCount { get; set; }

        /// <summary>
        /// x_product_tmpl_id__product_supplierinfo_count - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("x_product_tmpl_id__product_supplierinfo_count")]
        public int? XProductTmplIdProductSupplierinfoCount { get; set; }

        [JsonProperty("combination_indices")]
        public string CombinationIndices { get; set; }

        [JsonProperty("pricelist_item_count")]
        public int? PricelistItemCount { get; set; }

        [JsonProperty("image_variant_1920")]
        public string ImageVariant1920 { get; set; }

        [JsonProperty("image_variant_1024")]
        public string ImageVariant1024 { get; set; }

        [JsonProperty("image_variant_512")]
        public string ImageVariant512 { get; set; }

        [JsonProperty("image_variant_256")]
        public string ImageVariant256 { get; set; }

        [JsonProperty("image_variant_128")]
        public string ImageVariant128 { get; set; }

        [JsonProperty("can_image_variant_1024_be_zoomed")]
        public bool? CanImageVariant1024BeZoomed { get; set; }

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

        [JsonProperty("can_image_1024_be_zoomed")]
        public bool? CanImage1024BeZoomed { get; set; }

        [JsonProperty("my_activity_date_deadline")]
        public DateTime? MyActivityDateDeadline { get; set; }

        [JsonProperty("activity_exception_decoration")]
        public ActivityExceptionDecorationProductProductOdooEnum? ActivityExceptionDecoration { get; set; }

        [JsonProperty("activity_exception_icon")]
        public string ActivityExceptionIcon { get; set; }

        [JsonProperty("message_has_sms_error")]
        public bool? MessageHasSmsError { get; set; }

        [JsonProperty("activity_type_icon")]
        public string ActivityTypeIcon { get; set; }

        [JsonProperty("volume_uom_name")]
        public string VolumeUomName { get; set; }

        [JsonProperty("has_configurable_attributes")]
        public bool? HasConfigurableAttributes { get; set; }
    }

    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoiceStateProductProductOdooEnum
    {
        [EnumMember(Value = "paid")]
        Paid = 1,

        [EnumMember(Value = "open_paid")]
        OpenAndPaid = 2,

        [EnumMember(Value = "draft_open_paid")]
        DraftOpenAndPaid = 3,
    }


    /// <summary>
    /// Help: Status based on activities <br />
    /// Overdue: Due date is already passed <br />
    /// Today: Activity date is today <br />
    /// Planned: Future activities.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActivityStateProductProductOdooEnum
    {
        [EnumMember(Value = "overdue")]
        Overdue = 1,

        [EnumMember(Value = "today")]
        Today = 2,

        [EnumMember(Value = "planned")]
        Planned = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum KmMillasCompraProductProductOdooEnum
    {
        [EnumMember(Value = "kms")]
        Kms = 1,

        [EnumMember(Value = "millas")]
        Millas = 2,
    }


    /// <summary>
    /// Help: A storable product is a product for which you manage stock. The Inventory app has to be installed. <br />
    /// A consumable product is a product for which stock is not managed. <br />
    /// A service is a non-material product you provide.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductTypeProductProductOdooEnum
    {
        [EnumMember(Value = "consu")]
        Consumable = 1,

        [EnumMember(Value = "service")]
        Service = 2,

        [EnumMember(Value = "product")]
        StorableProduct = 3,
    }


    /// <summary>
    /// Help: Ensure the traceability of a storable product in your warehouse.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrackingProductProductOdooEnum
    {
        [EnumMember(Value = "serial")]
        ByUniqueSerialNumber = 1,

        [EnumMember(Value = "lot")]
        ByLots = 2,

        [EnumMember(Value = "none")]
        NoTracking = 3,
    }


    /// <summary>
    /// Help: On ordered quantities: Control bills based on ordered quantities. <br />
    /// On received quantities: Control bills based on received quantities.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ControlPolicyProductProductOdooEnum
    {
        [EnumMember(Value = "purchase")]
        OnOrderedQuantities = 1,

        [EnumMember(Value = "receive")]
        OnReceivedQuantities = 2,
    }


    /// <summary>
    /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PurchaseOrderLineProductProductOdooEnum
    {
        [EnumMember(Value = "no-message")]
        NoMessage = 1,

        [EnumMember(Value = "warning")]
        Warning = 2,

        [EnumMember(Value = "block")]
        BlockingMessage = 3,
    }


    /// <summary>
    /// Help: Manual: The accounting entries to value the inventory are not posted automatically. <br />
    ///         Automated: An accounting entry is automatically created to value the inventory when a product enters or leaves the company.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InventoryValuationProductProductOdooEnum
    {
        [EnumMember(Value = "manual_periodic")]
        PeriodicManual = 1,

        [EnumMember(Value = "real_time")]
        PerpetualAutomated = 2,
    }


    /// <summary>
    /// Help: Standard Price: The products are valued at their standard cost defined on the product. <br />
    ///         Average Cost (AVCO): The products are valued at weighted average cost. <br />
    ///         First In First Out (FIFO): The products are valued supposing those that enter the company first will also leave it first.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CostingMethodProductProductOdooEnum
    {
        [EnumMember(Value = "standard")]
        StandardPrice = 1,

        [EnumMember(Value = "fifo")]
        FirstInFirstOutFIFO = 2,

        [EnumMember(Value = "average")]
        AverageCostAVCO = 3,
    }


    /// <summary>
    /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SalesOrderLineProductProductOdooEnum
    {
        [EnumMember(Value = "no-message")]
        NoMessage = 1,

        [EnumMember(Value = "warning")]
        Warning = 2,

        [EnumMember(Value = "block")]
        BlockingMessage = 3,
    }


    /// <summary>
    /// Help: Expenses and vendor bills can be re-invoiced to a customer.With this option, a validated expense can be re-invoice to a customer at its cost or sales price.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReInvoicePolicyProductProductOdooEnum
    {
        [EnumMember(Value = "no")]
        No = 1,

        [EnumMember(Value = "cost")]
        AtCost = 2,

        [EnumMember(Value = "sales_price")]
        SalesPrice = 3,
    }


    /// <summary>
    /// Help: Ordered Quantity: Invoice quantities ordered by the customer. <br />
    /// Delivered Quantity: Invoice quantities delivered to the customer.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoicingPolicyProductProductOdooEnum
    {
        [EnumMember(Value = "order")]
        OrderedQuantities = 1,

        [EnumMember(Value = "delivery")]
        DeliveredQuantities = 2,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceInvoicingPolicyProductProductOdooEnum
    {
        [EnumMember(Value = "ordered_timesheet")]
        OrderedQuantities = 1,

        [EnumMember(Value = "delivered_timesheet")]
        TimesheetsOnTasks = 2,

        [EnumMember(Value = "delivered_manual")]
        MilestonesManuallySetQuantitiesOnOrder = 3,
    }


    /// <summary>
    /// Help: Manually set quantities on order: Invoice based on the manually entered quantity, without creating an analytic account. <br />
    /// Timesheets on contract: Invoice based on the tracked hours on the related timesheet. <br />
    /// Create a task and track hours: Create a task on the sales order validation and track the work hours.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrackServiceProductProductOdooEnum
    {
        [EnumMember(Value = "manual")]
        ManuallySetQuantitiesOnOrder = 1,

        [EnumMember(Value = "timesheet")]
        TimesheetsOnProjectOneFarePerSOProject = 2,
    }


    /// <summary>
    /// Help: On Sales order confirmation, this product can generate a project and/or task. From those, you can track the service you are selling.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceTrackingProductProductOdooEnum
    {
        [EnumMember(Value = "no")]
        DonTCreateTask = 1,

        [EnumMember(Value = "task_global_project")]
        CreateATaskInAnExistingProject = 2,

        [EnumMember(Value = "task_new_project")]
        CreateATaskInANewProject = 3,

        [EnumMember(Value = "project_only")]
        CreateANewProjectButNoTask = 4,
    }

    // Type of the exception activity on record.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActivityExceptionDecorationProductProductOdooEnum
    {
        [EnumMember(Value = "warning")]
        Alert = 1,

        [EnumMember(Value = "danger")]
        Error = 2,
    }

}
