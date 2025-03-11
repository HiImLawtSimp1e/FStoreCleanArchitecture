namespace FStore.Infrastructure.Persistence.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Username)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasMany(c => c.CartItems)
              .WithOne(ci => ci.Cart)
              .HasForeignKey(ci => ci.CartId);
        }
    }
}
