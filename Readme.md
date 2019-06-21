<!-- default file list -->
*Files to look at*:

* [Category.cs](./CS/T120425/Category.cs) (VB: [Category.vb](./VB/T120425/Category.vb))
* [Default.aspx](./CS/T120425/Default.aspx) (VB: [Default.aspx](./VB/T120425/Default.aspx))
* [Default.aspx.cs](./CS/T120425/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/T120425/Default.aspx.vb))
* [Global.asax.cs](./CS/T120425/Global.asax.cs) (VB: [Global.asax.vb](./VB/T120425/Global.asax.vb))
* **[XPCollectionSerializer.cs](./CS/T120425/XPCollectionSerializer.cs) (VB: [XPCollectionSerializer.vb](./VB/T120425/XPCollectionSerializer.vb))**
<!-- default file list end -->
# Web Report Designer - How to use the custom serializer class (IDataSerializer) to serialize the XPO data source to make it visible in the web report designer
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t120425/)**
<!-- run online end -->


<p>This example demonstrates how to use the custom data source component serializer class that implements the IDataSerializer interface to serialize a report's data source component. This approach is actual when you are displaying a report that uses the data source component that cannot be serialized by the report (for example, XPCollection, DataSet <em>(untyped)</em>, IList). The Web Report Designer stores only the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument2592">report definition</a>, so if the data source component is not serialized, this component cannot be restored on the callbacks. As a result, the designer's Field List and Preview will be empty.<br /><strong>Note</strong> that such data source components as <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataAccessSqlSqlDataSourcetopic">SqlDataSource</a>, <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataAccessEntityFrameworkEFDataSourcetopic">EFDataSource</a>, <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataAccessObjectBindingObjectDataSourcetopic">ObjectDataSource</a> and <a href="https://msdn.microsoft.com/en-us/library/esbykkzb%28v=vs.110%29.aspx">Typed DataSets</a> are serialized out-of-the-box, so it is not necessary to use this approach in case of using these components.<br /><br />Use the following steps to serialize your report's data source component:<br />1. Create a custom data source component serializer class that implements the IDataSerializer interface. Implement this interface's methods to save (in the Serialize method) and restore (in the Deserialize method) your data source component from the string.<br />2. Register your custom data source component serializer class when your application is started. For example, use the Application_Start event in the application's Global.asax.cs file for this purpose:</p>


```cs
protected void Application_Start(object sender, EventArgs e) {
        SerializationService.RegisterSerializer(XPCollectionSerializer.NAME, new XPCollectionSerializer());
}
```


<p>3. Assign the custom data source component serializer name (that you have registered in the previous step) to your report as demonstrated below:</p>


```cs
XtraReport report = new CategoriesReport();
report.Extensions[SerializationService.Guid] = XPCollectionSerializer.NAME;
```


<p>You should do that before opening you report in the Web report designer.</p>
<br /><strong>Important Note:</strong> This approach will work only for <strong>XML</strong> serialization. So, if you want to save the report along with the serialized DataSource, use the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReport_SaveLayoutToXmltopic">XtraReport.SaveLayoutToXml</a> method to save the report's definition.<br /><br /><br /><strong>FAQ:</strong><br /><em>How to implement the custom serializer class (IDataSerializer) to serialize the <strong>DataSet</strong> data source?</em><br />Please refer to the to the following KB article to learn how to do that: <a href="https://www.devexpress.com/Support/Center/p/T269534">How to serialize a report to XML with an untyped DataSet as a data source</a>.<br /><br />

<br/>


