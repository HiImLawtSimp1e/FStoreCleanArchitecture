namespace FStore.Application.Account.DTOs.AuthDTOs
{
    public class ChangePasswordDto
    {
        [Required(ErrorMessage = "Old password is required")]
        public string OldPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "New password cannot be empty"), StringLength(100, MinimumLength = 6, ErrorMessage = "New password must be between 6 and 100 characters long")]
        public string Password { get; set; } = string.Empty;

        [Compare("Password", ErrorMessage = "Password confirmation does not match")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
