using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Repositories;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class DeneyimController : Controller
    {
 
        DeneyimRepository repo = new DeneyimRepository();
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult DeneyimEkle()
        {

            return View();
        }

        [HttpPost]
        public ActionResult DeneyimEkle(TblDeneyimler p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");

        }

        public ActionResult Deneyimsil(int id)
        {
            TblDeneyimler t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");

        }

        [HttpGet]

        public ActionResult DeneyimGetir(int id)
        {
            TblDeneyimler t =repo.Find(x => x.ID == id);
            return View(t);
        }

        [HttpPost]

        public ActionResult DeneyimGetir(TblDeneyimler p)
        {
            TblDeneyimler t = repo.Find(x => x.ID == p.ID);
            t.Baslık = p.Baslık;
            t.AltBaslık = p.AltBaslık;
            t.Aciklama = p.Aciklama;
            t.tarih = p.tarih;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }

    }
}