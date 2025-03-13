namespace FStore.Application.UserIdentity.DTOs.AddressDTOs
{
    public class UpdateAddressDto
    {
        [Required(ErrorMessage = "Full name is required"), MinLength(6, ErrorMessage = "Full name must be at least 6 characters long"), StringLength(50, ErrorMessage = "Full name must not exceed 50 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required"), EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required"), RegularExpression(@"^(\+?\d{1,3})?0?\d{9}$", ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required"), MinLength(6, ErrorMessage = "Address must be at least 6 characters long"), StringLength(250, ErrorMessage = "Address must not exceed 250 characters")]
        public string AddressLine { get; set; } = string.Empty;

        public bool IsMain { get; set; }
    }
}
