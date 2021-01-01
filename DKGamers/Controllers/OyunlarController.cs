using DKGamers.Data;
using DKGamers.Identity;
using DKGamers.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Controllers
{
    public class OyunlarController : Controller
    {
        private Context context = new Context();
        private UserManager<Kullanici> kullaniciYoneticisi;
        public OyunlarController(UserManager<Kullanici> _kullaniciYoneticisi)
        {
            kullaniciYoneticisi = _kullaniciYoneticisi;
        }
        public IActionResult Index()
        {
            var oyunlar = context.Oyun.OrderBy(o => o.OyunAdi).ToList();

            return View(new OyunListViewModel()
            {
                Oyunlar = oyunlar
            });
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            Oyun oyun = context.Oyun.Include(i => i.OyunKategorileri).ThenInclude(i => i.Kategori).FirstOrDefault(i => i.OyunID == id);
            var yorumlar = context.Yorum.Include(i => i.Oyun).Where(i => i.OyunID == id).ToList();
            var favorilerdemi = context.Favori.Any(i => i.Oyun.OyunID==id);
            return View(new OyunDetailViewModel()
            {
                Oyun = oyun,
                Yorumlar = yorumlar,
                favorilerdemi=favorilerdemi

            });
        }
        [HttpPost]
        public IActionResult CreateComment(YorumModel model)
        {
            var user = kullaniciYoneticisi.FindByNameAsync(User.Identity.Name).Result;
            var Yorum = new Yorum()
            {
                OlusturulmaTarihi = DateTime.Now,
                KullaniciAdi = user.UserName,
                OyunID = model.OyunID,
                YapilanYorum = model.YapilanYorum
            };
            context.Yorum.Add(Yorum);
            context.SaveChanges();
            return Redirect("/Oyunlar/Detail/" + model.OyunID);
        }
    }
}
