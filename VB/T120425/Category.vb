Imports System
Imports DevExpress.Xpo

Namespace T120425

	<Persistent("Categories")>
	Public Class Category
		Inherits XPLiteObject

		Public Sub New()
			MyBase.New()
			' This constructor is used when an object is loaded from a persistent storage.
			' Do not place any code here.
		End Sub

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
			' This constructor is used when an object is loaded from a persistent storage.
			' Do not place any code here.
		End Sub

		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
			' Place here your initialization code.
		End Sub

		<Key(True)>
		Public Property CategoryID() As Integer

		Public Property CategoryName() As String

		Public Property Description() As String

		Public Property Picture() As Byte()
	End Class

End Namespace