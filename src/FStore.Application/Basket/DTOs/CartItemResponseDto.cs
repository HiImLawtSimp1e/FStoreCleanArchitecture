namespace FStore.Application.Basket.DTOs
{
    public class CartItemResponseDto
    {
        public Guid ProductId { get; set; }
        public Guid ProductTypeId { get; set; }
        public string ProductTitle { get; set; } = string.Empty;
        public string ProductTypeName { get; set; } = string.Empty;
        public decimal Price { get; set; } = default;
        public decimal OriginalPrice { get; set; } = default;
        public string ImageUrl { get; set; } = string.Empty;
        public int Quantity { get; set; } = 1;
    }
}
