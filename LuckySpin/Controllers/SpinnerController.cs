using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LuckySpin.Models;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        Random random = new Random();

        //TODO: Update the Conroller to receive the Luck number from the Route
        public IActionResult Index(int luck)
        {
            Spin spin = new Spin();
            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);

            if (a == luck || b == luck || c == luck)
                spin.Image = "block";
            else
                spin.Image = "none";

            spin.A = a;
            spin.B = b;
            spin.C = c;

            switch(luck)
            {
                default:
                    spin.Title = "Nothing";
                    break;
                case 1:
                    spin.Title = "One";
                    break;
                case 2:
                    spin.Title = "Two";
                    break;
                case 3:
                    spin.Title = "Three";
                    break;
                case 4:
                    spin.Title = "Four";
                    break;
                case 5:
                    spin.Title = "Five";
                    break;
                case 6:
                    spin.Title = "Six";
                    break;
                case 7:
                    spin.Title = "Seven";
                    break;
            }


            return View(spin);
        }
    }
}