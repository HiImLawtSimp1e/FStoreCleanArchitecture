namespace FStore.Application.Catalog.DTOs.ProductDTOs
{
    public class CreateProductDto
    {
        [Required(ErrorMessage = "Product title is required")]
        [MinLength(2, ErrorMessage = "Product title must be at least 2 characters long")]
        [StringLength(100, ErrorMessage = "Product title must not exceed 100 characters")]
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        [Required(ErrorMessage = "Product description is required")]
        [MinLength(6, ErrorMessage = "Product description must be at least 6 characters long")]
        [StringLength(250, ErrorMessage = "Product description must not exceed 250 characters")]
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        [Required(ErrorMessage = "You must select a category for the product")]
        public Guid CategoryId { get; set; }
        [Required(ErrorMessage = "You must select a product type")]
        public Guid ProductTypeId { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; } = default;
        public decimal OriginalPrice { get; set; } = default;
        public int Quantity { get; set; } = default;
    }
}
