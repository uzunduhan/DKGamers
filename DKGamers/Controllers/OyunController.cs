using DKGamers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Controllers
{
    public class OyunController : Controller
    {
        private Context context = new Context();
        public IActionResult Index()
        {
            var oyunlar = context.Oyun.ToList();
            oyunlar = oyunlar.OrderBy(x => x.OyunAdi).ToList();

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
