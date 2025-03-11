namespace FStore.Infrastructure.Persistence.Configurations
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasKey(pt => pt.Id);

            builder.Property(pt => pt.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
