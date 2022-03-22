using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("account.payment.term")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class AccountPaymentTermOdooModel : IOdooModel
    {

        /// <summary>
        /// name - char  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// active - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: If the active field is set to False, it will allow you to hide the payment terms without removing it. <br />
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// note - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// line_ids - one2many - account.payment.term.line (payment_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("line_ids")]
        public long[] LineIds { get; set; }

        /// <summary>
        /// company_id - many2one - res.company <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("company_id")]
        public long CompanyId { get; set; }

        /// <summary>
        /// sequence - integer  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

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
}
