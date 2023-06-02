using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Nancy;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using TesteAPI.Models;
namespace TesteAPI.Controllers
{
    [Route("api/[controller]")]
    public class IntegracaoNuvemShopController : ControllerBase
    {
        private readonly IIntegracoes _services;

        public IntegracaoNuvemShopController(IIntegracoes services)
        {
            _services = services;
        }

        //[HttpPost("GerarEndPointNuvemShop")]
        //public async Task<IActionResult> GerarEndPoint(int codigoIntegracao)
        //{
        //    try
        //    {
        //        var result = await _services.GerarUrlNuvemShop(codigoIntegracao);

        //        if (result != null)
        //            return Ok(result);

        //        return StatusCode(500, new Response { Status = 500, Message = Mensagens.ERRO_GERAR_URL });
        //    }
        //    catch (Exception ex)
        //    {
        //        TratamentoErros.GravarLog(ex.Message, null, ex, "IntegracaoNuvemShopController", "GerarEndPointNuvemShop");
        //        return StatusCode(500, new Response { Status = 500, Message = ex.Message });
        //    }
        //}

        [AllowAnonymous]
        [HttpPost("NuvemShopWebhook")]
        public async Task<IActionResult> NuvemShopWebhook([FromBody] NuvemShopWebhook pedidoJson)
        {

            if (pedidoJson.Id == null)
            {
                Console.WriteLine("Erro ao buscar o pedido, id do pedido = null ");
                return StatusCode(500);
            }

            try
            {
                var result = await _services.SalvarPedidoNuvemShop(pedidoJson);
                if(!result)
                    return StatusCode(500);

                return Ok(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, null, ex, "IntegracaoNuvemShopController", "GetNuvemShopPedidoWebhook");
                return StatusCode(500);
            }

        }

        [HttpPost(("GeraToken"))]
        public async Task<IActionResult> GeraToken([FromQuery] string code)
        {
            try
            {
                var result = await _services.AutenticarNuvemshop(code);
                return Ok(result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message, null, ex, "IntegracaoNuvemShopController", "GeraToken");
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(("GeraLoja"))]
        public async Task<IActionResult> GeraLoja(string token, string idLoja)
        {
            try
            {
                var result = await _services.CriarLojaNuvemShop(token, idLoja);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, null, ex, "IntegracaoNuvemShopController", "GeraToken");
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{codigo}")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteStore(int codigo)
        {
            if (codigo == 0)
                return StatusCode(400);

            try
            {
                var result = true; //await _services.DeleteStoreNuvemShop(codigo);

                if (result == false)
                    return StatusCode(500);

                return NoContent();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, null, ex, "IntegracoesController", "Delete");
                return StatusCode(500);
            }
        }
    }
}

