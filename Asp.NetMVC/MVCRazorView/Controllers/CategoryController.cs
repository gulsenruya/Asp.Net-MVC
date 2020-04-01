using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRazorView.Models;

namespace MVCRazorView.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            List<Category> categories = new List<Category>()
            {
                new Category{ID=1,CategoryName="İcecek",Description="içecekler"},
                new Category{ID=2,CategoryName="Yiyecek",Description="yiyecekler"},
                new Category{ID=3,CategoryName="Tatlı",Description="Tatlılar"},
            };
            return View(categories);
        }
    }
}