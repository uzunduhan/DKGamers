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

            var oyunlar1 = context.Oyun.ToList();
            oyunlar1 = oyunlar1.OrderByDescending(x => x.PiyasayaSurulmeTarihi).ToList();
            oyunlar1 = oyunlar1.Take(5).ToList();

            var oyunlar2 = context.Oyun.ToList();
            oyunlar2 = oyunlar2.OrderByDescending(x => x.GoruntulenmeSayisi).ToList();
            oyunlar2 = oyunlar2.Take(5).ToList();

            return View(new HaberListViewModel()
            {
                Haberler = haberler,
                Oyunlar1 = oyunlar1,
                Oyunlar2 = oyunlar2
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