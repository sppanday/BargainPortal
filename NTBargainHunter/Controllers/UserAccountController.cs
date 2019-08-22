using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
/*
 * All the login stamina will go through this
 * @author : Surendra Panday
 * **/
namespace NTBargainHunter.Views.Login
{
   //[Route("Login")]
    public class UserAccountController : Controller
    {
      // [Route("")]
        [Route("Login")]
        //[Route("~/")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("Login")]
        [HttpPost]

        public IActionResult Login(string username, string password)
        {
            if (username !=null && password !=null && username.Equals("surendra") && password.Equals("123"))
            {
                HttpContext.Session.SetString("username", username);
                return View("Login");
            } else
            {
                ViewBag.error = "Invalid Account";
                return View("Login");
            }
        }

        [Route("Logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index");
        }
    }
}