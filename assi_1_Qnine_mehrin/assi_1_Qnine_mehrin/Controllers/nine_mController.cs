using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assi_1_Qnine_mehrin.Controllers
{
    public class nine_mController : Controller
    {
        // GET: nine_m
        public ActionResult Index()
        {
            return View();
        }

        public string methodone9()
        {
            return @"
           <h1>detailing</h1>
           <table border='1'>
            <tr>
                <th>ID</th>
                <th>NAME</th>
                <th>ADDRESS</th>
               <th>PHONE</th>
              <th>AGE</th>
            </tr>
            <tr>
                <td>1</td>
                <td>mehrin</td>
                <td>wankaner</td>
               <td>14565656525</td>
               <td>20</td>
             <td>
            </tr>
            <tr>
                <td>1</td>
                <td>aayushi</td>
                <td>rajkot</td>
               <td>14565656525</td>
               <td>21</td>

            </tr>
        </table>";
        }
    }
}