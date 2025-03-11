namespace FStore.Domain.Catalog
{
    public class Category : Entity<Guid>
    {
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public bool Deleted { get; set; } = false;
        [JsonIgnore]
        public List<Product>? Products { get; set; }
    }
}
