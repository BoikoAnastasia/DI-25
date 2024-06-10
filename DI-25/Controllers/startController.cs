using Di_25.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Di_25.Controllers
{
    public class startController : Controller
    {
            public ActionResult GetGreeting()
            {
                DateTime currentTime = DateTime.Now;
                string greeting = "";

                if (currentTime.Hour >= 0 && currentTime.Hour < 6)
                {
                    greeting = "Доброй ночи";
                }
                else if (currentTime.Hour >= 6 && currentTime.Hour < 12)
                {
                    greeting = "Доброе утро";
                }
                else if (currentTime.Hour >= 12 && currentTime.Hour < 18)
                {
                    greeting = "Добрый день";
                }
                else
                {
                    greeting = "Добрый вечер";
                }

                return Content(greeting);
            }
        }
    }


