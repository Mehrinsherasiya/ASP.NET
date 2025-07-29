using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assi_1_Qthird_mehrin.Controllers
{
    public class third_mController : Controller
    {
        // GET: third_m
        public ActionResult Index()
        {
            return View();
        }
        public string methodone3()
        {
            return @"
           <h2>Customer Table</h2>
    <table>
        <tr>
            <th>Customer ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Phone</th>
        </tr>
        <tr>
            <td>301</td>
            <td>David</td>
            <td>david@example.com</td>
            <td>1234567890</td>
        </tr>
        <tr>
            <td>302</td>
            <td>Linda</td>
            <td>linda@example.com</td>
            <td>9876543210</td>
        </tr>
    </table>
";
        }
    }
}