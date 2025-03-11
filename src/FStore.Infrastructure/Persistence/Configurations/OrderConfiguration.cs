namespace FStore.Infrastructure.Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.InvoiceCode)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(o => o.State)
                .HasConversion<int>()
                .IsRequired();

            builder.Property(o => o.PaymentMethod)
                .HasConversion<int>()
                .IsRequired();

            builder.Property(o => o.FullName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(o => o.Email)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(o => o.Phone)
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(o => o.Address)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(o => o.DiscountValue)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(o => o.TotalAmount)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId);

            builder.HasOne(o => o.Coupon)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CouponId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
