namespace FStore.Infrastructure.Persistence.Configurations
{
    public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Code)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(c => c.VoucherName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.DiscountValue)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(c => c.MinOrderCondition)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(c => c.MaxDiscountValue)
                .HasColumnType("decimal(18,2)")
                .IsRequired();
        }
    }
}
