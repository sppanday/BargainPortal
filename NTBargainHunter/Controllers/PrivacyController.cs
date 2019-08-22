using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NTBargainHunter.Controllers
{
   
    public class PrivacyController : Controller
    {
        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}