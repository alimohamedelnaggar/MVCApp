using System.ComponentModel.DataAnnotations;

namespace Demo.Presentation.ViewModels
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "password is required")]
        [MinLength(5, ErrorMessage = "minimum password length is 5")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "password is required")]
        [Compare(nameof(Password), ErrorMessage = "Confirm Password don't match password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
