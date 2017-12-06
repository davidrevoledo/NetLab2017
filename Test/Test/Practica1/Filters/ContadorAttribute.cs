using System.Web;
using System.Web.Mvc;

namespace Practica1.Filters
{
    public class ContadorAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var count = 1;

            if (HttpContext.Current.Application["count"] == null)
            {
                HttpContext.Current.Application["count"] = count;
            }
            else
            {
                count = int.Parse(HttpContext.Current.Application["count"].ToString()) + 1;
                HttpContext.Current.Application["count"] = count;
            }
        }
    }
}