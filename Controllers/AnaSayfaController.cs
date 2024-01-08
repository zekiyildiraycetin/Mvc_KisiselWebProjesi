using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KisiselWebProjesi.Models.Siniflar;

namespace KisiselWebProjesi.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa

        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }

        public PartialViewResult ikonlar()
        {
            var deger = c.ikonlars.ToList();
            return PartialView(deger); 
        }
    }
}