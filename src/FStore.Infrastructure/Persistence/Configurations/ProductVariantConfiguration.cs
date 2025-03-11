namespace FStore.Infrastructure.Persistence.Configurations
{
    public class ProductVariantConfiguration : IEntityTypeConfiguration<ProductVariant>
    {
        public void Configure(EntityTypeBuilder<ProductVariant> builder)
        {
            builder.HasKey(v => new { v.ProductId, v.ProductTypeId });

            builder.Property(c => c.Price)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(c => c.OriginalPrice)
                .HasColumnType("decimal(18,2)");

            builder.HasOne(pv => pv.Product)
                .WithMany(p => p.ProductVariants)
                .HasForeignKey(p => p.ProductId);

            builder.HasOne(v => v.ProductType)
                .WithMany(pt => pt.ProductVariants);
        }
    }
}
