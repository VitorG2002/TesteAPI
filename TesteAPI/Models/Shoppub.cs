using Newtonsoft.Json;

namespace TesteAPI.Models
{
        #region objetos
        public class FreteSet
        {
            [JsonProperty("seller_id")]
            public object SellerId { get; set; }

            [JsonProperty("transportadora_nome")]
            public string TransportadoraNome { get; set; }

            [JsonProperty("transportadora_servico")]
            public object TransportadoraServico { get; set; }

            [JsonProperty("is_correios")]
            public bool? IsCorreios { get; set; }

            [JsonProperty("valor")]
            public string Valor { get; set; }

            [JsonProperty("prazo")]
            public int? Prazo { get; set; }

            [JsonProperty("id_cotacao")]
            public object IdCotacao { get; set; }

            [JsonProperty("link_etiqueta")]
            public List<object> LinkEtiqueta { get; set; }
        }

        public class Marketplace
        {
            [JsonProperty("hub")]
            public object Hub { get; set; }

            [JsonProperty("hub_id")]
            public object HubId { get; set; }

            [JsonProperty("loja_vendedora")]
            public object LojaVendedora { get; set; }

            [JsonProperty("id_pedido_loja")]
            public object IdPedidoLoja { get; set; }

            [JsonProperty("sincronizado")]
            public bool? Sincronizado { get; set; }

            [JsonProperty("fulfillment")]
            public bool? Fulfillment { get; set; }

            [JsonProperty("cnpj_loja_vendedora")]
            public object CnpjLojaVendedora { get; set; }

            [JsonProperty("cnpj_metodo_pagamento")]
            public object CnpjMetodoPagamento { get; set; }

            [JsonProperty("status")]
            public object Status { get; set; }
        }

        public class PedidoitemSet
        {
            [JsonProperty("produto_id")]
            public int? ProdutoId { get; set; }

            [JsonProperty("produto_codigo")]
            public string ProdutoCodigo { get; set; }

            [JsonProperty("produto_sku")]
            public string ProdutoSku { get; set; }

            [JsonProperty("produto_gtin")]
            public string ProdutoGtin { get; set; }

            [JsonProperty("produto_nome")]
            public string ProdutoNome { get; set; }

            [JsonProperty("produto_sem_estoque")]
            public bool? ProdutoSemEstoque { get; set; }

            [JsonProperty("produto_entregavel")]
            public bool? ProdutoEntregavel { get; set; }

            [JsonProperty("produto_sem_estoque_prazo_adicional")]
            public int? ProdutoSemEstoquePrazoAdicional { get; set; }

            [JsonProperty("produto_sem_estoque_quantidade")]
            public int? ProdutoSemEstoqueQuantidade { get; set; }

            [JsonProperty("valor_unitario_custo")]
            public string ValorUnitarioCusto { get; set; }

            [JsonProperty("valor_unitario_sem_descontos")]
            public string ValorUnitarioSemDescontos { get; set; }

            [JsonProperty("valor_unitario_com_descontos")]
            public string ValorUnitarioComDescontos { get; set; }

            [JsonProperty("valor_unitario_com_todos_descontos")]
            public string ValorUnitarioComTodosDescontos { get; set; }

            [JsonProperty("quantidade")]
            public int? Quantidade { get; set; }

            [JsonProperty("total")]
            public string Total { get; set; }

            [JsonProperty("valor_total_sem_descontos")]
            public string ValorTotalSemDescontos { get; set; }

            [JsonProperty("valor_total_com_todos_descontos")]
            public string ValorTotalComTodosDescontos { get; set; }

            [JsonProperty("valor_total_custo")]
            public string ValorTotalCusto { get; set; }

            [JsonProperty("valor_total_lucro")]
            public string ValorTotalLucro { get; set; }

            [JsonProperty("seller_id_perpetuo")]
            public int? SellerIdPerpetuo { get; set; }

            [JsonProperty("pedidoitemdescontoscampanhas_set")]
            public List<object> PedidoitemdescontoscampanhasSet { get; set; }

            [JsonProperty("datatix")]
            public List<object> Datatix { get; set; }

            [JsonProperty("fabricante")]
            public object Fabricante { get; set; }

            [JsonProperty("atributo_label")]
            public object AtributoLabel { get; set; }

            [JsonProperty("atributo_valor")]
            public object AtributoValor { get; set; }

            [JsonProperty("is_kit")]
            public bool? IsKit { get; set; }

            [JsonProperty("brinde")]
            public bool? Brinde { get; set; }

