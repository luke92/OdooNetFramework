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

        public async static Task<string> GetJsonRepositoryResult<T>(OdooRepository<T> repository) where T : IOdooModel, new()
        {
            var result = await repository.Query().OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            return JsonConvert.SerializeObject(result);
        }
    }
}
