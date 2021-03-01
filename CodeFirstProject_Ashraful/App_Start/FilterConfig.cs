using System.Web;
using System.Web.Mvc;

namespace CodeFirstProject_Ashraful
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
