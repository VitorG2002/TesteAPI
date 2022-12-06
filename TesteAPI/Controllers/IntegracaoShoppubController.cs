using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nancy;
using TesteAPI.Models;

namespace TesteAPI.Controllers
{
    [Route("api/[controller]")]
    public class IntegracaoShoppubController : ControllerBase
    {
        private readonly IIntegracoes _services;

        public IntegracaoShoppubController(IIntegracoes services)
        {
            _services = services;
        }

        [AllowAnonymous]
        [HttpPost("ShoppubWebhook")]
        public async Task<IActionResult> ShoppubWebhook([FromBody] PedidoShoppubWebhook pedidoJson, [FromQuery] string token)
        {

            token = token.Substring(6).Trim();

            try
            {
                return Ok(await _services.GetPedidoShoppubWebhook(pedidoJson, token));
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
