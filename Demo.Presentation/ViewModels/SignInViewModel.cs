using System.ComponentModel.DataAnnotations;

namespace Demo.Presentation.ViewModels
{
    public class SignInViewModel
    {
        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
