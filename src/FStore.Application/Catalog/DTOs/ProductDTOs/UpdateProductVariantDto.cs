namespace FStore.Application.Catalog.DTOs.ProductDTOs
{
    public class UpdateProductVariantDto
    {
        [Required(ErrorMessage = "Product type is required")]
        public Guid ProductTypeId { get; set; }

        [Required(ErrorMessage = "Product price cannot be empty")]
        public decimal Price { get; set; } = default;
        public decimal OriginalPrice { get; set; } = default;
        public int Quantity { get; set; } = default;
        public bool IsActive { get; set; }
    }
}
