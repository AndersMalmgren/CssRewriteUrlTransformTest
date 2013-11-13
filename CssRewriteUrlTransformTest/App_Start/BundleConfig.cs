using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace CssRewriteUrlTransformTest.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var cssBundle = new StyleBundle("~/bundles/css");
            new[]
                {
                    "~/Content/test.css"
                }
                .ToList()
                .ForEach(css => bundles.Add(cssBundle.Include(css, new CssRewriteUrlTransform())));
        }
    }
}