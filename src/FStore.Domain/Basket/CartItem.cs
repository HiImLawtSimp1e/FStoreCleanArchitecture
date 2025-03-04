namespace FStore.Domain.Basket
{
    public class CartItem
    {
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
        public Guid ProductTypeId { get; set; }
        public int Quantity { get; set; } = 1;
        [JsonIgnore]
        public Cart? Cart { get; set; }
    }
}
