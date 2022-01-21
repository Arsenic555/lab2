using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public List<Product> catalog;
        private int i = 0;
        private readonly ILogger<HomeController> _logger;
        
        public HomeController()
        {
            catalog = new List<Product>
            {
                new Product
                {
                    id = 1,
                    name = "Товар1",
                    price = 100,
                    ammount = 10,
                    desc = "Описание",
                    img = "/img/7356.jpg"
                },
                new Product
                {
                    id = 2,
                    name = "Товар2",
                    price = 1000,
                    ammount = 13,
                    desc = "Описание",
                    img = "/img/ui_ph.jpg"
                },
                new Product
                {
                    id = 3,
                    name = "Товар3",
                    price = 10,
                    ammount = 1,
                    desc = "Описание",
                    img = "/img/ui_ph.jpg"
                },
                new Product
                {
                    id = 4,
                    name = "Товар4",
                    price = 100,
                    ammount = 10,
                    desc = "Описание",
                    img = "/img/ui_ph.jpg"
                },
                new Product
                {
                    id = 5,
                    name = "Товар5",
                    price = 1050,
                    ammount = 103,
                    desc = "Описание",
                    img = "/img/ui_ph.jpg"
                }
            };
        }
        public IActionResult Index()
        {
            ViewBag.name = catalog[i].name;
            ViewBag.desc = catalog[i].desc;
            ViewBag.img = catalog[i].img;
            ViewBag.ammount = catalog[i].ammount;
            return View(catalog);
        }

        public IActionResult Manager()
        {
            return View(catalog);
        }

        public void Shower(int n)
        {
            i = n;
            Index();
        }

        public IActionResult Privacy()
        {
            return View();
        }



        public IActionResult Cart()
        {
            return View();
        }

        /*
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        */
    }
}
