using Newtonsoft.Json;
using OdooIntegration.ConsoleApp.Helpers;
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
            await PrintVersion(odooClient);

            if (args.Length > 0)
            {
                foreach(var arg in args)
                {
                    await OdooHelper.PrintDotNetModel(odooClient, arg);
                }
            }
            else
            {
                var option = SelectMenu();

                switch(option)
                {
                    case "2":
                        await InsertInvoiceLineAsync(odooClient);
                        break;
                    case "1":
                        await PrintRecordsModelsAsync(odooClient);
                        break;
                    default:
                        await PrintRecordsModelsAsync(odooClient);
                        break;
                }
                
            }
            Console.WriteLine("Press any key to finish");
            Console.ReadKey();
        }

        public static string SelectMenu()
        {
            Console.WriteLine("Select an option");
            Console.WriteLine("1) Print Records of Models");
            Console.WriteLine("2) Insert Invoice Line Test");
            var key = Console.ReadLine();
            Console.WriteLine("");
            return key;
        }

        public async static Task PrintRecordsModelsAsync(OdooClient odooClient)
        {
            await PrintIdentificationTypes(odooClient);

            await PrintAccountAnalyticGroups(odooClient);

            await PrintVehicleBrands(odooClient);

            await PrintVehicleModels(odooClient);

            await PrintProducts(odooClient);

            await PrintProducts2(odooClient);

            await PrintCustomers(odooClient);

            await PrintInvoices(odooClient);

            await PrintInvoiceLine(odooClient);

            await PrintInvoicesOdooV12(odooClient);

            await PrintInvoiceLineOdooV12(odooClient);

            await PrintPayments(odooClient);

            await PrintVehicleFleet(odooClient);

            await PrintAccountAnalytics(odooClient);
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
                var repository = new OdooRepository<L10nLatamIdentificationTypeOdooModel>(odooClient.Config);
                var json = await OdooHelper.GetJsonRepositoryResults(repository);
                Console.WriteLine(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            Console.WriteLine("");
        }

        public async static Task PrintAccountAnalyticGroups(OdooClient odooClient)
        {
            Console.WriteLine("Account Analytic Groups");
            try
            {
                var repository = new OdooRepository<AccountAnalyticGroupOdooModel>(odooClient.Config);
                var json = await OdooHelper.GetJsonRepositoryResults(repository);
                Console.WriteLine(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("");
        }

        public async static Task PrintVehicleBrands(OdooClient odooClient)
        {
            Console.WriteLine("Vehicle Brands");
            try
            {
                var repository = new OdooRepository<FleetVehicleModelBrandOdooModel>(odooClient.Config);
                var json = await OdooHelper.GetJsonRepositoryResult(repository);
                Console.WriteLine(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("");
        }

        public async static Task PrintVehicleModels(OdooClient odooClient)
        {
            Console.WriteLine("Vehicle Models");
            try
            {
                var repository = new OdooRepository<FleetVehicleModelOdooModel>(odooClient.Config);
                var json = await OdooHelper.GetJsonRepositoryResult(repository);
                Console.WriteLine(json);
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
                var repository = new OdooRepository<ProductProductOdooModel>(odooClient.Config);
                var json = await OdooHelper.GetJsonRepositoryResult(repository);
                Console.WriteLine(json);
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
                var repository = new OdooRepository<ProductTemplateOdooModel>(odooClient.Config);
                var json = await OdooHelper.GetJsonRepositoryResult(repository);
                Console.WriteLine(json);
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
                var repository = new OdooRepository<ResPartnerOdooModel>(odooClient.Config);
                var json = await OdooHelper.GetJsonRepositoryResult(repository);
                Console.WriteLine(json);
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
                var repository = new OdooRepository<AccountMoveOdooModel>(odooClient.Config);
                var json = await OdooHelper.GetJsonRepositoryResult(repository);
                Console.WriteLine(json);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            Console.WriteLine("");
        }

        public async static Task PrintInvoiceLine(OdooClient odooClient)
        {
            Console.WriteLine("Invoice Line");
            try
            {
                var repository = new OdooRepository<AccountMoveLineOdooModel>(odooClient.Config);
                var json = await OdooHelper.GetJsonRepositoryResult(repository);
                Console.WriteLine(json);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("");
        }

        public async static Task PrintInvoicesOdooV12(OdooClient odooClient)
        {
            Console.WriteLine("Invoices ODOO V12");
            try
            {
                var repository = new OdooRepository<AccountInvoiceOdooModel>(odooClient.Config);
                var json = await OdooHelper.GetJsonRepositoryResult(repository);
                Console.WriteLine(json);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("");
        }

        public async static Task PrintInvoiceLineOdooV12(OdooClient odooClient)
        {
            Console.WriteLine("Invoice Line ODOO V12");
            try
            {
                var repository = new OdooRepository<AccountInvoiceLineOdooModel>(odooClient.Config);
                var json = await OdooHelper.GetJsonRepositoryResult(repository);
                Console.WriteLine(json);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("");
        }

        public async static Task PrintPayments(OdooClient odooClient)
        {
            Console.WriteLine("Payments");
            try
            {
                var repository = new OdooRepository<AccountPaymentOdooModel>(odooClient.Config);
                var json = await OdooHelper.GetJsonRepositoryResult(repository);
                Console.WriteLine(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            Console.WriteLine("");
        }

        public async static Task PrintVehicleFleet(OdooClient odooClient)
        {
            Console.WriteLine("Flota de vehiculos");
            try
            {
                var repository = new OdooRepository<FleetVehicleOdooModel>(odooClient.Config);
                var json = await OdooHelper.GetJsonRepositoryResult(repository);
                Console.WriteLine(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("");
        }

        public async static Task PrintAccountAnalytics(OdooClient odooClient)
        {
            Console.WriteLine("Cuentas Analiticas");
            try
            {
                var repository = new OdooRepository<AccountAnalyticAccountOdooModel>(odooClient.Config);
                var json = await OdooHelper.GetJsonRepositoryResult(repository);
                Console.WriteLine(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("");
        }

        public async static Task InsertInvoiceLineAsync(OdooClient odooClient)
        {
            Console.WriteLine("Insert invoice line");
            try
            {
                var model = OdooDictionaryModel.Create(() => new AccountMoveOdooModel()
                {
                    PartnerId = 1,
                    InvoiceDate = DateTime.Now,
                    Date = DateTime.Now,
                    CreateDate = DateTime.Now,
                    WriteDate = DateTime.Now,
                    LastUpdate = DateTime.Now,
                    State = StatusAccountMoveOdooEnum.Draft,
                    MoveType = TypeAccountMoveOdooEnum.CustomerInvoice,
                });

                var result = await OdooHelper.AddModelAsync(model, odooClient);
                Console.WriteLine(JsonConvert.SerializeObject(result));

                if (result.Id.HasValue)
                {
                    var modelLine = OdooDictionaryModel.Create(() => new AccountMoveLineOdooModel()
                    {
                        AccountInternalGroup = InternalGroupAccountMoveLineOdooEnum.OffBalance,
                        MoveId = result.Id.Value,
                        Date = DateTime.Now,
                        ParentState = StatusAccountMoveLineOdooEnum.Draft,
                        JournalId = 1,
                        AccountId = 77,
                        Quantity = 1,
                        PriceUnit = 100,
                        CurrencyId = 19,
                        PartnerId = 1,                        
                        ProductId = 1,
                        TaxIds = new long[] {19},
                        CreateDate = DateTime.Now,
                        WriteDate = DateTime.Now,
                        LastUpdate = DateTime.Now,                        
                    });

                    var result2 = await OdooHelper.AddModelAsync(modelLine, odooClient);
                    Console.WriteLine(JsonConvert.SerializeObject(result2));

                    if (result2.Id.HasValue)
                    {
                        var modelUpdate = OdooDictionaryModel.Create(() => new AccountMoveOdooModel()
                        {
                            State = StatusAccountMoveOdooEnum.Posted,
                            LineIds = new long[result2.Id.Value],
                            InvoiceLineIds = new long[result2.Id.Value],
                        });

                        var result3 = await OdooHelper.UpdateModelAsync(modelUpdate, result.Id.Value, odooClient);
                        Console.WriteLine(JsonConvert.SerializeObject(result3));
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("");
        }
    }
}
