using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       

        public ActionResult HiddenCount(int counter = 0)
        {

            ViewBag.Counter = ++counter;

            return View();
        }

        public ActionResult CookieCount()
        {
            int counter = 0;
           var cookiecount = Request.Cookies.Get("Counter");
            if (cookiecount != null)
            {
                counter = Convert.ToInt32(cookiecount.Value);
            }
            ViewBag.Counter = ++counter;
            Response.Cookies.Set(new HttpCookie ("Counter", counter.ToString()));
            return View();
        }

        public ActionResult SessionCount()
        {
            int counter = 0;
            var sessioncount = Session["Counter"];
            if (sessioncount != null)
            {
                counter = Convert.ToInt32(sessioncount);
            }
            ViewBag.Counter = ++counter;
            Session.Add("Counter", counter);
            return View();
        }
    }
}