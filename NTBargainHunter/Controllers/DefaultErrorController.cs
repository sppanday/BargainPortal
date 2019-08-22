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
    public class DefaultErrorController : Controller
    {
        public IActionResult DefaultError()
        {
            return View();
        }
    }
}