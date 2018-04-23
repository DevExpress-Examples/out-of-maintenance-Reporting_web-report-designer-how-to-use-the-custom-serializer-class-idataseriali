using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace T120425 {
    public partial class CategoriesReport : DevExpress.XtraReports.UI.XtraReport {
        public CategoriesReport() {
            InitializeComponent();
        }

        private void CategoriesReport_DataSourceDemanded(object sender, EventArgs e) {
            //nwindSession.
        }

    }
}
