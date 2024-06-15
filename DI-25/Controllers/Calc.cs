using Microsoft.AspNetCore.Mvc;

namespace Di_25.Controllers
{
    public class Calc : Controller
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
