using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assi_1_Qsecond_mehrin.Controllers
{
    public class secondController : Controller
    {
        // GET: second
        public ActionResult Index()
        {
            return View();
        }

        public string methodsecond()
        {
            return @"
            <h2>Employee Table</h2>
    <table>
        <tr>
            <th>Employee ID</th>
            <th>Name</th>
            <th>Department</th>
            <th>Salary</th>
        </tr>
        <tr>
            <td>201</td>
            <td>John</td>
            <td>HR</td>
            <td>40000</td>
        </tr>
        <tr>
            <td>202</td>
            <td>Emma</td>
            <td>IT</td>
            <td>60000</td>
        </tr>
    </table>";
}      

 }


}
