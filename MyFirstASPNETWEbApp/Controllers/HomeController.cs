using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNETWEbApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.Title = "Home Page";
            return View();
        }

        public IActionResult FanMail()
        {

            ViewBag.Title = "Home Page";
            return View();
        }
    }
}
