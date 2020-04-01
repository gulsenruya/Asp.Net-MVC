using MVCDataTransfer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataTransfer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Category> categories = new List<Category>()
            {
                new Category{ID=1,CategoryName="Beverages",Description="Soft drinks,coffe"},
                new Category{ID=2,CategoryName="Condiments",Description="Soft drinks,coffe"},
                new Category{ID=3,CategoryName="Confection",Description="Soft drinks,coffe"},
                new Category{ID=4,CategoryName="Beverages",Description="Soft drinks,coffe"},
            };
            ViewData["KategoriListesi"] = categories;
            ViewBag.KategoriListesi = categories;
            TempData["KategoriListesi"] = categories;
                
            return View();
        }
        public ActionResult Category()
        {
            return View();

        }
    }
}