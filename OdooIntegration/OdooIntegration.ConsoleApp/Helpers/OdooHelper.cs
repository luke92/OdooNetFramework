using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using PortaCapena.OdooJsonRpcClient.Result;
using System;
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

        public async static Task<long> GetFirstId<T>(OdooRepository<T> repository) where T : IOdooModel, new()
        {
            var result = await repository.Query().OrderBy(x => x.Id).Select(x => x.Id).FirstOrDefaultAsync();
            return result.Value.Id;
        }

        public async static Task<long> GetLastId<T>(OdooRepository<T> repository) where T : IOdooModel, new()
        {
            var result = await repository.Query().OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefaultAsync();
            return result.Value.Id;
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
