using Microsoft.EntityFrameworkCore;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using TesteAPI.Models;
using TesteAPI.Util;

namespace TesteAPI.Services
{


    public class IntegracoesServices : IIntegracoes
    {
        //private readonly RadarDataContext _context;
        private Hashtable htPedidosProcessados = new Hashtable();
        private string nomeArquivoLogWooCommerceWebHook = "WOOCOMMERCE_WEBHOOK";
        private string strIdentificadorServicoUsuario = "WOOCOMMERCE_WEBHOOK_(COD_SERV={0})(COD_USUARIO={1})";
        private string pastaDestinoJsonWooCommerce = "";
        //Separação
        private string nomeArquivoLogShoppubWebHook = "SHOPPUB_WEBHOOK";
        private string strIdentificadorServicoUsuario1 = "SHOPPUB_WEBHOOK_(COD_SERV={0})(COD_USUARIO={1})";
        private string pastaDestinoJsonShoppub = "";
        //Separação
        private string nomeArquivoLogBlingWebhook = "BLING";
        private string strIdentificadorServicoUsuario2 = "BLING_(COD_SERV={0})(COD_USUARIO={1})";
        private string pastaDestinoJsonBling = "";
        //Separação
        private string pastaDestinoJsonNuvemShop = "";
        private string nomeArquivoLogNuvemShop = "NUVEMSHOP";
        private string strIdentificadorServicoUsuario3 = "NUVEM_SHOP_(COD_SERV={0})(COD_USUARIO={1})";
        JavaScriptSerializer serializer = new JavaScriptSerializer();
        private readonly IConfiguration _configuration;

        public IntegracoesServices(IConfiguration configuration)
        {
            //_context = context;
            _configuration = configuration;
            pastaDestinoJsonWooCommerce = _configuration.GetValue<string>("pastaWooCommerceWebhook");
            pastaDestinoJsonShoppub = _configuration.GetValue<string>("pastaShoppubWebhook");
            pastaDestinoJsonBling = _configuration.GetValue<string>("pastaBlingWebhook");
            pastaDestinoJsonNuvemShop = _configuration.GetValue<string>("pastaNuvemshopWebhook");
        }

        public async Task<T> CapturarTokenServicos<T>(string _token, int tipoIntegracao) where T : new()
        {
            T servico1 = new T();
            try
            {
                //using (_context)
                //{
                //    var servico = await _context.Database.SqlQuery<T>($@"select 
                //                                                                            s.codigo,
                //                                                                            s.fk_servico,
                //                                                                            s.descricao,
                //                                                                            e.nome_fantasia,
                //                                                                            e.cnpj_cpf,
                //                                                                            s.integracao_api_key,
                //                                                                            s.integracao_id,
                //                                                                            s.integracao_tipo,
                //                                                                            s.integracao_nome_transportadora,
                //                                                                            s.integracao_url,
                //                                                                            coalesce(s.integracao_importar_sem_nf, false) as integracao_importar_sem_nf
                //                                                                        from
                //                                                                            cl_integracoes s
                //                                                                            inner join cl_empresas e on e.codigo = s.fk_empresa
                //                                                                        where
                //                                                                            s.integracao_api_key='{_token}' and s.integracao_tipo= {tipoIntegracao}").FirstOrDefaultAsync();
                //    servico1 = servico;
                //}

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar o serviço, Token do Serviço: " + _token, nomeArquivoLogShoppubWebHook, ex);
            }

            return servico1;
        }

