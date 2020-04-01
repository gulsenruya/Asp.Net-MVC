using MVCRazorViewNortwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRazorViewNortwind.Controllers
{
    public class ProductController : Controller
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public ActionResult Index()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }
        public ActionResult Detail(int id)
        {
            var product = db.Products.FirstOrDefault(x => x.CategoryID == id);
            return View(product);
        }
        public ActionResult AddProduct()
        {
            return View(new Product());
        }
        [HttpPost]
        public ActionResult AddProduct(string ProductName,string UnitPrice)
        {
            return View();
        }
    }
}