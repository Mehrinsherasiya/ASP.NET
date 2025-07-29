using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assi_one_Qthird_mehrin.Controllers
{
    public class thirdController : Controller
    {
        // GET: third
        public string third()
        {
            return @"<h2>Book Library Table</h2>

        <!-- Book Library Table -->
        <table>
            <thead>
                <tr>
                    <th>Book ID</th>
                    <th>Title</th>
                    <th>Author</th>
                    <th>Genre</th>
                    <th>Publication Date</th>
                    <th>ISBN</th>
                    <th>Availability</th>
                </tr>
            </thead>
            <tbody>
                <!-- Sample Book Rows -->
                <tr>
                    <td>101</td>
                    <td>To Kill a Mockingbird</td>
                    <td>Harper Lee</td>
                    <td>Fiction</td>
                    <td>1960-07-11</td>
                    <td>9780061120084</td>
                    <td>Available</td>
                </tr>
                <tr>
                    <td>102</td>
                    <td>1984</td>
                    <td>George Orwell</td>
                    <td>Dystopian</td>
                    <td>1949-06-08</td>
                    <td>9780451524935</td>
                    <td>Checked Out</td>
                </tr>
 </tbody>
        </table>
          
    
}

}
}