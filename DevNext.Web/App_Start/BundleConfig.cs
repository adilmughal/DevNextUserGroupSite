using System.Web.Optimization;

namespace DevNext.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/ThirdPartyScripts").Include("~/Scripts/jquery-{version}.js",
                                                                                "~/Scripts/jquery-ui-{version}.js",
                                                                                "~/Scripts/jquery.unobtrusive*",
                                                                                "~/Scripts/jquery.validate*",
                                                                                "~/Scripts/jquery.flexslider.js",
                                                                                "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/Scripts/modernizr").Include("~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/Scripts/site").Include("~/Scripts/site.js"));

            bundles.Add(new StyleBundle("~/Content/ThirdPartyStyleSheets").Include("~/Content/flexslider.css",
                                                                                   "~/Content/themes/base/jquery.ui.core.css",
                                                                                   "~/Content/themes/base/jquery.ui.resizable.css",
                                                                                   "~/Content/themes/base/jquery.ui.selectable.css",
                                                                                   "~/Content/themes/base/jquery.ui.accordion.css",
                                                                                   "~/Content/themes/base/jquery.ui.autocomplete.css",
                                                                                   "~/Content/themes/base/jquery.ui.button.css",
                                                                                   "~/Content/themes/base/jquery.ui.dialog.css",
                                                                                   "~/Content/themes/base/jquery.ui.slider.css",
                                                                                   "~/Content/themes/base/jquery.ui.tabs.css",
                                                                                   "~/Content/themes/base/jquery.ui.datepicker.css",
                                                                                   "~/Content/themes/base/jquery.ui.progressbar.css",
                                                                                   "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle("~/Content/sitecss").Include("~/Content/Site.css"));
        }
    }
}