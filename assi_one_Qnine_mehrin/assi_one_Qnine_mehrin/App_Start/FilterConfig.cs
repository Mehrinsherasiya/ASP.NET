﻿using System.Web;
using System.Web.Mvc;

namespace assi_one_Qnine_mehrin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
