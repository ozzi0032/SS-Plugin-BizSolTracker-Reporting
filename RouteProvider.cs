using SmartStore.Web.Framework.Routing;
using System.Web.Mvc;
using System.Web.Routing;

namespace BizSolTracker.Reporting
{
    public class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {

            routes.MapRoute("BizSolTracker.Reporting",
                "Plugins/BizSolTracker/{action}/{id}",
                new { controller = "Reporting", action = "Index", id = UrlParameter.Optional},
                new[] { "BizSolTracker.Reporting.Controllers" }
           )
           .DataTokens["area"] = Plugin.SystemName;

            routes.MapRoute("BizSolTracker.Home",
                "Plugins/TrackerReporting/Home/{action}",
                new { controller = "TrackerHome", action = "Index"},
                new[] { "BizSolTracker.Reporting.Controllers" }
           )
           .DataTokens["area"] = Plugin.SystemName;

        }

        public int Priority => 0;
    }
}