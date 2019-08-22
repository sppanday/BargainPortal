using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NTBargainHunter.Models;

/*
 * @author : Surendra Panday
 * **/

namespace NTBargainHunter.Controllers
{
    public class HomeController : Controller
    {
       // [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("FAQ")]
        public IActionResult FAQ()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        //[Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
