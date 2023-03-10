using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC101.Models;

namespace MVC101.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Bogus()
    {
        ViewData["author"] = "Jane Bond";
        ViewBag.Date = DateTime.Now;
        string[] days = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};
        return View(days);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
