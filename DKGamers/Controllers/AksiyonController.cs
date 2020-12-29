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
        public IActionResult Cok()
        {
            List<Oyun> oyun = context.Oyun.Include(i => i.OyunKategorileri).ThenInclude(t => t.Kategori).ToList();

            return View(new OyunListViewModel()
            {
                oyunlar = oyun
            });
        }

        public IActionResult Tek()
        {
            return View();
        }

       
    }
}