            [JsonProperty("pedidoitemkit_set")]
            public List<object> PedidoitemkitSet { get; set; }

            [JsonProperty("complemento")]
            public object Complemento { get; set; }

            [JsonProperty("observacao_impressao")]
            public object ObservacaoImpressao { get; set; }
        }

        public class PedidoShoppub
        {
            [JsonProperty("id")]
            public int? Id { get; set; }

            [JsonProperty("data")]
            public string Data { get; set; }

            [JsonProperty("hora")]
            public string Hora { get; set; }

            [JsonProperty("status")]
            public int? Status { get; set; }

            [JsonProperty("status_resumido")]
            public int? StatusResumido { get; set; }

            [JsonProperty("data_alteracao_status")]
            public DateTime? DataAlteracaoStatus { get; set; }

            [JsonProperty("data_alteracao_status_marketplace")]
            public object DataAlteracaoStatusMarketplace { get; set; }

            [JsonProperty("data_pagamento")]
            public DateTime? DataPagamento { get; set; }

            [JsonProperty("pedido_origem")]
            public string PedidoOrigem { get; set; }

            [JsonProperty("pedidoitem_set")]
            public List<PedidoitemSet> PedidoitemSet { get; set; }

            [JsonProperty("cupom_vale")]
            public object CupomVale { get; set; }

            [JsonProperty("metodo_pagamento")]
            public int? MetodoPagamento { get; set; }

            [JsonProperty("metodo_pagamento_forma")]
            public int? MetodoPagamentoForma { get; set; }

            [JsonProperty("metodo_pagamento_conector")]
            public string MetodoPagamentoConector { get; set; }

            [JsonProperty("banco_nome")]
            public object BancoNome { get; set; }

            [JsonProperty("agencia")]
            public object Agencia { get; set; }

            [JsonProperty("conta")]
            public object Conta { get; set; }

            [JsonProperty("frete_set")]
            public List<FreteSet> FreteSet { get; set; }

            [JsonProperty("tipo_servico")]
            public string TipoServico { get; set; }

            [JsonProperty("retirada_no_local")]
            public bool? RetiradaNoLocal { get; set; }

            [JsonProperty("is_correios")]
            public bool? IsCorreios { get; set; }

            [JsonProperty("prazo")]
            public int? Prazo { get; set; }

            [JsonProperty("frete_is_entrega_agendada")]
            public bool? FreteIsEntregaAgendada { get; set; }

            [JsonProperty("frete_entrega_agendada_data")]
            public object FreteEntregaAgendadaData { get; set; }

            [JsonProperty("frete_entrega_agendada_periodo")]
            public object FreteEntregaAgendadaPeriodo { get; set; }

            [JsonProperty("frete_entrega_agendada_transportadora")]
            public object FreteEntregaAgendadaTransportadora { get; set; }

            [JsonProperty("cliente_id")]
            public int? ClienteId { get; set; }

            [JsonProperty("cliente_nome")]
            public string ClienteNome { get; set; }

            [JsonProperty("tipo_cliente")]
            public string TipoCliente { get; set; }

            [JsonProperty("nascimento")]
            public string Nascimento { get; set; }

            [JsonProperty("documento1")]
            public string Documento1 { get; set; }

            [JsonProperty("documento2")]
            public object Documento2 { get; set; }

            [JsonProperty("ie_isento")]
            public bool? IeIsento { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("telefone1")]
            public string Telefone1 { get; set; }

            [JsonProperty("telefone2")]
            public object Telefone2 { get; set; }

            [JsonProperty("celular")]
            public object Celular { get; set; }

            [JsonProperty("codigo_vendedor")]
            public object CodigoVendedor { get; set; }

            [JsonProperty("cobranca_cep")]
            public string CobrancaCep { get; set; }

            [JsonProperty("cobranca_tipo_logradouro")]
            public string CobrancaTipoLogradouro { get; set; }

            [JsonProperty("cobranca_logradouro")]
            public string CobrancaLogradouro { get; set; }

            [JsonProperty("cobranca_numero")]
            public string CobrancaNumero { get; set; }

            [JsonProperty("cobranca_complemento")]
            public string CobrancaComplemento { get; set; }

            [JsonProperty("cobranca_referencia")]
            public object CobrancaReferencia { get; set; }

            [JsonProperty("cobranca_bairro")]
            public string CobrancaBairro { get; set; }

            [JsonProperty("cobranca_cidade")]
            public string CobrancaCidade { get; set; }

