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
            return View(ProductList.products);
        }

        public IActionResult Cart()
        {
            return View(ProductList.products);
        }

		public IActionResult ProductDetails(int id)
		{
			var product = ProductList.products.FirstOrDefault(p => p.Id == id);
			if (product == null)
				return NotFound();

			return View(product);
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

        public IActionResult Product(int i)
        {
            return View(ProductList.products);
        }
    }
}