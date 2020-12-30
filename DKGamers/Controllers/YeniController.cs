using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DKGamers.Models;

namespace DKGamers.Controllers
{
    public class YeniController : Controller
    {
        private Context context = new Context();
        public IActionResult Index()
        {
            var oyunlar = context.Oyun.ToList();
            oyunlar = oyunlar.OrderByDescending(x => x.PiyasayaSurulmeTarihi).ToList();
            oyunlar = oyunlar.Take(10).ToList();
            return View(new OyunListViewModel()
            {
                Oyunlar = oyunlar
            });
        }
        public IActionResult Detail(int id)
        {
            var oyun = context.Oyun.FirstOrDefault(i => i.OyunID == id);
            return View(oyun);
        }
    }
}