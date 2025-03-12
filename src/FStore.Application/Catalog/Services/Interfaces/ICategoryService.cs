using FStore.Application.Catalog.DTOs.CategoryDTOs;

namespace FStore.Application.Catalog.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<ServiceResponse<IEnumerable<CustomerCategoryResponseDto>>> GetCategoriesAsync();
        Task<ServiceResponse<Pagination<IEnumerable<Category>>>> GetAdminCategoriesAsync(int pageNumber, int pageSize);
        Task<ServiceResponse<Category>> GetCategoryAsync(Guid categoryId);
        Task<ServiceResponse<bool>> CreateCategory(CreateCategoryDto newCategory);
        Task<ServiceResponse<bool>> UpdateCategory(Guid categoryId, UpdateCategoryDto updateCategory);
        Task<ServiceResponse<bool>> SoftDeleteCategory(Guid categoryId);
    }
}
