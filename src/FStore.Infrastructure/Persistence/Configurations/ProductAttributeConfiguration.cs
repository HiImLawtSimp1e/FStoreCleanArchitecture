namespace FStore.Infrastructure.Persistence.Configurations
{
    public class ProductAttributeConfiguration : IEntityTypeConfiguration<ProductAttribute>
    {
        public void Configure(EntityTypeBuilder<ProductAttribute> builder)
        {
            builder.HasKey(pa => pa.Id);

            builder.Property(pa => pa.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
