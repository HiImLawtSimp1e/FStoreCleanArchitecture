namespace FStore.Application.Catalog.DTOs.ProductDTOs
{
    public class ProductAttributeDto
    {
        [Required(ErrorMessage = "Product attribute name is required")]
        [MinLength(2, ErrorMessage = "Product attribute name must be at least 2 characters long")]
        [StringLength(50, ErrorMessage = "Product attribute name must not exceed 50 characters")]
        public string Name { get; set; } = string.Empty;
    }
}
