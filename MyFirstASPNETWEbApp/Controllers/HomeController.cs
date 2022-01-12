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
            throw new IndexOutOfRangeException();
            return View();
        }
    }
}
