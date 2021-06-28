using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        DbCVEntities db = new DbCVEntities();
        public ActionResult Index()
        {
            var degerler = db.TblHakkimdas.ToList();
            return View(degerler);
        }

        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlers.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult Eğitim()
        {
            var egitim = db.TblDeneyimlers.ToList();
            return PartialView(egitim);
        }
    }
}