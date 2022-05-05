using Newtonsoft.Json;
using OdooIntegration.ConsoleApp.Models;
using PortaCapena.OdooJsonRpcClient;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using PortaCapena.OdooJsonRpcClient.Request;
using PortaCapena.OdooJsonRpcClient.Result;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdooIntegration.ConsoleApp.Helpers
{
    public static class OdooHelper
    {
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

        public async static Task<string> GetJsonRepositoryResults<T>(OdooRepository<T> repository) where T : IOdooModel, new()
        {
            var results = await repository.Query().ToListAsync();
            return JsonConvert.SerializeObject(results);
        }

        public async static Task<string> GetJsonRepositoryResult<T>(OdooRepository<T> repository, long? id = null) where T : IOdooModel, new()
        {
            if (id.HasValue)
            {
                var result = await repository.Query().Where(x => x.Id, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, id.Value).FirstOrDefaultAsync();
                return JsonConvert.SerializeObject(result);
            }
            else
            {
                var result = await repository.Query().OrderByDescending(x => x.Id).FirstOrDefaultAsync();
                return JsonConvert.SerializeObject(result);
            }            
        }

        public async static Task<T> GetAsync<T>(OdooRepository<T> repository, long id) where T : IOdooModel, new()
        {
            var result = await repository.Query().Where(x => x.Id, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, id).FirstOrDefaultAsync();
            return result.Value;
        }

        public async static Task<T> GetFirst<T>(OdooRepository<T> repository, long? companyId = null) where T : IOdooModel, new()
        {
            var query = GetQuery(repository, companyId);
            var result = await query.OrderBy(x => x.Id).FirstOrDefaultAsync();
            return result.Value;
        }

        public async static Task<long> GetFirstId<T>(OdooRepository<T> repository, long? companyId = null) where T : IOdooModel, new()
        {
            var query = GetQuery(repository, companyId);
            var result = await query.OrderBy(x => x.Id).Select(x => x.Id).FirstOrDefaultAsync();
            return result.Value.Id;
        }

        public async static Task<T> GetLast<T>(OdooRepository<T> repository, long? companyId = null) where T : IOdooModel, new()
        {
            var query = GetQuery(repository, companyId);
            var result = await query.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            return result.Value;
        }

        public async static Task<long> GetLastId<T>(OdooRepository<T> repository, long? companyId = null) where T : IOdooModel, new()
        {
            var query = GetQuery(repository, companyId);
            var result = await query.OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefaultAsync();
            return result.Value.Id;
        }

        public async static Task<long> GetAccountLastId(OdooRepository<AccountAccountOdooModel> repository, long? companyId = null, InternalTypeAccountAccountOdooEnum? internalType = null, InternalGroupAccountAccountOdooEnum? internalGroup = null)
        {
            var query = GetAccountQuery(repository, companyId, internalType, internalGroup);
            query = query.OrderByDescending(x => x.Id);
            var result = await query.FirstOrDefaultAsync();
            return result.Value.Id;
        }

        public async static Task<long> GetAccountFirstId(OdooRepository<AccountAccountOdooModel> repository, long? companyId = null, InternalTypeAccountAccountOdooEnum? internalType = null, InternalGroupAccountAccountOdooEnum? internalGroup = null)
        {
            var query = GetAccountQuery(repository, companyId, internalType, internalGroup);
            query = query.OrderBy(x => x.Id);
            var result = await query.FirstOrDefaultAsync();
            return result.Value.Id;
        }

        public async static Task<long> GetJournalLastId(OdooRepository<AccountJournalOdooModel> repository, long? companyId = null, TypeAccountJournalOdooEnum? typeAccountJournal = null, long? currencyId = null)
        {
            var query = GetJournalQuery(repository, companyId, typeAccountJournal, currencyId);
            query = query.OrderByDescending(x => x.Id);
            var result = await query.FirstOrDefaultAsync();
            return result.Value.Id;
        }

        public async static Task<long> GetJournalFirstId(OdooRepository<AccountJournalOdooModel> repository, long? companyId = null, TypeAccountJournalOdooEnum? typeAccountJournal = null, long? currencyId = null)
        {
            var query = GetJournalQuery(repository, companyId, typeAccountJournal, currencyId);
            query = query.OrderBy(x => x.Id);
            var result = await query.FirstOrDefaultAsync();
            return result.Value.Id;
        }

        public async static Task<long> GetVendorFirstId(OdooRepository<ResPartnerOdooModel> repository, long? companyId = null)
        {
            var query = GetQuery(repository, companyId);
            var result = await query.Where(x => x.IdVend, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, true).OrderBy(x => x.Id).Select(x => x.Id).FirstOrDefaultAsync();
            return result.Value.Id;
        }

        public async static Task<long> GetCustomerLastId(OdooRepository<ResPartnerOdooModel> repository, long? companyId = null)
        {
            var query = GetQuery(repository, companyId);
            var result = await query.Where(x => x.Customer, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, true).OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefaultAsync();
            return result.Value.Id;
        }

        public async static Task<ProductProductOdooModel> GetProdouctForSale(OdooRepository<ProductProductOdooModel> repository, bool getLast = true, long? companyId = null)
        {
            var query = GetQuery(repository, companyId);
            query = query.Where(x => x.SaleOk, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, true);
            query = query.Where(x => x.Type, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, ProductTypeProductProductOdooEnum.Service);
            query = query.Where(x => x.PurchaseOk, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, false);

            if (getLast)
            {
                query = query.OrderByDescending(x => x.Id);
            }
            else
            {
                query = query.OrderBy(x => x.Id);
            }

            var result = await query.FirstOrDefaultAsync();
            return result.Value;
        }

        public async static Task<long?> AddModelAndReturnIdAsync<T>(OdooDictionaryModel<T> model, OdooClient odooClient) where T : IOdooModel, new()
        {
            var repository = new OdooRepository<T>(odooClient.Config);
            var result = await repository.CreateAsync(model);
            return GetNewId(result);
        }

        public async static Task<StatusResponseWithAction> AddModelAsync<T>(OdooDictionaryModel<T> model, OdooClient odooClient) where T : IOdooModel, new()
        {
            var repository = new OdooRepository<T>(odooClient.Config);
            var result = await repository.CreateAsync(model);
            return GetStatusResponse(result);
        }

        public async static Task<StatusResponseWithAction> UpdateModelAsync<T>(OdooDictionaryModel<T> model, long id, OdooClient odooClient) where T : IOdooModel, new()
        {
            var repository = new OdooRepository<T>(odooClient.Config);
            var result = await repository.UpdateAsync(model, id);
            return GetStatusResponse(result);
        }

        private static long? GetNewId(OdooResult<long> result)
        {
            if (!result.Failed && result.Value > 0)
            {
                return result.Value;
            }
            return null;
        }

        private static StatusResponseWithAction GetStatusResponse(OdooResult<long> result)
        {
            var statusResponse = new StatusResponseWithAction();
            if (!result.Failed && result.Value > 0)
            {
                statusResponse.OperationConcreted = true;
                statusResponse.Message = result.Value.ToString();
                statusResponse.CanContinueAction = true;
                statusResponse.IsNew = true;
                statusResponse.Id = result.Value;
            }
            else
            {
                statusResponse.Message = GetOdooErrors(result);
            }
            return statusResponse;
        }

        private static StatusResponseWithAction GetStatusResponse(OdooResult<bool> result)
        {
            var statusResponse = new StatusResponseWithAction();
            if (!result.Failed && result.Value)
            {
                statusResponse.OperationConcreted = true;
                statusResponse.Message = result.Value.ToString();
                statusResponse.CanContinueAction = true;
            }
            else
            {
                statusResponse.Message = GetOdooErrors(result);
            }
            return statusResponse;
        }

        private static string GetOdooErrors<T>(PortaCapena.OdooJsonRpcClient.Result.OdooResult<T> odooResult)
        {
            var message = "";
            if (odooResult != null)
            {
                message += odooResult.Message;
                if (odooResult.Error != null && odooResult.Error.Data != null)
                    message += ". " + odooResult.Error.Data.Message;
            }
            return message;
        }

        private static OdooQueryBuilder<AccountAccountOdooModel> GetAccountQuery(OdooRepository<AccountAccountOdooModel> repository, long? companyId = null, InternalTypeAccountAccountOdooEnum? internalType = null, InternalGroupAccountAccountOdooEnum? internalGroup = null)
        {
            var query = GetQuery(repository, companyId);
            if (internalType.HasValue)
            {
                query = query.Where(x => x.InternalType, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, internalType);
            }
            if (internalGroup.HasValue)
            {
                query = query.Where(x => x.InternalGroup, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, internalGroup);
            }
            return query.Select(x => x.Id);
        }

        private static OdooQueryBuilder<AccountJournalOdooModel> GetJournalQuery(OdooRepository<AccountJournalOdooModel> repository, long? companyId = null, TypeAccountJournalOdooEnum? typeAccountJournal = null, long? currencyId = null)
        {
            var query = GetQuery(repository, companyId);
            if (typeAccountJournal.HasValue)
            {
                query = query.Where(x => x.Type, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, typeAccountJournal);
            }
            if (currencyId.HasValue)
            {
                query = query.Where(x => x.CurrencyId, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, currencyId);
            }

            query = query.Where(x => x.RefundSequence, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, true);
            query = query.Where(x => x.UpdatePosted, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, true);

            return query.Select(x => x.Id);
        }

        private static OdooQueryBuilder<T> GetQuery<T>(OdooRepository<T> repository, long? companyId = null) where T : IOdooModel, new()
        {
            var query = repository.Query();
            if (companyId.HasValue && companyId.Value > 0)
            {
                var filter = OdooFilter.Create()
                .EqualTo("company_id", companyId.Value);
                query = query.Where(filter);
            }
            return query;
        }

        public async static Task<AccountTaxOdooModel> GetTaxAsync(OdooClient odooClient, long taxId)
        {
            var repoTaxes = new OdooRepository<AccountTaxOdooModel>(odooClient.Config);
            var query = GetQueryId(repoTaxes, taxId);
            var result = await query.FirstOrDefaultAsync();
            return result.Value;
        }
        public async static Task<AccountInvoiceOdooModel> GetInvoiceOdooV12Async(OdooClient odooClient, long id)
        {
            var repository = new OdooRepository<AccountInvoiceOdooModel>(odooClient.Config);
            var query = GetQueryId(repository, id);
            var result = await query.FirstOrDefaultAsync();
            return result.Value;
        }

        public async static Task<AccountPaymentOdooModel> GetPaymentAsync(OdooClient odooClient, long id)
        {
            var repository = new OdooRepository<AccountPaymentOdooModel>(odooClient.Config);
            var query = GetQueryId(repository, id);
            var result = await query.FirstOrDefaultAsync();
            return result.Value;
        }

        public async static Task<List<PaymentModel>> GetPaymentsWithoutInvoiceAsync(OdooClient odooClient, long? companyId = null)
        {
            var repository = new OdooRepository<AccountPaymentOdooModel>(odooClient.Config);
            var query = GetQuery(repository,companyId);            
            query = query.Where( x=> x.State, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, StatusAccountPaymentOdooEnum.Posted);
            query = query.Where(x => x.HasInvoices, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, false);
            query = query.Where(x => x.AmountPayable, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.GreaterThan, 0);
            query = query.Where(x => x.MoveReconciled, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, false);
            var result = await query.Select(x => new PaymentModel
            {
                Id = x.Id,
                Name = x.Name,
                DisplayName = x.DisplayName,
                Amount = x.Amount,
                AmountPayable = x.AmountPayable
            }).Take(10).ToListAsync();
            var list = new List<PaymentModel>();
            foreach( var paymentOdoo in result.Value)
            {
                var payment = new PaymentModel
                {
                    Id = paymentOdoo.Id,
                    Name = paymentOdoo.Name,
                    DisplayName = paymentOdoo.DisplayName,
                    Amount = paymentOdoo.Amount,
                    AmountPayable = paymentOdoo.AmountPayable
                };
                list.Add(payment);
            }
            return list;
        }

        public async static Task<AccountInvoiceLineOdooModel[]> GetInvoiceLinesAsync(OdooClient odooClient, long invoiceId, long? companyId = null)
        {
            var repository = new OdooRepository<AccountInvoiceLineOdooModel>(odooClient.Config);
            var query = GetQuery(repository, companyId);
            query = query.Where(x => x.InvoiceId, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, invoiceId);
            var results = await query.ToListAsync();
            return results.Value;
        }

        public async static Task<AccountInvoiceTaxOdooModel[]> GetInvoiceTaxesAsync(OdooClient odooClient, long invoiceId, long? companyId = null)
        {
            var repository = new OdooRepository<AccountInvoiceTaxOdooModel>(odooClient.Config);
            var query = GetQuery(repository, companyId);
            query = query.Where(x => x.InvoiceId, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, invoiceId);
            var results = await query.ToListAsync();
            return results.Value;
        }

        private static OdooQueryBuilder<T> GetQueryId<T>(OdooRepository<T> repository, long id) where T : IOdooModel, new()
        {
            var query = repository.Query();
            query = query.Where(x => x.Id, PortaCapena.OdooJsonRpcClient.Consts.OdooOperator.EqualsTo, id);
            return query;
        }

    }

    public class PaymentModel : GenericOdooModel
    {
        public decimal? Amount { get; set; }
        public decimal? AmountPayable { get; set; }

    }

    public class GenericOdooModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }

    public class StatusResponse
    {
        /// <summary>
        /// Obtiene o establece si la respuesta es satisfactoria, Operacion Concretada (Indica si la Conexión con el sistema externo es correcta o no) o si la operación realizada fue satisfactoria
        /// </summary>
        public bool OperationConcreted { get; set; }
        /// <summary>
        /// Mensaje de excepción o de respuesta
        /// </summary>
        public string Message { get; set; }

        public void SetException(Exception ex)
        {
            OperationConcreted = false;
            Message = ex.Source + " " + ex.Message;
        }

        public void SetOperationNotConcreted(string message)
        {
            OperationConcreted = false;
            Message = message;
        }

        public void SetOperationSuccessfully(string message)
        {
            OperationConcreted = true;
            Message = message;
        }

        public StatusResponse() { }
        public StatusResponse(bool operationConcreted, string message = null)
        {
            OperationConcreted = operationConcreted;
            Message = message;
        }
    }

    public class StatusResponseWithAction : StatusResponse
    {
        /// <summary>
        /// Indica si la acción que sigue a la operacion debe continuar o no 
        /// (Ejemplo: Se agrega o actualiza cliente en ERP e indica si se debe crear la factura o no)
        /// Necesario para ITRIS u ODOO
        /// </summary>
        public bool CanContinueAction { get; set; }
        /// <summary>
        /// Para saber si lo enviado es nuevo en el otro sistema
        /// </summary>
        public bool IsNew { get; set; }

        public long? Id { get; set; }

        public StatusResponseWithAction() { }
        public StatusResponseWithAction(bool operationConcreted, bool continueAction, string message = null)
        {
            OperationConcreted = operationConcreted;
            CanContinueAction = continueAction;
            Message = message;
        }

        public static StatusResponseWithAction FromException(Exception ex)
        {
            var status = new StatusResponseWithAction();
            status.SetException(ex);
            return status;
        }
    }
}
