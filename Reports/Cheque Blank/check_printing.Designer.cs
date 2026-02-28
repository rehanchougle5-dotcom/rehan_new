namespace dxReports.Reports.Cheque_Blank
{
    partial class check_printing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(check_printing));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand3 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand4 = new DevExpress.XtraReports.UI.SubBand();
            this.checkNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.checkDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.bpName = new DevExpress.XtraReports.Parameters.Parameter();
            this.checkAmount = new DevExpress.XtraReports.Parameters.Parameter();
            this.bankName = new DevExpress.XtraReports.Parameters.Parameter();
            this.countryCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.bankCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.remarks = new DevExpress.XtraReports.Parameters.Parameter();
            this.company = new DevExpress.XtraReports.Parameters.Parameter();
            this.userId = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport3 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport4 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport5 = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 20F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 20F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport1});
            this.Detail.HeightF = 390F;
            this.Detail.Name = "Detail";
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1,
            this.SubBand2,
            this.SubBand3,
            this.SubBand4});
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport2});
            this.SubBand1.HeightF = 382F;
            this.SubBand1.Name = "SubBand1";
            // 
            // SubBand2
            // 
            this.SubBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport3});
            this.SubBand2.HeightF = 291F;
            this.SubBand2.Name = "SubBand2";
            // 
            // SubBand3
            // 
            this.SubBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport4});
            this.SubBand3.HeightF = 307F;
            this.SubBand3.Name = "SubBand3";
            // 
            // SubBand4
            // 
            this.SubBand4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport5});
            this.SubBand4.HeightF = 400F;
            this.SubBand4.Name = "SubBand4";
            // 
            // checkNo
            // 
            this.checkNo.Name = "checkNo";
            // 
            // checkDate
            // 
            this.checkDate.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "Today()")});
            this.checkDate.Name = "checkDate";
            this.checkDate.Type = typeof(System.DateTime);
            // 
            // bpName
            // 
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
            this.bankName.Name = "bankName";
            // 
            // countryCode
            // 
            this.countryCode.Name = "countryCode";
            // 
            // bankCode
            // 
            this.bankCode.Name = "bankCode";
            // 
            // remarks
            // 
            this.remarks.Name = "remarks";
            // 
            // company
            // 
            this.company.Name = "company";
            // 
            // userId
            // 
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
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.CanShrink = true;
            this.xrSubreport1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?bankCode == \'ENBD\'")});
            this.xrSubreport1.GenerateOwnPages = true;
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("checkNo", this.checkNo));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("checkDate", this.checkDate));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("bpName", this.bpName));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("checkAmount", this.checkAmount));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("bankName", this.bankName));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("countryCode", this.countryCode));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("bankCode", this.bankCode));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("remarks", this.remarks));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("comapny", this.company));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("userId", this.userId));
            this.xrSubreport1.ReportSource = new dxReports.Reports.Cheque_Blank.emiratesNBDCheque();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(810F, 390F);
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.CanShrink = true;
            this.xrSubreport2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?bankCode == \'CBI\'")});
            this.xrSubreport2.GenerateOwnPages = true;
            this.xrSubreport2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport2.Name = "xrSubreport2";
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("checkNo", this.checkNo));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("checkDate", this.checkDate));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("bpName", this.bpName));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("checkAmount", this.checkAmount));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("bankName", this.bankName));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("countryCode", this.countryCode));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("bankCode", this.bankCode));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("remarks", this.remarks));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("company", this.company));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("userId", this.userId));
            this.xrSubreport2.ReportSource = new dxReports.Reports.Cheque_Blank.CBICheque();
            this.xrSubreport2.SizeF = new System.Drawing.SizeF(810F, 382F);
            // 
            // xrSubreport3
            // 
            this.xrSubreport3.CanShrink = true;
            this.xrSubreport3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?bankCode == \'ADCB\'")});
            this.xrSubreport3.GenerateOwnPages = true;
            this.xrSubreport3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport3.Name = "xrSubreport3";
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("bankName", this.bankName));
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("checkNo", this.checkNo));
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("checkDate", this.checkDate));
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("bpName", this.bpName));
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("checkAmount", this.checkAmount));
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("countryCode", this.countryCode));
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("bankCode", this.bankCode));
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("remarks", this.remarks));
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("company", this.company));
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("userId", this.userId));
            this.xrSubreport3.ReportSource = new dxReports.Reports.Cheque_Blank.ADCB();
            this.xrSubreport3.SizeF = new System.Drawing.SizeF(810F, 291F);
            // 
            // xrSubreport4
            // 
            this.xrSubreport4.CanShrink = true;
            this.xrSubreport4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?bankCode == \'DIB\'")});
            this.xrSubreport4.GenerateOwnPages = true;
            this.xrSubreport4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport4.Name = "xrSubreport4";
            this.xrSubreport4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("bankName", this.bankName));
            this.xrSubreport4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("checkNo", this.checkNo));
            this.xrSubreport4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("checkDate", this.checkDate));
            this.xrSubreport4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("bpName", this.bpName));
            this.xrSubreport4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("checkAmount", this.checkAmount));
            this.xrSubreport4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("countryCode", this.countryCode));
            this.xrSubreport4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("bankCode", this.bankCode));
            this.xrSubreport4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("remarks", this.remarks));
            this.xrSubreport4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("comapny", this.company));
            this.xrSubreport4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("userId", this.userId));
            this.xrSubreport4.ReportSource = new dxReports.Reports.Cheque_Blank.DIB();
            this.xrSubreport4.SizeF = new System.Drawing.SizeF(810F, 297F);
            // 
            // xrSubreport5
            // 
            this.xrSubreport5.CanShrink = true;
            this.xrSubreport5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?bankCode == \'EIB\'")});
            this.xrSubreport5.GenerateOwnPages = true;
            this.xrSubreport5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport5.Name = "xrSubreport5";
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("bankName", this.bankName));
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("checkDate", this.checkDate));
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("bpName", this.bpName));
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("checkAmount", this.checkAmount));
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("countryCode", this.countryCode));
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("bankCode", this.bankCode));
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("company", this.company));
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("checkNo", this.checkNo));
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("remarks", this.remarks));
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("userId", this.userId));
            this.xrSubreport5.ReportSource = new dxReports.Reports.Cheque_Blank.EmirateIslamic();
            this.xrSubreport5.SizeF = new System.Drawing.SizeF(810F, 400F);
            // 
            // check_printing
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Rpt_ChequePrint";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(20F, 20F, 20F, 20F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.checkNo, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.checkDate, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.bpName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.checkAmount, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.bankName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.countryCode, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.bankCode, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.remarks, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.company, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
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
            this.company,
            this.userId});
            this.Scripts.OnBeforePrint = "Cheque_BeforePrint";
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport3;
        private DevExpress.XtraReports.UI.SubBand SubBand3;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport4;
        private DevExpress.XtraReports.UI.SubBand SubBand4;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport5;
        private DevExpress.XtraReports.Parameters.Parameter checkNo;
        private DevExpress.XtraReports.Parameters.Parameter checkDate;
        private DevExpress.XtraReports.Parameters.Parameter bpName;
        private DevExpress.XtraReports.Parameters.Parameter checkAmount;
        private DevExpress.XtraReports.Parameters.Parameter bankName;
        private DevExpress.XtraReports.Parameters.Parameter countryCode;
        private DevExpress.XtraReports.Parameters.Parameter bankCode;
        private DevExpress.XtraReports.Parameters.Parameter remarks;
        private DevExpress.XtraReports.Parameters.Parameter company;
        private DevExpress.XtraReports.Parameters.Parameter userId;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}
