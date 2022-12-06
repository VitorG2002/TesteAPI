using Nancy.Json;
using Newtonsoft.Json;
using System.Collections;
using System.Configuration;
using System.Net;
using System.Text;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace TesteAPI.Models
{

    #region objetos
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Billing
    {
        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("last_name")]
        public string? LastName { get; set; }

        [JsonProperty("company")]
        public string? Company { get; set; }

        [JsonProperty("address_1")]
        public string? Address1 { get; set; }

        [JsonProperty("address_2")]
        public string? Address2 { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("postcode")]
        public string? Postcode { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }
    }

    public class Collection
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }

    public class Image
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("src")]
        public string? Src { get; set; }
    }

    public class LineItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("variation_id")]
        public int VariationId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("tax_class")]
        public string? TaxClass { get; set; }

        [JsonProperty("subtotal")]
        public string? Subtotal { get; set; }

        [JsonProperty("subtotal_tax")]
        public string? SubtotalTax { get; set; }

        [JsonProperty("total")]
        public string? Total { get; set; }

        [JsonProperty("total_tax")]
        public string? TotalTax { get; set; }

        [JsonProperty("taxes")]
        public List<object> Taxes { get; set; }

        [JsonProperty("meta_data")]
        public List<object> MetaData { get; set; }

        [JsonProperty("sku")]
        public string? Sku { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("parent_name")]
        public object ParentName { get; set; }
    }

    public class Links
    {
        [JsonProperty("self")]
        public List<Self> Self { get; set; }

        [JsonProperty("collection")]
        public List<Collection> Collection { get; set; }
    }

    public class MetaData
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }
    }

    public class WooCommercePedido
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }

        [JsonProperty("prices_include_tax")]
        public bool PricesIncludeTax { get; set; }

        [JsonProperty("date_created")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("date_modified")]
        public DateTime DateModified { get; set; }

        [JsonProperty("discount_total")]
        public string? DiscountTotal { get; set; }

        [JsonProperty("discount_tax")]
        public string? DiscountTax { get; set; }

        [JsonProperty("shipping_total")]
        public string? ShippingTotal { get; set; }

        [JsonProperty("shipping_tax")]
        public string? ShippingTax { get; set; }

        [JsonProperty("cart_tax")]
        public string? CartTax { get; set; }

        [JsonProperty("total")]
        public string? Total { get; set; }

        [JsonProperty("total_tax")]
        public string? TotalTax { get; set; }

        [JsonProperty("customer_id")]
        public int CustomerId { get; set; }

        [JsonProperty("order_key")]
        public string? OrderKey { get; set; }

        [JsonProperty("billing")]
        public Billing? Billing { get; set; }

        [JsonProperty("shipping")]
        public Shipping? Shipping { get; set; }

        [JsonProperty("payment_method")]
        public string? PaymentMethod { get; set; }

        [JsonProperty("payment_method_title")]
        public string? PaymentMethodTitle { get; set; }

        [JsonProperty("transaction_id")]
        public string? TransactionId { get; set; }

        [JsonProperty("customer_ip_address")]
        public string? CustomerIpAddress { get; set; }

        [JsonProperty("customer_user_agent")]
        public string? CustomerUserAgent { get; set; }

        [JsonProperty("created_via")]
        public string? CreatedVia { get; set; }

        [JsonProperty("customer_note")]
        public string? CustomerNote { get; set; }

        [JsonProperty("date_completed")]
        public DateTime DateCompleted { get; set; }

        [JsonProperty("date_paid")]
        public DateTime DatePaid { get; set; }

        [JsonProperty("cart_hash")]
        public string? CartHash { get; set; }

        [JsonProperty("number")]
        public string? Number { get; set; }

        [JsonProperty("meta_data")]
        public List<MetaData>? MetaData { get; set; }

        [JsonProperty("line_items")]
        public List<LineItem>? LineItems { get; set; }

        [JsonProperty("tax_lines")]
        public List<object>? TaxLines { get; set; }

        [JsonProperty("shipping_lines")]
        public List<object>? ShippingLines { get; set; }

        [JsonProperty("fee_lines")]
        public List<object>? FeeLines { get; set; }

        [JsonProperty("coupon_lines")]
        public List<object>? CouponLines { get; set; }

        [JsonProperty("refunds")]
        public List<object>? Refunds { get; set; }

        [JsonProperty("payment_url")]
        public string? PaymentUrl { get; set; }

        [JsonProperty("is_editable")]
        public bool IsEditable { get; set; }

        [JsonProperty("needs_payment")]
        public bool NeedsPayment { get; set; }

        [JsonProperty("needs_processing")]
        public bool NeedsProcessing { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime DateCreatedGmt { get; set; }

        [JsonProperty("date_modified_gmt")]
        public DateTime DateModifiedGmt { get; set; }

        [JsonProperty("date_completed_gmt")]
        public DateTime DateCompletedGmt { get; set; }

        [JsonProperty("date_paid_gmt")]
        public DateTime DatePaidGmt { get; set; }

        [JsonProperty("currency_symbol")]
        public string? CurrencySymbol { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }
    }

    public class Self
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }

    public class Shipping
    {
        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("last_name")]
        public string? LastName { get; set; }

        [JsonProperty("company")]
        public string? Company { get; set; }

        [JsonProperty("address_1")]
        public string? Address1 { get; set; }

        [JsonProperty("address_2")]
        public string? Address2 { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("postcode")]
        public string? Postcode { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }
    }



    public class WooCommerceServicosIntegrar
    {
        public int Codigo { get; set; }
        public int FK_servico { get; set; }
        public string? Integracao_consumer_key { get; set; }
        public string? Descricao { get; set; }  
        public string? Integracao_consumer_secret { get; set; }
        public string? Integracao_id { get; set; }
        public string? Integracao_pasta_salvar_arq { get; set; }
        public string? Integracao_nome_transportadora { get; set; }
        public string? Integracao_url { get; set; }

    }

    #endregion
    public class WooCommerce
    {
        public WooCommercePedido WooCommercePedido { get; set; }    
        public WooCommerceServicosIntegrar WooCommerceServicosIntegrar { get; set; }
    }      
}

