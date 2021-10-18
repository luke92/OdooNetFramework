using Newtonsoft.Json;
using OdooIntegration.ConsoleApp.Models;
using PortaCapena.OdooJsonRpcClient;
using PortaCapena.OdooJsonRpcClient.Converters;
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
            var odooClient = GetClient();

            var loginResult = await odooClient.LoginAsync();

            await PrintVersion(odooClient);

            await PrintProducts(odooClient);

            await PrintProducts2(odooClient);

            await PrintCustomers(odooClient);

            await PrintInvoices(odooClient);

            await PrintPayments(odooClient);

            Console.ReadKey();
        }

        public static OdooClient GetClient()
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

            return new OdooClient(config);
        }
        
        public async static Task PrintVersion(OdooClient odooClient)
        {
            Console.WriteLine("Version");

            var versionResult = await odooClient.GetVersionAsync();
            Console.WriteLine(JsonConvert.SerializeObject(versionResult));

            Console.WriteLine("");
        }

        public async static Task PrintProducts(OdooClient odooClient)
        {
            Console.WriteLine("Products");

            var tableName = "product.product";
            var modelResult = await odooClient.GetModelAsync(tableName);

            var model = OdooModelMapper.GetDotNetModel(tableName, modelResult.Value);

            var repository = new OdooRepository<ProductProductOdooModel>(odooClient.Config);
            var results = await repository.Query().ToListAsync();

            Console.WriteLine(JsonConvert.SerializeObject(results));

            Console.WriteLine("");
        }

        public async static Task PrintProducts2(OdooClient odooClient)
        {
            Console.WriteLine("Products2");

            var tableName = "product.template";
            var modelResult = await odooClient.GetModelAsync(tableName);

            var model = OdooModelMapper.GetDotNetModel(tableName, modelResult.Value);

            var repository = new OdooRepository<ProductTemplateOdooModel>(odooClient.Config);
            var results = await repository.Query().ToListAsync();

            Console.WriteLine(JsonConvert.SerializeObject(results));

            Console.WriteLine("");
        }

        public async static Task PrintCustomers(OdooClient odooClient)
        {
            Console.WriteLine("Customers");

            var tableName = "res.partner";
            var modelResult = await odooClient.GetModelAsync(tableName);

            var model = OdooModelMapper.GetDotNetModel(tableName, modelResult.Value);

            var repository = new OdooRepository<ResPartnerOdooModel>(odooClient.Config);
            var results = await repository.Query().ToListAsync();

            Console.WriteLine(JsonConvert.SerializeObject(results));

            Console.WriteLine("");
        }

        public async static Task PrintInvoices(OdooClient odooClient)
        {
            Console.WriteLine("Invoices");

            var tableName = "account.move";
            var modelResult = await odooClient.GetModelAsync(tableName);

            var model = OdooModelMapper.GetDotNetModel(tableName, modelResult.Value);

            var repository = new OdooRepository<AccountMoveOdooModel>(odooClient.Config);
            var results = await repository.Query().ToListAsync();

            Console.WriteLine(JsonConvert.SerializeObject(results));

            Console.WriteLine("");
        }

        public async static Task PrintPayments(OdooClient odooClient)
        {
            Console.WriteLine("Payments");

            var tableName = "account.payment";
            var modelResult = await odooClient.GetModelAsync(tableName);

            var model = OdooModelMapper.GetDotNetModel(tableName, modelResult.Value);

            var repository = new OdooRepository<AccountPaymentOdooModel>(odooClient.Config);
            var results = await repository.Query().ToListAsync();

            Console.WriteLine(JsonConvert.SerializeObject(results));

            Console.WriteLine("");
        }
    }
}
