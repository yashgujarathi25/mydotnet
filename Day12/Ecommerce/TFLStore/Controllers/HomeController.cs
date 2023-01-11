using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;
namespace TFLStore.Controllers;

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

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register(string nm, string email, string pass, double mob)
    {
        User obj  = new User(){
            Name = nm,
            Email = email,
            Password = pass,
            Mobile =  mob,
        };
        List<User> userList = new List<User>();
        userList.Add(obj);

        string fileName = "user.json";
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot" , fileName);
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
