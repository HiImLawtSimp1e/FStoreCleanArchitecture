using FStore.Application.Catalog.DTOs.CategoryDTOs;
using FStore.Application.Catalog.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoriesAsync()
        {
            var response = await _service.GetCategoriesAsync();
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpGet("admin")]
        public async Task<IActionResult> GetAdminCategories(int pageNumber = 1, int pageSize = 10)
        {
            var response = await _service.GetAdminCategoriesAsync(pageNumber, pageSize);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpGet("admin/{id}")]
        public async Task<IActionResult> GetAdminCategory(Guid id)
        {
            var response = await _service.GetCategoryAsync(id);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("admin")]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto newCategory)
        {
            var response = await _service.CreateCategory(newCategory);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPut("admin/{id}")]
        public async Task<IActionResult> UpdateCategory(Guid id, UpdateCategoryDto updateCategory)
        {
            var response = await _service.UpdateCategory(id, updateCategory);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpDelete("admin/{id}")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            var response = await _service.SoftDeleteCategory(id);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
