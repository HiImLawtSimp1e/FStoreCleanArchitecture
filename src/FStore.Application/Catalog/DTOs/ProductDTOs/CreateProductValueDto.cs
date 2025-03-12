namespace FStore.Application.Catalog.DTOs.ProductDTOs
{
    public class CreateProductValueDto
    {
        [Required(ErrorMessage = "You must select a product attribute name")]
        public Guid ProductAttributeId { get; set; }
        [Required(ErrorMessage = "Product attribute value cannot be empty")]
        [MinLength(2, ErrorMessage = "Product attribute value must contain at least 2 characters")]
        [StringLength(100, ErrorMessage = "Product attribute value must not exceed 100 characters")]
        public string Value { get; set; } = string.Empty;
    }
}
