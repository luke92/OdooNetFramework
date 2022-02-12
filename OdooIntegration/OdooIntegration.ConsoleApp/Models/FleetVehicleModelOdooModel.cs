using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("fleet.vehicle.model")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class FleetVehicleModelOdooModel : IOdooModel
    {

        // required
        [JsonProperty("name")]
        public string Name { get; set; }

        // fleet.vehicle.model.brand
        // required
        [JsonProperty("brand_id")]
        public long BrandId { get; set; }

        // res.partner
        [JsonProperty("vendors")]
        public long[] Vendors { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("image_medium")]
        public string ImageMedium { get; set; }

        [JsonProperty("image_small")]
        public string ImageSmall { get; set; }

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
