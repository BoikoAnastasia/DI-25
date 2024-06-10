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


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public String index(int a)
        {
            var answer = "";
            for (int i = 0; i < Products.kursy.Count; i++)
            {
                answer += Products.kursy[i].ID;
                answer += "\n";
                answer += Products.kursy[i].Name;
                answer += "\n";
                answer += Products.kursy[i].Cost;
                answer += "\n";
                answer += Products.kursy[i].Description;
                answer += "\n";
                answer += "\n";
            }
            return answer;
        }
    }
}