using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            //ViewData["AdSoyad"] = "Mehmet Elbeyli";//ViewData bir Dictionary türündedir.Key value'ye göre çalışır.
            //ViewData["check1"] = true;//Aynı keyden birden fazla verilirse diğerleri ezilir en son verilen geçerlidir.

            //ViewData gibi işlev gören fakat dinamic yapıda olan çalışma zamanında kontrolleri ekleyen,kullanıcı dostu yazımı olan viewbag ile de aynı
            //işlem yapılabilir.ViewBag'de aslında ViewDatayı kullandığını unutmayalım
            //ViewBag.AdSoyad = "Mehmet Elbeyli";
            //ViewBag.check1 = true;

            //TempData ile ViewData yazımı ve kullanımı dahil olmak üzere tamamen aynıdır.Tek farkı şudur ki Tempdata'daki veriler aynı sayfadaki
            //farklı actionlar üzerinden erişilebilirken ViewData ve ViewBag sadece bulunulan actiondan erişilebir bir özelliktir.
            TempData["AdSoyad"] = "Mehmet Elbeyli";
            TempData["check1"] = true;


            return View();
        }
        public ActionResult About()
        {
            ViewBag.Ad = "Mehmet";
            ViewBag.Durum = true;
            ViewBag.List1 = new SelectListItem[]
            {
                new SelectListItem(){Text="Mehmet"},
                new SelectListItem() { Text = "Ahmet" },
                new SelectListItem(){Text="Hasan"}
            };
            TempData["t1"] = ViewBag.Ad;//Contact'da burdaki viewbag'i kullanması için tempdataya attık
            TempData["d1"] = ViewBag.Durum;
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Ad = TempData["t1"];//Aynı şekilde viewbag aynı datayı kullanması için temdatadan aldık
            ViewBag.Durum = TempData["d1"];

            return View();
        }
    }
}