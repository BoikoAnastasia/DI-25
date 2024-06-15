using Microsoft.AspNetCore.Mvc;

namespace Di_25.Controllers
{
    public class StartController : Controller
    {
        public string hello()
        {
            DateTime dateTime = DateTime.Now;
            int hour = dateTime.Hour;

            if (hour >= 0 && hour <= 5)
            {
                return "Доброй ночи";
            }
            else if (hour >= 6 && hour <= 11)
            {
                return "Доброе утро";
            }
            else if (hour >= 12 && hour <= 17)
            {
                return "Добрый день";
            }
            else
            {
                return "Добрый вечер";
            }
        }
    }
}
