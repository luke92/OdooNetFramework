using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient.Models;
using RestSharp;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OdooIntegration.ConsoleApp.Many2ManyHelpers
{
    public static class OdooMany2ManyService
    {
        private static string _urlAuth = "/web/session/authenticate";
        private static string _urlCallKw = "/web/dataset/call_kw";
        private static HttpClient _client;

        static OdooMany2ManyService()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async static Task<OdooResponseModel> UpdateFieldMany2Many(OdooConfig odooConfig, string table, long[] idsTable, string fieldMany2Many, long[] idsField)
        {
            var model = new OdooRequestCallKwModel()
            {
                Params = new ParamsCallKw
                {
                    Method = "write",
                    Model = table,
                }
            };

            var args = GetArgs(idsTable, fieldMany2Many, idsField);

            return await CallKwAsync(odooConfig, model, args);
        }

        public async static Task<OdooResponseModel> CallKwAsync(OdooConfig odooConfig, OdooRequestCallKwModel model, string argsReplacement = null)
        {
            var authentication = await AuthenticateAsync(odooConfig);
            if (authentication.HasSessionId)
            {
                var responseWrapper = new OdooResponseModel();
                var json = JsonConvert.SerializeObject(model);
                if (!string.IsNullOrEmpty(argsReplacement))
                {
                    json = json.Replace("\"" + model.Params.Args + "\"", argsReplacement);
                }

                var response = await CallAsync(odooConfig.ApiUrl + _urlCallKw, json);
                var responseString = await response.Content.ReadAsStringAsync();
                
                if (response.IsSuccessStatusCode)
                {
                    responseWrapper = JsonConvert.DeserializeObject<OdooResponseModel>(responseString);
                }
                else
                {
                    responseWrapper = new OdooResponseModel
                    {
                        Error = new Error
                        {
                            Code = (long)response.StatusCode,
                            Message = responseString,
                        }
                    };
                }
                return responseWrapper;
            }
            else
            {
                return authentication.ResponseError;
            }
            
        }

        private static string GetArgs(long[] idsTable, string fieldMany2Many, long[] idsField)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("[[");
            stringBuilder.Append(string.Join(",", idsTable));
            stringBuilder.Append("],{");

            stringBuilder.Append("\"" + fieldMany2Many + "\":[[6,false,[");
            stringBuilder.Append(string.Join(",", idsField));

            stringBuilder.Append("]]]}]");
            return stringBuilder.ToString();

            //return "[[60191],{\"invoice_line_tax_ids\":[[6,false,[3]]]}]";
        }

        private async static Task<OdooResponseAuthenticateWrapper> AuthenticateAsync(OdooConfig odooConfig)
        {
            var responseWrapper = new OdooResponseAuthenticateWrapper();
            var model = new OdooAuthenticateRequestModel(odooConfig.DbName, odooConfig.UserName, odooConfig.Password);
            var json = JsonConvert.SerializeObject(model);
            var response = await CallAsync(odooConfig.ApiUrl + _urlAuth, json);
            var responseString = await response.Content.ReadAsStringAsync();
            responseWrapper.IsOk = response.IsSuccessStatusCode;
            if (responseWrapper.IsOk)
            {
                responseWrapper.ResponseOk = JsonConvert.DeserializeObject<OdooAuthenticateResponseModel>(responseString);
            }
            else
            {
                responseWrapper.ResponseError = JsonConvert.DeserializeObject<OdooResponseModel>(responseString);
            }
            return responseWrapper;
        }

        private static RestClient GetClient(OdooConfig odooConfig)
        {
            var uri = odooConfig.ApiUrl;
            var client = new RestClient(uri);
            return client;
        }

        private static RestRequest GetRequest(string urlMethod, RestSharp.Method method, string json, string sessionId = null)
        {
            var request = new RestRequest(urlMethod,method);
            request.Timeout = -1;
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            if (!string.IsNullOrWhiteSpace(sessionId))
                sessionId = "";
            request.AddHeader("Cookie", "session_id=" + sessionId);
                      
            return request;
        }

        private static async Task<HttpResponseMessage> CallAsync(string uri, string json)
        {
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var result = await _client.PostAsync(uri, data);
            return result;
        }
    }
}
