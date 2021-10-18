using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooIntegration.ConsoleApp
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            var host = ConfigurationManager.AppSettings["host"];
            var database = ConfigurationManager.AppSettings["database"];
            var user = ConfigurationManager.AppSettings["username"];
            var pass = ConfigurationManager.AppSettings["password"];

            var config = new OdooConfig(
                apiUrl: host,
                dbName: database,
                userName: user,
                password: pass
            );

            var odooClient = new OdooClient(config);
            var versionResult = await odooClient.GetVersionAsync();
            Console.WriteLine(JsonConvert.SerializeObject(versionResult));
            Console.ReadKey();
        }
    }
}
