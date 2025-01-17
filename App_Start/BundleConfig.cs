﻿using System.Web;
using System.Web.Optimization;

namespace Mawjoud2
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/validate").Include(
          "~/Scripts/validate_login.js",
          "~/Scripts/validate_register.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/template/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/nouislider.min.css",
                      "~/Content/slick-theme.css",
                      "~/Content/slick.css",
                      "~/Content/style.css",
                      "~/Content/font-awesome.min.css"
                      ));
            bundles.Add(new ScriptBundle("~/template/js").Include(
                  "~/Scripts/jquery.min.js",
                  "~/Scripts/bootstrap.min.js",
                  "~/Scripts/slick.min.js",
                  "~/Scripts/nouislider.min.js",
                  "~/Scripts/jquery.zoom.min.js",
                  "~/Scripts/main.js"
                   ));

        }
    }
}
