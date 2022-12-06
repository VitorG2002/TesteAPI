using Newtonsoft.Json;

namespace TesteAPI.Models

{
    public class BlingNotaFiscalServicosIntegrar
    {
        public int Codigo { get; set; }
        public int FkServico { get; set; }
        public string Descricao { get; set; }
        public string NomeFantasia { get; set; }
        public string CnpjCpf { get; set; }
        public string IntegracaoId { get; set; }
        public string IntegracaoApiKey { get; set; }
        public bool IntegracaoImportarSemNf { get; set; }
        public string IntegracaoNomeTransportadora { get; set; }

    }

    public class BlingNotaFiscalCliente
    {
        [JsonProperty("idContato")]
        public string IdContato { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("ie")]
        public string Ie { get; set; }

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

        [JsonProperty("fone")]
        public string Fone { get; set; }
    }

    public class BlingNotaFiscalCodigosRastreamento
    {
        [JsonProperty("codigoRastreamento")]
        public string CodigoRastreamento { get; set; }
    }

    public class BlingNotaFiscalDimensoes
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

    public class BlingNotaFiscalEnderecoEntrega
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

    public class BlingNotaFiscal2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("serie")]
        public string Serie { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("loja")]
        public string Loja { get; set; }

        [JsonProperty("numeroPedidoLoja")]
        public string NumeroPedidoLoja { get; set; }

        [JsonProperty("tipo")]
        public string Tipo { get; set; }

        [JsonProperty("situacao")]
        public string Situacao { get; set; }

        [JsonProperty("cliente")]
        public BlingPedidoCliente Cliente { get; set; }

        [JsonProperty("contato")]
        public string Contato { get; set; }

        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("vendedor")]
        public string Vendedor { get; set; }

        [JsonProperty("dataEmissao")]
        public string DataEmissao { get; set; }

        [JsonProperty("valorNota")]
        public string ValorNota { get; set; }

        [JsonProperty("chaveAcesso")]
        public string ChaveAcesso { get; set; }

        [JsonProperty("xml")]
        public string Xml { get; set; }

        [JsonProperty("linkDanfe")]
        public string LinkDanfe { get; set; }

        [JsonProperty("linkPDF")]
        public string LinkPDF { get; set; }

        [JsonProperty("codigosRastreamento")]
        public BlingPedidoCodigosRastreamento CodigosRastreamento { get; set; }

        [JsonProperty("cfops")]
        public List<string> Cfops { get; set; }

        [JsonProperty("unidadeNegocio")]
        public string UnidadeNegocio { get; set; }

        [JsonProperty("tipoIntegracao")]
        public string TipoIntegracao { get; set; }

        [JsonProperty("transporte")]
        public BlingPedidoTransporte Transporte { get; set; }
    }

    public class BlingNotasFiscais
    {
        [JsonProperty("notafiscal")]
        public BlingNotaFiscal2 NotaFiscal { get; set; }
    }

    public class RetornoBlingNotaFiscal
    {
        [JsonProperty("notasfiscais")]
        public List<BlingNotasFiscais> NotasFiscais { get; set; }
    }

    public class BlingNotaFiscal
    {
        [JsonProperty("retorno")]
        public RetornoBlingNotaFiscal Retorno { get; set; }
    }

    public class BlingNotaFiscalTransporte
    {
        [JsonProperty("transportadora")]
        public string Transportadora { get; set; }

        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("tipo_frete")]
        public string TipoFrete { get; set; }

        [JsonProperty("volumes")]
        public List<BlingNotaFiscalVolume> Volumes { get; set; }

        [JsonProperty("enderecoEntrega")]
        public BlingNotaFiscalEnderecoEntrega EnderecoEntrega { get; set; }
    }

    public class BlingNotaFiscalVolume
    {
        [JsonProperty("volume")]
        public BlingNotaFiscalVolume2 Volume { get; set; }
    }

    public class BlingNotaFiscalVolume2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idServico")]
        public long IdServico { get; set; }

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



}
