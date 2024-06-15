using Di_25.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Di_25.Controllers
{
    public class HomeController : Controller
    {
        public String index(int a)
        {
            var answer = "";
            for (int i = 0; i < FlowerList.products.Count; i++)
            {
                answer = "";
                if (FlowerList.products[i].Id == a)
                {
                    answer += FlowerList.products[i].Id;
                    answer += "\n";
                    answer += FlowerList.products[i].Name;
                    answer += "\n";
                    answer += FlowerList.products[i].Price;
                    answer += "\n";
                    answer += FlowerList.products[i].Description;
                    return answer;
                    break;
                }
                else
                {
                    answer = "Продукта с таким id нет";
                }
            }
            return answer;
        }
    }
}

