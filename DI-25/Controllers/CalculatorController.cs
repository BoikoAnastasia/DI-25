using Microsoft.AspNetCore.Mvc;

namespace Di_25.Controllers
{
    public class CalculatorController : Controller
    {
        public String Index(int a, int b, string c)
        {
            if (c == "+")
            {
                return a + " + " + b + " = " + (a + b);
            }
            else if (c == "-")
            {
                return a + " - " + b + " = " + (a - b);
            }
            else if (c == "*")
            {
                return a + " * " + b + " = " + (a * b);
            }
            else if (c == null)
            {

                return a + " + " + b + " = " + (a + b);
            }
            else
            {
                return "Вам необходимо правильно задать операцию";
            }
        }
    }
}
//https://localhost:7124/calculator/index/1/2
