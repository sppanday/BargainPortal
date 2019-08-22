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
    [Route("Contact")]
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}