            [JsonProperty("cobranca_estado")]
            public string CobrancaEstado { get; set; }

            [JsonProperty("cobranca_ibge_municipio")]
            public string CobrancaIbgeMunicipio { get; set; }

            [JsonProperty("cobranca_ibge_municipio_verificador")]
            public string CobrancaIbgeMunicipioVerificador { get; set; }

            [JsonProperty("entrega_destinatario")]
            public string EntregaDestinatario { get; set; }

            [JsonProperty("entrega_cep")]
            public string EntregaCep { get; set; }

            [JsonProperty("entrega_tipo_logradouro")]
            public string EntregaTipoLogradouro { get; set; }

            [JsonProperty("entrega_logradouro")]
            public string EntregaLogradouro { get; set; }

            [JsonProperty("entrega_numero")]
            public string EntregaNumero { get; set; }

            [JsonProperty("entrega_complemento")]
            public string EntregaComplemento { get; set; }

            [JsonProperty("entrega_referencia")]
            public object EntregaReferencia { get; set; }

            [JsonProperty("entrega_cidade")]
            public string EntregaCidade { get; set; }

            [JsonProperty("entrega_bairro")]
            public string EntregaBairro { get; set; }

            [JsonProperty("entrega_estado")]
            public string EntregaEstado { get; set; }

            [JsonProperty("entrega_restricao")]
            public object EntregaRestricao { get; set; }

            [JsonProperty("entrega_ibge_municipio")]
            public string EntregaIbgeMunicipio { get; set; }

            [JsonProperty("entrega_ibge_municipio_verificador")]
            public string EntregaIbgeMunicipioVerificador { get; set; }

            [JsonProperty("qtde_itens")]
            public int? QtdeItens { get; set; }

            [JsonProperty("total_custo_presente")]
            public string TotalCustoPresente { get; set; }

            [JsonProperty("valor_total_itens_sem_desconto")]
            public string ValorTotalItensSemDesconto { get; set; }

            [JsonProperty("valor_total_itens_com_desconto")]
            public string ValorTotalItensComDesconto { get; set; }

            [JsonProperty("valor_desconto_metodo_pagamento")]
            public string ValorDescontoMetodoPagamento { get; set; }

            [JsonProperty("valor_desconto_cupom")]
            public string ValorDescontoCupom { get; set; }

            [JsonProperty("valor_credito_utilizado")]
            public string ValorCreditoUtilizado { get; set; }

            [JsonProperty("valor_cashback_utilizado")]
            public string ValorCashbackUtilizado { get; set; }

            [JsonProperty("valor_desconto_total_pedido")]
            public string ValorDescontoTotalPedido { get; set; }

            [JsonProperty("porcentagem_desconto_final")]
            public string PorcentagemDescontoFinal { get; set; }

            [JsonProperty("valor_total")]
            public string ValorTotal { get; set; }

            [JsonProperty("custo_envio")]
            public string CustoEnvio { get; set; }

            [JsonProperty("peso_total_produtos")]
            public int? PesoTotalProdutos { get; set; }

            [JsonProperty("peso_total_pedido")]
            public int? PesoTotalPedido { get; set; }

            [JsonProperty("sugestao_caixa")]
            public string SugestaoCaixa { get; set; }

            [JsonProperty("prazo_boleto")]
            public int? PrazoBoleto { get; set; }

            [JsonProperty("url_retorno_metodo_pagamento")]
            public string UrlRetornoMetodoPagamento { get; set; }

            [JsonProperty("boleto_codigo_de_barra")]
            public string BoletoCodigoDeBarra { get; set; }

            [JsonProperty("boleto_referencia")]
            public string BoletoReferencia { get; set; }

            [JsonProperty("boleto_dados")]
            public object BoletoDados { get; set; }

            [JsonProperty("boleto_nosso_numero")]
            public object BoletoNossoNumero { get; set; }

            [JsonProperty("boleto_data_emissao")]
            public string BoletoDataEmissao { get; set; }

            [JsonProperty("boleto_data_validade")]
            public string BoletoDataValidade { get; set; }

            [JsonProperty("sellers_ids_perpetuo")]
            public string SellersIdsPerpetuo { get; set; }

            [JsonProperty("lojas_vendedoras_ids_perpetuo")]
            public string LojasVendedorasIdsPerpetuo { get; set; }

            [JsonProperty("erp_exportado")]
            public bool? ErpExportado { get; set; }

            [JsonProperty("erp_id")]
            public object ErpId { get; set; }

