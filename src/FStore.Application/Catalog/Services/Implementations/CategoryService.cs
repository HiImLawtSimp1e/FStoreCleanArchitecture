using FStore.Application.Catalog.DTOs.CategoryDTOs;
using FStore.Application.Catalog.Services.Interfaces;
using Mapster;

namespace FStore.Application.Catalog.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ServiceResponse<IEnumerable<CustomerCategoryResponseDto>>> GetCategoriesAsync()
        {
            var categories = await _unitOfWork.Category
                .GetAllAsync(c => !c.Deleted && c.IsActive);

            var result = categories.Adapt<IEnumerable<CustomerCategoryResponseDto>>();

            return new ServiceResponse<IEnumerable<CustomerCategoryResponseDto>>
            {
                Data = result
            };
        }

        public async Task<ServiceResponse<Pagination<IEnumerable<Category>>>> GetAdminCategoriesAsync(int pageNumber, int pageSize)
        {
            var categories = await _unitOfWork.Category
                .GetAllAsync(c => !c.Deleted, pageNumber: pageNumber, pageSize: pageSize);

            var pagingData = new Pagination<IEnumerable<Category>>
            {
                Result = categories,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return new ServiceResponse<Pagination<IEnumerable<Category>>>
            {
                Data = pagingData,
            };
        }

        public async Task<ServiceResponse<Category>> GetCategoryAsync(Guid categoryId)
        {
            var category = await _unitOfWork.Category
                .GetAsync(c => c.Id == categoryId && !c.Deleted);

            if (category == null)
            {
                return new ServiceResponse<Category>
                {
                    Success = false,
                    Message = "Category not found!"
                };
            }

            return new ServiceResponse<Category>
            {
                Data = category
            };
        }

        public async Task<ServiceResponse<bool>> CreateCategory(CreateCategoryDto newCategory)
        {
            var category = newCategory.Adapt<Category>();

            _unitOfWork.Category.Add(category);
            await _unitOfWork.SaveAsync();

            return new ServiceResponse<bool> 
            { 
                Message = "Category added successfully.",
                Data = true
            };
        }

        public async Task<ServiceResponse<bool>> UpdateCategory(Guid categoryId, UpdateCategoryDto updateCategory)
        {
            var dbCategory = await _unitOfWork.Category
               .GetAsync(c => c.Id == categoryId && !c.Deleted);

            if (dbCategory == null)
            {
                return new ServiceResponse<bool>
                {
                    Success = false,
                    Message = "Category not found!"
                };
            }

            updateCategory.Adapt(dbCategory);
            _unitOfWork.Category.Update(dbCategory);
            await _unitOfWork.SaveAsync();

            return new ServiceResponse<bool>
            {
                Message = "Category updated successfully.",
                Data = true
            };
        }

        public async Task<ServiceResponse<bool>> SoftDeleteCategory(Guid categoryId)
        {
            var category = await _unitOfWork.Category
                .GetAsync(c => c.Id == categoryId && !c.Deleted);

            if (category == null)
            {
                return new ServiceResponse<bool>
                {
                    Success = false,
                    Message = "Category not found!"
                };
            }

            category.Deleted = true;

            _unitOfWork.Category.Update(category);
            await _unitOfWork.SaveAsync();

            return new ServiceResponse<bool>
            {
                Message = "Category deleted successfully.",
                Data = true
            };
        }
    }
}
