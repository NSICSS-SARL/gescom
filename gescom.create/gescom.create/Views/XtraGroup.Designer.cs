namespace gescom.create.Views
{
    partial class XtraGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraGroup));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridActions = new DevExpress.XtraGrid.GridControl();
            this.clicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.observationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réferenceFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grilleView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fermer = new DevExpress.XtraEditors.SimpleButton();
            this.imprimer = new DevExpress.XtraEditors.SimpleButton();
            this.myNum = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridActions)).BeginInit();
            this.clicDroit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilleView)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.imprimer);
            this.splitContainerControl1.Panel2.Controls.Add(this.myNum);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1415, 422);
            this.splitContainerControl1.SplitterPosition = 381;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.IsSplitterFixed = true;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.gridActions);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1415, 381);
            this.splitContainerControl2.SplitterPosition = 1393;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // gridActions
            // 
            this.gridActions.ContextMenuStrip = this.clicDroit;
            this.gridActions.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridActions.Location = new System.Drawing.Point(0, 0);
            this.gridActions.LookAndFeel.SkinName = "Office 2013";
            this.gridActions.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridActions.MainView = this.grilleView;
            this.gridActions.Name = "gridActions";
            this.gridActions.Size = new System.Drawing.Size(1393, 381);
            this.gridActions.TabIndex = 2;
            this.gridActions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grilleView});
            this.gridActions.DoubleClick += new System.EventHandler(this.gridActions_DoubleClick);
            // 
            // clicDroit
            // 
            this.clicDroit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.observationToolStripMenuItem,
            this.réferenceFournisseurToolStripMenuItem,
            this.remarqueToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.clicDroit.Name = "clicDroit";
            this.clicDroit.Size = new System.Drawing.Size(189, 92);
            // 
            // observationToolStripMenuItem
            // 
            this.observationToolStripMenuItem.Name = "observationToolStripMenuItem";
            this.observationToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.observationToolStripMenuItem.Text = "&Observation";
            this.observationToolStripMenuItem.Click += new System.EventHandler(this.observationToolStripMenuItem_Click);
            // 
            // réferenceFournisseurToolStripMenuItem
            // 
            this.réferenceFournisseurToolStripMenuItem.Name = "réferenceFournisseurToolStripMenuItem";
            this.réferenceFournisseurToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.réferenceFournisseurToolStripMenuItem.Text = "&Réference fournisseur";
            this.réferenceFournisseurToolStripMenuItem.Click += new System.EventHandler(this.réferenceFournisseurToolStripMenuItem_Click);
            // 
            // remarqueToolStripMenuItem
            // 
            this.remarqueToolStripMenuItem.Name = "remarqueToolStripMenuItem";
            this.remarqueToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.remarqueToolStripMenuItem.Text = "Re&marque";
            this.remarqueToolStripMenuItem.Click += new System.EventHandler(this.remarqueToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.modifierToolStripMenuItem.Text = "Mo&difier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // grilleView
            // 
            this.grilleView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colName,
            this.colPrix,
            this.colStock,
            this.colEst,
            this.colPerv,
            this.colPref,
            this.colCa,
            this.colCv,
            this.colUnt});
            this.grilleView.GridControl = this.gridActions;
            this.grilleView.Name = "grilleView";
            this.grilleView.OptionsFilter.AllowFilterEditor = false;
            this.grilleView.OptionsView.ColumnAutoWidth = false;
            this.grilleView.OptionsView.ShowAutoFilterRow = true;
            this.grilleView.OptionsView.ShowFooter = true;
            this.grilleView.OptionsView.ShowGroupPanel = false;
            // 
            // colCode
            // 
            this.colCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCode.Caption = "CODE";
            this.colCode.DisplayFormat.FormatString = "n0";
            this.colCode.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCode.FieldName = "Fcode";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.AllowFocus = false;
            this.colCode.OptionsColumn.FixedWidth = true;
            this.colCode.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Fcode", "{0:n0}")});
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 68;
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.Caption = "DESIGNATION";
            this.colName.FieldName = "Nomvers";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.OptionsColumn.FixedWidth = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 396;
            // 
            // colPrix
            // 
            this.colPrix.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrix.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrix.Caption = "PRIX DETAIL";
            this.colPrix.DisplayFormat.FormatString = "n0";
            this.colPrix.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrix.FieldName = "PDetail";
            this.colPrix.Name = "colPrix";
            this.colPrix.OptionsColumn.AllowFocus = false;
            this.colPrix.OptionsColumn.FixedWidth = true;
            this.colPrix.Visible = true;
            this.colPrix.VisibleIndex = 2;
            this.colPrix.Width = 105;
            // 
            // colStock
            // 
            this.colStock.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock.Caption = "DISPONIBLE";
            this.colStock.DisplayFormat.FormatString = "n0";
            this.colStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colStock.FieldName = "QStock";
            this.colStock.Name = "colStock";
            this.colStock.OptionsColumn.AllowFocus = false;
            this.colStock.OptionsColumn.FixedWidth = true;
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 3;
            this.colStock.Width = 102;
            // 
            // colEst
            // 
            this.colEst.AppearanceHeader.Options.UseTextOptions = true;
            this.colEst.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEst.Caption = "QT ESTIME";
            this.colEst.DisplayFormat.FormatString = "n0";
            this.colEst.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEst.FieldName = "QEstime";
            this.colEst.Name = "colEst";
            this.colEst.OptionsColumn.AllowFocus = false;
            this.colEst.OptionsColumn.FixedWidth = true;
            this.colEst.Visible = true;
            this.colEst.VisibleIndex = 4;
            this.colEst.Width = 102;
            // 
            // colPerv
            // 
            this.colPerv.AppearanceHeader.Options.UseTextOptions = true;
            this.colPerv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPerv.Caption = "PRIX ESTIME";
            this.colPerv.DisplayFormat.FormatString = "n0";
            this.colPerv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPerv.FieldName = "PEstime";
            this.colPerv.Name = "colPerv";
            this.colPerv.OptionsColumn.AllowFocus = false;
            this.colPerv.OptionsColumn.FixedWidth = true;
            this.colPerv.Visible = true;
            this.colPerv.VisibleIndex = 5;
            this.colPerv.Width = 119;
            // 
            // colPref
            // 
            this.colPref.AppearanceHeader.Options.UseTextOptions = true;
            this.colPref.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPref.Caption = "PREFERENCE";
            this.colPref.FieldName = "Frs";
            this.colPref.Name = "colPref";
            this.colPref.OptionsColumn.AllowFocus = false;
            this.colPref.OptionsColumn.FixedWidth = true;
            this.colPref.Visible = true;
            this.colPref.VisibleIndex = 6;
            this.colPref.Width = 152;
            // 
            // colCa
            // 
            this.colCa.AppearanceHeader.Options.UseTextOptions = true;
            this.colCa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCa.Caption = "CUMUL ACHAT";
            this.colCa.DisplayFormat.FormatString = "n0";
            this.colCa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCa.FieldName = "Qachat";
            this.colCa.Name = "colCa";
            this.colCa.OptionsColumn.AllowFocus = false;
            this.colCa.OptionsColumn.FixedWidth = true;
            this.colCa.Visible = true;
            this.colCa.VisibleIndex = 7;
            this.colCa.Width = 118;
            // 
            // colCv
            // 
            this.colCv.AppearanceHeader.Options.UseTextOptions = true;
            this.colCv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCv.Caption = "CUMUL VENTE";
            this.colCv.DisplayFormat.FormatString = "n0";
            this.colCv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCv.FieldName = "Qvente";
            this.colCv.Name = "colCv";
            this.colCv.OptionsColumn.AllowFocus = false;
            this.colCv.OptionsColumn.FixedWidth = true;
            this.colCv.Visible = true;
            this.colCv.VisibleIndex = 8;
            this.colCv.Width = 113;
            // 
            // colUnt
            // 
            this.colUnt.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnt.Caption = "UNITE";
            this.colUnt.FieldName = "Unite";
            this.colUnt.Name = "colUnt";
            this.colUnt.OptionsColumn.AllowFocus = false;
            this.colUnt.OptionsColumn.FixedWidth = true;
            this.colUnt.Visible = true;
            this.colUnt.VisibleIndex = 9;
            this.colUnt.Width = 80;
            // 
            // fermer
            // 
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fermer.Enabled = false;
            this.fermer.Location = new System.Drawing.Point(1316, 0);
            this.fermer.LookAndFeel.SkinName = "Office 2013";
            this.fermer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 8;
            this.fermer.Text = "&Fermer";
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // imprimer
            // 
            this.imprimer.Enabled = false;
            this.imprimer.Location = new System.Drawing.Point(1228, 0);
            this.imprimer.LookAndFeel.SkinName = "Office 2013";
            this.imprimer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(75, 23);
            this.imprimer.TabIndex = 7;
            this.imprimer.Text = "Im&primer";
            this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
            // 
            // myNum
            // 
            this.myNum.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.myNum.Appearance.Options.UseForeColor = true;
            this.myNum.Location = new System.Drawing.Point(717, 13);
            this.myNum.Name = "myNum";
            this.myNum.Size = new System.Drawing.Size(6, 13);
            this.myNum.TabIndex = 6;
            this.myNum.Text = "0";
            // 
            // XtraGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fermer;
            this.ClientSize = new System.Drawing.Size(1415, 422);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGROUPEMENT";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridActions)).EndInit();
            this.clicDroit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilleView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl gridActions;
        private DevExpress.XtraGrid.Views.Grid.GridView grilleView;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrix;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colEst;
        private DevExpress.XtraGrid.Columns.GridColumn colPerv;
        private DevExpress.XtraGrid.Columns.GridColumn colPref;
        private DevExpress.XtraGrid.Columns.GridColumn colCa;
        private DevExpress.XtraGrid.Columns.GridColumn colCv;
        private DevExpress.XtraGrid.Columns.GridColumn colUnt;
        private DevExpress.XtraEditors.LabelControl myNum;
        private System.Windows.Forms.ContextMenuStrip clicDroit;
        private System.Windows.Forms.ToolStripMenuItem observationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réferenceFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remarqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton imprimer;
        private DevExpress.XtraEditors.SimpleButton fermer;
    }
}