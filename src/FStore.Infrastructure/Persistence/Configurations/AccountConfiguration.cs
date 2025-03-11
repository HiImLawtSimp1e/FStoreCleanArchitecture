namespace FStore.Infrastructure.Persistence.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Role)
                .HasConversion<int>() 
                .IsRequired();

            builder.Property(a => a.Username)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
