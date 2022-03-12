Imports System.Web.Optimization
Imports DevExtreme.AspNet
Public Class DevExtremeBundleConfig

    Public Shared Sub RegisterBundles(ByVal bundles As BundleCollection)
        Dim styleBundle = New StyleBundle("~/Content/DevExtremeBundle")
        Dim scriptBundle = New ScriptBundle("~/Scripts/DevExtremeBundle")
        styleBundle.Include("~/Content/Charset.css")
        styleBundle.Include("~/Content/dx-gantt.css")
        styleBundle.Include("~/Content/dx-diagram.css")
        styleBundle.Include("~/Content/dx.common.css")
        styleBundle.Include("~/Content/dx.light.css")
        scriptBundle.Include("~/Scripts/dx-gantt.js")
        scriptBundle.Include("~/Scripts/dx-diagram.js")
        scriptBundle.Include("~/Scripts/jquery-3.5.1.js")
        scriptBundle.Include("~/Scripts/cldr.js")
        scriptBundle.Include("~/Scripts/cldr/event.js")
        scriptBundle.Include("~/Scripts/cldr/supplemental.js")
        scriptBundle.Include("~/Scripts/cldr/unresolved.js")
        scriptBundle.Include("~/Scripts/globalize.js")
        scriptBundle.Include("~/Scripts/globalize/message.js")
        scriptBundle.Include("~/Scripts/globalize/number.js")
        scriptBundle.Include("~/Scripts/globalize/currency.js")
        scriptBundle.Include("~/Scripts/globalize/date.js")
        scriptBundle.Include("~/Scripts/jszip.js")
        scriptBundle.Include("~/Scripts/dx.all.js")
        scriptBundle.Include("~/Scripts/vectormap-data/world.js")
        scriptBundle.Include("~/Scripts/aspnet/dx.aspnet.mvc.js")
        scriptBundle.Include("~/Scripts/aspnet/dx.aspnet.data.js")

        bundles.Add(styleBundle)
        bundles.Add(scriptBundle)
#If Not DEBUG Then
        BundleTable.EnableOptimizations = True
#End If

    End Sub
End Class