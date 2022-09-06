using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SecurityMVC.Models;

public class RegisterViewModel
{
    [EmailAddress]
    public string Email { get; set; }
    
    public string UserName { get; set; }
    
    [PasswordPropertyText]
    public string Password { get; set; }
    
    [PasswordPropertyText]
    [Compare(nameof(Password),ErrorMessage = "Passwords should match")]
    public string ConfirmPassword { get; set; }
    
}