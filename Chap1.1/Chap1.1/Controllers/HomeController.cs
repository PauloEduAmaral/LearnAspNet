using System;
using Microsoft.AspNetCore.Mvc;

namespace Chap1._1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Goodd morning" : "Good Afternoon";
            return View("MyView");
        }

    }
}
