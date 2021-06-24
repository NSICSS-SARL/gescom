namespace gescom.create.Views
{
    partial class XtraDispatch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraDispatch));
            this.fermer = new DevExpress.XtraEditors.SimpleButton();
            this.imprimer = new DevExpress.XtraEditors.SimpleButton();
            this.colRend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMont = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesig = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTerm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.myNum = new DevExpress.XtraEditors.LabelControl();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grilleVue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cocol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grillage = new DevExpress.XtraGrid.GridControl();
            this.clicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.détaillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.grilleVue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillage)).BeginInit();
            this.clicDroit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fermer
            // 
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fermer.Location = new System.Drawing.Point(1247, 0);
            this.fermer.LookAndFeel.SkinName = "Office 2013";
            this.fermer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 7;
            this.fermer.Text = "&Fermer";
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // imprimer
            // 
            this.imprimer.Enabled = false;
            this.imprimer.Location = new System.Drawing.Point(1163, 0);
            this.imprimer.LookAndFeel.SkinName = "Office 2013";
            this.imprimer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(75, 23);
            this.imprimer.TabIndex = 4;
            this.imprimer.Text = "Im&primer";
            // 
            // colRend
            // 
            this.colRend.AppearanceHeader.Options.UseTextOptions = true;
            this.colRend.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRend.Caption = "CA TAXABLE";
            this.colRend.DisplayFormat.FormatString = "n0";
            this.colRend.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRend.FieldName = "Taxable";
            this.colRend.Name = "colRend";
            this.colRend.OptionsColumn.AllowFocus = false;
            this.colRend.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Taxable", "{0:n0}")});
            this.colRend.Visible = true;
            this.colRend.VisibleIndex = 5;
            this.colRend.Width = 100;
            // 
            // colPerc
            // 
            this.colPerc.AppearanceHeader.Options.UseTextOptions = true;
            this.colPerc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPerc.Caption = "CA NON TAXABLE";
            this.colPerc.DisplayFormat.FormatString = "n0";
            this.colPerc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPerc.FieldName = "Exo";
            this.colPerc.Name = "colPerc";
            this.colPerc.OptionsColumn.AllowFocus = false;
            this.colPerc.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Exo", "{0:n0}")});
            this.colPerc.Visible = true;
            this.colPerc.VisibleIndex = 4;
            this.colPerc.Width = 100;
            // 
            // ColMont
            // 
            this.ColMont.AppearanceHeader.Options.UseTextOptions = true;
            this.ColMont.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColMont.Caption = "TOTAL";
            this.ColMont.DisplayFormat.FormatString = "n0";
            this.ColMont.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColMont.FieldName = "Total";
            this.ColMont.Name = "ColMont";
            this.ColMont.OptionsColumn.AllowFocus = false;
            this.ColMont.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n0}")});
            this.ColMont.Visible = true;
            this.ColMont.VisibleIndex = 6;
            this.ColMont.Width = 100;
            // 
            // colDesig
            // 
            this.colDesig.AppearanceHeader.Options.UseTextOptions = true;
            this.colDesig.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDesig.Caption = "NOMS";
            this.colDesig.FieldName = "Nom";
            this.colDesig.Name = "colDesig";
            this.colDesig.Visible = true;
            this.colDesig.VisibleIndex = 2;
            this.colDesig.Width = 258;
            // 
            // colTerm
            // 
            this.colTerm.AppearanceHeader.Options.UseTextOptions = true;
            this.colTerm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTerm.Caption = "ADRESSE";
            this.colTerm.FieldName = "Adresse";
            this.colTerm.Name = "colTerm";
            this.colTerm.OptionsColumn.AllowFocus = false;
            this.colTerm.Visible = true;
            this.colTerm.VisibleIndex = 3;
            this.colTerm.Width = 226;
            // 
            // myNum
            // 
            this.myNum.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.myNum.Location = new System.Drawing.Point(594, 15);
            this.myNum.Name = "myNum";
            this.myNum.Size = new System.Drawing.Size(6, 13);
            this.myNum.TabIndex = 6;
            this.myNum.Text = "0";
            // 
            // colNom
            // 
            this.colNom.AppearanceHeader.Options.UseTextOptions = true;
            this.colNom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNom.Caption = "REFERENCE";
            this.colNom.FieldName = "Reference";
            this.colNom.Name = "colNom";
            this.colNom.OptionsColumn.AllowFocus = false;
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 1;
            this.colNom.Width = 229;
            // 
            // grilleVue
            // 
            this.grilleVue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNom,
            this.colTerm,
            this.colDesig,
            this.ColMont,
            this.colPerc,
            this.colRend,
            this.colMax,
            this.colMol,
            this.cocol});
            this.grilleVue.GridControl = this.grillage;
            this.grilleVue.Name = "grilleVue";
            this.grilleVue.OptionsFilter.AllowFilterEditor = false;
            this.grilleVue.OptionsFind.AlwaysVisible = true;
            this.grilleVue.OptionsFind.FindNullPrompt = "";
            this.grilleVue.OptionsView.ColumnAutoWidth = false;
            this.grilleVue.OptionsView.ShowAutoFilterRow = true;
            this.grilleVue.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grilleVue.OptionsView.ShowFooter = true;
            this.grilleVue.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.Caption = "ID";
            this.colId.DisplayFormat.FormatString = "n0";
            this.colId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowFocus = false;
            this.colId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 72;
            // 
            // colMax
            // 
            this.colMax.AppearanceHeader.Options.UseTextOptions = true;
            this.colMax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMax.Caption = "TAXABLE";
            this.colMax.FieldName = "IsTaxable";
            this.colMax.Name = "colMax";
            this.colMax.OptionsColumn.AllowEdit = false;
            this.colMax.Visible = true;
            this.colMax.VisibleIndex = 8;
            this.colMax.Width = 62;
            // 
            // colMol
            // 
            this.colMol.AppearanceHeader.Options.UseTextOptions = true;
            this.colMol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMol.Caption = "FORMEL";
            this.colMol.FieldName = "IsFormel";
            this.colMol.Name = "colMol";
            this.colMol.OptionsColumn.AllowEdit = false;
            this.colMol.Visible = true;
            this.colMol.VisibleIndex = 9;
            this.colMol.Width = 60;
            // 
            // cocol
            // 
            this.cocol.AppearanceHeader.Options.UseTextOptions = true;
            this.cocol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cocol.Caption = "MARGE BRUTE";
            this.cocol.DisplayFormat.FormatString = "n0";
            this.cocol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cocol.FieldName = "Profit";
            this.cocol.Name = "cocol";
            this.cocol.OptionsColumn.AllowFocus = false;
            this.cocol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Profit", "{0:n0}")});
            this.cocol.Visible = true;
            this.cocol.VisibleIndex = 7;
            this.cocol.Width = 100;
            // 
            // grillage
            // 
            this.grillage.ContextMenuStrip = this.clicDroit;
            this.grillage.Cursor = System.Windows.Forms.Cursors.Default;
            this.grillage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grillage.Location = new System.Drawing.Point(0, 0);
            this.grillage.MainView = this.grilleVue;
            this.grillage.Name = "grillage";
            this.grillage.Size = new System.Drawing.Size(1348, 490);
            this.grillage.TabIndex = 0;
            this.grillage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grilleVue});
            this.grillage.DoubleClick += new System.EventHandler(this.grillage_DoubleClick);
            // 
            // clicDroit
            // 
            this.clicDroit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.détaillerToolStripMenuItem});
            this.clicDroit.Name = "clicDroit";
            this.clicDroit.Size = new System.Drawing.Size(105, 26);
            // 
            // détaillerToolStripMenuItem
            // 
            this.détaillerToolStripMenuItem.Name = "détaillerToolStripMenuItem";
            this.détaillerToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.détaillerToolStripMenuItem.Text = "&Filtrer";
            this.détaillerToolStripMenuItem.Click += new System.EventHandler(this.détaillerToolStripMenuItem_Click);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.IsSplitterFixed = true;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.grillage);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1367, 490);
            this.splitContainerControl2.SplitterPosition = 1348;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.fermer);
            this.splitContainerControl1.Panel2.Controls.Add(this.myNum);
            this.splitContainerControl1.Panel2.Controls.Add(this.imprimer);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1367, 531);
            this.splitContainerControl1.SplitterPosition = 490;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // XtraDispatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fermer;
            this.ClientSize = new System.Drawing.Size(1367, 531);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraDispatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTILATION CA";
            this.Activated += new System.EventHandler(this.XtraDispatch_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.grilleVue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillage)).EndInit();
            this.clicDroit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton fermer;
        private DevExpress.XtraEditors.SimpleButton imprimer;
        private DevExpress.XtraGrid.Columns.GridColumn colRend;
        private DevExpress.XtraGrid.Columns.GridColumn colPerc;
        private DevExpress.XtraGrid.Columns.GridColumn ColMont;
        private DevExpress.XtraGrid.Columns.GridColumn colDesig;
        private DevExpress.XtraGrid.Columns.GridColumn colTerm;
        private DevExpress.XtraEditors.LabelControl myNum;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Views.Grid.GridView grilleVue;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.GridControl grillage;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colMax;
        private DevExpress.XtraGrid.Columns.GridColumn colMol;
        private DevExpress.XtraGrid.Columns.GridColumn cocol;
        private System.Windows.Forms.ContextMenuStrip clicDroit;
        private System.Windows.Forms.ToolStripMenuItem détaillerToolStripMenuItem;
    }
}