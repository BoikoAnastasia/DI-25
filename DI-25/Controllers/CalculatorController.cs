using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Di_25.Controllers;

public class CalculatorController : ControllerBase
{
    public string Get(int arg1 = 0, int arg2 = 0, string operation = "+")
    {
        int result;

        switch (operation)
        {
            case "+":
                result = arg1 + arg2;
                break;
            case "-":
                result = arg1 - arg2;
                break;
            case "*":
                result = arg1 * arg2;
                break;
            default:
                result = arg1 + arg2;
                break;
        }

        return $"{arg1} {operation} {arg2} = {result}";
    }
}
