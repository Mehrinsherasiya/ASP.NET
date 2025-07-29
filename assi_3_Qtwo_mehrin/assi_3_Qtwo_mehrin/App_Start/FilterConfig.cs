using System.Web;
using System.Web.Mvc;

namespace assi_3_Qtwo_mehrin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
