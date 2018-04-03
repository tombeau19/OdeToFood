using System;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using Microsoft.AspNetCore.Mvc.Razor;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var model = new Restaurant { Id = 1, Name = "Tommy's Spot BABAYY" };

            return View(model);
        }
    }
}
