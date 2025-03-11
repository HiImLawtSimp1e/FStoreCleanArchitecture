namespace FStore.Domain.Ordering
{
    public class Coupon : Entity<Guid>
    {
        [StringLength(25, MinimumLength = 2)]
        public string Code { get; set; } = string.Empty;
        [StringLength(50, MinimumLength = 2)]
        public string VoucherName { get; set; } = string.Empty;
        public bool IsDiscountPercent { get; set; } = false;
        public decimal DiscountValue { get; set; } = default!;
        public decimal MinOrderCondition { get; set; } = default!;
        public decimal MaxDiscountValue { get; set; } = default!;
        public int Quantity { get; set; } = 1000;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(30);
        public bool IsActive { get; set; } = true;
        public List<Order>? Orders { get; set; }
    }
}
