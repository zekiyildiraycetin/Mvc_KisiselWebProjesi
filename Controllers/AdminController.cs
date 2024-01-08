using KisiselWebProjesi.Models;
using KisiselWebProjesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }

        public ActionResult AnaSayfaGetir(int Id)
        {
            var ag = c.AnaSayfas.Find(Id);
            return View("AnaSayfaGetir" , ag);
        }

        public ActionResult AnaSayfaGuncelle(AnaSayfa g)
        {
            var asg = c.AnaSayfas.Find(g.Id);
            asg.isim = g.isim;
            asg.profil = g.profil;
            asg.unvan = g.unvan;
            asg.aciklama = g.aciklama;
            asg.iletisim = g.iletisim;
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult ikonListesi()
        {
            var deger = c.ikonlars.ToList();
            return View(deger);
        }

        public ActionResult yeniIkon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult yeniIkon(ikonlar p)
        {
            c.ikonlars.Add(p);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }

        public ActionResult  ikonGetir(int id)
        {
            var ig = c.ikonlars.Find(id);
            return View("ikonGetir",ig);
        }

        public ActionResult ikonGuncelle(ikonlar x)
        {
            var ig = c.ikonlars.Find(x.Id);
            ig.ikon = x.ikon;
            ig.link= x.link;
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }

        public ActionResult ikonSil(int id)
        {
            var sil = c.ikonlars.Find(id);
            c.ikonlars.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }

    }
}