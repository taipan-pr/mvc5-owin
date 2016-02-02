using System.Web.Optimization;

namespace mvc5_owin
{
	public partial class Startup
	{
	    private void RegisterBundles()
	    {
            var bundles = BundleTable.Bundles;

#if !DEBUG
            BundleTable.EnableOptimizations = true;
            bundles.UseCdn = true;
#endif

            // Font Awesome icons
            bundles.Add(new StyleBundle("~/font-awesome/css",
                                        "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.5.0/css/font-awesome.min.css")
                                        .Include("~/fonts/font-awesome/css/font-awesome.css", new CssRewriteUrlTransform()));

            // jQuery-UI style
            bundles.Add(new StyleBundle("~/content/jquery-ui",
                                        "https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.11.4/jquery-ui.min.css")
                                        .Include("~/Scripts/jquery-ui/jquery-ui.css", new CssRewriteUrlTransform()));

            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery",
                                         "https://cdnjs.cloudflare.com/ajax/libs/jquery/2.2.0/jquery.min.js")
                                         .Include("~/Scripts/jquery-2.2.0.js"));

            // jQuery-UI Script
            bundles.Add(new ScriptBundle("~/bundles/jquery-ui-script",
                                         "https://cdnjs.cloudflare.com/ajax/libs/jquery/2.2.0/jquery.min.js")
                                         .Include("~/Scripts/jquery-ui/jquery-ui.js"));
        }
    }
}