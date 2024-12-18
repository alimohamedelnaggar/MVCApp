using System.ComponentModel.DataAnnotations;

namespace Demo.Presentation.ViewModels
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage ="UserName is required")]
        public string UserName {  get; set; }
        [Required(ErrorMessage = "first name is required")]
        public string FirstName {  get; set; }
        [Required(ErrorMessage = "last name is required")]
        public string LastName {  get; set; }
        [Required(ErrorMessage = "password is required")]
        [MinLength(5,ErrorMessage ="minimum password length is 5")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "password is required")]
        [Compare(nameof(Password),ErrorMessage = "Confirm Password dont match passowrd")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public bool IsAgree { get; set; }
        
    }
}
