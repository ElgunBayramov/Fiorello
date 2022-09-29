using Fiorello.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Controllers
{
    public class HomeController : Controller
    {

        static List<Flower> flowers = new List<Flower>()
        {
            new Flower
            {
                FlowerId=1,
                Name = "Messi",
                ImageUrl="shop-8-img.jpg",
                Price=25
            },
             new Flower
            {
                FlowerId=2,
                Name = "ronaldo",
                ImageUrl="shop-10-img.jpg",
                Price=20
            }
        };
       public IActionResult Index()
        {
            return View(flowers);
        }
    }
}
