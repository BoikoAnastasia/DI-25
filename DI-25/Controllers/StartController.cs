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
        public string hello()
        {
            DateTime dateTime = DateTime.Now;
            int hour = dateTime.Hour;

            if (hour >= 0 && hour <= 5)
            {
                return "Доброй ночи";
            }
            else if (hour >= 6 && hour <= 11)
            {
                return "Доброе утро";
            }
            else if (hour >= 12 && hour <= 17)
            {
                return "Добрый день";
            }
            else
            {
                return "Добрый вечер";
            }
        }
    }
}