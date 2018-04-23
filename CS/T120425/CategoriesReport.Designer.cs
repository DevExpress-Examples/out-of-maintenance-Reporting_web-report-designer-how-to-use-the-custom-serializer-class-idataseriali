namespace T120425 {
    partial class CategoriesReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lbDescription = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.lbCategoryName = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lbHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.pbPicture = new DevExpress.XtraReports.UI.XRPictureBox();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.nwindSession = new DevExpress.Xpo.Session(this.components);
            this.xpCategoriesCollection = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nwindSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategoriesCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // lbDescription
            // 
            this.lbDescription.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Description")});
            this.lbDescription.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbDescription.LocationFloat = new DevExpress.Utils.PointFloat(220F, 53.08332F);
            this.lbDescription.Multiline = true;
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDescription.SizeF = new System.Drawing.SizeF(430F, 56.91668F);
            this.lbDescription.StylePriority.UseFont = false;
            this.lbDescription.Text = "lbDescription";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbCategoryName
            // 
            this.lbCategoryName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CategoryName")});
            this.lbCategoryName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lbCategoryName.LocationFloat = new DevExpress.Utils.PointFloat(220F, 10.00001F);
            this.lbCategoryName.Name = "lbCategoryName";
            this.lbCategoryName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCategoryName.SizeF = new System.Drawing.SizeF(430F, 32F);
            this.lbCategoryName.StylePriority.UseFont = false;
            this.lbCategoryName.Text = "lbCategoryName";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbHeader});
            this.ReportHeader.HeightF = 100F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lbHeader
            // 
            this.lbHeader.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.lbHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbHeader.SizeF = new System.Drawing.SizeF(650.0001F, 79.99998F);
            this.lbHeader.StylePriority.UseFont = false;
            this.lbHeader.StylePriority.UseTextAlignment = false;
            this.lbHeader.Text = "Categories Report";
            this.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // pbPicture
            // 
            this.pbPicture.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Picture")});
            this.pbPicture.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.SizeF = new System.Drawing.SizeF(200F, 100F);
            this.pbPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbDescription,
            this.pbPicture,
            this.lbCategoryName});
            this.Detail.HeightF = 110F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // nwindSession
            // 
            this.nwindSession.ConnectionString = "XpoProvider=MSSqlServer;Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|" +
    "\\Northwind.mdf;Integrated Security=True;User Instance=True";
            this.nwindSession.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.nwindSession.TrackPropertiesModifications = false;
            // 
            // xpCategoriesCollection
            // 
            this.xpCategoriesCollection.DisplayableProperties = "This;CategoryID;CategoryName;Description;Picture";
            this.xpCategoriesCollection.ObjectType = typeof(T120425.Category);
            this.xpCategoriesCollection.Session = this.nwindSession;
            // 
            // CategoriesReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DataSource = this.xpCategoriesCollection;
            this.Version = "14.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.CategoriesReport_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.nwindSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategoriesCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.XRLabel lbDescription;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.XRLabel lbCategoryName;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lbHeader;
        private DevExpress.XtraReports.UI.XRPictureBox pbPicture;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.Xpo.Session nwindSession;
        private DevExpress.Xpo.XPCollection xpCategoriesCollection;

    }
}
