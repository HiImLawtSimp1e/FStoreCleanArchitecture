namespace FStore.Infrastructure.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasMany(p => p.ProductVariants)
                .WithOne(pvr => pvr.Product)
                .HasForeignKey(pvr => pvr.ProductId);

            builder.HasMany(p => p.ProductValues)
                .WithOne(pvl => pvl.Product)
                .HasForeignKey(pvl => pvl.ProductId);

            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
