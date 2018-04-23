Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.Xpo
Imports System.Xml.Serialization
Imports System.IO
Imports DevExpress.XtraReports.Native

Namespace T120425
    Public Class XPCollectionSerializer
        Implements IDataSerializer

        Public Const NAME As String = "XPCollectionSerializer"

        Public Function CanSerialize(ByVal data As Object, ByVal extensionProvider As Object) As Boolean Implements IDataSerializer.CanSerialize
            Dim xpCollection As XPCollection = TryCast(data, XPCollection)
            Return xpCollection IsNot Nothing AndAlso xpCollection.ObjectType IsNot Nothing
        End Function

        Public Function Serialize(ByVal data As Object, ByVal extensionProvider As Object) As String Implements IDataSerializer.Serialize
            Dim serializer As New XmlSerializer(GetType(XPCollectionInfo))

            Dim xpCollection As XPCollection = DirectCast(data, XPCollection)
            Dim collectionInfo As New XPCollectionInfo(xpCollection)

            Using serializationWriter As New StringWriter()
                serializer.Serialize(serializationWriter, collectionInfo)
                Return serializationWriter.ToString()
            End Using
        End Function

        Public Function CanDeserialize(ByVal value As String, ByVal typeName As String, ByVal extensionProvider As Object) As Boolean Implements IDataSerializer.CanDeserialize
            Return typeName = GetType(XPCollection).ToString()
        End Function

        Public Function Deserialize(ByVal value As String, ByVal typeName As String, ByVal extensionProvider As Object) As Object Implements IDataSerializer.Deserialize
            Dim serializer As New XmlSerializer(GetType(XPCollectionInfo))
            Using deserializationReader As New StringReader(value)
                Dim collectionInfo As XPCollectionInfo = DirectCast(serializer.Deserialize(deserializationReader), XPCollectionInfo)
                Return collectionInfo.CreateXPCollection()
            End Using
        End Function

        <Serializable()>
        Public Class XPCollectionInfo
            Public Property ObjectTypeName() As String
            Public Property ConnectionString() As String
            Public Property DisplayableProperties() As String

            Public Sub New()
            End Sub

            Public Sub New(ByVal xpCollection As XPCollection)
                Me.ConnectionString = "XpoProvider=MSSqlServer;" & xpCollection.Session.ConnectionString
                Me.ObjectTypeName = xpCollection.ObjectType.AssemblyQualifiedName
                Me.DisplayableProperties = xpCollection.DisplayableProperties
            End Sub

            Public Function CreateXPCollection() As XPCollection
                Dim session As New Session()
                session.ConnectionString = Me.ConnectionString

                Dim type As Type = System.Type.GetType(Me.ObjectTypeName, False)
                Return New XPCollection(session, type) With {.DisplayableProperties = Me.DisplayableProperties}
            End Function
        End Class
    End Class
End Namespace