namespace dxReports.Reports.Cheque_Blank
{
    partial class EmirateIslamic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmirateIslamic));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.bankName = new DevExpress.XtraReports.Parameters.Parameter();
            this.checkDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.bpName = new DevExpress.XtraReports.Parameters.Parameter();
            this.checkAmount = new DevExpress.XtraReports.Parameters.Parameter();
            this.countryCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.bankCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.company = new DevExpress.XtraReports.Parameters.Parameter();
            this.checkNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.remarks = new DevExpress.XtraReports.Parameters.Parameter();
            this.userId = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.AmountLineOne = new DevExpress.XtraReports.UI.CalculatedField();
            this.AmountKineTwo = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 10F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 10F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel5});
            this.Detail.HeightF = 390.0565F;
            this.Detail.Name = "Detail";
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([AmountLine2])")});
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(21.13444F, 195.0139F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(509.8775F, 40.14038F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "xrLabel7";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "upper([AmountLine1])")});
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(54.80693F, 159.564F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(496.0075F, 32.53384F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[checkAmount]")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Arial", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(572.4146F, 202.1185F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(186.8738F, 33.03581F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel3.TextFormatString = "{0:N}";
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([bpName])")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(76.36068F, 120.0621F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(541.8927F, 31.61584F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[checkDate]")});
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(572.4146F, 90.90017F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(185.6026F, 28.52259F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "xrLabel5";
            this.xrLabel5.TextFormatString = "{0:d}";
            // 
            // bankName
            // 
            this.bankName.Description = "bankName";
            this.bankName.Name = "bankName";
            // 
            // checkDate
            // 
            this.checkDate.Description = "checkDate";
            this.checkDate.Name = "checkDate";
            this.checkDate.Type = typeof(System.DateTime);
            this.checkDate.ValueInfo = "2026-01-27";
            // 
            // bpName
            // 
            this.bpName.Description = "bpName";
            this.bpName.Name = "bpName";
            // 
            // checkAmount
            // 
            this.checkAmount.Description = "checkAmount";
            this.checkAmount.Name = "checkAmount";
            this.checkAmount.Type = typeof(decimal);
            this.checkAmount.ValueInfo = "0";
            // 
            // countryCode
            // 
            this.countryCode.Description = "countryCode";
            this.countryCode.Name = "countryCode";
            this.countryCode.ValueInfo = "0";
            // 
            // bankCode
            // 
            this.bankCode.Description = "bankCode";
            this.bankCode.Name = "bankCode";
            // 
            // company
            // 
            this.company.Description = "company";
            this.company.Name = "company";
            // 
            // checkNo
            // 
            this.checkNo.Description = "checkNo";
            this.checkNo.Name = "checkNo";
            // 
            // remarks
            // 
            this.remarks.Description = "remarks";
            this.remarks.Name = "remarks";
            // 
            // userId
            // 
            this.userId.Description = "userId";
            this.userId.Name = "userId";
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "PowerBI";
            this.sqlDataSource2.Name = "sqlDataSource2";
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
            queryParameter9.Value = new DevExpress.DataAccess.Expression("?company", typeof(string));
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
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // AmountLineOne
            // 
            this.AmountLineOne.DataMember = "Rpt_ChequePrint";
            this.AmountLineOne.Expression = "Iif(Len([amountInWords]) > 50,\n    Substring([amountInWords], 0, 50),\n    [amount" +
    "InWords]\n)\n";
            this.AmountLineOne.Name = "AmountLineOne";
            // 
            // AmountKineTwo
            // 
            this.AmountKineTwo.DataMember = "Rpt_ChequePrint";
            this.AmountKineTwo.Expression = "Iif(Len([amountInWords]) > 50,\n    Substring([amountInWords], 50),\n    \'\'\n)\n";
            this.AmountKineTwo.Name = "AmountKineTwo";
            // 
            // EmirateIslamic
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.AmountLineOne,
            this.AmountKineTwo});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource2});
            this.DataMember = "Rpt_ChequePrint";
            this.DataSource = this.sqlDataSource2;
            this.FilterString = "[bankCode] = \'EIB\'";
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(10F, 8F, 10F, 10F);
            this.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100F);
            this.PageHeight = 390;
            this.PageWidth = 800;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.bankName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.checkDate, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.bpName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.checkAmount, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.countryCode, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.bankCode, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.company, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.checkNo, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.remarks, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.userId, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.bankName,
            this.checkDate,
            this.bpName,
            this.checkAmount,
            this.countryCode,
            this.bankCode,
            this.company,
            this.checkNo,
            this.remarks,
            this.userId});
            this.Version = "23.1";
            this.Watermark.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("EmirateIslamic.Watermark.ImageSource"));
            this.Watermark.ImageTransparency = 255;
            this.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Stretch;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.Parameters.Parameter bankName;
        private DevExpress.XtraReports.Parameters.Parameter checkDate;
        private DevExpress.XtraReports.Parameters.Parameter bpName;
        private DevExpress.XtraReports.Parameters.Parameter checkAmount;
        private DevExpress.XtraReports.Parameters.Parameter countryCode;
        private DevExpress.XtraReports.Parameters.Parameter bankCode;
        private DevExpress.XtraReports.Parameters.Parameter company;
        private DevExpress.XtraReports.Parameters.Parameter checkNo;
        private DevExpress.XtraReports.Parameters.Parameter remarks;
        private DevExpress.XtraReports.Parameters.Parameter userId;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.CalculatedField AmountLineOne;
        private DevExpress.XtraReports.UI.CalculatedField AmountKineTwo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
    }
}
