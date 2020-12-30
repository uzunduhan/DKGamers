using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DKGamers.Models;
using Microsoft.EntityFrameworkCore;

namespace DKGamers.Controllers
{
    public class AksiyonController : Controller
    {
        private Context context = new Context();
        public IActionResult Tek()
        {
            return View();
        }

        public IActionResult Cok()
        {
            var oyunlar = context.Oyun.Include(i => i.OyunKategorileri).ThenInclude(i => i.Kategori.KategoriID == 2).ToList();

            return View(new OyunListViewModel()
            {
                Oyunlar = oyunlar
            });
        }
    }
}