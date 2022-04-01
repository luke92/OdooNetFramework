using Newtonsoft.Json;

namespace OdooIntegration.ConsoleApp.Many2ManyHelpers
{
    public class OdooAuthenticateRequestModel
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("params")]
        public Params Params { get; set; }

        public OdooAuthenticateRequestModel(string db, string user, string password)
        {
            Jsonrpc = "2.0";
            Params = new Params()
            {
                Db = db,
                Login = user,
                Password = password
            };
        }
    }

    public class Params
    {
        [JsonProperty("db")]
        public string Db { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
