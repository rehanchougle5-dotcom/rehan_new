namespace dxReports.Reports.Cheque_Blank
{
    partial class emiratesNBDCheque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter9 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter10 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emiratesNBDCheque));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.checkNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.checkDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.bpName = new DevExpress.XtraReports.Parameters.Parameter();
            this.checkAmount = new DevExpress.XtraReports.Parameters.Parameter();
            this.bankName = new DevExpress.XtraReports.Parameters.Parameter();
            this.countryCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.bankCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.remarks = new DevExpress.XtraReports.Parameters.Parameter();
            this.comapny = new DevExpress.XtraReports.Parameters.Parameter();
            this.userId = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 10F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 14.24608F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel2});
            this.Detail.HeightF = 338.6508F;
            this.Detail.Name = "Detail";
            // 
            // checkNo
            // 
            this.checkNo.Description = "checkNo";
            this.checkNo.Name = "checkNo";
            // 
            // checkDate
            // 
            this.checkDate.Description = "checkDate";
            this.checkDate.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "Today()")});
            this.checkDate.Name = "checkDate";
            this.checkDate.Type = typeof(System.DateTime);
            this.checkDate.ValueInfo = "2026-02-27";
            // 
            // bpName
            // 
            this.bpName.Description = "bpName";
            this.bpName.Name = "bpName";
            // 
            // checkAmount
            // 
            this.checkAmount.Name = "checkAmount";
            this.checkAmount.Type = typeof(decimal);
            this.checkAmount.ValueInfo = "0";
            // 
            // bankName
            // 
            this.bankName.Description = "bankName";
            this.bankName.Name = "bankName";
            // 
            // countryCode
            // 
            this.countryCode.Description = "countryCode";
            this.countryCode.Name = "countryCode";
            // 
            // bankCode
            // 
            this.bankCode.Description = "bankCode";
            this.bankCode.Name = "bankCode";
            // 
            // remarks
            // 
            this.remarks.Description = "remarks";
            this.remarks.Name = "remarks";
            // 
            // comapny
            // 
            this.comapny.Description = "comapny";
            this.comapny.Name = "comapny";
            // 
            // userId
            // 
            this.userId.Description = "userId";
            this.userId.Name = "userId";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "PowerBI";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "Rpt_ChequePrint";
            queryParameter1.Name = "@checkNo";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?checkNo", typeof(string));
            queryParameter2.Name = "@checkDate";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?checkDate", typeof(System.DateTime));
            queryParameter3.Name = "@bpName";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?bpName", typeof(string));
            queryParameter4.Name = "@checkAmount";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?checkAmount", typeof(decimal));
            queryParameter5.Name = "@bankName";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("?bankName", typeof(string));
            queryParameter6.Name = "@countryCode";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("?countryCode", typeof(string));
            queryParameter7.Name = "@bankCode";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("?bankCode", typeof(string));
            queryParameter8.Name = "@remarks";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("?remarks", typeof(string));
            queryParameter9.Name = "@company";
            queryParameter9.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter9.Value = new DevExpress.DataAccess.Expression("?comapny", typeof(string));
            queryParameter10.Name = "@userId";
            queryParameter10.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter10.Value = new DevExpress.DataAccess.Expression("?userId", typeof(string));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3,
            queryParameter4,
            queryParameter5,
            queryParameter6,
            queryParameter7,
            queryParameter8,
            queryParameter9,
            queryParameter10});
            storedProcQuery1.StoredProcName = "Rpt_ChequePrint";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([bpName])")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(76.94431F, 128.0555F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(540.2776F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([amountInWords])")});
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(76.94444F, 173.5F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(406.9444F, 78.55554F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "xrLabel5";
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[checkDate]")});
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(487.778F, 89.16666F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(158.8889F, 22.99999F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "xrLabel4";
            this.xrLabel4.TextFormatString = "{0:d}";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[checkAmount]")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(579.1666F, 202.7778F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(170.8333F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // emiratesNBDCheque
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Rpt_ChequePrint";
            this.DataSource = this.sqlDataSource1;
            this.FilterString = "[bankCode] = \'ENBD\'";
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(10F, 10F, 10F, 14.24608F);
            this.PageHeight = 400;
            this.PageWidth = 780;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.checkNo, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.checkDate, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.bpName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.checkAmount, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.bankName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.countryCode, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.bankCode, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.remarks, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.comapny, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.userId, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.checkNo,
            this.checkDate,
            this.bpName,
            this.checkAmount,
            this.bankName,
            this.countryCode,
            this.bankCode,
            this.remarks,
            this.comapny,
            this.userId});
            this.Version = "23.1";
            this.Watermark.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("emiratesNBDCheque.Watermark.ImageSource"));
            this.Watermark.ImageTransparency = 255;
            this.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Stretch;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.Parameters.Parameter checkNo;
        private DevExpress.XtraReports.Parameters.Parameter checkDate;
        private DevExpress.XtraReports.Parameters.Parameter bpName;
        private DevExpress.XtraReports.Parameters.Parameter checkAmount;
        private DevExpress.XtraReports.Parameters.Parameter bankName;
        private DevExpress.XtraReports.Parameters.Parameter countryCode;
        private DevExpress.XtraReports.Parameters.Parameter bankCode;
        private DevExpress.XtraReports.Parameters.Parameter remarks;
        private DevExpress.XtraReports.Parameters.Parameter comapny;
        private DevExpress.XtraReports.Parameters.Parameter userId;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
    }
}
