using Nortwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nortwind.Controllers
{
    public class ProductController : Controller
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public ActionResult Index()
        {
            return View(db.Products.OrderByDescending(x=>x.ProductID).ToList());
        }
        public ActionResult Add()
        {
            ViewBag.Categories = new SelectList(db.Categories, "CategoryID", "CategoryName");
            ViewBag.Suppliers = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            return View();
        }
        [HttpPost]
        public ActionResult Add(Product product,string Categories,string Suppliers)
        {
            product.SupplierID = Convert.ToInt32(Suppliers);
            product.CategoryID = Convert.ToInt32(Categories);
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}