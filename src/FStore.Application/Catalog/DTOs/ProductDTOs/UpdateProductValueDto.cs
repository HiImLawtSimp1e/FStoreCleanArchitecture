namespace FStore.Application.Catalog.DTOs.ProductDTOs
{
    public class UpdateProductValueDto
    {
        [Required(ErrorMessage = "Missing product attribute ID")]
        public Guid ProductAttributeId { get; set; }
        [Required(ErrorMessage = "Product attribute value cannot be empty")]
        [MinLength(2, ErrorMessage = "Product attribute value must contain at least 2 characters")]
        [StringLength(100, ErrorMessage = "Product attribute value must not exceed 100 characters")]
        public string Value { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
