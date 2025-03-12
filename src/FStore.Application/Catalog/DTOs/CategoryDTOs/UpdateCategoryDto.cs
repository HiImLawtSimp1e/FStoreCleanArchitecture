namespace FStore.Application.Catalog.DTOs.CategoryDTOs
{
    public class UpdateCategoryDto
    {
        [Required(ErrorMessage = "Category title is required")]
        [MinLength(2, ErrorMessage = "Category title must be at least 2 characters long")]
        [StringLength(50, ErrorMessage = "Category title must not exceed 50 characters")]
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}
