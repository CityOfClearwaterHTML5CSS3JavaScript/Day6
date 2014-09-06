Imports System.Web.Optimization

Public Module BundleConfig
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
            "~/assets/scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/libraries.js").Include(
            "~/assets/scripts/libraries.js"))

        bundles.Add(New StyleBundle("~/bundles/stylesheets.css").Include(
                  "~/assets/css/stylesheets.css"))
    End Sub
End Module

