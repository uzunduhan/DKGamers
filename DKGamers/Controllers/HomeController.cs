using DKGamers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Controllers
{
    public class HomeController : Controller
    {
        private Context context = new Context();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var haberler = context.Haber.ToList();
            haberler.Reverse();
            var item = haberler.Take(2);
           
            return View(new HaberListViewModel()
            {
                haberler=item.ToList()
            });
        }
        public IActionResult Detail(int id)
        {
            var haber = context.Haber.FirstOrDefault(i => i.HaberID == id);
            return View(haber);
        }
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
