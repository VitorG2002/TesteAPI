using Newtonsoft.Json;
using System.Xml.Linq;

namespace TesteAPI.Models
{

    public class NuvemShopToken
    {
        public string Access_token { get; set; }
        public string Token_type { get; set; }
        public string Scope { get; set; }
        public int? User_id { get; set; }
    }
    public class NuvemShopServicosIntegrar
    {
        public int? Codigo { get; set; }
        public int? FK_servico { get; set; }
        public int? FK_empresa { get; set; }
        public string? Descricao { get; set; }
        public string? Nome_fantasia { get; set; }
        public string? Integracao_pasta_salvar_arq { get; set; }
        public string? Cnpj_cpf { get; set; }
        public string Integracao_api_key { get; set; }
        public string Integracao_token { get; set; }
        public string Integracao_app_id { get; set; }
        public string? Integracao_api_accountName { get; set; }
        public string? Integracao_api_environment { get; set; }
        public string Integracao_id { get; set; }
        public bool Integracao_importar_sem_nf { get; set; }
        public string Integracao_nome_transportadora { get; set; }
        public string? Integracao_url { get; set; }
        public string? Integracao_url_next { get; set; }
        public int? Cont_url_next { get; set; }
        public bool? Cliente_sincronizado { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Description
    {
        [JsonProperty("pt")]
        public object Pt { get; set; }
    }

    public class En
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class Es
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class Languages
    {
        [JsonProperty("es")]
        public Es Es { get; set; }

        [JsonProperty("pt")]
        public Pt Pt { get; set; }

        [JsonProperty("en")]
        public En En { get; set; }
    }

    public class Name
    {
        [JsonProperty("pt")]
        public string Pt { get; set; }
    }

    public class Pt
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class NuvemShopLoja
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("description")]
        public Description Description { get; set; }

        [JsonProperty("type")]
        public object Type { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("logo")]
        public object Logo { get; set; }

        [JsonProperty("contact_email")]
        public object ContactEmail { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("facebook")]
        public object Facebook { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("instagram")]
        public string Instagram { get; set; }

        [JsonProperty("pinterest")]
        public object Pinterest { get; set; }

        [JsonProperty("blog")]
        public object Blog { get; set; }

        [JsonProperty("business_id")]
        public object BusinessId { get; set; }

        [JsonProperty("business_name")]
        public object BusinessName { get; set; }

        [JsonProperty("business_address")]
        public object BusinessAddress { get; set; }

        [JsonProperty("address")]
        public object Address { get; set; }

        [JsonProperty("phone")]
        public object Phone { get; set; }

        [JsonProperty("customer_accounts")]
        public string CustomerAccounts { get; set; }

        [JsonProperty("plan_name")]
        public string PlanName { get; set; }

        [JsonProperty("domains")]
        public List<object> Domains { get; set; }

        [JsonProperty("languages")]
        public Languages Languages { get; set; }

        [JsonProperty("original_domain")]
        public string OriginalDomain { get; set; }

        [JsonProperty("url_with_protocol")]
        public string UrlWithProtocol { get; set; }

        [JsonProperty("main_currency")]
        public string MainCurrency { get; set; }

        [JsonProperty("current_theme")]
        public string CurrentTheme { get; set; }

        [JsonProperty("main_language")]
        public string MainLanguage { get; set; }

        [JsonProperty("admin_language")]
        public string AdminLanguage { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        public string? AccessToken { get; set; }
        public string? idNuvemShop { get; set; }
        public string? Nome { get; set; }
        public string? RazaoSocial { get; set; }    
        public string? Telefone { get; set; }
        public string? Cnpj { get; set; }
    }



    public class NuvemShopAddress
    {
        [JsonProperty("address")]
        public string? Address { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("floor")]
        public object Floor { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("locality")]
        public object Locality { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("number")]
        public string? Number { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }

        [JsonProperty("province")]
        public string? Province { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("zipcode")]
        public string? Zipcode { get; set; }
    }

    public class NuvemShopClientDetails
    {
        [JsonProperty("browser_ip")]
        public object BrowserIp { get; set; }

        [JsonProperty("user_agent")]
        public object UserAgent { get; set; }
    }

    public class NuvemShopCompletedAt
    {
        [JsonProperty("date")]
        public string? Date { get; set; }

        [JsonProperty("timezone_type")]
        public int? TimezoneType { get; set; }

        [JsonProperty("timezone")]
        public string? Timezone { get; set; }
    }

    public class NuvemShopCustomer
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("identification")]
        public string? Identification { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }

        [JsonProperty("note")]
        public object Note { get; set; }

        [JsonProperty("default_address")]
        public NuvemShopDefaultAddress DefaultAddress { get; set; }

        [JsonProperty("addresses")]
        public List<NuvemShopAddress> Addresses { get; set; }

        [JsonProperty("billing_name")]
        public string? BillingName { get; set; }

        [JsonProperty("billing_phone")]
        public string? BillingPhone { get; set; }

        [JsonProperty("billing_address")]
        public string? BillingAddress { get; set; }

