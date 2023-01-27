using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASP_NetCore_6.Models;

namespace ASP_NetCore_6.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger; // glabal vars can witten as _ too
    }

    public IActionResult Index() // IActionResult return a View aka a site.
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)] // cache 
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

//action = endpoints 