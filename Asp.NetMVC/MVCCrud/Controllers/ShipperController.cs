using MVCCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrud.Controllers
{
    public class ShipperController : Controller
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public ActionResult Index()
        {
            List<Shipper> shippers = db.Shippers.ToList();
            
            return View(shippers);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Shipper shipper)
        {
            if (ModelState.IsValid )
            {
                db.Shippers.Add(shipper);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Bilgi"] = "Model is not empty !";
                return View();
            }
           
        }
        public ActionResult Update(int id)
        {
            var shipper = db.Shippers.Find(id);
            if (shipper == null)
            {
                TempData["Bilgi"] = "Shipper not found";
            }
            return View(shipper);
        }
        [HttpPost]
        public ActionResult Update(Shipper shipper)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shipper).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Bilgi"] = "Model is not empty !";
                return View();
            }
          
        }
        public ActionResult Delete(int id)
        {           
                var shipper = db.Shippers.Find(id);
                db.Shippers.Remove(shipper);
                db.SaveChanges();
                return RedirectToAction("Index");
           
        }
        //[HttpPost]
        //public ActionResult Delete(Shipper shipper)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var shipper = db.Shippers.Find(id);
        //        db.Shippers.Remove(shipper);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        TempData["Bilgi"] = "Model is not empty !";
        //        return View();
        //    }
        //}
    }
}