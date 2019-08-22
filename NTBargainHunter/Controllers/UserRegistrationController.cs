using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

/*
 * @author : Surendra Panday
 * **/

namespace NTBargainHunter.Controllers
{
    [Route("Registration")]
    public class UserRegistrationController : Controller
    {
       
        public IActionResult UserRegistration()
        {
            return View();
        }
    }
}