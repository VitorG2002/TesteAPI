using TesteAPI.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TesteAPI
{
    public interface IIntegracoes
    {
        public Task<bool> GetPedidoWooCommerceWebhook(WooCommercePedido pedido, string consumer_key, string consumer_secret);
        public Task<bool> GetPedidoShoppubWebhook(PedidoShoppubWebhook pedido, string token);
        public Task<string> GetBlingNotaFiscal(BlingPedidos dadosPedido, string codigoServico, string apiKey);
        public Task<bool> SalvarPedidoNuvemShop(NuvemShopWebhook pedidoWebhook);
        public  Task<bool> SalvarPedidoML(WebhookML pedido);
        public Task<T> BuscarIntegracao<T>(string token, int  integracaoTipo) where T : new();
        public Task<string> AutenticarML(string code);
        public Task<string> AutenticarNuvemshop(string code);
        public  Task<NuvemShopLoja> CriarLojaNuvemShop(string token, string idLoja);
    }
}
