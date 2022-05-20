using SmartStore.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BizSolTracker.Reporting.Controllers
{
    public class TrackerHomeController : PluginControllerBase
    {
        // GET: TrackerHome
        public ActionResult Index()
        {
            Console.WriteLine("This is home index");
            return View();
        }
    }
}