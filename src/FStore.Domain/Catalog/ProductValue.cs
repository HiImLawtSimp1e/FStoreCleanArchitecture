namespace FStore.Domain.Catalog
{
    public class ProductValue
    {
        [JsonIgnore]
        public Product? Product { get; set; }
        public Guid ProductId { get; set; }
        public ProductAttribute? ProductAttribute { get; set; }
        public Guid ProductAttributeId { get; set; }
        [StringLength(100)]
        public string Value { get; set; } = string.Empty;
    }
}
