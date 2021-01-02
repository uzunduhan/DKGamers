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
    public class AdminController : Controller
    {
        private Context context = new Context();

        private UserManager<Kullanici> kullaniciYoneticisi;
        public AdminController(UserManager<Kullanici> _kullaniciYoneticisi)
        {
            kullaniciYoneticisi = _kullaniciYoneticisi;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Oyun()
        {
            var oyunlar = context.Oyun.OrderBy(o => o.OyunID).ToList();
            return View(new OyunListViewModel()
            {
                Oyunlar = oyunlar
            });
        }

        public IActionResult OyunuGizle(int id)
        {
            Oyun oyun = context.Oyun.FirstOrDefault(i => i.OyunID == id);
            oyun.oyunGosterilsinmi = true;
            context.Update(oyun);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult OyunuGoster(int id)
        {
            Oyun oyun = context.Oyun.FirstOrDefault(i => i.OyunID == id);
            oyun.oyunGosterilsinmi = false;
            context.Update(oyun);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult OyunuGuncelle(Oyun oyun)
        {

            context.Update(oyun);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult OyunEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OyunEkle(Oyun oyun)
        {
            context.Add(oyun);
            context.SaveChanges();
            return RedirectToAction("Oyun","Admin");
        }

        public IActionResult Haber()
        {
            var haberler = context.Haber.OrderBy(o => o.HaberID).ToList();
            return View(new HaberListViewModel()
            {
                Haberler = haberler
            });
        }

        public IActionResult HaberiGizle(int id)
        {
            Haber haber = context.Haber.FirstOrDefault(i => i.HaberID == id);
            haber.haberGosterilsinmi = true;
            context.Update(haber);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult HaberiGoster(int id)
        {
            Haber haber = context.Haber.FirstOrDefault(i => i.HaberID == id);
            haber.haberGosterilsinmi = false;
            context.Update(haber);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult HaberGuncelle(Haber haber)
        {

            context.Update(haber);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult HaberEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HaberEkle(Haber haber)
        {
            context.Add(haber);
            context.SaveChanges();
            return RedirectToAction("Haber", "Admin");
        }

        public IActionResult Kullanici()
        {
            return View(kullaniciYoneticisi.Users);
        }

        public async Task<IActionResult> KullaniciSil(string userId)
        {
            var user = await kullaniciYoneticisi.FindByIdAsync(userId);
            await kullaniciYoneticisi.DeleteAsync(user);
            return Redirect("/admin/kullanici");
        }

    }
}