        public async Task<T> CapturarTokenServicos<T>(string api_key, string consumer_secret, int tipoIntegracao) where T : new()
        {
            T servico1 = new T();
            //try
            //{
            //    using (RadarDataContext db = new RadarDataContext())
            //    {
            //        var servico = await db.Database.SqlQuery<T>($@"select 
            //                                                                                s.codigo,
            //                                                                                s.fk_servico,
            //                                                                                s.descricao,
            //                                                                                e.nome_fantasia,
            //                                                                                e.cnpj_cpf,
            //                                                                                s.integracao_api_key,
            //                                                                                s.integracao_id,
            //                                                                                s.integracao_tipo,
            //                                                                                s.integracao_nome_transportadora,
            //                                                                                s.integracao_url,
            //                                                                                coalesce(s.integracao_importar_sem_nf, false) as integracao_importar_sem_nf
            //                                                                            from
            //                                                                                cl_integracoes s
            //                                                                                inner join cl_empresas e on e.codigo = s.fk_empresa
            //                                                                            where
            //                                                                                s.integracao_api_key='{_token}' and s.integracao_tipo=" + (int)Tipos.TiposIntegracoes.Shoppub).FirstOrDefaultAsync();
            //        servico1 = servico;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Erro ao buscar o serviço, Token do Serviço: " + _token, nomeArquivoLogShoppubWebHook, ex);
            //}

            return servico1;
        }

        public async Task<bool> GravarArquivoJson<T, S>(T pedido, S servico, string pastaDestino, string strIdServicoUsuario, string nomeArquivoLog)
        {
            Type t = pedido.GetType();
            PropertyInfo prop = t.GetProperty("Id");
            var chaveUnicidade = prop.GetValue(pedido);

            Type s = servico.GetType();
            PropertyInfo propFkServico = s.GetProperty("FK_servico");
            var fk_servico = propFkServico.GetValue(servico);

            PropertyInfo propNomeServico = s.GetProperty("Descricao");
            var nomeServico = propNomeServico.GetValue(servico);

            string caminho = Path.Combine(pastaDestino, string.Format(FuncoesArquivos.GerarNomeArquivoTemporarioGuid(strIdServicoUsuario, FuncoesArquivos.EXTENSAO_JSON), fk_servico, 5));
            using (StreamWriter file = new StreamWriter(Path.Combine(pastaDestino, string.Format(FuncoesArquivos.GerarNomeArquivoTemporarioGuid(strIdServicoUsuario, FuncoesArquivos.EXTENSAO_JSON), fk_servico, 5)), false, Encoding.UTF8))
            {
                file.WriteLine(serializer.Serialize(pedido));
                Console.WriteLine("Pedido Salvo: " + chaveUnicidade + ", Serviço Utilizado: " + nomeServico);
                return true;
            }
        }

        #region WooCommerceWebhook

