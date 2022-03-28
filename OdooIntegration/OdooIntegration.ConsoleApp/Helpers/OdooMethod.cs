using PortaCapena.OdooJsonRpcClient;
using PortaCapena.OdooJsonRpcClient.Models;
using PortaCapena.OdooJsonRpcClient.Request;
using PortaCapena.OdooJsonRpcClient.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooIntegration.ConsoleApp.Helpers
{
    public class OdooMethod
    {
        protected readonly OdooConfig config;
        protected readonly OdooClient odooClient;
        protected readonly string tableName;

        public OdooMethod(OdooConfig config, string tableName)
        {
            this.config = config;
            this.odooClient = new OdooClient(config);
            this.tableName = tableName;
        }

        public async Task<OdooResult<T>> CallAsync<T>(string methodName, params object[] parameters)
        {
            var loginResult = await odooClient.GetCurrentUserUidOrLoginAsync();

            var requestParams = new OdooRequestParams(config.ApiUrlJson, "object", "execute_kw", config.DbName, loginResult.Value, config.Password, tableName, methodName, parameters);
            var requestModel = new OdooRequestModel(requestParams);

            return await OdooClient.CallAndDeserializeAsync<T>(requestModel);
        }

        /*
         * Example of use
            _transactionMethod = new OdooMethod(_odooSettings.GetOdooConfig(), "sale.order");
            var result = await _transactionMethod.CallAsync<long>("create_transaction", dict); 
         */
    }
}
