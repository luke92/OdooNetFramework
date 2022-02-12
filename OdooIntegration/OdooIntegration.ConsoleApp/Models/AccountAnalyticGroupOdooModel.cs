using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("account.analytic.group")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class AccountAnalyticGroupOdooModel : IOdooModel
    {

        // required
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        // account.analytic.group
        [JsonProperty("parent_id")]
        public long? ParentId { get; set; }

        [JsonProperty("parent_path")]
        public string ParentPath { get; set; }

        // account.analytic.group
        [JsonProperty("children_ids")]
        public long[] ChildrenIds { get; set; }

        [JsonProperty("complete_name")]
        public string CompleteName { get; set; }

        // res.company
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

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
