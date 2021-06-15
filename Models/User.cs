using System.ComponentModel.DataAnnotations;

namespace LoginRegistration.Models
{
public class User
{
    [Display(Name = "First Name:")] 
    [Required]
    [MinLength(3)]
    public string FirstName { get; set; }

    [Display(Name = "Last Name:")]
    [Required]
    [MinLength(4)]
    public string LastName { get; set; }

    [Display(Name = "Email Address:")]
    [Required]
    [EmailAddress]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required(ErrorMessage = "is required")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "must match Password")]
    [Display(Name = "Confirm Password")]
    public string PasswordConfirm { get; set; }
}
}