using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TesteAPI.Models;

namespace TesteAPI.Controllers
{
    [Route("api/[controller]")]
    public class IntegracaoMLController : ControllerBase
    {
        private readonly IIntegracoes _services;

        public IntegracaoMLController(IIntegracoes services)
        {
            _services = services;
        }

        [AllowAnonymous]
        [HttpPost("MLWebhookPedido")]
        public async Task<IActionResult> MLWebhookPedido([FromBody] WebhookML pedidoJson)
        {

            if (pedidoJson.Resource == null)
            {
                Console.WriteLine("Erro ao buscar o pedido, id do pedido = null ");
                return StatusCode(500);
            }

            try
            {
                var result = await _services.SalvarPedidoML(pedidoJson);
                if (!result)
                    return StatusCode(500);

                return Ok(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, null, ex, "IntegracaoMLController", "MLWebhook");
                return StatusCode(500);
            }

        }

        [HttpPost(("GeraToken"))]
        public async Task<IActionResult> GeraToken([FromQuery] string code)
        {
            try
            {
                var result = await _services.AutenticarML(code);
                if(result != null)
                return Ok(result);

                return StatusCode(500);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, null, ex, "IntegracaoMLController", "GeraToken");
                return StatusCode(500, ex.Message);
            }
        }
    }
}
