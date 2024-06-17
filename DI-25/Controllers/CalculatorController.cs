using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Di_25.Controllers;


public class CalculatorController : ControllerBase
{
    public string Get(int arg1 = 0, int arg2 = 0) => $"{arg1} + {arg2} = {arg1 + arg2}";
}
