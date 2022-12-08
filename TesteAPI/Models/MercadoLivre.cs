using Newtonsoft.Json;

namespace TesteAPI.Models
{
    public class MercadoLivre
    {
    }
    #region Objetos Pedido
    public class AtmTransferReferenceML
    {
        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }

    public class BuyerML
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    public class CollectorML
    {
        [JsonProperty("id")]
        public int? Id { get; set; }
    }

    public class ContextML
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("site")]
        public string Site { get; set; }

        [JsonProperty("flows")]
        public List<object> Flows { get; set; }
    }

    public class CouponML
    {
        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("amount")]
        public int? Amount { get; set; }
    }

    public class FeedbackML
    {
        [JsonProperty("buyer")]
        public object Buyer { get; set; }

        [JsonProperty("seller")]
        public object Seller { get; set; }
    }

    public class ItemML
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("variation_id")]
        public object VariationId { get; set; }

        [JsonProperty("seller_custom_field")]
        public object SellerCustomField { get; set; }

        [JsonProperty("variation_attributes")]
        public List<object> VariationAttributes { get; set; }

        [JsonProperty("warranty")]
        public string Warranty { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("seller_sku")]
        public object SellerSku { get; set; }

        [JsonProperty("global_price")]
        public object GlobalPrice { get; set; }

        [JsonProperty("net_weight")]
        public object NetWeight { get; set; }
    }

    public class OrderItemML
    {
        [JsonProperty("item")]
        public ItemML Item { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("requested_quantity")]
        public RequestedQuantityML RequestedQuantity { get; set; }

        [JsonProperty("picked_quantity")]
        public object PickedQuantity { get; set; }

        [JsonProperty("unit_price")]
        public int? UnitPrice { get; set; }

        [JsonProperty("full_unit_price")]
        public int? FullUnitPrice { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("manufacturing_days")]
        public object ManufacturingDays { get; set; }

        [JsonProperty("sale_fee")]
        public int? SaleFee { get; set; }

        [JsonProperty("listing_type_id")]
        public string ListingTypeId { get; set; }
    }

    public class OrderRequestML
    {
        [JsonProperty("return")]
        public object Return { get; set; }

        [JsonProperty("change")]
        public object Change { get; set; }
    }

    public class PaymentML
    {
        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("order_id")]
        public object OrderId { get; set; }

        [JsonProperty("payer_id")]
        public int? PayerId { get; set; }

        [JsonProperty("collector")]
        public CollectorML Collector { get; set; }

        [JsonProperty("card_id")]
        public object CardId { get; set; }

        [JsonProperty("site_id")]
        public string SiteId { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("payment_method_id")]
        public string PaymentMethodId { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("installments")]
        public int? Installments { get; set; }

        [JsonProperty("issuer_id")]
        public string IssuerId { get; set; }

        [JsonProperty("atm_transfer_reference")]
        public AtmTransferReferenceML AtmTransferReference { get; set; }

        [JsonProperty("coupon_id")]
        public object CouponId { get; set; }

        [JsonProperty("activation_uri")]
        public string ActivationUri { get; set; }

        [JsonProperty("operation_type")]
        public string OperationType { get; set; }

        [JsonProperty("payment_type")]
        public string PaymentType { get; set; }

        [JsonProperty("available_actions")]
        public List<string> AvailableActions { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_code")]
        public object StatusCode { get; set; }

        [JsonProperty("status_detail")]
        public string StatusDetail { get; set; }

        [JsonProperty("transaction_amount")]
        public int? TransactionAmount { get; set; }

        [JsonProperty("transaction_amount_refunded")]
        public int? TransactionAmountRefunded { get; set; }

        [JsonProperty("taxes_amount")]
        public int? TaxesAmount { get; set; }

        [JsonProperty("shipping_cost")]
        public int? ShippingCost { get; set; }

        [JsonProperty("coupon_amount")]
        public int? CouponAmount { get; set; }

        [JsonProperty("overpaid_amount")]
        public int? OverpaidAmount { get; set; }

        [JsonProperty("total_paid_amount")]
        public double? TotalPaidAmount { get; set; }

        [JsonProperty("installment_amount")]
        public double? InstallmentAmount { get; set; }

        [JsonProperty("deferred_period")]
        public object DeferredPeriod { get; set; }

        [JsonProperty("date_approved")]
        public DateTime? DateApproved { get; set; }

        [JsonProperty("authorization_code")]
        public string AuthorizationCode { get; set; }

        [JsonProperty("transaction_order_id")]
        public object TransactionOrderId { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("date_last_modified")]
        public DateTime? DateLastModified { get; set; }
    }

    public class RequestedQuantityML
    {
        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("measure")]
        public string Measure { get; set; }
    }

    public class OrderML
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("date_closed")]
        public DateTime? DateClosed { get; set; }

        [JsonProperty("last_updated")]
        public DateTime? LastUpdated { get; set; }

        [JsonProperty("manufacturing_ending_date")]
        public object ManufacturingEndingDate { get; set; }

        [JsonProperty("comment")]
        public object Comment { get; set; }

        [JsonProperty("pack_id")]
        public object PackId { get; set; }

        [JsonProperty("pickup_id")]
        public object PickupId { get; set; }

        [JsonProperty("order_request")]
        public OrderRequestML OrderRequest { get; set; }

        [JsonProperty("fulfilled")]
        public object Fulfilled { get; set; }

        [JsonProperty("mediations")]
        public List<object> Mediations { get; set; }

        [JsonProperty("total_amount")]
        public int? TotalAmount { get; set; }

        [JsonProperty("paid_amount")]
        public int? PaidAmount { get; set; }

        [JsonProperty("coupon")]
        public CouponML Coupon { get; set; }

        [JsonProperty("expiration_date")]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty("order_items")]
        public List<OrderItemML> OrderItems { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("payments")]
        public List<PaymentML> Payments { get; set; }

        [JsonProperty("shipping")]
        public ShippingML Shipping { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_detail")]
        public object StatusDetail { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("feedback")]
        public FeedbackML Feedback { get; set; }

        [JsonProperty("context")]
        public ContextML Context { get; set; }

        [JsonProperty("seller")]
        public SellerML Seller { get; set; }

        [JsonProperty("buyer")]
        public BuyerML Buyer { get; set; }

        [JsonProperty("taxes")]
        public TaxesML Taxes { get; set; }
    }

    public class SellerML
    {
        [JsonProperty("id")]
        public int? Id { get; set; }
    }

    public class ShippingML
    {
        [JsonProperty("id")]
        public object Id { get; set; }
    }

    public class TaxesML
    {
        [JsonProperty("amount")]
        public object Amount { get; set; }

        [JsonProperty("currency_id")]
        public object CurrencyId { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }
    }

    #endregion

    public class WebhookML
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

        [JsonProperty("sent")]
        public DateTime? Sent { get; set; }

        [JsonProperty("attempts")]
        public int? Attempts { get; set; }

        [JsonProperty("received")]
        public DateTime? Received { get; set; }
    }

    public class IntegracaoML
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
}
