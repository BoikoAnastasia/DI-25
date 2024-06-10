using Microsoft.AspNetCore.Mvc;

public class Calculator : Controller
{
    public string Index(int a, int b, char operation)
    {

        string result = " ";

        switch (operation)
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
            case '\0':
                return $"{a} + {b} = {a + b}";
                break;
            default:
                return $"нот воркинг";
        }
    }
}