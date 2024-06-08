using Di_25.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Di_25.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a, double b)
        {
            return a + " + " + b + " = " + (a + b);
        }
    }
}
