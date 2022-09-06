using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SecureApi.Controllers;

[ApiController]
public class SecretController : ControllerBase
{
    // GET
    [Authorize]
    [HttpGet("/Secret")]
    public string Secret()
    {
        var g = new StringBuilder();

        foreach (var claims in User.Claims)
        {
            var line = String.Format("{0} -- {1}",claims.Type,claims.Value);
            g.AppendLine(line);
        }
        return String.IsNullOrEmpty(g.ToString()) ? "Sorry, no claims for u" : g.ToString();
    }
}