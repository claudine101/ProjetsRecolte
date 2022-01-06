using System.Web;
using System.Web.Optimization;

namespace WebApplicationrRecolte
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour développer et apprendre. Puis, lorsque vous êtes
            // prêt pour la production, utilisez l’outil de génération sur http://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
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

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/webfont").Include(
                "~/Assets/js/plugin/webfont/webfont.js"));
            bundles.Add(new StyleBundle("~/Assets/css").Include(
               "~/Assets/css/bootstrap.css",
               "~/Assets/css/atlantis.css",
               "~/Assets/css/demo.css"));

            bundles.Add(new ScriptBundle("~/Assets/js/core").Include(
               "~/Assets/js/core/jquery.3.2.1.js",
               "~/Assets/js/core/popper.js",
               "~/Assets/js/core/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/jquery-ui-1.12.1.custom").Include(
            "~/Assets/js/plugin/jquery-ui-1.12.1.custom/jquery-ui.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/jquery-ui-touch-punch").Include(
            "~/Assets/js/plugin/jquery-ui-1.12.1.custom/jquery.ui.touch-punch.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/jquery-scrollbar").Include(
           "~/Assets/js/plugin/jquery-scrollbar/jquery.scrollbar.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/moment").Include(
           "~/Assets/js/plugin/moment/moment.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/chart.js").Include(
           "~/Assets/js/plugin/chart.js/chart.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/chart-circle").Include(
             "~/Assets/js/plugin/chart-circle/circles.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/datatables").Include(
             "~/Assets/js/plugin/datatables/datatables.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/bootstrap-notify").Include(
            "~/Assets/js/plugin//bootstrap-notify/bootstrap-notify.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/bootstrap-toggle/bootstrap-toggle.js").Include(
            "~/Assets/js/plugin/bootstrap-toggle"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/jqvmap/maps").Include(
            "~/Assets/js/plugin/jqvmap/maps/jquery.vmap.world.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/gmaps").Include(
            "~/Assets/js/plugin/gmaps/gmaps.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/dropzone").Include(
            "~/Assets/js/plugin/dropzone/dropzone.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/fullcalendar").Include(
            "~/Assets/js/plugin/fullcalendar/fullcalendar.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/datepicker").Include(
           "~/Assets/js/plugin/datepicker/bootstrap-datetimepicker.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/bootstrap-tagsinput").Include(
            "~/Assets/js/plugin/bootstrap-tagsinput/bootstrap-tagsinput.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/bootstrap-wizard").Include(
            "~/Assets/js/plugin/bootstrap-wizard/bootstrapwizard.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/jquery.validate").Include(
            "~/Assets/js/plugin/jquery.validate/jquery.validate.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/summernote").Include(
            "~/Assets/js/plugin/summernote/summernote-bs4.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/select2").Include(
            "~/Assets/js/plugin/select2/select2.full.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/sweetalert").Include(
            "~/Assets/js/plugin/sweetalert/sweetalert.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/owl-carousel").Include(
            "~/Assets/js/plugin/owl-carousel/owl.carousel.js"));

            bundles.Add(new ScriptBundle("~/Assets/js/plugin/jquery.magnific-popup").Include(
            "~/Assets/js/plugin/jquery.magnific-popup/jquery.magnific-popup.js"));

            bundles.Add(new ScriptBundle("~/Assets/js").Include(
            "~/Assets/js/atlantis.js",
             "~/Assets/js/setting-demo.js",
              "~/Assets/js/demo.js",
              "~/Assets/js/main.js"));
        }
    }
}
