using System.Web;
using System.Web.Mvc;

namespace MVC4_Bootstrap_AngularJS_Boilerplate
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}