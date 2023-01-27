using Microsoft.AspNetCore.Mvc;

namespace ASP_NetCore_6.Help;

public class HelpController : Controller
{
    [HttpGet, Route(template: "/terms")]

    public IActionResult termOfUse()
    {
        return View();
    }
    
}