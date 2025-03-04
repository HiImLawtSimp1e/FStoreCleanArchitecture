namespace FStore.Domain.Catalog
{
    public class ProductType : Entity<Guid>
    {
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [JsonIgnore]
        public List<ProductVariant>? ProductVariants { get; set; }
    }
}
