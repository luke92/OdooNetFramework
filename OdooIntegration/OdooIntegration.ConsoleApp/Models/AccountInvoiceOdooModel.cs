using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("account.invoice")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class AccountInvoiceOdooModel : IOdooModel
    {

        // payment.transaction
        [JsonProperty("transaction_ids")]
        public long[] TransactionIds { get; set; }

        // payment.transaction
        [JsonProperty("authorized_transaction_ids")]
        public long[] AuthorizedTransactionIds { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("type")]
        public TypeAccountInvoiceOdooEnum? Type { get; set; }

        // account.invoice
        [JsonProperty("refund_invoice_id")]
        public long? RefundInvoiceId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("move_name")]
        public string MoveName { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("state")]
        public StatusAccountInvoiceOdooEnum? State { get; set; }

        [JsonProperty("sent")]
        public bool? Sent { get; set; }

        [JsonProperty("date_invoice")]
        public DateTime? DateInvoice { get; set; }

        [JsonProperty("date_due")]
        public DateTime? DateDue { get; set; }

        // res.partner
        [JsonProperty("partner_id")]
        public long? PartnerId { get; set; }

        // account.invoice
        [JsonProperty("vendor_bill_id")]
        public long? VendorBillId { get; set; }

        // account.payment.term
        [JsonProperty("payment_term_id")]
        public long? PaymentTermId { get; set; }

        // account.account
        [JsonProperty("account_id")]
        public long? AccountId { get; set; }

        // account.invoice.line
        [JsonProperty("invoice_line_ids")]
        public long[] InvoiceLineIds { get; set; }

        // account.invoice.tax
        [JsonProperty("tax_line_ids")]
        public long[] TaxLineIds { get; set; }

        // account.invoice
        [JsonProperty("refund_invoice_ids")]
        public long[] RefundInvoiceIds { get; set; }

        // account.move
        [JsonProperty("move_id")]
        public long? MoveId { get; set; }

        /*
        [JsonProperty("amount_by_group")]
        public string AmountByGroup { get; set; }
        */

        [JsonProperty("amount_untaxed")]
        public decimal? AmountUntaxed { get; set; }

        [JsonProperty("amount_untaxed_signed")]
        public decimal? AmountUntaxedSigned { get; set; }

        [JsonProperty("amount_untaxed_invoice_signed")]
        public decimal? AmountUntaxedInvoiceSigned { get; set; }

        [JsonProperty("amount_tax")]
        public decimal? AmountTax { get; set; }

        [JsonProperty("amount_tax_signed")]
        public decimal? AmountTaxSigned { get; set; }

        [JsonProperty("amount_total")]
        public decimal? AmountTotal { get; set; }

        [JsonProperty("amount_total_signed")]
        public decimal? AmountTotalSigned { get; set; }

        [JsonProperty("amount_total_company_signed")]
        public decimal? AmountTotalCompanySigned { get; set; }

        // res.currency
        // required
        [JsonProperty("currency_id")]
        public long CurrencyId { get; set; }

        // res.currency
        [JsonProperty("company_currency_id")]
        public long? CompanyCurrencyId { get; set; }

        // res.company
        // required
        [JsonProperty("company_id")]
        public long CompanyId { get; set; }

        [JsonProperty("reconciled")]
        public bool? Reconciled { get; set; }

        // res.partner.bank
        [JsonProperty("partner_bank_id")]
        public long? PartnerBankId { get; set; }

        [JsonProperty("residual")]
        public decimal? Residual { get; set; }

        [JsonProperty("residual_signed")]
        public decimal? ResidualSigned { get; set; }

        [JsonProperty("residual_company_signed")]
        public decimal? ResidualCompanySigned { get; set; }

        // account.payment
        [JsonProperty("payment_ids")]
        public long[] PaymentIds { get; set; }

        // account.move.line
        [JsonProperty("payment_move_line_ids")]
        public long[] PaymentMoveLineIds { get; set; }

        // res.users
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        // account.fiscal.position
        [JsonProperty("fiscal_position_id")]
        public long? FiscalPositionId { get; set; }

        // res.partner
        [JsonProperty("commercial_partner_id")]
        public long? CommercialPartnerId { get; set; }

        [JsonProperty("outstanding_credits_debits_widget")]
        public string OutstandingCreditsDebitsWidget { get; set; }

        [JsonProperty("payments_widget")]
        public string PaymentsWidget { get; set; }

        [JsonProperty("has_outstanding")]
        public bool? HasOutstanding { get; set; }

        // account.cash.rounding
        [JsonProperty("cash_rounding_id")]
        public long? CashRoundingId { get; set; }

        [JsonProperty("sequence_number_next")]
        public string SequenceNumberNext { get; set; }

        [JsonProperty("sequence_number_next_prefix")]
        public string SequenceNumberNextPrefix { get; set; }

        // account.incoterms
        [JsonProperty("incoterm_id")]
        public long? IncotermId { get; set; }

        [JsonProperty("source_email")]
        public string SourceEmail { get; set; }

        [JsonProperty("vendor_display_name")]
        public string VendorDisplayName { get; set; }

        [JsonProperty("invoice_icon")]
        public string InvoiceIcon { get; set; }

        [JsonProperty("no_contrato")]
        public string NoContrato { get; set; }

        [JsonProperty("sucursal")]
        public SucursalDeAperturaAccountInvoiceOdooEnum? Sucursal { get; set; }

        [JsonProperty("sucursal_entrega")]
        public SucursalDeEntregaAccountInvoiceOdooEnum? SucursalEntrega { get; set; }

        [JsonProperty("cod_auto")]
        public string CodAuto { get; set; }

        [JsonProperty("marca")]
        public string Marca { get; set; }

        [JsonProperty("modelo")]
        public string Modelo { get; set; }

        [JsonProperty("placa")]
        public string Placa { get; set; }

        [JsonProperty("sucursal_cr")]
        public SucursalAccountInvoiceOdooEnum? SucursalCr { get; set; }

        // hr.employee
        [JsonProperty("comprador")]
        public long? Comprador { get; set; }

        // hr.employee
        [JsonProperty("vendedor")]
        public long? Vendedor { get; set; }

        [JsonProperty("text_date")]
        public string TextDate { get; set; }

        [JsonProperty("anulada_invoice")]
        public bool? AnuladaInvoice { get; set; }

        // res.partner
        [JsonProperty("vend")]
        public long? Vend { get; set; }

        [JsonProperty("text_amount")]
        public string TextAmount { get; set; }

        [JsonProperty("type_currencychange")]
        public double? TypeCurrencychange { get; set; }

        // purchase.order
        [JsonProperty("purchase_id")]
        public long? PurchaseId { get; set; }

        // purchase.bill.union
        [JsonProperty("vendor_bill_purchase_id")]
        public long? VendorBillPurchaseId { get; set; }

        [JsonProperty("tds_total")]
        public decimal? TdsTotal { get; set; }

        // payment.tds
        [JsonProperty("withholdings")]
        public long[] Withholdings { get; set; }

        // payment.way
        [JsonProperty("payment_way")]
        public long? PaymentWay { get; set; }

        // payment.anticiped
        [JsonProperty("apliqued_witholding")]
        public long[] ApliquedWitholding { get; set; }

        // required
        [JsonProperty("extract_state")]
        public ExtractStateAccountInvoiceOdooEnum ExtractState { get; set; }

        [JsonProperty("extract_remoteid")]
        public int? ExtractRemoteid { get; set; }

        // account.invoice_extract.words
        [JsonProperty("extract_word_ids")]
        public long[] ExtractWordIds { get; set; }

        [JsonProperty("extract_can_show_resend_button")]
        public bool? ExtractCanShowResendButton { get; set; }

        [JsonProperty("extract_can_show_send_button")]
        public bool? ExtractCanShowSendButton { get; set; }

        // crm.team
        [JsonProperty("team_id")]
        public long? TeamId { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        // res.partner
        [JsonProperty("partner_shipping_id")]
        public long? PartnerShippingId { get; set; }

        // fleet.vehicle.cost
        [JsonProperty("fleet_vehicle_cost_ids")]
        public long[] FleetVehicleCostIds { get; set; }

        [JsonProperty("clave_numerica")]
        public string ClaveNumerica { get; set; }

        [JsonProperty("request_datetime")]
        public string RequestDatetime { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("response")]
        public string Response { get; set; }

        [JsonProperty("response_xml")]
        public string ResponseXml { get; set; }

        [JsonProperty("show_button")]
        public bool? ShowButton { get; set; }

        [JsonProperty("show_submit_button")]
        public bool? ShowSubmitButton { get; set; }

        [JsonProperty("haicenda_status")]
        public HaciendaStatusAccountInvoiceOdooEnum? HaicendaStatus { get; set; }

        [JsonProperty("sale_condition")]
        public CondicionVentaAccountInvoiceOdooEnum? SaleCondition { get; set; }

        [JsonProperty("payment_method")]
        public MedioPagoAccountInvoiceOdooEnum? PaymentMethod { get; set; }

        // terminal
        [JsonProperty("terminal")]
        public long? Terminal { get; set; }

        // activity
        [JsonProperty("economic_activity")]
        public long? EconomicActivity { get; set; }

        [JsonProperty("export")]
        public bool? Export { get; set; }

        [JsonProperty("ispurchase")]
        public bool? Ispurchase { get; set; }

        [JsonProperty("xml_file")]
        public string XmlFile { get; set; }

        [JsonProperty("response_file")]
        public string ResponseFile { get; set; }

        [JsonProperty("submit_tries")]
        public int? SubmitTries { get; set; }

        [JsonProperty("status_tries")]
        public int? StatusTries { get; set; }

        [JsonProperty("electronic_invoice")]
        public bool? ElectronicInvoice { get; set; }

        [JsonProperty("folio")]
        public string Folio { get; set; }

        [JsonProperty("pdf_sync")]
        public bool? PdfSync { get; set; }

        [JsonProperty("ref_code")]
        public CodigoDeReferenciaAccountInvoiceOdooEnum? RefCode { get; set; }

        [JsonProperty("type_doc_ref")]
        public TipoDeDocumentoDeReferenciaAccountInvoiceOdooEnum? TypeDocRef { get; set; }

        [JsonProperty("date_ref")]
        public DateTime? DateRef { get; set; }

        [JsonProperty("number_ref")]
        public string NumberRef { get; set; }

        [JsonProperty("razon")]
        public string Razon { get; set; }

        [JsonProperty("state_invoice_partner")]
        public RespuestaDelClienteAccountInvoiceOdooEnum? StateInvoicePartner { get; set; }

        [JsonProperty("xml_supplier_approval")]
        public string XmlSupplierApproval { get; set; }

        // account.journal
        // required
        [JsonProperty("journal_id")]
        public long JournalId { get; set; }

        // account.invoice
        [JsonProperty("child_ids")]
        public long[] ChildIds { get; set; }

        [JsonProperty("refund_type")]
        public RefundTypeAccountInvoiceOdooEnum? RefundType { get; set; }

        [JsonProperty("origin_client")]
        public OrigenAccountInvoiceOdooEnum? OriginClient { get; set; }

        // purchase.cost.distribution.expense
        [JsonProperty("expense_line_ids")]
        public long[] ExpenseLineIds { get; set; }

        // account.incoterms
        [JsonProperty("incoterms_id")]
        public long? IncotermsId { get; set; }

        // fleet.vehicle.revenue
        [JsonProperty("fleet_vehicle_revenue_ids")]
        public long[] FleetVehicleRevenueIds { get; set; }

        // ir.attachment
        [JsonProperty("attachment_ids")]
        public long[] AttachmentIds { get; set; }

        [JsonProperty("create_form_fleet")]
        public bool? CreateFormFleet { get; set; }

        [JsonProperty("auto_generated")]
        public bool? AutoGenerated { get; set; }

        // account.invoice
        [JsonProperty("auto_invoice_id")]
        public long? AutoInvoiceId { get; set; }

        // account.analytic.line
        [JsonProperty("timesheet_ids")]
        public long[] TimesheetIds { get; set; }

        [JsonProperty("timesheet_count")]
        public int? TimesheetCount { get; set; }

        // fleet.vehicle
        [JsonProperty("fleet")]
        public long? Fleet { get; set; }

        // utm.campaign
        [JsonProperty("campaign_id")]
        public long? CampaignId { get; set; }

        // utm.source
        [JsonProperty("source_id")]
        public long? SourceId { get; set; }

        // utm.medium
        [JsonProperty("medium_id")]
        public long? MediumId { get; set; }

        // mail.activity
        [JsonProperty("activity_ids")]
        public long[] ActivityIds { get; set; }

        [JsonProperty("activity_state")]
        public ActivityStateAccountInvoiceOdooEnum? ActivityState { get; set; }

        // res.users
        [JsonProperty("activity_user_id")]
        public long? ActivityUserId { get; set; }

        // mail.activity.type
        [JsonProperty("activity_type_id")]
        public long? ActivityTypeId { get; set; }

        [JsonProperty("activity_date_deadline")]
        public DateTime? ActivityDateDeadline { get; set; }

        [JsonProperty("activity_summary")]
        public string ActivitySummary { get; set; }

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

        [JsonProperty("access_url")]
        public string AccessUrl { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("access_warning")]
        public string AccessWarning { get; set; }

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

        [JsonProperty("x_studio_exdueno")]
        public string XStudioExdueno { get; set; }
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeAccountInvoiceOdooEnum
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


    //  * The 'Draft' status is used when a user is encoding a new and unconfirmed Invoice.
    //  * The 'Open' status is used when user creates invoice, an invoice number is generated. It stays in the open status till the user pays the invoice.
    //  * The 'In Payment' status is used when payments have been registered for the entirety of the invoice in a journal configured to post entries at bank reconciliation only, and some of them haven't been reconciled with a bank statement line yet.
    //  * The 'Paid' status is set automatically when the invoice is paid. Its related journal entries may or may not be reconciled.
    //  * The 'Cancelled' status is used when user cancel invoice.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusAccountInvoiceOdooEnum
    {
        [EnumMember(Value = "draft")]
        Draft = 1,

        [EnumMember(Value = "open")]
        Open = 2,

        [EnumMember(Value = "in_payment")]
        InPayment = 3,

        [EnumMember(Value = "paid")]
        Paid = 4,

        [EnumMember(Value = "cancel")]
        Cancelled = 5,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum SucursalDeAperturaAccountInvoiceOdooEnum
    {
        [EnumMember(Value = "central")]
        OficinaCentral = 1,

        [EnumMember(Value = "masaya")]
        CarreteraMasaya = 2,

        [EnumMember(Value = "aeropuerto")]
        Aeropuerto = 3,

        [EnumMember(Value = "san_juan_del_sur")]
        SanJuanDelSur = 4,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum SucursalDeEntregaAccountInvoiceOdooEnum
    {
        [EnumMember(Value = "central")]
        OficinaCentral = 1,

        [EnumMember(Value = "masaya")]
        CarreteraMasaya = 2,

        [EnumMember(Value = "aeropuerto")]
        Aeropuerto = 3,

        [EnumMember(Value = "san_juan_del_sur")]
        SanJuanDelSur = 4,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum SucursalAccountInvoiceOdooEnum
    {
        [EnumMember(Value = "rio_segundo")]
        SJOATORIOSEGUNDO = 1,

        [EnumMember(Value = "uvita")]
        UVITA = 2,

        [EnumMember(Value = "liberia")]
        LIRATOLIBERIA = 3,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExtractStateAccountInvoiceOdooEnum
    {
        [EnumMember(Value = "no_extract_requested")]
        NoExtractRequested = 1,

        [EnumMember(Value = "not_enough_credit")]
        NotEnoughCredit = 2,

        [EnumMember(Value = "error_status")]
        AnErrorOccured = 3,

        [EnumMember(Value = "waiting_extraction")]
        WaitingExtraction = 4,

        [EnumMember(Value = "extract_not_ready")]
        WaitingExtractionButItIsNotReady = 5,

        [EnumMember(Value = "waiting_validation")]
        WaitingValidation = 6,

        [EnumMember(Value = "done")]
        CompletedFlow = 7,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum HaciendaStatusAccountInvoiceOdooEnum
    {
        [EnumMember(Value = "procesando")]
        Procesando = 1,

        [EnumMember(Value = "aceptado")]
        Aceptado = 2,

        [EnumMember(Value = "rechazado")]
        Rechazado = 3,

        [EnumMember(Value = "aceptacio´n parcial")]
        AceptacioNParcial = 4,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum CondicionVentaAccountInvoiceOdooEnum
    {
        [EnumMember(Value = "01")]
        Contado = 1,

        [EnumMember(Value = "02")]
        CreDito = 2,

        [EnumMember(Value = "03")]
        ConsignacioN = 3,

        [EnumMember(Value = "04")]
        Apartado = 4,

        [EnumMember(Value = "05")]
        ArrendamientoConOpcioNDeCompra = 5,

        [EnumMember(Value = "06")]
        ArrendamientoEnFuncioNFinanciera = 6,

        [EnumMember(Value = "07")]
        CobroAFavorDeUnTercero = 7,

        [EnumMember(Value = "08")]
        ServiciosPrestadosAlEstadoACreDito = 8,

        [EnumMember(Value = "09")]
        PagoDelServiciosPrestadoAlEstado = 9,

        [EnumMember(Value = "99")]
        OtrosSeDebeIndicarLaCondicioNDeLaVenta = 10,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum MedioPagoAccountInvoiceOdooEnum
    {
        [EnumMember(Value = "01")]
        Efectivo = 1,

        [EnumMember(Value = "02")]
        Tarjeta = 2,

        [EnumMember(Value = "03")]
        Cheque = 3,

        [EnumMember(Value = "04")]
        TransferenciaDepoSitoBancario = 4,

        [EnumMember(Value = "05")]
        RecaudadoPorTerceros = 5,

        [EnumMember(Value = "99")]
        OtrosSeDebeIndicarElMedioDePago = 6,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum CodigoDeReferenciaAccountInvoiceOdooEnum
    {
        [EnumMember(Value = "01")]
        AnulaDocumentoDeReferencia = 1,

        [EnumMember(Value = "02")]
        CorrigeMonto = 2,

        [EnumMember(Value = "03")]
        ReferenciaAOtroDocumento = 3,

        [EnumMember(Value = "04")]
        SustituyeComprobanteProvisionalPorContingencia = 4,

        [EnumMember(Value = "99")]
        Otros = 5,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum TipoDeDocumentoDeReferenciaAccountInvoiceOdooEnum
    {
        [EnumMember(Value = "01")]
        FacturaElectroNica = 1,

        [EnumMember(Value = "02")]
        NotaDeDeBitoElectroNica = 2,

        [EnumMember(Value = "03")]
        NotaDeCreDitoElectroNica = 3,

        [EnumMember(Value = "04")]
        TiqueteElectroNico = 4,

        [EnumMember(Value = "05")]
        NotaDeDespacho = 5,

        [EnumMember(Value = "06")]
        Contrato = 6,

        [EnumMember(Value = "07")]
        Procedimiento = 7,

        [EnumMember(Value = "08")]
        ComprobanteEmitidoEnContingencia = 8,

        [EnumMember(Value = "09")]
        DevolucioNMercaderiA = 9,

        [EnumMember(Value = "10")]
        SustituyeFacturaRechazadaPorElMinisterioDeHacienda = 10,

        [EnumMember(Value = "11")]
        SustituyeFacturaRechazadaPorElReceptorDelComprobante = 11,

        [EnumMember(Value = "12")]
        SustituyeFacturaDeExportacioN = 12,

        [EnumMember(Value = "13")]
        FacturacioNMesVencido = 13,

        [EnumMember(Value = "14")]
        ComprobanteAportadoPorContribuyenteDelReGimenDeTributacioNSimplificado = 14,

        [EnumMember(Value = "15")]
        SustituyeUnaFacturaElectroNicaDeCompra = 15,

        [EnumMember(Value = "99")]
        Otros = 16,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum RespuestaDelClienteAccountInvoiceOdooEnum
    {
        [EnumMember(Value = "1")]
        Aceptado = 1,

        [EnumMember(Value = "3")]
        Rechazado = 2,

        [EnumMember(Value = "2")]
        AceptacionParcial = 3,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum RefundTypeAccountInvoiceOdooEnum
    {
        [EnumMember(Value = "debit")]
        DebitNote = 1,

        [EnumMember(Value = "credit")]
        CreditNote = 2,
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrigenAccountInvoiceOdooEnum
    {
        [EnumMember(Value = "ace")]
        ACE = 1,

        [EnumMember(Value = "canje")]
        Canje = 2,

        [EnumMember(Value = "corporativo")]
        Corporativo = 3,

        [EnumMember(Value = "fb")]
        FB = 4,

        [EnumMember(Value = "instagram")]
        Instagram = 5,

        [EnumMember(Value = "nu_car_rental")]
        NuCarRental = 6,

        [EnumMember(Value = "presencial")]
        Presencial = 7,

        [EnumMember(Value = "rental_cars")]
        RentalCars = 8,

        [EnumMember(Value = "telefonica")]
        TelefNica = 9,

        [EnumMember(Value = "web")]
        Web = 10,

        [EnumMember(Value = "whatsapp")]
        Whatsapp = 11,

        [EnumMember(Value = "discovercars")]
        Discovercars = 12,

        [EnumMember(Value = "contact_center")]
        ContactCenter = 13,

        [EnumMember(Value = "cliente_frecuente")]
        ClienteFrecuente = 14,

        [EnumMember(Value = "recomendado")]
        Recomendado = 15,

        [EnumMember(Value = "renitng")]
        Renting = 16,
    }


    // Status based on activities
    // Overdue: Due date is already passed
    // Today: Activity date is today
    // Planned: Future activities.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActivityStateAccountInvoiceOdooEnum
    {
        [EnumMember(Value = "overdue")]
        Overdue = 1,

        [EnumMember(Value = "today")]
        Today = 2,

        [EnumMember(Value = "planned")]
        Planned = 3,
    }
}
