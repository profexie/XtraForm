Imports System.Web.Optimization
Imports DevExtreme.AspNet


Public Class BundleConfig

    Public Shared Sub RegisterBundles(ByVal bundles As BundleCollection)

        Dim scriptBundle = New ScriptBundle("~/Scripts/bundle")
        Dim styleBundle = New StyleBundle("~/Content/bundle")


        scriptBundle.Include("~/Scripts/jquery-3.5.1.js")
        scriptBundle.Include("~/Scripts/bootstrap.js")

        styleBundle.Include("~/Content/bootstrap.css")


        styleBundle.Include("~/Content/Site.css")
        styleBundle.Include("~/Content/Fonts/Roboto-300.tff")

        bundles.Add(scriptBundle)
        bundles.Add(styleBundle)

#If Not DEBUG Then
        BundleTable.EnableOptimizations = True
#End If
    End Sub
End Class
