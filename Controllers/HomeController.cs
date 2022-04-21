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
            //işlem yapılabilir.
            //ViewBag.AdSoyad = "Mehmet Elbeyli";
            //ViewBag.check1 = true;

            //TempData ile ViewData yazımı ve kullanımı dahil olmak üzere tamamen aynıdır.Tek farkı şudur ki Tempdata'daki veriler aynı sayfadaki
            //farklı actionlar üzerinden erişilebilirken ViewData ve ViewBag sadece bulunulan actiondan erişilebir bir özelliktir.
            TempData["AdSoyad"] = "Mehmet Elbeyli";
            TempData["check1"] = true;


            return View();
        }
    }
}