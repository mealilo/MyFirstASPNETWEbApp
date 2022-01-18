using Microsoft.AspNetCore.Mvc;
using MyFirstASPNETWEbApp.Models;
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
        [HttpGet]
        public IActionResult FanMail()
        {

            ViewBag.Title = "Home Page";
            return View();
        }
        [HttpPost]
        public IActionResult FanMail(FanMailModel model)
        {

            
            return View();
        }
    }
}
