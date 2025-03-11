namespace FStore.Infrastructure.Persistence.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.PhoneNumber)
            .HasMaxLength(14)
            .IsRequired();

            builder.Property(a => a.DeliveryAddress)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(a => a.IsMain)
                .IsRequired();

            builder.Property(a => a.AccountId)
                .IsRequired();

            builder.HasOne(add => add.Account)
                .WithMany(acc => acc.Addresses)
                .HasForeignKey(add => add.AccountId);
        }
    }
}
