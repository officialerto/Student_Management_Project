using System.Web;
using System.Web.Mvc;

namespace StudentMngProject_Orgn
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
