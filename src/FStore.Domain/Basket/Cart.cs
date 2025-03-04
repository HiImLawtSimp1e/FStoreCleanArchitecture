namespace FStore.Domain.Basket
{
    public class Cart : Entity<Guid>
    {
        [StringLength(100)]
        public string Username { get; set; } = string.Empty;
        public Guid? AccountId { get; set; }
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
