using System.Web;
using System.Web.Optimization;

namespace AdministrationTool
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Assets/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/bundles/dashkit-styles").Include(
                "~/Assets/Vendors/Dashkit/fonts/feather/feather.min.css",
                "~/Assets/Vendors/Dashkit/libs/highlight.js/styles/vs2015.css",
                "~/Assets/Vendors/Dashkit/libs/quill/dist/quill.core.css",
                "~/Assets/Vendors/Dashkit/libs/select2/dist/css/select2.min.css",
                "~/Assets/Vendors/Dashkit/libs/flatpickr/dist/flatpickr.min.css",
                "~/Assets/Vendors/Dashkit/scss/theme-dark.min.css"));


            bundles.Add(new StyleBundle("~/bundles/custom-styles").Include(
                "~/Assets/Styles/main.min.css"));


            bundles.Add(new ScriptBundle("~/bundles/dashkit-scripts").Include(
                "~/Assets/Vendors/Dashkit/libs/jquery/dist/jquery.min.js",
                "~/Assets/Vendors/Dashkit/libs/bootstrap/dist/js/bootstrap.bundle.min.js",
                "~/Assets/Vendors/Dashkit/libs/chart.js/dist/Chart.min.js",
                "~/Assets/Vendors/Dashkit/libs/chart.js/Chart.extension.min.js",
                "~/Assets/Vendors/Dashkit/libs/highlightjs/highlight.pack.min.js",
                "~/Assets/Vendors/Dashkit/libs/flatpickr/dist/flatpickr.min.js",
                "~/Assets/Vendors/Dashkit/libs/jquery-mask-plugin/dist/jquery.mask.min.js",
                "~/Assets/Vendors/Dashkit/libs/list.js/dist/list.min.js",
                "~/Assets/Vendors/Dashkit/libs/quill/dist/quill.min.js",
                "~/Assets/Vendors/Dashkit/libs/dropzone/dist/min/dropzone.min.js",
                "~/Assets/Vendors/Dashkit/libs/select2/dist/js/select2.min.js",
                "~/Assets/Vendors/Dashkit/js/theme.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/custom-scripts").Include(
                "~/Assets/Scripts/JavaScript/Main.js"));


        }
    }
}
