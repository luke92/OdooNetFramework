using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OdooIntegration.ConsoleApp.Helpers;
using OdooIntegration.ConsoleApp.Many2ManyHelpers;
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
        private static long _companyId;
        public async static Task Main(string[] args)
        {
            long.TryParse(ConfigurationManager.AppSettings["companyId"], out _companyId);

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
                    case "5":
                        await AddPaymentAsync(odooClient);
                        break;
                    case "4":
                        await PrintTaxData(odooClient);
                        break;
                    case "3":
                        await PrintInvoiceData(odooClient);
                        break;
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

        private static string SelectMenu()
        {
            Console.WriteLine("Select an option");
            Console.WriteLine("1) Print Records of Models");
            Console.WriteLine("2) Insert Invoice Line Test");
            Console.WriteLine("3) Print Invoice by Id");
            Console.WriteLine("4) Print Tax by Id");
            Console.WriteLine("5) Add Payment");
            var key = Console.ReadLine();
            Console.WriteLine("");
            return key;
        }

        private static long Prompt(string field)
        {
            var idString = "";
            var id = 0l;
            do
            {
                Console.WriteLine("Enter " + field);
                idString = Console.ReadLine();
            } while (!long.TryParse(idString, out id));

            Console.WriteLine(field + ": " + id);
            return id;
        }

        private static long? PromptOrDefault(string field)
        {
            var idString = "";
            var id = 0l;
            do
            {
                Console.WriteLine("Enter " + field);
                idString = Console.ReadLine();
            } while (!long.TryParse(idString, out id));

            Console.WriteLine(field + ": " + id);
            
            if (id == 0)
            {
                return null;
            }
            return id;
        }

        private static string PromptString(string field)
        {
            Console.WriteLine("Enter " + field);
            var data = Console.ReadLine();
            Console.WriteLine(field + ": " + data);
            return data;
        }

        private static decimal? PromptMoneyOrDefault(string field)
        {
            var input = "";
            var value = 0m;
            do
            {
                Console.WriteLine("Enter " + field);
                input = Console.ReadLine();
            } while (!decimal.TryParse(input, out value));

            Console.WriteLine(field + ": " + value);

            if (value == 0)
            {
                return null;
            }
            return value;
        }

        private static bool PrompBoolean(string booleanQuestion)
        {
            Console.WriteLine(booleanQuestion);
            Console.WriteLine("Enter Y or N (N is Default)");
            var data = Console.ReadKey();
            return data.Key == ConsoleKey.Y;
        }

        private async static Task PrintTaxData(OdooClient odooClient)
        {
            var taxId = Prompt("Tax ID");
            var repository = new OdooRepository<AccountTaxOdooModel>(odooClient.Config);
            var tax = await OdooHelper.GetAsync(repository, taxId);
            Console.WriteLine(JsonConvert.SerializeObject(tax));
        }

        

        public async static Task PrintRecordsModelsAsync(OdooClient odooClient)
        {
            await PrintCompanies(odooClient);

            await PrintIdentificationTypes(odooClient);

            await PrintPaymentTerms(odooClient);

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
            return new OdooClient(GetConfig());
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

        public async static Task PrintCompanies(OdooClient odooClient)
        {
            Console.WriteLine("Companies");
            try
            {
                var repository = new OdooRepository<ResCompanyOdooModel>(odooClient.Config);
                var json = await OdooHelper.GetJsonRepositoryResults(repository);
                Console.WriteLine(json);
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

        public async static Task PrintPaymentTerms(OdooClient odooClient)
        {
            Console.WriteLine("Payment Terms");
            try
            {
                var repository = new OdooRepository<AccountPaymentTermOdooModel>(odooClient.Config);
                var repositoryLines = new OdooRepository<AccountPaymentTermLineOdooModel>(odooClient.Config);
                var results = await repository.Query().ToListAsync();
                foreach (var result in results.Value)
                {
                    var json = JsonConvert.SerializeObject(result);
                    Console.WriteLine(json);
                    foreach(var line in result.LineIds)
                    {
                        var resultLine = await OdooHelper.GetAsync(repositoryLines, line);
                        var jsonLine = JsonConvert.SerializeObject(resultLine);
                        Console.WriteLine(jsonLine);
                    }                    
                }
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
                var repoCustomer = new OdooRepository<ResPartnerOdooModel>(odooClient.Config);
                var partnerId = await OdooHelper.GetCustomerLastId(repoCustomer);

                var repoProduct = new OdooRepository<ProductProductOdooModel>(odooClient.Config);
                var product = await OdooHelper.GetProdouctForSale(repoProduct, false);

                var repoAccount = new OdooRepository<AccountAccountOdooModel>(odooClient.Config);
                var accountIdInvoice = await OdooHelper.GetAccountFirstId(repoAccount, _companyId, InternalTypeAccountAccountOdooEnum.Receivable, InternalGroupAccountAccountOdooEnum.Asset);
                var accountIdInvoiceLine = await OdooHelper.GetAccountFirstId(repoAccount, _companyId, InternalTypeAccountAccountOdooEnum.Regular, InternalGroupAccountAccountOdooEnum.Income);

                var repoCurrency = new OdooRepository<ResCurrencyOdooModel>(odooClient.Config);
                var currencyId = await OdooHelper.GetFirstId(repoCurrency);

                var repoJournal = new OdooRepository<AccountJournalOdooModel>(odooClient.Config);
                var journalId = await OdooHelper.GetJournalFirstId(repoJournal, _companyId, TypeAccountJournalOdooEnum.Sale, currencyId);

                var repoAccountPaymentTerm = new OdooRepository<AccountPaymentTermOdooModel>(odooClient.Config);
                var accountPaymentTermId = await OdooHelper.GetFirstId(repoAccountPaymentTerm, _companyId);

                var versionServer = await GetVersionServer(odooClient);
                if (versionServer > 12)
                {
                    await InsertInvoiceOdooV14(odooClient, partnerId, journalId, accountIdInvoice, currencyId, product.Id, product.TaxesId, product.Name, accountPaymentTermId);
                }
                else
                {
                    var repoAccountAnalytic = new OdooRepository<AccountAnalyticAccountOdooModel>(odooClient.Config);
                    var accountAnalyticId = await OdooHelper.GetLastId(repoAccountAnalytic, _companyId);

                    var repoFleet = new OdooRepository<FleetVehicleOdooModel>(odooClient.Config);
                    var fleetId = await OdooHelper.GetLastId(repoFleet, _companyId);

                    var repoMedium = new OdooRepository<UtmMediumOdooModel>(odooClient.Config);
                    var mediumId = await OdooHelper.GetFirstId(repoMedium);

                    var repoSource = new OdooRepository<UtmMediumOdooModel>(odooClient.Config);
                    var sourceId = await OdooHelper.GetFirstId(repoSource);

                    var repoTeamCrm = new OdooRepository<CrmTeamOdooModel>(odooClient.Config);
                    var teamCrmId = await OdooHelper.GetFirstId(repoTeamCrm, _companyId);

                    var vendorId = await OdooHelper.GetVendorFirstId(repoCustomer, _companyId);

                    await InsertInvoiceOdooV12(odooClient, _companyId, partnerId, journalId, accountAnalyticId, accountIdInvoice, accountIdInvoiceLine, currencyId, product.Id, product.TaxesId, product.Name, mediumId, sourceId, accountPaymentTermId, vendorId, teamCrmId, fleetId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("");
        }

        public async static Task AddPaymentAsync(OdooClient odooClient)
        {
            var paymentAndInvoices = await AddPaymentDraftAsync(odooClient);
            
            if (paymentAndInvoices.Item1.HasValue && paymentAndInvoices.Item2.Count() > 0)
            {
                await AddInvoicesToPayment(paymentAndInvoices.Item1.Value, paymentAndInvoices.Item2);
            }

            await ConfirmPaymentAsync(paymentAndInvoices.Item1);

            //await ValidateInvoicePaymentAsync(paymentId);
        }

        private async static Task<Tuple<long?, long[]>> AddPaymentDraftAsync(OdooClient odooClient)
        {
            var invoiceId = PromptOrDefault("Invoice Id");
            var invoice = (AccountInvoiceOdooModel)null;
            var circular = "";
            var partnerId = (long?)null;
            var currencyId = (long?)null;

            if (invoiceId.HasValue)
            {
                var repositoryInvoice = new OdooRepository<AccountInvoiceOdooModel>(odooClient.Config);
                invoice = await OdooHelper.GetAsync(repositoryInvoice, invoiceId.Value);
                circular = invoice.Name;
                partnerId = invoice.PartnerId;
                currencyId = invoice.CurrencyId;
            }
            else
            {
                partnerId = PromptOrDefault("Partner Id");
                currencyId = PromptOrDefault("CurrencyId Id");
            }

            var journalId = Prompt("Journal Id");
            var paymentMethodId = PromptOrDefault("Payment Method Id");
            var amount = PromptMoneyOrDefault("Amount");
            var isFullyPaid = PrompBoolean("Mark Invoice as Fully Paid?");
            var paymentDifferenceHandling = isFullyPaid ? PaymentDifferenceHandlingAccountPaymentOdooEnum.MarkInvoiceAsFullyPaid : PaymentDifferenceHandlingAccountPaymentOdooEnum.KeepOpen;

            var invoiceIds = invoiceId.HasValue ? new long[] { invoiceId.Value } : new long[] { };
            var date = DateTime.Now;
            var model = OdooDictionaryModel.Create(() => new AccountPaymentOdooModel()
            {   
                InvoiceIds = invoiceIds,
                PartnerId = partnerId,
                CurrencyId = currencyId,
                JournalId = journalId,
                PaymentMethodId = paymentMethodId,
                PaymentDifferenceHandling = paymentDifferenceHandling,
                PaymentType = PaymentTypeAccountPaymentOdooEnum.ReceiveMoney,
                Communication = circular,
                Amount = amount,
                PartnerType = PartnerTypeAccountPaymentOdooEnum.Customer,
                PaymentDate = date,
                CreateDate = date,
                WriteDate = date,
                LastUpdate = date,
            });

            var result = await OdooHelper.AddModelAsync(model, odooClient);
            Console.WriteLine(JsonConvert.SerializeObject(result));
            
            return new Tuple<long?, long []>(result.Id, invoiceIds);
        }

        private async static Task ConfirmPaymentAsync(long? paymentId)
        {
            if (!paymentId.HasValue) return;

            var method = new OdooMethod(GetConfig(), "account.payment");

            var result = await method.CallAsync<long>("post", paymentId);

            Console.WriteLine(JsonConvert.SerializeObject(result));

            var payment = await OdooHelper.GetPaymentAsync(GetClient(), paymentId.Value);
            Console.WriteLine(payment.DisplayName);

        }

        private async static Task ValidateInvoicePaymentAsync(long? paymentId)
        {
            if (!paymentId.HasValue) return;

            var method = new OdooMethod(GetConfig(), "account.payment");

            var result = await method.CallAsync<long>("action_validate_invoice_payment", paymentId);

            Console.WriteLine(JsonConvert.SerializeObject(result));

            var payment = await OdooHelper.GetInvoiceOdooV12Async(GetClient(), paymentId.Value);
            Console.WriteLine(payment.DisplayName);
        }

        private async static Task AddInvoicesToPayment(long paymentId, long[] invoiceIds)
        {
            var result = await OdooMany2ManyService.UpdateFieldMany2Many(GetConfig(), "account.payment", new long[] { paymentId }, "invoice_ids", invoiceIds);
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }

        private async static Task<string> GetVersion(OdooClient odooClient)
        {
            var versionResult = await odooClient.GetVersionAsync();
            return versionResult.Value.ServerSerie;
        }

        private async static Task<int> GetVersionServer(OdooClient odooClient)
        {
            var version = await GetVersion(odooClient);
            int.TryParse(version.Trim().Split('.')[0], out var versionServer);
            return versionServer;
        }

        private async static Task InsertInvoiceOdooV14(OdooClient odooClient, long partnerId, long journalId, long accountId, long currencyId, long productId, long[] taxesId, string productName, long accountPaymentTermId)
        {
            var model = OdooDictionaryModel.Create(() => new AccountMoveOdooModel()
            {
                PartnerId = partnerId,
                InvoiceDate = DateTime.Now,
                Date = DateTime.Now,
                CreateDate = DateTime.Now,
                WriteDate = DateTime.Now,
                LastUpdate = DateTime.Now,
                State = StatusAccountMoveOdooEnum.Draft,
                MoveType = TypeAccountMoveOdooEnum.CustomerInvoice,
                CurrencyId = currencyId,
                JournalId = journalId,
                InvoicePaymentTermId = accountPaymentTermId,
                InvoiceDateDue = DateTime.Now.AddDays(30),
            });

            var result = await OdooHelper.AddModelAsync(model, odooClient);
            Console.WriteLine(JsonConvert.SerializeObject(result));

            if (result.Id.HasValue)
            {
                var modelLine = OdooDictionaryModel.Create(() => new AccountMoveLineOdooModel()
                {
                    AccountInternalGroup = InternalGroupAccountMoveLineOdooEnum.Income,
                    Name = productName,
                    MoveId = result.Id.Value,
                    Date = DateTime.Now,
                    ParentState = StatusAccountMoveLineOdooEnum.Draft,
                    AccountId = accountId,
                    Quantity = 1,
                    PriceUnit = 100,
                    CurrencyId = currencyId,
                    PartnerId = partnerId,
                    ProductId = productId,
                    TaxIds = taxesId,
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

        private async static Task InsertInvoiceOdooV12(OdooClient odooClient, long companyId, long partnerId, long journalId, long accountAnalyticId, long accountIdInvoice, long accountIdInvoiceLine, long currencyId, long productId, long[] taxesId, string productName, long mediumId, long sourceId, long accountPaymentTermId, long vendorId, long teamCrmId, long fleetId)
        {
            var invoiceId = await InsertInvoiceHeaderOdooV12(odooClient, companyId, partnerId, journalId, accountIdInvoice, currencyId, mediumId, sourceId, accountPaymentTermId, vendorId, teamCrmId, fleetId, null);
            var priceUnit = 100d;
            var quantity = 1d;
            var subTotal = priceUnit * quantity;
            if (invoiceId.HasValue)
            {
                var invoiceLineId = await InsertInvoiceLineOdooV12(odooClient, companyId, invoiceId, accountIdInvoiceLine, productId, accountAnalyticId, taxesId, productName, priceUnit, quantity);
                var taxLineId = await InsertTaxLineOdooV12(odooClient, invoiceId.Value, taxesId, (decimal)subTotal, currencyId);
                await AddTaxesToInvoiceLineOdooV12(invoiceLineId.Value, taxesId);
                await ValidateInvoiceOdooV12(invoiceId);
            }
        }

        private async static Task<long?> InsertInvoiceHeaderOdooV12(OdooClient odooClient, long companyId, long partnerId, long journalId, long accountIdInvoice, long currencyId, long mediumId, long sourceId, long accountPaymentTermId, long vendorId, long teamCrmId, long fleetId, long? invoiceLineId)
        {
            var invoiceLineIds = invoiceLineId.HasValue ? new long[] { invoiceLineId.Value } : new long[] {};
            var date = DateTime.Now;
            var dateDue = date.AddDays(30);
            var model = OdooDictionaryModel.Create(() => new AccountInvoiceOdooModel()
            {
                PartnerId = partnerId,
                DateInvoice = date,
                DateDue = dateDue,
                SaleCondition = CondicionVentaAccountInvoiceOdooEnum.Contado,
                Type = TypeAccountInvoiceOdooEnum.CustomerInvoice,
                State = StatusAccountInvoiceOdooEnum.Draft,
                CurrencyId = currencyId,
                JournalId = journalId,
                AccountId = accountIdInvoice,
                //MediumId = mediumId,
                //SourceId = sourceId,                
                PaymentTermId = accountPaymentTermId,
                //Vend = vendorId,
                //TeamId = teamCrmId,
                NoContrato = date.ToString(),
                Sucursal = SucursalDeAperturaAccountInvoiceOdooEnum.OficinaCentral,
                SucursalEntrega = SucursalDeEntregaAccountInvoiceOdooEnum.OficinaCentral,
                //Fleet = fleetId,
                CompanyId = companyId,
                InvoiceLineIds = invoiceLineIds,
                CreateDate = date,
                WriteDate = date,
                LastUpdate = date,
            });

            var result = await OdooHelper.AddModelAsync(model, odooClient);
            Console.WriteLine(JsonConvert.SerializeObject(result));

            return result.Id;
        }

        private async static Task<long?> InsertInvoiceLineOdooV12(OdooClient odooClient, long companyId, long? invoiceId, long accountIdInvoiceLine, long productId, long accountAnalyticId, long[] taxesId, string productName, double priceUnit, double quantity)
        {
            var modelLine = OdooDictionaryModel.Create(() => new AccountInvoiceLineOdooModel()
            {
                InvoiceId = invoiceId,
                Name = productName,
                AccountId = accountIdInvoiceLine,
                Quantity = quantity,
                PriceUnit = priceUnit,
                ProductId = productId,
                AccountAnalyticId = accountAnalyticId,
                CreateDate = DateTime.Now,
                WriteDate = DateTime.Now,
                LastUpdate = DateTime.Now,
                CompanyId = companyId,
                InvoiceLineTaxIds = taxesId
            });

            var result = await OdooHelper.AddModelAsync(modelLine, odooClient);
            Console.WriteLine(JsonConvert.SerializeObject(result));

            return result.Id;
        }

        private async static Task<long?> InsertTaxLineOdooV12(OdooClient odooClient, long invoiceId, long[] taxesId, decimal subTotalAmount, long currencyId)
        {
            if (taxesId.Length > 0)
            {
                var taxId = taxesId.FirstOrDefault();
                var taxModel = await OdooHelper.GetTaxAsync(odooClient, taxId);
                var name = taxModel.Name;
                var accountId = taxModel.AccountId.Value;
                var amount = subTotalAmount / 100 * (decimal)taxModel.Amount;
                var modelLine = OdooDictionaryModel.Create(() => new AccountInvoiceTaxOdooModel()
                {
                    InvoiceId = invoiceId,
                    TaxId = taxId,
                    Amount = amount,
                    Name = name,
                    AccountId = accountId,
                    CurrencyId = currencyId
                });

                var result = await OdooHelper.AddModelAsync(modelLine, odooClient);
                Console.WriteLine(JsonConvert.SerializeObject(result));

                return result.Id;
            }
            else
            {
                return null;
            }            
        }

        private async static Task ValidateInvoiceOdooV12(long? invoiceId)
        {
            if (!invoiceId.HasValue) return;

            var method = new OdooMethod(GetConfig(), "account.invoice");

            var result = await method.CallAsync<long>("action_invoice_open", invoiceId);

            Console.WriteLine(JsonConvert.SerializeObject(result));

            var invoice = await OdooHelper.GetInvoiceOdooV12Async(GetClient(), invoiceId.Value);
            Console.WriteLine(invoice.DisplayName);

        }

        private async static Task AddTaxesToInvoiceLineOdooV12(long invoiceLineId, long[] taxesId)
        {
            var result = await OdooMany2ManyService.UpdateFieldMany2Many(GetConfig(), "account.invoice.line", new long[] { invoiceLineId }, "invoice_line_tax_ids", taxesId);
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }

        private async static Task PrintInvoiceData(OdooClient odooClient)
        {
            var invoiceId = Prompt("Invoice ID");

            var versionServer = await GetVersionServer(odooClient);
            if (versionServer > 12)
            {
                await PrintInvoiceDataOdooV14(odooClient, invoiceId);
            }
            else
            {
                await PrintInvoiceDataOdooV12(odooClient, invoiceId);
            }
        }

        private async static Task PrintInvoiceDataOdooV14(OdooClient odooClient, long invoiceId)
        {
            var repoInvoice = new OdooRepository<AccountMoveOdooModel>(odooClient.Config);
            var repoInvoiceLine = new OdooRepository<AccountMoveLineOdooModel>(odooClient.Config);

            var invoice = await OdooHelper.GetAsync(repoInvoice, invoiceId);
            Console.WriteLine(JsonConvert.SerializeObject(invoice));

            Console.WriteLine("Invoice Lines");
            foreach (var line in invoice.InvoiceLineIds)
            {
                Console.WriteLine("Invoice Line ID: " + line);
                var invoiceLine = await OdooHelper.GetAsync(repoInvoiceLine, line);
                Console.WriteLine(JsonConvert.SerializeObject(invoiceLine));
            }
        }

        private async static Task PrintInvoiceDataOdooV12(OdooClient odooClient, long invoiceId)
        {
            var repoInvoiceV12 = new OdooRepository<AccountInvoiceOdooModel>(odooClient.Config);            
            var repoTaxes = new OdooRepository<AccountTaxOdooModel>(odooClient.Config);
            var repoInvoiceTaxes = new OdooRepository<AccountInvoiceTaxOdooModel>(odooClient.Config);
            var repoInvoiceLine = new OdooRepository<AccountInvoiceLineOdooModel>(odooClient.Config);
            var repoAccount = new OdooRepository<AccountAccountOdooModel>(odooClient.Config);

            var invoice = await OdooHelper.GetAsync(repoInvoiceV12, invoiceId);
            Console.WriteLine(JsonConvert.SerializeObject(invoice));

            await PrintAccountAsync(repoAccount, invoice.AccountId);    

            Console.WriteLine("Invoice Lines");
            foreach (var line in invoice.InvoiceLineIds)
            {
                Console.WriteLine("Invoice Line ID: " + line);
                var invoiceLine = await OdooHelper.GetAsync(repoInvoiceLine, line);
                Console.WriteLine(JsonConvert.SerializeObject(invoiceLine));

                if (invoiceLine != null)
                {
                    await PrintAccountAsync(repoAccount, invoiceLine.AccountId);

                    Console.WriteLine("Invoice Line Taxes");
                    foreach (var tax in invoiceLine.InvoiceLineTaxIds)
                    {
                        var invoiceLineTax = await OdooHelper.GetAsync(repoTaxes, tax);
                        Console.WriteLine(JsonConvert.SerializeObject(invoiceLineTax));
                    }
                }                
            }

            Console.WriteLine("Invoice Taxes");            
            foreach (var tax in invoice.TaxLineIds)
            {
                Console.WriteLine("Invoice Tax ID: " + tax);
                var taxLine = await OdooHelper.GetAsync(repoInvoiceTaxes, tax);
                Console.WriteLine(JsonConvert.SerializeObject(taxLine));
            }
        }

        private async static Task PrintAccountAsync(OdooRepository<AccountAccountOdooModel> repository, long? accountId)
        {
            if (accountId.HasValue)
            {
                Console.WriteLine("AccountId: " + accountId.Value);
                var account = await OdooHelper.GetAsync(repository, accountId.Value);
                Console.WriteLine(JsonConvert.SerializeObject(account));
            }
        }

        private static OdooConfig GetConfig()
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

            return config;
        }
    }
}
