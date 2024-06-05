using Di_25.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Di_25.Controllers
{
    public class startController : Controller
    {
        private readonly ILogger<startController> _logger;

        public startController(ILogger<startController> logger)
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
        public string hello(int a, int b)
        {
            if a = null 
                { 
                    a = 0; 
                }
            if b = null 
                { 
                    b = 0; 
                }
            return $"Ответ {a} + {b} = {a + b}";
        }
    }
}
