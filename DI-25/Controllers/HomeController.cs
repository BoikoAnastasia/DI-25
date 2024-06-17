using Di_25.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Di_25.Controllers
{
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

public class CalcController : Controller
{
    public String Index(double a, double b, char c)
    {
        switch (c)
        {
            case '+':
                return $"{a} + {b} = {a + b}";
                break;
            case '-':
                return $"{a} - {b} = {a - b}"; break;
            case '*':
                return $"{a} * {b} = {a * b}";
                break;
            case '/':
                return $"{a} / {b} = {a / b}"; break;
            case '\0':
                return $"{a} + {b} = {a + b}"; break;
            default: return $"Вы дурак";
        }
    }
}
