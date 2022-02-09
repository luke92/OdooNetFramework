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

            await PrintLogin(odooClient);

            if(args.Length > 0)
            {
                foreach(var arg in args)
                {
                    PrintDotNetModel(odooClient, arg);
                }
            }
            else
            {
                await PrintVersion(odooClient);

                await PrintIdentificationTypes(odooClient);

                await PrintProducts(odooClient);

                await PrintProducts2(odooClient);

                await PrintCustomers(odooClient);

                await PrintInvoices(odooClient);

                await PrintPayments(odooClient);
            }
            Console.WriteLine("Press any key");
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

        public async static Task PrintLogin(OdooClient odooClient)
        {
            Console.WriteLine("Login");
            try
            {
                var loginResult = await odooClient.LoginAsync();
                Console.WriteLine(JsonConvert.SerializeObject(loginResult));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("");

        }
        
        public async static Task PrintVersion(OdooClient odooClient)
        {
            Console.WriteLine("Version");
            try
            {
                var versionResult = await odooClient.GetVersionAsync();
                Console.WriteLine(JsonConvert.SerializeObject(versionResult));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            Console.WriteLine("");
        }

        public async static Task PrintIdentificationTypes(OdooClient odooClient)
        {
            Console.WriteLine("Identification types");
            try
            {
                var tableName = "l10n_latam.identification.type";
                var repository = new OdooRepository<L10nLatamIdentificationTypeOdooModel>(odooClient.Config);
                var results = await repository.Query().ToListAsync();
                Console.WriteLine(JsonConvert.SerializeObject(results));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            Console.WriteLine("");
        }

        public async static Task PrintProducts(OdooClient odooClient)
        {
            Console.WriteLine("Products");
            try
            {
                var tableName = "product.product";
                var repository = new OdooRepository<ProductProductOdooModel>(odooClient.Config);
                var results = await repository.Query().ToListAsync();

                Console.WriteLine(JsonConvert.SerializeObject(results));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }            
            Console.WriteLine("");
        }

        public async static Task PrintProducts2(OdooClient odooClient)
        {
            Console.WriteLine("Products2");
            try
            {
                var tableName = "product.template";
                var repository = new OdooRepository<ProductTemplateOdooModel>(odooClient.Config);
                var results = await repository.Query().ToListAsync();
                Console.WriteLine(JsonConvert.SerializeObject(results));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            Console.WriteLine("");
        }

        public async static Task PrintCustomers(OdooClient odooClient)
        {
            Console.WriteLine("Customers");
            try
            {
                var tableName = "res.partner";
                var repository = new OdooRepository<ResPartnerOdooModel>(odooClient.Config);
                var results = await repository.Query().ToListAsync();

                Console.WriteLine(JsonConvert.SerializeObject(results));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            Console.WriteLine("");
        }

        public async static Task PrintInvoices(OdooClient odooClient)
        {
            Console.WriteLine("Invoices");
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            var tableName = "account.move";
            var repository = new OdooRepository<AccountMoveOdooModel>(odooClient.Config);
            var results = await repository.Query().ToListAsync();

            Console.WriteLine(JsonConvert.SerializeObject(results));
            Console.WriteLine("");
        }

        public async static Task PrintPayments(OdooClient odooClient)
        {
            Console.WriteLine("Payments");
            try
            {
                var tableName = "account.payment";
                var repository = new OdooRepository<AccountPaymentOdooModel>(odooClient.Config);
                var results = await repository.Query().ToListAsync();

                Console.WriteLine(JsonConvert.SerializeObject(results));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            Console.WriteLine("");
        }

        public async static Task PrintDotNetModel(OdooClient odooClient, string argument)
        {
            Console.WriteLine(argument);
            try
            {
                var modelResult = await odooClient.GetModelAsync(argument);
                var model = OdooModelMapper.GetDotNetModel(argument, modelResult.Value);
                Console.WriteLine(model);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }            
            Console.WriteLine();
        }
    }
}
