using System.ComponentModel.DataAnnotations;

namespace Bakery.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    [Comapre("Password", ErrorMessage = "The password and password confirmation do not match.")]
    public string ConfirmPassword { get; set; }
  }
}