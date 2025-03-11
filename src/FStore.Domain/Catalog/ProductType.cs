namespace FStore.Domain.Catalog
{
    public class ProductType : Entity<Guid>
    {
        public string Name { get; set; } = string.Empty;
        [JsonIgnore]
        public List<ProductVariant>? ProductVariants { get; set; }
    }
}
