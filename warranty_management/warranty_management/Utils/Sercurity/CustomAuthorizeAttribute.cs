using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace warranty_management.Utils.Sercurity
{
    public class CustomAuthorizeAttribute
    {
        //public class NoneAuthorizeAttribute : FilterAttribute, IAuthorizationFilter
        //{
        //    protected virtual CustomPrincipal CurrentUser
        //    {
        //        get { return HttpContext.Current.User as CustomPrincipal; }
        //    }


        //    public void OnAuthorization(AuthorizationContext filterContext)
        //    {
        //        if (filterContext.HttpContext.Request.IsAuthenticated)
        //            filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Account", action = "Index" }));
        //    }
        //}

        //public class ActivedAuthorizeAttribute : FilterAttribute, IAuthorizationFilter
        //{
        //    protected virtual CustomPrincipal CurrentUser
        //    {
        //        get { return HttpContext.Current.User as CustomPrincipal; }
        //    }
        //    public void OnAuthorization(AuthorizationContext filterContext)
        //    {
        //        if (filterContext.HttpContext.Request.IsAuthenticated)
        //        {
        //            if (CurrentUser.Status == "Banner")
        //                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Auth", action = "Banner" }));
        //            else if (CurrentUser.Status == "Unactived")
        //                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Auth", action = "Unactived" }));
        //        }
        //    }
        //}

        //public class ForceLoginAttribute : FilterAttribute, IAuthorizationFilter
        //{
        //    public void OnAuthorization(AuthorizationContext filterContext)
        //    {

        //    }
        //}
    }
}