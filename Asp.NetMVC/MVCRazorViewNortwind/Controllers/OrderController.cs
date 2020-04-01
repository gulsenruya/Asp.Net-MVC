using MVCRazorViewNortwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRazorViewNortwind.Controllers
{
    public class OrderController : Controller
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public ActionResult Index()
        {
            List<Order> orders = db.Orders.ToList();
            return View(orders);
        }
    }
}