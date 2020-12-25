using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Controllers
{
    public class KorkuController : Controller
    {
        public IActionResult Tek()
        {
            return View();
        }

        public IActionResult Cok()
        {
            return View();
        }
    }
}
