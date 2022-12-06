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
        //public Task<object> CapturarTokenServicos();
        //public Task<bool> MandaRequisicao(WooCommercePedido? pedido, WooCommerceServicosIntegrar? servico, PedidoShoppub? pedidoShoppub);
        public Task<T> CapturarTokenServicos<T>(string token, int  integracaoTipo) where T : new();

        public Task<string> Autenticar(string code);
    }
}
