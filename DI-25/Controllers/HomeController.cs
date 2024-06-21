﻿using Di_25.Models;
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
            int kol = ProductList.products.Where(p => p.Value > 0).Sum(p => p.Value);
            decimal totalSum = ProductList.products.Where(p => p.Value > 0).Sum(p => p.Value * p.Price);
            ViewBag.kol = kol;
            ViewBag.TotalSum = totalSum;
            return View(ProductList.products);
        }

        public IActionResult AddToCart(int productId)
        {
            Product product = ProductList.products.Find(p => p.Id == productId);
            product.Value++;

            return RedirectToAction("Cart");

        }

        public IActionResult ProductDetails(int id)
        {
            var product = ProductList.products.FirstOrDefault(p => p.Id == id);

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