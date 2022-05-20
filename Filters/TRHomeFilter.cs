using SmartStore.Core.Plugins;
using SmartStore.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BizSolTracker.Reporting.Filters
{
    public class TRHomeFilter : IActionFilter
    {
        private readonly IPluginFinder _pluginFinder;

        public TRHomeFilter(IPluginFinder pluginFinder)
        {
            _pluginFinder = pluginFinder;
        }
        public void OnActionExecuting(ActionExecutingContext ctx)
        {
            var plugin = _pluginFinder.GetPluginDescriptorBySystemName("BizSolTracker.Reporting");
            if (ctx == null ||
                    ctx.ActionDescriptor == null ||
                    ctx.HttpContext == null ||
                    ctx.HttpContext.Request == null)
            {
                return;
            }

            if (plugin.Installed)
            {
                if (ctx.Controller.GetType().Equals(typeof(HomeController)) &&
                ctx.ActionDescriptor.ActionName.Equals("Index"))
                {

                    if (ctx.HttpContext.Request.HttpMethod == "GET")
                    {
                        var _routeValues = new RouteValueDictionary(
                            new
                            {
                                controller = "TrackerHome",
                                action = "Index"
                            }
                            );
                        ctx.Result = new RedirectToRouteResult("BizSolTracker.Home", _routeValues);
                    }
                }
            }
        }

        public void OnActionExecuted(ActionExecutedContext ctx) { }
    }
}