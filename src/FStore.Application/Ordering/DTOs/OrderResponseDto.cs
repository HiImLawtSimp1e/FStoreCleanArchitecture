namespace FStore.Application.Ordering.DTOs
{
    public class OrderResponseDto
    {
        Guid Id { get; set; }
        public string InvoiceCode { get; set; } = string.Empty;
        public OrderState State { get; set; } = OrderState.Pending;
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.COD;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string DeliveryAddress { get; set; } = string.Empty;
        public decimal DiscountValue { get; set; } = default!;
        public decimal TotalAmount { get; set; } = default!;
        public bool IsCounterOrder { get; set; }
    }
}
