using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
       
        // GET: Home
        public ActionResult Index()
        {
           
            Session["MyTimeSession"] = DateTime.Now.ToString();
            String ses = Session["MyTimeSession"].ToString();
            TempData["MyTimeTemp"] = DateTime.Now.ToString();
            ViewBag.MyTime = DateTime.Now.ToString();
            GotoHome();
            //return RedirectToAction("GotoHome","Home");
            return View();
        }

        public ActionResult GotoHome()
        {
            //ViewData["MyTime"] = DateTime.Now.ToString();
            ViewBag.MyTime = DateTime.Now.ToString();

            return View("MyHomePage");
        }
    }
}