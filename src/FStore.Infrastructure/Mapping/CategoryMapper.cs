using FStore.Application.Catalog.DTOs.CategoryDTOs;
namespace FStore.Infrastructure.Mapping
{
    public class CategoryMapper : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Category, CustomerCategoryResponseDto>()
                .Map(dest => dest.Title, src => src.Title)
                .Map(dest => dest.Slug, src => src.Slug);

            config.NewConfig<CreateCategoryDto, Category>()
                .Map(dest => dest.Title, src => src.Title)
                .Map(dest => dest.Slug, src => src.Slug);

            config.NewConfig<UpdateCategoryDto, Category>()
                .Map(dest => dest.Title, src => src.Title)
                .Map(dest => dest.IsActive, src => src.IsActive);
        }
    }
}
