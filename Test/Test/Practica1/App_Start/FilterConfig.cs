using System.Web;
using System.Web.Mvc;
using Practica1.Filters;

namespace Practica1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new ContadorAttribute());
        }
    }
}
