namespace gescom.create.Views
{
    partial class XtraMag
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOper = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grillage = new DevExpress.XtraGrid.GridControl();
            this.grilleVue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.refComumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colheure = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleVue)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientColumn
            // 
            this.ClientColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.ClientColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClientColumn.Caption = "TIERS";
            this.ClientColumn.FieldName = "Tiers";
            this.ClientColumn.Name = "ClientColumn";
            this.ClientColumn.Width = 206;
            // 
            // colPrice
            // 
            this.colPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrice.Caption = "PRIX";
            this.colPrice.DisplayFormat.FormatString = "n0";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Prix";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowFocus = false;
            this.colPrice.Width = 90;
            // 
            // colOper
            // 
            this.colOper.AppearanceHeader.Options.UseTextOptions = true;
            this.colOper.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOper.Caption = "REFERENCE";
            this.colOper.FieldName = "Info";
            this.colOper.Name = "colOper";
            this.colOper.OptionsColumn.AllowFocus = false;
            this.colOper.OptionsColumn.AllowSize = false;
            this.colOper.Width = 312;
            // 
            // grillage
            // 
            this.grillage.Cursor = System.Windows.Forms.Cursors.Default;
            this.grillage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grillage.Location = new System.Drawing.Point(0, 0);
            this.grillage.MainView = this.grilleVue;
            this.grillage.Name = "grillage";
            this.grillage.Size = new System.Drawing.Size(564, 591);
            this.grillage.TabIndex = 2;
            this.grillage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grilleVue});
            // 
            // grilleVue
            // 
            this.grilleVue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.refComumn,
            this.colEntre,
            this.colheure});
            this.grilleVue.GridControl = this.grillage;
            this.grilleVue.Name = "grilleVue";
            this.grilleVue.OptionsFilter.AllowFilterEditor = false;
            this.grilleVue.OptionsView.ColumnAutoWidth = false;
            this.grilleVue.OptionsView.ShowAutoFilterRow = true;
            this.grilleVue.OptionsView.ShowFooter = true;
            this.grilleVue.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.Caption = "ID";
            this.colId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colId.FieldName = "Rang";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowFocus = false;
            this.colId.OptionsColumn.FixedWidth = true;
            this.colId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Rang", "{0:n0}")});
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 59;
            // 
            // refComumn
            // 
            this.refComumn.AppearanceHeader.Options.UseTextOptions = true;
            this.refComumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.refComumn.Caption = "REFERENCE";
            this.refComumn.FieldName = "Info";
            this.refComumn.Name = "refComumn";
            this.refComumn.OptionsColumn.AllowFocus = false;
            this.refComumn.OptionsColumn.AllowSize = false;
            this.refComumn.Visible = true;
            this.refComumn.VisibleIndex = 2;
            this.refComumn.Width = 297;
            // 
            // colEntre
            // 
            this.colEntre.AppearanceHeader.Options.UseTextOptions = true;
            this.colEntre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEntre.Caption = "ENTREE";
            this.colEntre.DisplayFormat.FormatString = "n0";
            this.colEntre.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEntre.FieldName = "QEntre";
            this.colEntre.Name = "colEntre";
            this.colEntre.OptionsColumn.AllowFocus = false;
            this.colEntre.OptionsColumn.FixedWidth = true;
            this.colEntre.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QEntre", "{0:n0}")});
            this.colEntre.Visible = true;
            this.colEntre.VisibleIndex = 4;
            this.colEntre.Width = 90;
            // 
            // colheure
            // 
            this.colheure.AppearanceCell.Options.UseTextOptions = true;
            this.colheure.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colheure.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colheure.AppearanceHeader.Options.UseTextOptions = true;
            this.colheure.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colheure.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colheure.Caption = "HEURE";
            this.colheure.DisplayFormat.FormatString = "HH:mm";
            this.colheure.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colheure.FieldName = "DATY";
            this.colheure.Name = "colheure";
            this.colheure.OptionsColumn.AllowFocus = false;
            this.colheure.Visible = true;
            this.colheure.VisibleIndex = 3;
            // 
            // XtraMag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 591);
            this.Controls.Add(this.grillage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "XtraMag";
            this.Text = "DETAILS";
            ((System.ComponentModel.ISupportInitialize)(this.grillage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleVue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn ClientColumn;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colOper;
        private DevExpress.XtraGrid.GridControl grillage;
        private DevExpress.XtraGrid.Views.Grid.GridView grilleVue;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn refComumn;
        private DevExpress.XtraGrid.Columns.GridColumn colEntre;
        private DevExpress.XtraGrid.Columns.GridColumn colheure;
    }
}