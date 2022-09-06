using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SecurityMVC.Controllers;


public class SecretController : Controller
{
    // GET
    [HttpGet("~/Secret")]
    [Authorize]
    public IActionResult Secret()
    {
        return View();
    }
}