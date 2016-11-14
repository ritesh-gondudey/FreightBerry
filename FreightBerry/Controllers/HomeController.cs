using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreightBerry.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ManageRequest()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult RateRequestForm()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult QuoteForRequest()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewRateRequest()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AgentQuoteReceived()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Quote()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult QuoteReceived()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult AgentQuoteReceived()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        //public ActionResult AgentQuoteReceived()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}