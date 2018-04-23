Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Native

Namespace T120425
	Partial Public Class [Default]
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim report As XtraReport = New CategoriesReport()
			report.Extensions(SerializationService.Guid) = XPCollectionSerializer.NAME
			reportDesigner.OpenReport(report)
		End Sub
	End Class
End Namespace