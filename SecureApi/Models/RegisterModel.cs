using System.ComponentModel.DataAnnotations;

namespace SecureApi.Models;

public class RegisterModel
{
    [EmailAddress]
    public string Email { get; set; }
    
    public string UserName { get; set; }
    
    public string Password { get; set; }
}