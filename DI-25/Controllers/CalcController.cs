using Microsoft.AspNetCore.Mvc;

namespace Di_25.Controllers
{
    public class CalcController : Controller
    {
        public string Index(double a, double b, string c)
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
            else if (c == "/")
            {
                return a + " / " + b + " = " + (a / b);
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
//https://localhost:7124/calc/index?a=1&b=3&c=+