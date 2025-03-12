namespace FStore.Application.Catalog.DTOs.ProductDTOs
{
    public class CustomerProductResponseDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public List<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();
        public List<ProductValue>? ProductValues { get; set; } = new List<ProductValue>();
    }
}
