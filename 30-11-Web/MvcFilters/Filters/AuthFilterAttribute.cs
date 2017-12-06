using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MvcFilters.Filters
{
    public class AuthFilterAttribute : AuthorizeAttribute
    {
        public bool isLogged = true;

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (!isLogged)
            {
                throw new HttpException(HttpStatusCode.Unauthorized.ToString());
            }

            return true;
        }
    }

    public class A : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            throw new NotImplementedException();
        }
    }

    public class ActionFilter2Attribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var g = 1;
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            var a = 1;
            base.OnActionExecuted(filterContext);
        }
    }
}