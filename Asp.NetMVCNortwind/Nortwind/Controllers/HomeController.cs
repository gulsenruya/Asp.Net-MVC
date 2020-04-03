using Nortwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nortwind.Controllers
{
    public class HomeController : Controller
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public ActionResult Index()
        {
            List<Order_Detail> order_Details = db.Order_Details.Take(10).ToList();
            int count=db.Employees.Count();
            List<Product> products = db.Products.ToList();
            int productPiece = db.Products.Count();
            int orderPiece = db.Order_Details.Count();
            //int earnings=db.Order_Details.
            ViewBag.EmployeeList = count;
            TempData["ProductPiece"] = productPiece;
            TempData["Order_Detail"] = orderPiece;
            TempData["Order_Detail1"] = order_Details;

            return View(db.Orders.Take(10).ToList());
        }

        
    }
}