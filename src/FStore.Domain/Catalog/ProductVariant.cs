namespace FStore.Domain.Catalog
{
    public class ProductVariant
    {
        [JsonIgnore]
        public Product? Product { get; set; }
        public Guid ProductId { get; set; }
        public ProductType? ProductType { get; set; }
        public Guid ProductTypeId { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Quantity { get; set; } = 1000;
    }
}
