using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assi_3_Qone_mehrin.Controllers
{
    public class one_mController : Controller
    {
        // GET: one_m
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult artithmeticoprator()
        {
            ViewBag.valueA = 10;
            ViewBag.valueB = 20;
            return View();
        }
    }
}