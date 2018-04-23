Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Security
Imports System.Web.SessionState
Imports DevExpress.XtraReports.Native

Namespace T120425
	Public Class [Global]
		Inherits System.Web.HttpApplication

		Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
			SerializationService.RegisterSerializer(XPCollectionSerializer.NAME, New XPCollectionSerializer())
		End Sub
	End Class
End Namespace