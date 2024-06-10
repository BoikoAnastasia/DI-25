using Di_25.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Di_25.Controllers
{
    public class HomeController : Controller
    {
        public string Index() { 
            string product1 = ProductsList.Products[0].Id.ToString() + "\n" + ProductsList.Products[0].Name + "\n" +
                ProductsList.Products[0].Cost + "\n\n";
            string product2 = ProductsList.Products[1].Id.ToString() + "\n" + ProductsList.Products[1].Name + "\n" +
                ProductsList.Products[1].Cost + "\n\n";
            string product3 = ProductsList.Products[2].Id.ToString() + "\n" + ProductsList.Products[2].Name + "\n" +
                ProductsList.Products[2].Cost + "\n\n";
            return product1 + product2 + product3;
        }
    }
}