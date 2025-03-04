namespace FStore.Domain.Catalog
{
    public class ProductAttribute : Entity<Guid>
    {
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [JsonIgnore]
        public List<ProductValue>? ProductValues { get; set; }
    }
}
