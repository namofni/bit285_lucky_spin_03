using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        Random random = new Random();

        //TODO: Update the Conroller to receive the Luck number from the Route
        public IActionResult Index()
        {
            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);

            if (a == 7 || b == 7 || c == 7)
                ViewBag.Display = "block";
            else
                ViewBag.Display = "none";


            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.C = c;


            return View();
        }
    }
}