            [JsonProperty("site_id")]
            public int? SiteId { get; set; }

            [JsonProperty("site_codigo")]
            public string SiteCodigo { get; set; }

            [JsonProperty("empresa")]
            public object Empresa { get; set; }

            [JsonProperty("pedidodescontoscampanhas_set")]
            public List<object> PedidodescontoscampanhasSet { get; set; }

            [JsonProperty("transacaocartaocredito_set")]
            public List<object> TransacaocartaocreditoSet { get; set; }

            [JsonProperty("venda_sem_estoque")]
            public bool? VendaSemEstoque { get; set; }

            [JsonProperty("venda_sem_estoque_prazo_adicional")]
            public int? VendaSemEstoquePrazoAdicional { get; set; }

            [JsonProperty("centro_distribuicao_id")]
            public object CentroDistribuicaoId { get; set; }

            [JsonProperty("centro_distribuicao_descricao")]
            public object CentroDistribuicaoDescricao { get; set; }

            [JsonProperty("nota_data_emissao")]
            public object NotaDataEmissao { get; set; }

            [JsonProperty("nota_numero")]
            public object NotaNumero { get; set; }

            [JsonProperty("nota_serie")]
            public object NotaSerie { get; set; }

            [JsonProperty("nota_chave_acesso")]
            public object NotaChaveAcesso { get; set; }

            [JsonProperty("refazer_pedido_link")]
            public string RefazerPedidoLink { get; set; }

            [JsonProperty("troca_ou_devolucao")]
            public TrocaOuDevolucao TrocaOuDevolucao { get; set; }

            [JsonProperty("observacoes")]
            public object Observacoes { get; set; }

            [JsonProperty("observacoes_internas")]
            public object ObservacoesInternas { get; set; }

            [JsonProperty("parceiro_de_vendas_id")]
            public object ParceiroDeVendasId { get; set; }

            [JsonProperty("marketplace")]
            public Marketplace Marketplace { get; set; }

            [JsonProperty("cfops")]
            public object Cfops { get; set; }
        }

        public class TrocaOuDevolucao
        {
            [JsonProperty("solicitado_troca_devolucao")]
            public bool? SolicitadoTrocaDevolucao { get; set; }

            [JsonProperty("processo_atendido")]
            public bool? ProcessoAtendido { get; set; }
        }



        public class ShoppubServicosIntegrar
        {
            public int? Codigo { get; set; }
            public int? FK_servico { get; set; }
            public string Descricao { get; set; }
            public string Nome_fantasia { get; set; }
            public string Cnpj_cpf { get; set; }
            public string Integracao_api_key { get; set; }
            public string Integracao_api_accountName { get; set; }
            public string Integracao_api_environment { get; set; }
            public string Integracao_url { get; set; }
            public string Integracao_id { get; set; }
            public bool Integracao_importar_sem_nf { get; set; }
            public string Integracao_nome_transportadora { get; set; }
            public string CsvString { get; set; }

        }
        public class NotaFiscalWebhook
        {
            [JsonProperty("nota_serie")]
            public string NotaSerie { get; set; }

            [JsonProperty("nota_numero")]
            public string NotaNumero { get; set; }

            [JsonProperty("nota_situacao")]
            public int NotaSituacao { get; set; }

            [JsonProperty("nota_chave_acesso")]
            public string NotaChaveAcesso { get; set; }

            [JsonProperty("nota_link_xml")]
            public string NotaLinkXml { get; set; }

            [JsonProperty("nota_link_danfe")]
            public string NotaLinkDanfe { get; set; }
        }

        public class PedidoShoppubWebhook
        {
            [JsonProperty("tipo")]
            public string Tipo { get; set; }

            [JsonProperty("id")]
            public int? Id { get; set; }

            [JsonProperty("status")]
            public int Status { get; set; }

            [JsonProperty("status_descricao")]
            public string StatusDescricao { get; set; }

            [JsonProperty("identificador")]
            public string Identificador { get; set; }

            [JsonProperty("nota_fiscal")]
            public NotaFiscalWebhook NotaFiscal { get; set; }
        }


        #endregion
        public class Shoppub
        {
            public PedidoShoppub PedidoShoppub { get; set; }
            public ShoppubServicosIntegrar ShoppubServicosIntegrar { get; set; }
            public PedidoShoppubWebhook PedidoShoppubWebhook { get; set; }
            public NotaFiscalWebhook NotaFiscalWebhook { get; set; }
        }
}
