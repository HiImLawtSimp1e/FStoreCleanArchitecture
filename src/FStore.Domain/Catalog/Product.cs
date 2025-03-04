namespace FStore.Domain.Catalog
{
    public class Product : Entity<Guid>
    {
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        [StringLength(250)]
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public bool Deleted { get; set; } = false;
        public Category? Category { get; set; }
        public Guid CategoryId { get; set; }
        public List<ProductVariant> ProductVariants { get; set; }
        public List<ProductValue>? ProductValues { get; set; } 
    }
}
