namespace FStore.Application.Catalog.DTOs.ProductDTOs
{
    public class ProductTypeDto
    {
        [Required(ErrorMessage = "Product type name cannot be empty")]
        [MinLength(2, ErrorMessage = "Product type name must contain at least 2 characters")]
        [StringLength(50, ErrorMessage = "Product type name must not exceed 50 characters")]
        public string Name { get; set; } = string.Empty;
    }
}
