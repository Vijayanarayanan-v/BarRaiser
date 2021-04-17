using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebApplication1.App_Start
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;

            bundles.Add(new Bundle("~/bundle/scripts")
                .Include("~/Libs/scripts/jquery-min.js",
                          "~/Libs/scripts/bootstrap.bundle.min.js"));
        }
        }
}