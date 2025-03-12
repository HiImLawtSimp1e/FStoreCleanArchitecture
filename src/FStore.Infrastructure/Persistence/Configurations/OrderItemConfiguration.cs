namespace FStore.Infrastructure.Persistence.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductTypeId });

            builder.Property(o => o.ProductTitle)
              .HasMaxLength(100)
              .IsRequired();

            builder.Property(o => o.ProductTypeName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Price)
              .HasColumnType("decimal(18,2)")
              .IsRequired();

            builder.Property(c => c.OriginalPrice)
                .HasColumnType("decimal(18,2)");
        }
    }
}
