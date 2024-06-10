using Di_25.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Di_25.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = ProductRepository.GetAllProducts();

            StringBuilder result = new StringBuilder();
            foreach (var product in products)
            {
                result.AppendLine($"Id: {product.Id}");
                result.AppendLine($"Name: {product.Name}");
                result.AppendLine($"Cost: {product.Cost}");
                result.AppendLine();
            }

            return Content(result.ToString());
        }

        public IActionResult Product(int id)
        {
            Product product = ProductRepository.GetAllProducts().FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            StringBuilder result = new StringBuilder();
            result.AppendLine($"Id: {product.Id}");
            result.AppendLine($"Name: {product.Name}");
            result.AppendLine($"Cost: {product.Cost}");
            result.AppendLine($"Description: {product.Description}");

            return Content(result.ToString());
        }
    }
}