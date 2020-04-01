using MVCHtmlHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHtmlHelpers.Controllers
{
    public class ActionController : Controller
    {
        // GET: Action
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Action()
        {
            return View();
        }
        public ActionResult _PartialAction()
        {
            return PartialView();
        }
        public PartialViewResult _PartialActionRoute(int id)
        {
            List<Sehirler> sehirler = new List<Sehirler>()
            {
                new Sehirler{ID=1,SehirAdi="Istanbul"},
                new Sehirler{ID=2,SehirAdi="Ankara"},
                new Sehirler{ID=3,SehirAdi="Izmır"},
            };
            var sehir = sehirler.Where(x => x.ID == id).FirstOrDefault();
            return PartialView(sehir);
        }
    }
}