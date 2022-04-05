using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("account.payment.term.line")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class AccountPaymentTermLineOdooModel : IOdooModel
    {

        /// <summary>
        /// value - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Select here the kind of valuation related to this payment terms line. <br />
        /// </summary>
        [JsonProperty("value")]
        public TypeAccountPaymentTermLineOdooEnum Value { get; set; }

        /// <summary>
        /// value_amount - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: For percent enter a ratio between 0-100. <br />
        /// </summary>
        [JsonProperty("value_amount")]
        public double? ValueAmount { get; set; }

        /// <summary>
        /// days - integer  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("days")]
        public int Days { get; set; }

        /// <summary>
        /// day_of_the_month - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Day of the month on which the invoice must come to its term. If zero or negative, this value will be ignored, and no specific day will be set. If greater than the last day of a month, this number will instead select the last day of this month. <br />
        /// </summary>
        [JsonProperty("day_of_the_month")]
        public int? DayOfTheMonth { get; set; }

        /// <summary>
        /// option - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("option")]
        public OptionsAccountPaymentTermLineOdooEnum Option { get; set; }

        /// <summary>
        /// payment_id - many2one - account.payment.term <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("payment_id")]
        public long PaymentId { get; set; }

        /// <summary>
        /// sequence - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Gives the sequence order when displaying a list of payment terms lines. <br />
        /// </summary>
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

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
    /// Help: Select here the kind of valuation related to this payment terms line.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeAccountPaymentTermLineOdooEnum
    {
        [EnumMember(Value = "balance")]
        Balance = 1,

        [EnumMember(Value = "percent")]
        Percent = 2,

        [EnumMember(Value = "fixed")]
        FixedAmount = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OptionsAccountPaymentTermLineOdooEnum
    {
        [EnumMember(Value = "day_after_invoice_date")]
        DaySAfterTheInvoiceDate = 1,

        [EnumMember(Value = "after_invoice_month")]
        DaySAfterTheEndOfTheInvoiceMonth = 2,

        [EnumMember(Value = "day_following_month")]
        OfTheFollowingMonth = 3,

        [EnumMember(Value = "day_current_month")]
        OfTheCurrentMonth = 4,
    }
}
