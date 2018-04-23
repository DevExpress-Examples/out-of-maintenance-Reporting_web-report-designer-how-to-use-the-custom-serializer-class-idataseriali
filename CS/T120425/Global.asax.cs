using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using DevExpress.XtraReports.Native;

namespace T120425 {
    public class Global : System.Web.HttpApplication {
        protected void Application_Start(object sender, EventArgs e) {
            SerializationService.RegisterSerializer(XPCollectionSerializer.NAME, new XPCollectionSerializer());
        }
    }
}