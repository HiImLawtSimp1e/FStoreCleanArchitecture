namespace FStore.Domain.Account
{
    public class Address : Entity<Guid>
    {
        [StringLength(50, MinimumLength = 6)]
        public string Name { get; set; } = string.Empty;
        [StringLength(30, MinimumLength = 6)]
        public string Email { get; set; } = string.Empty;
        [StringLength(14)]
        public string PhoneNumber { get; set; } = string.Empty;
        [StringLength(250, MinimumLength = 6)]
        public string DeliveryAddress { get; set; } = string.Empty;
        public bool IsMain { get; set; }
        public Guid AccountId { get; set; }
        [JsonIgnore]
        public Account? Account { get; set; }
    }
}
