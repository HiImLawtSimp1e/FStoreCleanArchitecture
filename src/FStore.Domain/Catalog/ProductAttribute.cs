namespace FStore.Domain.Catalog
{
    public class ProductAttribute : Entity<Guid>
    {
        public string Name { get; set; } = string.Empty;
        [JsonIgnore]
        public List<ProductValue>? ProductValues { get; set; }
    }
}
