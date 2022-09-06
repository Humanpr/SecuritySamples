using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SecurityMVC.Models;

public class LoginViewModel
{
    [EmailAddress]
    public string Email { get; set; }
    
    [PasswordPropertyText]
    public string Password { get; set; }
    
    public bool RememberMe { get; set; }
}