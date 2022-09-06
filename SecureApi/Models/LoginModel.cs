using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SecureApi.Models;

public class LoginModel
{
    [EmailAddress]
    public string Email { get; set; }
    
    [PasswordPropertyText]
    public string Password { get; set; }
    
    public bool RememberMe { get; set; }
}
