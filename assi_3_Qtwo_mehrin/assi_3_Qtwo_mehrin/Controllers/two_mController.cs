using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assi_3_Qtwo_mehrin.Controllers
{
    public class two_mController : Controller
    {
        // GET: two_m
        public ActionResult Index()
        {

            ViewBag.value = 3;

            ViewBag.valA = 20;
            ViewBag.valB = 30;

            ViewBag.val = 700;
            return View();
        }

    }
}