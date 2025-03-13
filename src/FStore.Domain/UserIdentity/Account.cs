namespace FStore.Domain.UserIdentity
{
    public class Account : Entity<Guid>
    {
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public UserRole Role { get; set; } = UserRole.Customer;
        public bool IsActive { get; set; } = true;
        public bool Deleted { get; set; } = false;
        public List<Address> Addresses { get; set; }
    }
}
