namespace FStore.Application.UserIdentity.DTOs.ManageAccountDTOs
{
    public class UpdateAccountDto
    {
        [Required(ErrorMessage = "Full name is required"), StringLength(50, MinimumLength = 6, ErrorMessage = "Full name must be between 6 and 50 characters long")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required"), EmailAddress(ErrorMessage = "Invalid email format")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Email must be between 6 and 30 characters long")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required"), RegularExpression(@"^(\+?\d{1,3})?0?\d{9}$", ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required"), StringLength(250, MinimumLength = 6, ErrorMessage = "Address must be between 6 and 250 characters long")]
        public string AddressLine { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}
