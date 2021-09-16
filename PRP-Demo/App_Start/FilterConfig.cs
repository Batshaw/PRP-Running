using System.Web;
using System.Web.Mvc;

namespace PRP_Demo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            filters.Add(new AuthorizeAttribute());      //Restrict globaly the application

            filters.Add(new RequireHttpsAttribute());
        }
    }
}
