using SmartStore.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace BizSolTracker.Reporting
{
    public class Plugin : BasePlugin
    {
        public static string SystemName => "BizSolTracker.Reporting";

        public override void Install()
        {
            base.Install();
        }

        public override void Uninstall()
        {
            base.Uninstall();
        }
    }
}