        public async Task<WooCommerceServicosIntegrar> CapturarTokenServicoWooCommerce(string api_key, string consumer_secret)
        {
            WooCommerceServicosIntegrar servico = new WooCommerceServicosIntegrar
            {
                Codigo = 123,
                Descricao = "TESTANDO",
                Integracao_nome_transportadora = "Teste",
                Integracao_consumer_key = "ck_53dbcfb485fc41db9532b178f6c25d54c58c2956",
                Integracao_consumer_secret = "cs_7d3e8582c31bd92895144936a1f01d418a94eb4d",
                Integracao_url = "https://localhost",
                FK_servico = 4717
            };

            return servico;
        }
        public bool ValidaPedidoWooCommerce(WooCommercePedido dadosPedido, WooCommerceServicosIntegrar servico)
        {
            if (dadosPedido != null)
            {
                if (dadosPedido.Shipping != null)
                {
                    if (dadosPedido.Shipping.Company != null)
                    {
                        if (!string.IsNullOrEmpty(dadosPedido.Shipping.Company) && !string.IsNullOrEmpty(servico.Integracao_nome_transportadora))
                        {
                            if (dadosPedido.Shipping.Company.ToUpper().Trim().Contains(servico.Integracao_nome_transportadora.ToUpper().Trim())
                                || servico.Integracao_nome_transportadora.ToUpper().Trim().Contains(dadosPedido.Shipping.Company.ToUpper().Trim()))
                            {
                                return true;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erro ao validar o Pedido, Transporte = null" + ", nro pedido: " + dadosPedido.Id, nomeArquivoLogWooCommerceWebHook, null);
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Erro ao validar o Pedido, transportadora = null", nomeArquivoLogWooCommerceWebHook, null);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Erro ao validar o Pedido, pedido = null", nomeArquivoLogWooCommerceWebHook, null);
                return false;
            }
            Console.WriteLine("Erro ao validar o Pedido", nomeArquivoLogWooCommerceWebHook, null);
            return false;
        }

        public async Task<bool> GetPedidoWooCommerceWebhook(WooCommercePedido pedido, string consumer_key, string consumer_secret)
        {
            var servico = await CapturarTokenServicoWooCommerce(consumer_key, consumer_secret);

            if (servico == null)
            {
                Console.WriteLine("Erro ao buscar o serviço", nomeArquivoLogWooCommerceWebHook, null);
                return false;
            }

            bool pedidoValido = ValidaPedidoWooCommerce(pedido, servico);
            if (!pedidoValido)
            {
                return false;
            }

            try
            {
                return await BuscarPedidoWooCommerce(pedido, servico);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar o pedido, id do pedido: " + pedido.Id + " Serviço utilizado: ", nomeArquivoLogWooCommerceWebHook, ex);
                return false;
            }
        }

        public async Task<bool> BuscarPedidoWooCommerce(WooCommercePedido pedido, WooCommerceServicosIntegrar servico)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            using (var httpCliente = new HttpClient(clientHandler))
            {
                ServicePointManager.Expect100Continue = true;
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                httpCliente.Timeout = new TimeSpan(0, 0, 60);
                string url = $"{servico.Integracao_url}/wordpress/wp-json/wc/v3/orders/{pedido.Id}?consumer_key={servico.Integracao_consumer_key}&consumer_secret={servico.Integracao_consumer_secret}";
                HttpResponseMessage response = await httpCliente.GetAsync(new Uri(url));
                var jsonRetorno = await response.Content.ReadAsStringAsync();

                if ((jsonRetorno != null) && (response.IsSuccessStatusCode))
                {
                    WooCommercePedido dadosRetorno = JsonConvert.DeserializeObject<WooCommercePedido>(jsonRetorno);

                    try
                    {
                        return await GravarArquivoJson(dadosRetorno, servico, pastaDestinoJsonWooCommerce, strIdentificadorServicoUsuario, nomeArquivoLogWooCommerceWebHook);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro para buscar o pedido - Shoppub Webhook: ", nomeArquivoLogWooCommerceWebHook, ex);
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Erro ao buscar o pedido, id do pedido: " + pedido.Id + " Serviço utilizado: ", nomeArquivoLogWooCommerceWebHook, null);
                    return false;
                }
            }
        }

        #endregion

        #region ShoppubWebhook
        public async Task<ShoppubServicosIntegrar> CapturarTokenServicosShoppub(string token)
        {
            ShoppubServicosIntegrar servico = new ShoppubServicosIntegrar
            {
                Codigo = 123,
                Descricao = "MARIA EDUARDA FONTANEZI FERREIRA COM DE CALÇ (BROGAN)",
                Nome_fantasia = "simonvergan",
                Integracao_nome_transportadora = "Transfolha",
                Integracao_api_key = "efd655fa6fee5beb7b71725cb93e98b2b789b4ca",
                Integracao_url = "https://www.brogan.com.br",
                Integracao_importar_sem_nf = false,
                FK_servico = 4716
            };

            return servico;
        }

        private bool ValidarTransportadoraShoppub(PedidoShoppub pedido, ShoppubServicosIntegrar servico)
        {
            if (pedido != null)
                if (pedido.FreteSet != null)
                    if (pedido.FreteSet.Count > 0)
                        if (!string.IsNullOrEmpty(pedido.FreteSet[0].TransportadoraNome))
                            if (pedido.FreteSet[0].TransportadoraNome.ToUpper().Trim().Contains(servico.Integracao_nome_transportadora.ToUpper().Trim()))
                            {
                                return true;
                            }
                            else
                                Console.WriteLine($"Transportadora diferente, transportadora_nome: '{pedido.FreteSet[0].TransportadoraNome.ToUpper().Trim()}', pedido_id: {pedido.Id}, Serviço descrição {servico.Descricao} ", nomeArquivoLogShoppubWebHook, null);


            Console.WriteLine($" Erro ao validar transportadora, pedido_id: {pedido.Id}, Serviço descrição: '{servico.Descricao}'", nomeArquivoLogShoppubWebHook, null);
            return false;
        }

        public async Task<bool> GetPedidoShoppubWebhook(PedidoShoppubWebhook pedido, string token)
        {
            var servico = await CapturarTokenServicosShoppub(token);

            if (servico == null)
                Console.WriteLine("Erro ao buscar o serviço", nomeArquivoLogShoppubWebHook, null);

            if (pedido.Id == null)
                Console.WriteLine("Erro ao buscar o pedido, id do pedido = null " + " Serviço utilizado: " + servico.Descricao, nomeArquivoLogShoppubWebHook, null);

            if (servico == null || pedido.Id == null)
                return false;

            try
            {
                return await BuscarPedidoShoppub(pedido, servico);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar o pedido, id do pedido: " + pedido.Id + " Serviço utilizado: " + servico.Descricao, nomeArquivoLogShoppubWebHook, ex);
                return false;
            }
        }


        public async Task<bool> BuscarPedidoShoppub(PedidoShoppubWebhook pedido, ShoppubServicosIntegrar servico)
        {
            using (var httpCliente = new HttpClient())
            {
                httpCliente.DefaultRequestHeaders.Add("Authorization", $"Token {servico.Integracao_api_key}");
                ServicePointManager.Expect100Continue = true;
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                HttpResponseMessage response = null;
                httpCliente.Timeout = new TimeSpan(0, 0, 60);
                string url = $"{servico.Integracao_url}/api/v1/pedido/{pedido.Id}/";
                response = await httpCliente.GetAsync(new Uri(url));
                var jsonRetorno = await response.Content.ReadAsStringAsync();

                if ((jsonRetorno != null) && (response.IsSuccessStatusCode))
                {
                    PedidoShoppub dadosRetorno = JsonConvert.DeserializeObject<PedidoShoppub>(jsonRetorno);

                    var transportadoraValida = ValidarTransportadoraShoppub(dadosRetorno, servico);

                    if (!transportadoraValida)
                        return false;

                    try
                    {
                        return await GravarArquivoJson(dadosRetorno, servico, pastaDestinoJsonShoppub, strIdentificadorServicoUsuario1, nomeArquivoLogShoppubWebHook);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro para buscar o pedido - Shoppub Webhook: ", nomeArquivoLogShoppubWebHook, ex);
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Erro ao buscar o pedido, id do pedido: " + pedido.Id + " Serviço utilizado: " + servico.Descricao, nomeArquivoLogShoppubWebHook, null);
                    return false;
                }
            }
        }
        #endregion

        #region BlingWebhook
        public async Task<BlingServicosIntegrar> CapturarTokenServicosBling(string codigoServico, string apiKey)
        {
            BlingServicosIntegrar servico = new BlingServicosIntegrar
            {
                Codigo = 3826,
                FK_servico = 3826,
                Descricao = "BARBARA LANE SIVIERI ME ( BMODA ) - BLING",
                Integracao_id = "14892718473",
                Cnpj_cpf = "01110173000125",
                Integracao_nome_transportadora = "Premici Distribuidora Ltda - Epp",
                Integracao_api_key = "fe77495c56afbc786b2734ac3599067633ba4c23c03ed24e51377464058ebc11d57ceff0",
                Integracao_importar_sem_nf = false
            };

            return servico;
        }

        public async Task<bool> ValidaPedidoBling(BlingPedidos dadosPedido, BlingServicosIntegrar servico)
        {
            if (dadosPedido != null)
            {
                var pedido = dadosPedido.Retorno.Pedidos.FirstOrDefault();
                if (pedido.Pedido != null)
                {
                    if (pedido.Pedido.Transporte != null)
                    {
                        if (!string.IsNullOrEmpty(pedido.Pedido.Transporte.Cnpj))
                        {
                            var cnpjPedido = FuncoesString.TirarPontosBarrasCNPJCPF(pedido.Pedido.Transporte.Cnpj).Trim();
                            var cnpjServico = FuncoesString.TirarPontosBarrasCNPJCPF(servico.Cnpj_cpf).Trim();
                            if (cnpjPedido == cnpjServico)
                            {
                                return true;
                            }
                        }
                        if (!string.IsNullOrEmpty(pedido.Pedido.Transporte.Transportadora) && !string.IsNullOrEmpty(servico.Integracao_nome_transportadora))
                        {
                            if (pedido.Pedido.Transporte.Transportadora.ToUpper().Trim().Contains(servico.Integracao_nome_transportadora.ToUpper().Trim())
                                || servico.Integracao_nome_transportadora.ToUpper().Trim().Contains(pedido.Pedido.Transporte.Transportadora.ToUpper().Trim()))
                            {
                                return true;
                            }
                        }
                        if (pedido.Pedido.Transporte.Volumes != null)
                        {
                            if (pedido.Pedido.Transporte.Volumes.Count > 0)
                            {
                                if (pedido.Pedido.Transporte.Volumes.FirstOrDefault().Volume != null)
                                {
                                    if (pedido.Pedido.Transporte.Volumes.FirstOrDefault().Volume.IdServico != null)
                                    {
                                        if (pedido.Pedido.Transporte.Volumes.FirstOrDefault().Volume.IdServico == servico.Integracao_id.ToUpper().Trim())
                                        {
                                            return true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Transporte = null" + ", nro pedido: " + pedido.Pedido.Numero, nomeArquivoLogBlingWebhook, null);
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("pedido.pedido = null", nomeArquivoLogBlingWebhook, null);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("pedido = null", nomeArquivoLogBlingWebhook, null);
                return false;
            }
            return false;
        }

        public async Task<string> GetBlingNotaFiscal(BlingPedidos dadosPedido, string codigoServico, string apiKey)
        {
            var servico = await CapturarTokenServicosBling(codigoServico, apiKey);
            if (servico == null)
            {
                return "Erro ao buscar o serviço" + nomeArquivoLogBlingWebhook;
            }

            if (dadosPedido != null)
            {
                if (dadosPedido.Retorno != null)
                {
                    if (dadosPedido.Retorno.Pedidos.FirstOrDefault() != null)
                    {
                        if (dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido != null)
                        {
                            if (dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Nota != null)
                            {
                                try
                                {
                                    bool pedidoValido = await ValidaPedidoBling(dadosPedido, servico);

                                    if (!pedidoValido)
                                    {

                                        return "Erro ao buscar o pedido, pedido inválido " + " Serviço utilizado: " + servico.Descricao + nomeArquivoLogBlingWebhook;
                                    }
                                    return await BuscarNotaFiscal(dadosPedido, servico);
                                }
                                catch (Exception ex)
                                {
                                    return "Erro para buscar a Nota fiscal - Bling Webhook: " + dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Numero + nomeArquivoLogBlingWebhook;
                                }
                            }
                        }
                    }
                }
            }
            return "Erro para buscar a Nota fiscal - Bling Webhook.GetNotaFiscal, pedido inválido " + nomeArquivoLogBlingWebhook;
        }

        public async Task<string> BuscarNotaFiscal(BlingPedidos dadosPedido, BlingServicosIntegrar servico)
        {
            if (!string.IsNullOrEmpty(dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Nota.ChaveAcesso))
            {
                using (var httpCliente = new HttpClient())
                {

                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                    HttpResponseMessage response = null;
                    httpCliente.Timeout = new TimeSpan(0, 0, 60);

                    string url = $"https://bling.com.br/relatorios/nfe.xml.php?s&chaveAcesso={dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Nota.ChaveAcesso}";
                    response = await httpCliente.GetAsync(new Uri(url));
                    string strXML = response.Content.ReadAsStringAsync().Result;
                    response.Dispose();
                    httpCliente.Dispose();

                    if ((strXML != null) && response.IsSuccessStatusCode)
                    {
                        try
                        {
                            var sucesso = await GravarArquivoBling(dadosPedido, servico, strXML);
                            if (sucesso)
                                return strXML;
                        }
                        catch (Exception ex)
                        {

                            return "Erro para salvar a NF - Bling Webhook: " + nomeArquivoLogBlingWebhook;
                        }
                    }
                }
            }
            else
            if (!string.IsNullOrEmpty(dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Nota.Numero) && !string.IsNullOrEmpty(dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Nota.Serie))
            {
                using (var httpCliente = new HttpClient())
                {
                    string urlIntegracao = "https://bling.com.br";

                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                    HttpResponseMessage response = null;
                    httpCliente.Timeout = new TimeSpan(0, 0, 60);

                    string url = $"{urlIntegracao}/Api/v2/notafiscal/{dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Nota.Numero}/{dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Nota.Serie}/json?apikey={servico.Integracao_api_key}";
                    response = await httpCliente.GetAsync(new Uri(url));
                    string notaJson = await response.Content.ReadAsStringAsync();

                    if (notaJson == null || !response.IsSuccessStatusCode || notaJson.Contains("erro"))
                    {

                        return "Erro para buscar a nota - Bling Webhook, chave de acesso = null: " + nomeArquivoLogBlingWebhook;
                    }


                    BlingNotaFiscal notaBling = serializer.Deserialize<BlingNotaFiscal>(notaJson);
                    if (notaBling.Retorno.NotasFiscais.FirstOrDefault().NotaFiscal.ChaveAcesso == null)
                    {

                        return "Erro para buscar a nota - Bling Webhook, chave de acesso = null: " + nomeArquivoLogBlingWebhook;
                    }

                    response = await httpCliente.GetAsync(new Uri($"https://bling.com.br/relatorios/nfe.xml.php?s&chaveAcesso={notaBling.Retorno.NotasFiscais.FirstOrDefault().NotaFiscal.ChaveAcesso}"));
                    string strXML = await response.Content.ReadAsStringAsync();
                    response.Dispose();
                    httpCliente.Dispose();

                    if ((strXML != null) && response.IsSuccessStatusCode)
                    {
                        try
                        {

                            var sucesso = await GravarArquivoBling(dadosPedido, servico, strXML);
                            if (sucesso)
                                return strXML;
                        }
                        catch (Exception ex)
                        {
                            return "Erro para salvar a NF - Bling Webhook: " + nomeArquivoLogBlingWebhook;
                        }
                    }
                }
            }
            else
            if (string.IsNullOrEmpty(dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Nota.ChaveAcesso)
                && (string.IsNullOrEmpty(dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Nota.Numero)
                || string.IsNullOrEmpty(dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Nota.Serie)))
            {
                return "Erro para buscar a Nota fiscal - Bling Webhook, nota sem chave de acesso e numero ou serie: " + dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Nota.Numero + ", pedido: " + dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Numero + nomeArquivoLogBlingWebhook;
            }
            return "Erro para buscar a Nota fiscal - Bling Webhook (if do final do método MandaRequisicao) " + nomeArquivoLogBlingWebhook;
        }


        public async Task<bool> GravarArquivoBling(BlingPedidos dadosPedido, BlingServicosIntegrar servico, string xmlRetorno)
        {
            string chaveNF = dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Nota.ChaveAcesso;
            try
            {
                string pasta = string.Format(FuncoesArquivos.GerarNomeArquivoTemporarioGuid(strIdentificadorServicoUsuario2, FuncoesArquivos.EXTENSAO_XML), servico.FK_servico, 5);
                using (StreamWriter file = new StreamWriter(Path.Combine(pastaDestinoJsonBling, string.Format(FuncoesArquivos.GerarNomeArquivoTemporarioGuid(strIdentificadorServicoUsuario2, FuncoesArquivos.EXTENSAO_XML), servico.FK_servico, 5)), false, Encoding.UTF8))
                {
                    file.WriteLine(xmlRetorno);

                }
                Console.WriteLine("NF salva: " + dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Nota.Numero, nomeArquivoLogBlingWebhook, null);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar NF: " + dadosPedido.Retorno.Pedidos.FirstOrDefault().Pedido.Nota.Numero, nomeArquivoLogBlingWebhook, ex);
                return false;
            }
        }

        #endregion

        #region NuvemshopWebhooks

        public async Task<NuvemShopServicosIntegrar> CapturarTokenServicosNuvemShop(int? storeId)
        {
            NuvemShopServicosIntegrar servico = new NuvemShopServicosIntegrar
            {
                Codigo = 123,
                Descricao = "TesteEnglobaWebhook",
                Integracao_nome_transportadora = "Correios - PAC",
                Integracao_id = "5730",
                Integracao_token = "2597928",
                Integracao_api_key = "4d13edba0022fa9704a3ab205a30b5d53bc0ae5d",
                Integracao_importar_sem_nf = false,
                FK_servico = 4716

                //Quando for buscar pelo banco de dados tem que pegar a integracao que tem o campo integracao_id igual o storeId passado pelo webhook
                //Também tem que comparar o tipo da integracao, que é uma constante que vai ser passado na chamada do método.
            };

            return servico;
        }

        public async Task<bool> ValidarPedidoNuvemShop(NuvemShopPedido pedido, NuvemShopServicosIntegrar servico)
        {
            if (pedido != null)
            {
                if (!string.IsNullOrEmpty(pedido.AppId))
                {
                    if (pedido.AppId.Equals(servico.Integracao_id))
                    {
                        if (!string.IsNullOrEmpty(pedido.PromotionalDiscount.StoreId.ToString()))
                        {
                            if (pedido.PromotionalDiscount.StoreId.ToString().Equals(servico.Integracao_token))
                            {
                                if (!string.IsNullOrEmpty(pedido.ShippingOption))
                                {
                                    if (pedido.ShippingOption.Contains(servico.Integracao_nome_transportadora) || servico.Integracao_nome_transportadora.Contains(pedido.ShippingOption))
                                    {
                                        return true;
                                    }
                                }
                                return false;
                            }
                            return false;
                        }
                        return false;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }
        public async Task<bool> SalvarPedidoNuvemShop(NuvemShopWebhook pedido)
        {
            var servico = await CapturarTokenServicosNuvemShop(pedido.StoreId);

            if (servico == null)
            {
                Console.WriteLine("Erro ao buscar o serviço", nomeArquivoLogNuvemShop, null);
                return false;
            }

            try
            {
                return await BuscarPedidoNuvemShop(pedido, servico);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar o pedido, id do pedido: " + pedido.Id + " Serviço utilizado: " + servico.Descricao, nomeArquivoLogNuvemShop, ex);
                return false;
            }
        }

        public async Task<bool> BuscarPedidoNuvemShop(NuvemShopWebhook pedido, NuvemShopServicosIntegrar servico)
        {
            using (var httpCliente = new HttpClient())
            {
                httpCliente.DefaultRequestHeaders.Add("Authentication", $"bearer {servico.Integracao_api_key}");
                httpCliente.DefaultRequestHeaders.Add("User-Agent", $"{servico.Descricao} ({servico.Integracao_id})");
                ServicePointManager.Expect100Continue = true;
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                HttpResponseMessage response = null;
                httpCliente.Timeout = new TimeSpan(0, 0, 60);
                string url = $"https://api.nuvemshop.com.br/v1/{servico.Integracao_token}/orders/{pedido.Id}";
                response = await httpCliente.GetAsync(new Uri(url));
                var jsonRetorno = await response.Content.ReadAsStringAsync();

                if ((jsonRetorno != null) && (response.IsSuccessStatusCode))
                {
                    NuvemShopPedido dadosRetorno = JsonConvert.DeserializeObject<NuvemShopPedido>(jsonRetorno);

                    var pedidoValido = await ValidarPedidoNuvemShop(dadosRetorno, servico);

                    if (!pedidoValido)
                    {
                        Console.WriteLine("Erro ao validar o pedido, verifique se os campos AppId, PromotionalDiscount.StoreId e ShippingOption estão corretos", nomeArquivoLogNuvemShop);
                        return false;
                    }

                    try
                    {
                        return await GravarArquivoJson(dadosRetorno, servico, pastaDestinoJsonNuvemShop, strIdentificadorServicoUsuario3, nomeArquivoLogNuvemShop);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao salvar o pedido - NuvemShop Webhook: ", nomeArquivoLogNuvemShop, ex);
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Erro ao buscar o pedido, id do pedido: " + pedido.Id + " Serviço utilizado: " + servico.Descricao, nomeArquivoLogNuvemShop, null);
                    return false;
                }
            }
        }

        public async Task<string> Autenticar(string code)
        {
            try
            {
                using (var httpCliente = new HttpClient())
                {
                    var values = new Dictionary<string, string>
                {
                    { "client_id", "5730" },
                    { "client_secret", "68abe745b2eceb13318a6a6b507afb1c3005140098c3bd7b" },
                    { "grant_type", "authorization_code"},
                    { "code", code}
                };

                    var json = JsonConvert.SerializeObject(values);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");

                    string contentType = "application/json";
                    httpCliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                    httpCliente.DefaultRequestHeaders.Add("User-Agent", "Teste Engloba (5730)");

                    ServicePointManager.Expect100Continue = true;
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                    HttpResponseMessage response = null;
                    httpCliente.Timeout = new TimeSpan(0, 0, 60);
                    response = await httpCliente.PostAsync(new Uri($"https://www.nuvemshop.com.br/apps/authorize/token"), data);
                    var jsonRetorno = await response.Content.ReadAsStringAsync();

                    if ((jsonRetorno != null) && response.IsSuccessStatusCode && !jsonRetorno.Contains("error"))
                    {
                        var objetoRetorno = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonRetorno);
                        string? storeId, accessToken;
                        objetoRetorno.TryGetValue("user_id", out storeId);
                        objetoRetorno.TryGetValue("access_token", out accessToken);
                        Console.WriteLine(storeId + "\n" + accessToken);

                        return "StoreId: " + storeId + "\n" + " AcessToken: " + accessToken;

                    }
                    else
                    {
                        throw new Exception("Houve um erro na autenticação!");
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //    public async Task<bool> DeleteStoreNuvemShop(int codigo)
        //    {
        //        try
        //        {
        //            var integracao = await _context.Integracoes.FirstOrDefaultAsync(i => i.Codigo == codigo);

        //            if (integracao == null)
        //                throw new Exception(Mensagens.INTEGRACAO_NAO_ENCONTRADA);

        //            _funcoesDB.GerarLogDados(Tipos.TipoLog.Exclusao, integracao.Codigo, _user.CodigoUsuario, String.Format("Exclusão de integração", integracao.Codigo));
        //            _context.Entry(integracao).State = EntityState.Deleted;
        //            await _context.SaveChangesAsync();
        //            _context.Dispose();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.InnerException.Message);
        //        }

        //        return true;
        //    }
        //}

        //public async Task<string> GerarUrlNuvemShop(int codigoIntegracao)
        //{
        //    try
        //    {
        //        var integracaoExistente = await _context.Integracoes.FirstOrDefaultAsync(x => x.Codigo == codigoIntegracao && x.IntegracaoTipo == 7);

        //        if (integracaoExistente == null)
        //            throw new Exception("Erro ao criar url!");

        //        string integracaoCriptografada = FuncoesString.Base64Encode(codigoIntegracao.ToString());


        //        string urlGerada = $"https://englobasistemas.com.br/api/IntegracaoNuvemShop/NuvemShopWebhook?codigoIntegracao={integracaoCriptografada}";

        //        return urlGerada;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        #endregion

    }
}

