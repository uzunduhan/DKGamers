using DKGamers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Controllers
{
    public class YeniController : Controller
    {
        private Context context = new Context();
        public IActionResult Index()
        {
            var GosterilecekOyunlar = context.Oyun.ToList();
            GosterilecekOyunlar = GosterilecekOyunlar.OrderByDescending(x => x.CıkısTarihi).ToList();
            GosterilecekOyunlar = GosterilecekOyunlar.Take(2).ToList();
            
            return View(new OyunListViewModel()
            {
                oyunlar = GosterilecekOyunlar
            });
        }

        public IActionResult Detail(int id)
        {
            var oyun = context.Oyun.FirstOrDefault(i => i.OyunID == id);
            return View(oyun);
        }
    }
}
