﻿using System.Web;
using System.Web.Optimization;

namespace appSISUR
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // SweetAlert
            bundles.Add(new ScriptBundle("~/bundles/sweetalert").Include("~/Scripts/sweetalert.min.js"));

            //jQuery.Unobtrusive
            bundles.Add(new ScriptBundle("~/bundles/jqueryajax").Include(
                       "~/Scripts/jquery.unobtrusive*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/chart-area-demo.js",
                        "~/Scripts/bootstrap.js"));
                    

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 // "~/Content/bootstrap.css",

                  "~/Content/bootstrap-flatly.min.css",
                    "~/Content/bootstrap.min.css",
                    "~/Content/css/stylesSisur2.css",
                    "~/Content/bootstrap-Sisur.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                   //"~/Content/bootstrap.css",
                   //"~/Content/site.css",
                   "~/Content/bootstrap-materia.min.css",
                    "~/Content/jquery-ui.css", "~/Content/sweetalert.css"
                   ));

        }
    }
}
