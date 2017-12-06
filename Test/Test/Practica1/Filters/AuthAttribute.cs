using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Practica1.Filters
{
    public class AuthAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return httpContext.Session["user"] != null;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary(new {controller = "Home", action = "Login"})
            );
        }
    }
}