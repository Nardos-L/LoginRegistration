using System.ComponentModel.DataAnnotations;

namespace LoginRegistration.Models
{
    public class LoginUser
    {
        [Display(Name = "Email Address:")]
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string EmailLogin { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string PasswordLogin { get; set; }
    }
}