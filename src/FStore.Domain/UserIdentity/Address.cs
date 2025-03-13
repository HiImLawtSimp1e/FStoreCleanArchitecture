namespace FStore.Domain.UserIdentity
{
    public class Address : Entity<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string AddressLine { get; set; } = string.Empty;
        public bool IsMain { get; set; }
        public Guid AccountId { get; set; }
        [JsonIgnore]
        public Account? Account { get; set; }
    }
}
