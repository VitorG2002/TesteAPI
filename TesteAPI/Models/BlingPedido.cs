using Newtonsoft.Json;

namespace TesteAPI.Models
{

    public class BlingPedidoCliente
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("ie")]
        public object Ie { get; set; }

        [JsonProperty("rg")]
        public string Rg { get; set; }

        [JsonProperty("endereco")]
        public string Endereco { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("cidade")]
        public string Cidade { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("celular")]
        public string Celular { get; set; }

        [JsonProperty("fone")]
        public string Fone { get; set; }
    }

    public class BlingPedidoCodigosRastreamento
    {
        [JsonProperty("codigoRastreamento")]
        public string CodigoRastreamento { get; set; }
    }

    public class BlingPedidoDimensoes
    {
        [JsonProperty("peso")]
        public string Peso { get; set; }

        [JsonProperty("altura")]
        public string Altura { get; set; }

        [JsonProperty("largura")]
        public string Largura { get; set; }

        [JsonProperty("comprimento")]
        public string Comprimento { get; set; }

        [JsonProperty("diametro")]
        public string Diametro { get; set; }
    }

    public class BlingPedidoEnderecoEntrega
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("endereco")]
        public string Endereco { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("cidade")]
        public string Cidade { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }
    }

    public class BlingPedidoFormaPagamento
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; }

        [JsonProperty("codigoFiscal")]
        public string CodigoFiscal { get; set; }
    }

    public class BlingPedidoItem
    {
        [JsonProperty("codigo")]
        public string Codigo { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; }

        [JsonProperty("quantidade")]
        public string Quantidade { get; set; }

        [JsonProperty("valorunidade")]
        public string Valorunidade { get; set; }

        [JsonProperty("precocusto")]
        public string Precocusto { get; set; }

        [JsonProperty("descontoItem")]
        public string DescontoItem { get; set; }

        [JsonProperty("un")]
        public string Un { get; set; }

        [JsonProperty("pesoBruto")]
        public string PesoBruto { get; set; }

        [JsonProperty("largura")]
        public string Largura { get; set; }

        [JsonProperty("altura")]
        public string Altura { get; set; }

        [JsonProperty("profundidade")]
        public string Profundidade { get; set; }

        [JsonProperty("descricaoDetalhada")]
        public string DescricaoDetalhada { get; set; }

        [JsonProperty("unidadeMedida")]
        public string UnidadeMedida { get; set; }

        [JsonProperty("gtin")]
        public string Gtin { get; set; }
    }

    public class BlingPedidoItens
    {
        [JsonProperty("item")]
        public BlingPedidoItem Item { get; set; }
    }

    public class BlingPedidoNota
    {
        [JsonProperty("serie")]
        public string Serie { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("dataEmissao")]
        public string DataEmissao { get; set; }

        [JsonProperty("situacao")]
        public string Situacao { get; set; }

        [JsonProperty("valorNota")]
        public string ValorNota { get; set; }

        [JsonProperty("chaveAcesso")]
        public string ChaveAcesso { get; set; }
    }

    public class BlingPedidoParcela
    {
        [JsonProperty("parcela")]
        public BlingPedidoParcela2 Parcela { get; set; }
    }

    public class BlingPedidoParcela2
    {
        [JsonProperty("idLancamento")]
        public string IdLancamento { get; set; }

        [JsonProperty("valor")]
        public string Valor { get; set; }

        [JsonProperty("dataVencimento")]
        public string DataVencimento { get; set; }

        [JsonProperty("obs")]
        public string Obs { get; set; }

        [JsonProperty("destino")]
        public string Destino { get; set; }

        [JsonProperty("forma_pagamento")]
        public BlingPedidoFormaPagamento FormaPagamento { get; set; }
    }

    public class BlingPedidoTransporte
    {
        [JsonProperty("transportadora")]
        public string Transportadora { get; set; }

        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("tipo_frete")]
        public string TipoFrete { get; set; }

        [JsonProperty("qtde_volumes")]
        public string QtdeVolumes { get; set; }

        [JsonProperty("enderecoEntrega")]
        public BlingPedidoEnderecoEntrega EnderecoEntrega { get; set; }

        [JsonProperty("volumes")]
        public List<BlingPedidoVolume> Volumes { get; set; }

        [JsonProperty("servico_correios")]
        public string ServicoCorreios { get; set; }
    }

    public class BlingPedidoVolume
    {
        [JsonProperty("volume")]
        public BlingPedidoVolume2 Volume { get; set; }
    }

    public class BlingPedidoVolume2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idServico")]
        public string IdServico { get; set; }

        [JsonProperty("idOrigem")]
        public string IdOrigem { get; set; }

        [JsonProperty("servico")]
        public string Servico { get; set; }

        [JsonProperty("codigoServico")]
        public string CodigoServico { get; set; }

        [JsonProperty("codigoRastreamento")]
        public string CodigoRastreamento { get; set; }

        [JsonProperty("valorFretePrevisto")]
        public string ValorFretePrevisto { get; set; }

        [JsonProperty("remessa")]
        public object Remessa { get; set; }

        [JsonProperty("dataSaida")]
        public string DataSaida { get; set; }

        [JsonProperty("prazoEntregaPrevisto")]
        public string PrazoEntregaPrevisto { get; set; }

        [JsonProperty("valorDeclarado")]
        public string ValorDeclarado { get; set; }

        [JsonProperty("avisoRecebimento")]
        public bool AvisoRecebimento { get; set; }

        [JsonProperty("maoPropria")]
        public bool MaoPropria { get; set; }

        [JsonProperty("dimensoes")]
        public BlingPedidoDimensoes Dimensoes { get; set; }

        [JsonProperty("urlRastreamento")]
        public string UrlRastreamento { get; set; }
    }

    public class BlingPedido
    {
        [JsonProperty("pedido")]
        public BlingPedido2 Pedido { get; set; }
    }

    public class BlingPedido2
    {
        [JsonProperty("desconto")]
        public string Desconto { get; set; }

        [JsonProperty("observacoes")]
        public string Observacoes { get; set; }

        [JsonProperty("observacaointerna")]
        public string Observacaointerna { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("numeroOrdemCompra")]
        public string NumeroOrdemCompra { get; set; }

        [JsonProperty("vendedor")]
        public string Vendedor { get; set; }

        [JsonProperty("valorfrete")]
        public string Valorfrete { get; set; }

        [JsonProperty("outrasdespesas")]
        public string Outrasdespesas { get; set; }

        [JsonProperty("totalprodutos")]
        public string Totalprodutos { get; set; }

        [JsonProperty("totalvenda")]
        public string Totalvenda { get; set; }

        [JsonProperty("situacao")]
        public string Situacao { get; set; }

        [JsonProperty("dataSaida")]
        public string DataSaida { get; set; }

        [JsonProperty("loja")]
        public string Loja { get; set; }

        [JsonProperty("numeroPedidoLoja")]
        public string NumeroPedidoLoja { get; set; }

        [JsonProperty("tipoIntegracao")]
        public string TipoIntegracao { get; set; }

        [JsonProperty("cliente")]
        public BlingPedidoCliente Cliente { get; set; }

        [JsonProperty("nota")]
        public BlingPedidoNota Nota { get; set; }

        [JsonProperty("transporte")]
        public BlingPedidoTransporte Transporte { get; set; }

        [JsonProperty("itens")]
        public List<BlingPedidoItens> Itens { get; set; }

        [JsonProperty("parcelas")]
        public List<BlingPedidoParcela> Parcelas { get; set; }

        [JsonProperty("codigosRastreamento")]
        public BlingPedidoCodigosRastreamento CodigosRastreamento { get; set; }
    }

    public class BlingPedidoRetorno
    {
        [JsonProperty("pedidos")]
        public List<BlingPedido> Pedidos { get; set; }
    }

    public class BlingPedidos
    {
        [JsonProperty("retorno")]
        public BlingPedidoRetorno Retorno { get; set; }
    }

    public class BlingServicosIntegrar
    {
        public int Codigo { get; set; }
        public int FK_servico { get; set; }
        public string Descricao { get; set; }
        public string Nome_fantasia { get; set; }
        public string Cnpj_cpf { get; set; }
        public string Integracao_api_key { get; set; }
        public string Integracao_id { get; set; }
        public bool Integracao_importar_sem_nf { get; set; }
        public string Integracao_nome_transportadora { get; set; }

    }
}
