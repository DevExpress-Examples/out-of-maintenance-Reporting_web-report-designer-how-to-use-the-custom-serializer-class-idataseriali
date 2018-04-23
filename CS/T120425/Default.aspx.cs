using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Native;

namespace T120425 {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            XtraReport report = new CategoriesReport();
            report.Extensions[SerializationService.Guid] = XPCollectionSerializer.NAME;
            reportDesigner.OpenReport(report);
        }
    }
}