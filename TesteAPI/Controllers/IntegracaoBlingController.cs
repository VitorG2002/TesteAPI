using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nancy;
using System.Resources;
using TesteAPI.Models;
using TesteAPI.Util;
using System.Net.Http;

namespace TesteAPI.Controllers
{
    [Route("api/[controller]")]
    public class IntegracaoBlingController : ControllerBase
    {
        private readonly IIntegracoes _services;

        public IntegracaoBlingController(IIntegracoes services)
        {
            _services = services;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> BlingWebhook([FromBody] BlingPedidos pedidoJson, string cs, string apikey)
        {

            if (pedidoJson.Retorno == null)
            {
                string msgErro = "Erro pedido =  null";
               Console.WriteLine($"Erro pegar NF: " + msgErro, "BLING_WEBHOOK", null);
                return StatusCode(500, msgErro);
            }
            else if (string.IsNullOrEmpty(cs))
            {
                string msgErro = "Erro codigoServico = null";
               Console.WriteLine($"Erro Parametro cs null ou vazio", "BLING_WEBHOOK", null);
                return StatusCode(500, msgErro);
            }
            else if (string.IsNullOrEmpty(apikey))
            {
                string msgErro = "Erro apikey =  null";
               Console.WriteLine($"Erro Parametro apikey null ou vazio", "BLING_WEBHOOK", null);
                return StatusCode(500, msgErro);
            }

            string chaveDecript = "";

            try
            {
                chaveDecript = FuncoesString.Base64Decode(cs);
            }
            catch
            {
                string msgErro = $"Erro chaveDecript: " + chaveDecript + "BLING_WEBHOOK";
                Console.WriteLine($"Erro chaveDecript: " + chaveDecript, "BLING_WEBHOOK", null);
                return StatusCode(500, msgErro);
            }


            try
            {
                var nota = await _services.GetBlingNotaFiscal(pedidoJson, chaveDecript, apikey);                   
                if (nota.Contains("Erro") || nota.Contains("erro")){
                    return StatusCode(500, nota);
                }
                else             
                return Created("C:\\temp\\PASTA_BLING_WEBHOOK", nota);
            }
            catch (Exception ee)
            {
                string msgErro = $"Erro ao pegar NF: ";
               Console.WriteLine($"Erro pegar NF: " + msgErro, "BLING_WEBHOOK", null);
                return StatusCode(500, msgErro);
            }

        }
    }
}
