namespace gescom.create.Views
{
    partial class XtraDeclaration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraDeclaration));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.grillage = new DevExpress.XtraGrid.GridControl();
            this.clicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.détaillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grilleVue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesig = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTerm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMont = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaux = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.myNum = new DevExpress.XtraEditors.LabelControl();
            this.fermer = new DevExpress.XtraEditors.SimpleButton();
            this.imprimer = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillage)).BeginInit();
            this.clicDroit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilleVue)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.grillage);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.myNum);
            this.splitContainerControl1.Panel2.Controls.Add(this.fermer);
            this.splitContainerControl1.Panel2.Controls.Add(this.imprimer);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(871, 531);
            this.splitContainerControl1.SplitterPosition = 487;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // grillage
            // 
            this.grillage.ContextMenuStrip = this.clicDroit;
            this.grillage.Cursor = System.Windows.Forms.Cursors.Default;
            this.grillage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grillage.Location = new System.Drawing.Point(0, 0);
            this.grillage.MainView = this.grilleVue;
            this.grillage.Name = "grillage";
            this.grillage.Size = new System.Drawing.Size(871, 487);
            this.grillage.TabIndex = 1;
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
            // grilleVue
            // 
            this.grilleVue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNom,
            this.colDesig,
            this.colTerm,
            this.ColMont,
            this.colTaux,
            this.colPerc,
            this.colRend});
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
            this.colId.OptionsColumn.FixedWidth = true;
            this.colId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 70;
            // 
            // colNom
            // 
            this.colNom.AppearanceHeader.Options.UseTextOptions = true;
            this.colNom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNom.Caption = "DATE";
            this.colNom.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNom.FieldName = "D2";
            this.colNom.Name = "colNom";
            this.colNom.OptionsColumn.AllowFocus = false;
            this.colNom.OptionsColumn.FixedWidth = true;
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 1;
            this.colNom.Width = 80;
            // 
            // colDesig
            // 
            this.colDesig.AppearanceHeader.Options.UseTextOptions = true;
            this.colDesig.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDesig.Caption = "CA TAXABLE";
            this.colDesig.DisplayFormat.FormatString = "n0";
            this.colDesig.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDesig.FieldName = "VenteTaxable";
            this.colDesig.Name = "colDesig";
            this.colDesig.OptionsColumn.AllowFocus = false;
            this.colDesig.OptionsColumn.FixedWidth = true;
            this.colDesig.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VenteTaxable", "{0:n0}")});
            this.colDesig.Visible = true;
            this.colDesig.VisibleIndex = 2;
            this.colDesig.Width = 120;
            // 
            // colTerm
            // 
            this.colTerm.AppearanceHeader.Options.UseTextOptions = true;
            this.colTerm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTerm.Caption = "CA NON TAXABLE";
            this.colTerm.DisplayFormat.FormatString = "n0";
            this.colTerm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTerm.FieldName = "VenteExo";
            this.colTerm.Name = "colTerm";
            this.colTerm.OptionsColumn.AllowFocus = false;
            this.colTerm.OptionsColumn.FixedWidth = true;
            this.colTerm.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VenteExo", "{0:n0}")});
            this.colTerm.Visible = true;
            this.colTerm.VisibleIndex = 3;
            this.colTerm.Width = 120;
            // 
            // ColMont
            // 
            this.ColMont.AppearanceHeader.Options.UseTextOptions = true;
            this.ColMont.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColMont.Caption = "CA TOTAL";
            this.ColMont.DisplayFormat.FormatString = "n0";
            this.ColMont.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColMont.FieldName = "VenteTotal";
            this.ColMont.Name = "ColMont";
            this.ColMont.OptionsColumn.AllowFocus = false;
            this.ColMont.OptionsColumn.FixedWidth = true;
            this.ColMont.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VenteTotal", "{0:n0}")});
            this.ColMont.Visible = true;
            this.ColMont.VisibleIndex = 4;
            this.ColMont.Width = 120;
            // 
            // colTaux
            // 
            this.colTaux.AppearanceCell.Options.UseTextOptions = true;
            this.colTaux.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTaux.AppearanceHeader.Options.UseTextOptions = true;
            this.colTaux.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTaux.Caption = "TAUX";
            this.colTaux.DisplayFormat.FormatString = "n0";
            this.colTaux.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTaux.FieldName = "Taux";
            this.colTaux.Name = "colTaux";
            this.colTaux.OptionsColumn.AllowFocus = false;
            this.colTaux.OptionsColumn.FixedWidth = true;
            this.colTaux.Visible = true;
            this.colTaux.VisibleIndex = 5;
            this.colTaux.Width = 80;
            // 
            // colPerc
            // 
            this.colPerc.AppearanceHeader.Options.UseTextOptions = true;
            this.colPerc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPerc.Caption = "TVA COLLECTEE";
            this.colPerc.DisplayFormat.FormatString = "n0";
            this.colPerc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPerc.FieldName = "Collecte";
            this.colPerc.Name = "colPerc";
            this.colPerc.OptionsColumn.AllowFocus = false;
            this.colPerc.OptionsColumn.FixedWidth = true;
            this.colPerc.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Collecte", "{0:n0}")});
            this.colPerc.Visible = true;
            this.colPerc.VisibleIndex = 6;
            this.colPerc.Width = 120;
            // 
            // colRend
            // 
            this.colRend.AppearanceHeader.Options.UseTextOptions = true;
            this.colRend.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRend.Caption = "TVA DEDUCTIBLE";
            this.colRend.DisplayFormat.FormatString = "n0";
            this.colRend.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRend.FieldName = "Deductible";
            this.colRend.Name = "colRend";
            this.colRend.OptionsColumn.AllowFocus = false;
            this.colRend.OptionsColumn.FixedWidth = true;
            this.colRend.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Deductible", "{0:n0}")});
            this.colRend.Visible = true;
            this.colRend.VisibleIndex = 7;
            this.colRend.Width = 120;
            // 
            // myNum
            // 
            this.myNum.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.myNum.Location = new System.Drawing.Point(584, 9);
            this.myNum.Name = "myNum";
            this.myNum.Size = new System.Drawing.Size(6, 13);
            this.myNum.TabIndex = 11;
            this.myNum.Text = "0";
            // 
            // fermer
            // 
            this.fermer.Location = new System.Drawing.Point(774, 4);
            this.fermer.LookAndFeel.SkinName = "Office 2013";
            this.fermer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 9;
            this.fermer.Text = "&Fermer";
            // 
            // imprimer
            // 
            this.imprimer.Enabled = false;
            this.imprimer.Location = new System.Drawing.Point(690, 5);
            this.imprimer.LookAndFeel.SkinName = "Office 2013";
            this.imprimer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(75, 23);
            this.imprimer.TabIndex = 8;
            this.imprimer.Text = "Im&primer";
            // 
            // XtraDeclaration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 531);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraDeclaration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DECLARATION";
            this.Activated += new System.EventHandler(this.XtraDeclaration_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillage)).EndInit();
            this.clicDroit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilleVue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton fermer;
        private DevExpress.XtraEditors.SimpleButton imprimer;
        private DevExpress.XtraGrid.GridControl grillage;
        private DevExpress.XtraGrid.Views.Grid.GridView grilleVue;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn colTerm;
        private DevExpress.XtraGrid.Columns.GridColumn colDesig;
        private DevExpress.XtraGrid.Columns.GridColumn ColMont;
        private DevExpress.XtraGrid.Columns.GridColumn colPerc;
        private DevExpress.XtraGrid.Columns.GridColumn colRend;
        private DevExpress.XtraEditors.LabelControl myNum;
        private System.Windows.Forms.ContextMenuStrip clicDroit;
        private System.Windows.Forms.ToolStripMenuItem détaillerToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colTaux;
    }
}