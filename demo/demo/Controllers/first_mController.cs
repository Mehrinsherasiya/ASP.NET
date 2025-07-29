using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class first_mController : Controller
    {
        // GET: first_m
        public ActionResult Index()
        {
            return View();
        }

        public string methodone()
        {
            return "<b> <h1>html form</h1> </b>";
        }
    }
}