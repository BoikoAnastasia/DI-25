using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Di_25.Controllers
{
    public class ProductController : Controller
    {
        public string Index(int id) { 
            string product = ProductsList.Products[id].Id.ToString() + "\n\n" + ProductsList.Products[id].Name + "\n\n" +
                ProductsList.Products[id].Cost + "\n\n" + ProductsList.Products[id].Description;
            return product;
        }
    }
}
