using Microsoft.AspNetCore.Mvc;
using Nancy;
using TesteAPI.Models;
using AllowAnonymousAttribute = Microsoft.AspNetCore.Authorization.AllowAnonymousAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace TesteAPI.Controllers
{
    [Route("api/[controller]")]
    public class IntegracaoWooCommerceController : ControllerBase
    {
        private readonly IIntegracoes _services;
        public IntegracaoWooCommerceController(IIntegracoes services)
        {
            _services = services;
        }

        [AllowAnonymous]
        [HttpPost("WooCommerceWebhook")]
        public async Task<IActionResult> WooCommerceWebhook([Microsoft.AspNetCore.Mvc.FromBody] WooCommercePedido pedidoJson, [FromQuery] string consumer_key, [FromQuery] string consumer_secret)
        {
                try
                {
                return  Ok(await _services.GetPedidoWooCommerceWebhook(pedidoJson, consumer_key, consumer_secret));
                }
                catch (Exception ee)
                {
                string msgErro = "";
                Console.WriteLine($"Erro pegar Pedido: " + msgErro, "SHOPPUB_WEBHOOK", null);
                return StatusCode(500);
                }
            }

        }

    }
