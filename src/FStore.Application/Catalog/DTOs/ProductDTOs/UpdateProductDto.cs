namespace FStore.Application.Catalog.DTOs.ProductDTOs
{
    public class UpdateProductDto
    {
        [Required(ErrorMessage = "Product title cannot be empty")]
        [MinLength(2, ErrorMessage = "Product title must contain at least 2 characters")]
        [StringLength(100, ErrorMessage = "Product title cannot exceed 100 characters")]
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        [Required(ErrorMessage = "Product description cannot be empty")]
        [MinLength(6, ErrorMessage = "Product description must contain at least 6 characters")]
        [StringLength(250, ErrorMessage = "Product description cannot exceed 250 characters")]
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "You must select a category for the product")]
        public Guid CategoryId { get; set; }
    }
}
