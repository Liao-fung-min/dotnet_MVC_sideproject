using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductSideproject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return Redirect("https://www.netflix.com/browse");
        }
        public ActionResult FirstAction() 
        {
            return View();
        }
        public ActionResult GotoProduct() 
        {
            //Operation
            //return RedirectToAction("Index");
            return RedirectToAction("Index","Product");
        }
        public ActionResult GotoUpdateProduct() 
        {
            return RedirectToAction("UpdateProduct", "Product", new {ID = 20});
        
        }
    }
}