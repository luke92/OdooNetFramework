using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooIntegration.ConsoleApp.Many2ManyHelpers
{
    public class OdooRequestCallKwModel
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public ParamsCallKw Params { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        public OdooRequestCallKwModel()
        {
            Jsonrpc = "2.0";
            Method = "call";
            Params = new ParamsCallKw();
        }
    }

    public class ParamsCallKw
    {
        [JsonProperty("args")]
        public string Args { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("kwargs", NullValueHandling = NullValueHandling.Ignore)]
        public Kwargs Kwargs { get; set; }

        public ParamsCallKw()
        {
            Args = "REPLACEARGS";
            Kwargs = new Kwargs();
        }
    }

    public class Kwargs
    {
        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public Context Context { get; set; }
        public Kwargs()
        {
            Context = new Context();
        }
    }

    public class Context
    {
        [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
        public string Lang { get; set; }

        [JsonProperty("tz", NullValueHandling = NullValueHandling.Ignore)]
        public string Tz { get; set; }

        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Uid { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("journal_type", NullValueHandling = NullValueHandling.Ignore)]
        public string JournalType { get; set; }
    }
}