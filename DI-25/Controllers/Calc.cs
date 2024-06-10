using Microsoft.AspNetCore.Mvc;

public class Calc : Controller
{
    public string Index(int a, int b, char c)
    {

        string result = " ";

        switch (c)
        {
            case '+':
                return $"{a} + {b} = {a + b}";
                break;
            case '-':
                return $"{a} - {b} = {a - b}";
                break;
            case '*':
                return $"{a} * {b} = {a * b}";
                break;
            case '/':
                return $"{a} / {b} = {a / b}";
                break;
            case '\0':
                return $"{a} + {b} = {a + b}";
                break;
            default:
                return $"нот воркинг";
        }
    }
}