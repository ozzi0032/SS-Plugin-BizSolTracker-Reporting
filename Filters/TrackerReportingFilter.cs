using SmartStore.Web.Controllers;
using SmartStore.Web.Models.Customer;
using System.Web.Mvc;
using System.Web.Routing;

namespace BizSolTracker.Reporting.Filters
{
    public class TrackerReportingFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {

            if (filterContext == null ||
                filterContext.ActionDescriptor == null ||
                filterContext.HttpContext == null ||
                filterContext.HttpContext.Request == null)
            {
                return;
            }

            if (filterContext.Controller.GetType().Equals(typeof(CustomerController)) &&
                filterContext.ActionDescriptor.ActionName.Equals("Register"))
            {

                if (filterContext.HttpContext.Request.HttpMethod == "GET")
                {
                    var _routeValues = new RouteValueDictionary(
                        new
                        {
                            controller = "Reporting",
                            action = "Register"
                        }
                        );
                    filterContext.Result = new RedirectToRouteResult("BizSolTracker.Reporting", _routeValues);
                }
            }
        }

        public void OnActionExecuted(ActionExecutedContext filterContext) { }
    }
}