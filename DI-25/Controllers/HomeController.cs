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

[Route("calculator")]
public class CalculatorController : ControllerBase
{
    [HttpGet("index/{arg1:int?}/{arg2:int?}/{operation?}")]
    public string Get(int arg1 = 0, int arg2 = 0, string operation = "+")
    {
        int result;

        switch (operation)
        {
            case "+":
                result = arg1 + arg2;
                break;
            case "-":
                result = arg1 - arg2;
                break;
            case "*":
                result = arg1 * arg2;
                break;
            default:
                result = arg1 + arg2;
                break;
        }

        return $"{arg1} {operation} {arg2} = {result}";
    }
}