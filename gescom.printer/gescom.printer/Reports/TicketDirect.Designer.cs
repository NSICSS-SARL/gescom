namespace gescom.printer.Reports
{
    partial class TicketDirect
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketDirect));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.codevente = new DevExpress.XtraReports.UI.XRTableCell();
            this.def = new DevExpress.XtraReports.UI.XRTableCell();
            this.quantite = new DevExpress.XtraReports.UI.XRTableCell();
            this.sepq = new DevExpress.XtraReports.UI.XRTableCell();
            this.nom = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.somme = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.message = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.artcell = new DevExpress.XtraReports.UI.XRTableCell();
            this.count = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.nomPro = new DevExpress.XtraReports.UI.XRLabel();
            this.operateur = new DevExpress.XtraReports.UI.XRLabel();
            this.vendeur = new DevExpress.XtraReports.UI.XRLabel();
            this.temps = new DevExpress.XtraReports.UI.XRLabel();
            this.num = new DevExpress.XtraReports.UI.XRLabel();
            this.dataReport1 = new gescom.printer.DataReport();
            this.ticketTempTableAdapter1 = new gescom.printer.DataReportTableAdapters.TicketTempTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 40F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.Dpi = 254F;
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(740.7396F, 40F);
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.codevente,
            this.def,
            this.quantite,
            this.sepq,
            this.nom});
            this.xrTableRow1.Dpi = 254F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // codevente
            // 
            this.codevente.Dpi = 254F;
            this.codevente.Name = "codevente";
            this.codevente.Weight = 10.453918494170747D;
            // 
            // def
            // 
            this.def.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.def.Dpi = 254F;
            this.def.Name = "def";
            this.def.StylePriority.UseBorders = false;
            this.def.StylePriority.UseTextAlignment = false;
            this.def.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.def.Weight = 0.3655216271075914D;
            // 
            // quantite
            // 
            this.quantite.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.quantite.Dpi = 254F;
            this.quantite.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantite.Name = "quantite";
            this.quantite.StylePriority.UseBorders = false;
            this.quantite.StylePriority.UseFont = false;
            this.quantite.StylePriority.UseTextAlignment = false;
            this.quantite.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.quantite.Weight = 2.2757303497298711D;
            // 
            // sepq
            // 
            this.sepq.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.sepq.Dpi = 254F;
            this.sepq.Name = "sepq";
            this.sepq.StylePriority.UseBorders = false;
            this.sepq.Weight = 0.36552162713398562D;
            // 
            // nom
            // 
            this.nom.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.nom.Dpi = 254F;
            this.nom.Name = "nom";
            this.nom.StylePriority.UseBorders = false;
            this.nom.Weight = 12.701141380524579D;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 50F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Dpi = 254F;
            this.GroupHeader1.HeightF = 10.79504F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.GroupFooter1.Dpi = 254F;
            this.GroupFooter1.HeightF = 51F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrTable2
            // 
            this.xrTable2.Dpi = 254F;
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(386.4999F, 10.00005F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(331.6147F, 39.08331F);
            this.xrTable2.StylePriority.UseFont = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTotal,
            this.somme});
            this.xrTableRow2.Dpi = 254F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTotal
            // 
            this.xrTotal.Dpi = 254F;
            this.xrTotal.Name = "xrTotal";
            this.xrTotal.StylePriority.UseTextAlignment = false;
            this.xrTotal.Text = "TOTAL/Ar";
            this.xrTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTotal.Weight = 0.7311598968240286D;
            // 
            // somme
            // 
            this.somme.Dpi = 254F;
            this.somme.Name = "somme";
            this.somme.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:#,#}";
            this.somme.Summary = xrSummary1;
            this.somme.Text = "total";
            this.somme.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.somme.Weight = 0.60673415932005492D;
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.message,
            this.xrTable3});
            this.GroupFooter2.Dpi = 254F;
            this.GroupFooter2.HeightF = 56.6561F;
            this.GroupFooter2.Level = 1;
            this.GroupFooter2.Name = "GroupFooter2";
            // 
            // message
            // 
            this.message.Dpi = 254F;
            this.message.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.LocationFloat = new DevExpress.Utils.PointFloat(282.4456F, 0F);
            this.message.Name = "message";
            this.message.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.message.SizeF = new System.Drawing.SizeF(420.5544F, 40F);
            this.message.StylePriority.UseFont = false;
            this.message.StylePriority.UseTextAlignment = false;
            this.message.Text = "Prière d\'aller au caisse.";
            this.message.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTable3
            // 
            this.xrTable3.Dpi = 254F;
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(47.625F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(198.4954F, 40F);
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.artcell,
            this.count});
            this.xrTableRow3.Dpi = 254F;
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // artcell
            // 
            this.artcell.Dpi = 254F;
            this.artcell.Name = "artcell";
            this.artcell.Text = "Art.";
            this.artcell.Weight = 0.46982891897983875D;
            // 
            // count
            // 
            this.count.Dpi = 254F;
            this.count.Name = "count";
            this.count.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:#,#}";
            xrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
            this.count.Summary = xrSummary2;
            this.count.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.count.Weight = 0.92584201951198275D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.nomPro,
            this.operateur,
            this.vendeur,
            this.temps,
            this.num});
            this.ReportHeader.Dpi = 254F;
            this.ReportHeader.HeightF = 192F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(182.4999F, 54.49663F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(17.50006F, 37.25334F);
            this.xrLabel1.Text = "-";
            // 
            // nomPro
            // 
            this.nomPro.Dpi = 254F;
            this.nomPro.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomPro.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 0F);
            this.nomPro.Name = "nomPro";
            this.nomPro.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.nomPro.SizeF = new System.Drawing.SizeF(711.6354F, 51.36443F);
            this.nomPro.StylePriority.UseFont = false;
            this.nomPro.StylePriority.UseTextAlignment = false;
            this.nomPro.Text = "COMMANDE NON PAYEE";
            this.nomPro.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // operateur
            // 
            this.operateur.Dpi = 254F;
            this.operateur.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 54.99999F);
            this.operateur.Name = "operateur";
            this.operateur.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.operateur.SizeF = new System.Drawing.SizeF(157.4999F, 36.74998F);
            this.operateur.StylePriority.UseTextAlignment = false;
            this.operateur.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // vendeur
            // 
            this.vendeur.Dpi = 254F;
            this.vendeur.LocationFloat = new DevExpress.Utils.PointFloat(200F, 54.99999F);
            this.vendeur.Name = "vendeur";
            this.vendeur.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.vendeur.SizeF = new System.Drawing.SizeF(181.3124F, 36.74998F);
            this.vendeur.StylePriority.UseTextAlignment = false;
            this.vendeur.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // temps
            // 
            this.temps.Dpi = 254F;
            this.temps.LocationFloat = new DevExpress.Utils.PointFloat(47.625F, 136.75F);
            this.temps.Name = "temps";
            this.temps.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.temps.SizeF = new System.Drawing.SizeF(520.1025F, 47.83667F);
            this.temps.StylePriority.UseTextAlignment = false;
            this.temps.Text = "temps";
            this.temps.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // num
            // 
            this.num.Dpi = 254F;
            this.num.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.LocationFloat = new DevExpress.Utils.PointFloat(424.0105F, 54.99999F);
            this.num.Name = "num";
            this.num.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.num.SizeF = new System.Drawing.SizeF(294.1041F, 58.22916F);
            this.num.StylePriority.UseFont = false;
            this.num.StylePriority.UseTextAlignment = false;
            this.num.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // dataReport1
            // 
            this.dataReport1.DataSetName = "DataReport";
            this.dataReport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketTempTableAdapter1
            // 
            this.ticketTempTableAdapter1.ClearBeforeFill = true;
            // 
            // TicketDirect
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupFooter1,
            this.GroupFooter2,
            this.ReportHeader});
            this.DataSourceSchema = resources.GetString("$this.DataSourceSchema");
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 50);
            this.PageHeight = 2969;
            this.PageWidth = 800;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PrinterName = "\\\\\\\\WIN-HOST.photo104.mg\\\\XP-80C";
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;
            this.RollPaper = true;
            this.ShowPrintMarginsWarning = false;
            this.ShowPrintStatusDialog = false;
            this.SnapGridSize = 25F;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTotal;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell artcell;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel operateur;
        private DevExpress.XtraReports.UI.XRLabel vendeur;
        private DevExpress.XtraReports.UI.XRLabel temps;
        private DevExpress.XtraReports.UI.XRLabel num;
        private DataReport dataReport1;
        private DataReportTableAdapters.TicketTempTableAdapter ticketTempTableAdapter1;
        public DevExpress.XtraReports.UI.XRLabel nomPro;
        public DevExpress.XtraReports.UI.XRTableCell somme;
        public DevExpress.XtraReports.UI.XRTableCell count;
        public DevExpress.XtraReports.UI.XRLabel message;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell codevente;
        private DevExpress.XtraReports.UI.XRTableCell def;
        private DevExpress.XtraReports.UI.XRTableCell quantite;
        private DevExpress.XtraReports.UI.XRTableCell sepq;
        private DevExpress.XtraReports.UI.XRTableCell nom;
    }
}
