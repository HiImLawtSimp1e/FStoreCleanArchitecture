namespace FStore.Domain.Ordering
{
    public class Order : Entity<Guid>
    {
        [StringLength(50)]
        public string InvoiceCode { get; set; } = string.Empty;
        public OrderState State { get; set; } = OrderState.Pending;
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.COD;
        [StringLength(50, MinimumLength = 6)]
        public string FullName { get; set; } = string.Empty;
        [StringLength(30, MinimumLength = 6)]
        public string Email { get; set; } = string.Empty;
        [StringLength(14)]
        public string Phone { get; set; } = string.Empty;
        [StringLength(250, MinimumLength = 6)]
        public string Address { get; set; } = string.Empty;
        public decimal DiscountValue { get; set; } = default!;
        public decimal TotalAmount { get; set; } = default!;
        public bool IsCounterOrder { get; set; }
        public Guid? AccountId { get; set; }
        public Guid? CouponId { get; set; }
        public List<OrderItem>? OrderItems { get; set; }
    }
}
