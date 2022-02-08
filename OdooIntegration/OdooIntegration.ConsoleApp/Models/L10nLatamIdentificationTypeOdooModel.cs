using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("l10n_latam.identification.type")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class L10nLatamIdentificationTypeOdooModel : IOdooModel
    {

        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        // required
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("is_vat")]
        public bool? IsVat { get; set; }

        // res.country
        [JsonProperty("country_id")]
        public long? CountryId { get; set; }

        [JsonProperty("l10n_ar_afip_code")]
        public string L10nArAfipCode { get; set; }

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
}
