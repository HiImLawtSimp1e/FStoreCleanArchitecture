namespace FStore.Infrastructure.Persistence.Configurations
{
    public class ProductValueConfiguration : IEntityTypeConfiguration<ProductValue>
    {
        public void Configure(EntityTypeBuilder<ProductValue> builder)
        {
            builder.HasKey(pv => new { pv.ProductId, pv.ProductAttributeId });

            builder.HasOne(pv => pv.Product)
                .WithMany(p => p.ProductValues)
                .HasForeignKey(pv => pv.ProductId);

            builder.HasOne(pv => pv.ProductAttribute)
                .WithMany(pa => pa.ProductValues)
                .HasForeignKey(pv => pv.ProductAttributeId);
        }
    }
}
