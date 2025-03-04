using FStore.Domain.Catalog;

namespace FStore.Domain.Ordering
{
    public class OrderItem
    {
        public Order? Order { get; set; }
        public Guid OrderId { get; set; }
        public Product? Product { get; set; }
        public Guid ProductId { get; set; }
        public ProductType? ProductType { get; set; }
        public Guid ProductTypeId { get; set; }
        [StringLength(100)]
        public string ProductTitle { get; set; } = string.Empty;
        [StringLength(50)]
        public string ProductTypeName { get; set; } = string.Empty;
        public decimal Price { get; set; } = default!;
        public decimal OriginalPrice { get; set; } = default!;
        public int Quantity { get; set; } = 1;
    }
}