        [JsonProperty("billing_number")]
        public string? BillingNumber { get; set; }

        [JsonProperty("billing_floor")]
        public object BillingFloor { get; set; }

        [JsonProperty("billing_locality")]
        public object BillingLocality { get; set; }

        [JsonProperty("billing_zipcode")]
        public string? BillingZipcode { get; set; }

        [JsonProperty("billing_city")]
        public string? BillingCity { get; set; }

        [JsonProperty("billing_province")]
        public string? BillingProvince { get; set; }

        [JsonProperty("billing_country")]
        public string? BillingCountry { get; set; }

        [JsonProperty("extra")]
        public NuvemShopExtra Extra { get; set; }

        [JsonProperty("total_spent")]
        public string? TotalSpent { get; set; }

        [JsonProperty("total_spent_currency")]
        public string? TotalSpentCurrency { get; set; }

        [JsonProperty("last_order_id")]
        public int? LastOrderId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("first_interaction")]
        public DateTime? FirstInteraction { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("accepts_marketing")]
        public bool AcceptsMarketing { get; set; }

        [JsonProperty("accepts_marketing_updated_at")]
        public DateTime? AcceptsMarketingUpdatedAt { get; set; }
    }

    public class NuvemShopDefaultAddress
    {
        [JsonProperty("address")]
        public string? Address { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("floor")]
        public object Floor { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("locality")]
        public object Locality { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("number")]
        public string? Number { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }

        [JsonProperty("province")]
        public string? Province { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("zipcode")]
        public string? Zipcode { get; set; }
    }

    public class NuvemShopExtra
    {
    }

    public class NuvemShopImage
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("alt")]
        public List<object> Alt { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }

    public class NuvemShopPaymentDetails
    {
        [JsonProperty("method")]
        public object Method { get; set; }

        [JsonProperty("credit_card_company")]
        public object CreditCardCompany { get; set; }

        [JsonProperty("installments")]
        public string? Installments { get; set; }
    }

    public class NuvemShopProduct
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("depth")]
        public string? Depth { get; set; }

        [JsonProperty("height")]
        public string? Height { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("price")]
        public string? Price { get; set; }

        [JsonProperty("compare_at_price")]
        public string? CompareAtPrice { get; set; }

        [JsonProperty("product_id")]
        public int? ProductId { get; set; }

        [JsonProperty("image")]
        public NuvemShopImage NuvemShopImage { get; set; }

        [JsonProperty("quantity")]
        public string? Quantity { get; set; }

        [JsonProperty("free_shipping")]
        public bool FreeShipping { get; set; }

        [JsonProperty("weight")]
        public string? Weight { get; set; }

        [JsonProperty("width")]
        public string? Width { get; set; }

        [JsonProperty("variant_id")]
        public string? VariantId { get; set; }

        [JsonProperty("variant_values")]
        public List<object> VariantValues { get; set; }

        [JsonProperty("properties")]
        public List<object> Properties { get; set; }

        [JsonProperty("sku")]
        public object Sku { get; set; }

        [JsonProperty("barcode")]
        public object Barcode { get; set; }
    }

    public class NuvemShopPromotionalDiscount
    {
        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("store_id")]
        public int StoreId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("total_discount_amount")]
        public string? TotalDiscountAmount { get; set; }

        [JsonProperty("contents")]
        public List<object> Contents { get; set; }

        [JsonProperty("promotions_applied")]
        public List<object> PromotionsApplied { get; set; }
    }

    public class NuvemShopPedido
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("store_id")]
        public string StoreId { get; set; }

        [JsonProperty("contact_email")]
        public string? ContactEmail { get; set; }

        [JsonProperty("contact_name")]
        public string? ContactName { get; set; }

        [JsonProperty("contact_phone")]
        public string? ContactPhone { get; set; }

        [JsonProperty("contact_identification")]
        public string? ContactIdentification { get; set; }

        [JsonProperty("shipping_min_days")]
        public int? ShippingMinDays { get; set; }

        [JsonProperty("shipping_max_days")]
        public int? ShippingMaxDays { get; set; }

        [JsonProperty("billing_name")]
        public string? BillingName { get; set; }

        [JsonProperty("billing_phone")]
        public string? BillingPhone { get; set; }

        [JsonProperty("billing_address")]
        public string? BillingAddress { get; set; }

        [JsonProperty("billing_number")]
        public string? BillingNumber { get; set; }

        [JsonProperty("billing_floor")]
        public object BillingFloor { get; set; }

        [JsonProperty("billing_locality")]
        public object BillingLocality { get; set; }

        [JsonProperty("billing_zipcode")]
        public string? BillingZipcode { get; set; }

        [JsonProperty("billing_city")]
        public string? BillingCity { get; set; }

        [JsonProperty("billing_province")]
        public string? BillingProvince { get; set; }

        [JsonProperty("billing_country")]
        public string? BillingCountry { get; set; }

        [JsonProperty("shipping_cost_owner")]
        public string? ShippingCostOwner { get; set; }

        [JsonProperty("shipping_cost_customer")]
        public string? ShippingCostCustomer { get; set; }

        [JsonProperty("coupon")]
        public List<object> Coupon { get; set; }

        [JsonProperty("promotional_discount")]
        public NuvemShopPromotionalDiscount PromotionalDiscount { get; set; }

        [JsonProperty("subtotal")]
        public string? Subtotal { get; set; }

        [JsonProperty("discount")]
        public string? Discount { get; set; }

        [JsonProperty("discount_coupon")]
        public string? DiscountCoupon { get; set; }

        [JsonProperty("discount_gateway")]
        public string? DiscountGateway { get; set; }

        [JsonProperty("total")]
        public string? Total { get; set; }

        [JsonProperty("total_usd")]
        public string? TotalUsd { get; set; }

        [JsonProperty("checkout_enabled")]
        public bool CheckoutEnabled { get; set; }

        [JsonProperty("weight")]
        public string? Weight { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("language")]
        public string? Language { get; set; }

        [JsonProperty("gateway")]
        public string? Gateway { get; set; }

        [JsonProperty("gateway_id")]
        public object GatewayId { get; set; }

        [JsonProperty("gateway_name")]
        public string? GatewayName { get; set; }

        [JsonProperty("shipping")]
        public string? Shipping { get; set; }

        [JsonProperty("shipping_option")]
        public string? ShippingOption { get; set; }

        [JsonProperty("shipping_option_code")]
        public object ShippingOptionCode { get; set; }

        [JsonProperty("shipping_option_reference")]
        public object ShippingOptionReference { get; set; }

        [JsonProperty("shipping_pickup_details")]
        public object ShippingPickupDetails { get; set; }

        [JsonProperty("shipping_tracking_number")]
        public object ShippingTrackingNumber { get; set; }

        [JsonProperty("shipping_tracking_url")]
        public object ShippingTrackingUrl { get; set; }

        [JsonProperty("shipping_store_branch_name")]
        public object ShippingStoreBranchName { get; set; }

        [JsonProperty("shipping_pickup_type")]
        public string? ShippingPickupType { get; set; }

        [JsonProperty("shipping_suboption")]
        public List<object> ShippingSuboption { get; set; }

        [JsonProperty("extra")]
        public NuvemShopExtra Extra { get; set; }

        [JsonProperty("storefront")]
        public string? Storefront { get; set; }

        [JsonProperty("note")]
        public object Note { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("completed_at")]
        public NuvemShopCompletedAt CompletedAt { get; set; }

        [JsonProperty("next_action")]
        public string? NextAction { get; set; }

        [JsonProperty("payment_details")]
        public NuvemShopPaymentDetails PaymentDetails { get; set; }

        [JsonProperty("attributes")]
        public List<object> Attributes { get; set; }

        [JsonProperty("customer")]
        public NuvemShopCustomer Customer { get; set; }

        [JsonProperty("products")]
        public List<NuvemShopProduct> Products { get; set; }

        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("cancel_reason")]
        public object CancelReason { get; set; }

        [JsonProperty("owner_note")]
        public object OwnerNote { get; set; }

        [JsonProperty("cancelled_at")]
        public object CancelledAt { get; set; }

        [JsonProperty("closed_at")]
        public object ClosedAt { get; set; }

        [JsonProperty("read_at")]
        public object ReadAt { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("payment_status")]
        public string? PaymentStatus { get; set; }

        [JsonProperty("gateway_link")]
        public object GatewayLink { get; set; }

        [JsonProperty("shipping_carrier_name")]
        public object ShippingCarrierName { get; set; }

        [JsonProperty("shipping_address")]
        public NuvemShopShippingAddress ShippingAddress { get; set; }

        [JsonProperty("shipping_status")]
        public string? ShippingStatus { get; set; }

        [JsonProperty("shipped_at")]
        public object ShippedAt { get; set; }

        [JsonProperty("paid_at")]
        public DateTime? PaidAt { get; set; }

        [JsonProperty("landing_url")]
        public object LandingUrl { get; set; }

        [JsonProperty("client_details")]
        public NuvemShopClientDetails ClientDetails { get; set; }

        [JsonProperty("app_id")]
        public string? AppId { get; set; }
    }

    public class NuvemShopShippingAddress
    {
        [JsonProperty("address")]
        public string? Address { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("floor")]
        public string? Floor { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("locality")]
        public string? Locality { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("number")]
        public string? Number { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }

        [JsonProperty("province")]
        public string? Province { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("zipcode")]
        public string? Zipcode { get; set; }

        [JsonProperty("customs")]
        public object Customs { get; set; }
    }

    public class NuvemShopWebhook
    {
        [JsonProperty("store_id")]
        public int StoreId { get; set; }

        [JsonProperty("event")]
        public string? Event { get; set; }

        [JsonProperty("id")]
        public int? Id { get; set; }
    }

    public class NuvemShop
    {
        public NuvemShopPedido NuvemShopPedido { get; set; }
    }
}
