namespace gescom.create.Views
{
    partial class XtraDiary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraDiary));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.grillage = new DevExpress.XtraGrid.GridControl();
            this.clicDroit = new System.Windows.Forms.ContextMenuStrip();
            this.détaillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grilleVue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTache = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fermer = new DevExpress.XtraEditors.SimpleButton();
            this.imprimer = new DevExpress.XtraEditors.SimpleButton();
            this.myNum = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.fermer);
            this.splitContainerControl1.Panel2.Controls.Add(this.imprimer);
            this.splitContainerControl1.Panel2.Controls.Add(this.myNum);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(876, 496);
            this.splitContainerControl1.SplitterPosition = 448;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
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
            this.splitContainerControl2.Size = new System.Drawing.Size(876, 448);
            this.splitContainerControl2.SplitterPosition = 858;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // grillage
            // 
            this.grillage.ContextMenuStrip = this.clicDroit;
            this.grillage.Cursor = System.Windows.Forms.Cursors.Default;
            this.grillage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grillage.Location = new System.Drawing.Point(0, 0);
            this.grillage.MainView = this.grilleVue;
            this.grillage.Name = "grillage";
            this.grillage.Size = new System.Drawing.Size(858, 448);
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
            // grilleVue
            // 
            this.grilleVue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDate,
            this.colTache,
            this.colNom,
            this.colMontant});
            this.grilleVue.GridControl = this.grillage;
            this.grilleVue.Name = "grilleVue";
            this.grilleVue.OptionsFilter.AllowFilterEditor = false;
            this.grilleVue.OptionsFind.AlwaysVisible = true;
            this.grilleVue.OptionsFind.FindNullPrompt = "";
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
            this.colId.DisplayFormat.FormatString = "n0";
            this.colId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowFocus = false;
            this.colId.OptionsColumn.AllowSize = false;
            this.colId.OptionsColumn.FixedWidth = true;
            this.colId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", "{0:n0}")});
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 78;
            // 
            // colDate
            // 
            this.colDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate.Caption = "REFERENCE";
            this.colDate.FieldName = "Info";
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.AllowFocus = false;
            this.colDate.OptionsColumn.AllowSize = false;
            this.colDate.OptionsColumn.FixedWidth = true;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 2;
            this.colDate.Width = 244;
            // 
            // colTache
            // 
            this.colTache.AppearanceCell.Options.UseTextOptions = true;
            this.colTache.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTache.AppearanceHeader.Options.UseTextOptions = true;
            this.colTache.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTache.Caption = "TACHE";
            this.colTache.FieldName = "Tache";
            this.colTache.Name = "colTache";
            this.colTache.OptionsColumn.AllowFocus = false;
            this.colTache.OptionsColumn.AllowSize = false;
            this.colTache.Visible = true;
            this.colTache.VisibleIndex = 1;
            this.colTache.Width = 101;
            // 
            // colNom
            // 
            this.colNom.AppearanceHeader.Options.UseTextOptions = true;
            this.colNom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNom.Caption = "NOMS";
            this.colNom.FieldName = "PersonName";
            this.colNom.Name = "colNom";
            this.colNom.OptionsColumn.AllowFocus = false;
            this.colNom.OptionsColumn.AllowSize = false;
            this.colNom.OptionsColumn.FixedWidth = true;
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 3;
            this.colNom.Width = 281;
            // 
            // colMontant
            // 
            this.colMontant.AppearanceHeader.Options.UseTextOptions = true;
            this.colMontant.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMontant.Caption = "MONTANT";
            this.colMontant.DisplayFormat.FormatString = "n0";
            this.colMontant.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontant.FieldName = "Montant";
            this.colMontant.Name = "colMontant";
            this.colMontant.OptionsColumn.AllowFocus = false;
            this.colMontant.OptionsColumn.AllowSize = false;
            this.colMontant.OptionsColumn.FixedWidth = true;
            this.colMontant.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Montant", "{0:n0}")});
            this.colMontant.Visible = true;
            this.colMontant.VisibleIndex = 4;
            this.colMontant.Width = 117;
            // 
            // fermer
            // 
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fermer.Location = new System.Drawing.Point(762, 1);
            this.fermer.LookAndFeel.SkinName = "Office 2013";
            this.fermer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 26);
            this.fermer.TabIndex = 4;
            this.fermer.Text = "&Fermer";
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // imprimer
            // 
            this.imprimer.Location = new System.Drawing.Point(676, 1);
            this.imprimer.LookAndFeel.SkinName = "Office 2013";
            this.imprimer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(75, 26);
            this.imprimer.TabIndex = 3;
            this.imprimer.Text = "Im&primer";
            this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
            // 
            // myNum
            // 
            this.myNum.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.myNum.Location = new System.Drawing.Point(28, 9);
            this.myNum.Name = "myNum";
            this.myNum.Size = new System.Drawing.Size(6, 13);
            this.myNum.TabIndex = 1;
            this.myNum.Text = "0";
            // 
            // XtraDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fermer;
            this.ClientSize = new System.Drawing.Size(876, 496);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraDiary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOURNALS";
            this.Activated += new System.EventHandler(this.XtraDiary_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillage)).EndInit();
            this.clicDroit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilleVue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl grillage;
        private DevExpress.XtraGrid.Views.Grid.GridView grilleVue;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTache;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn colMontant;
        private DevExpress.XtraEditors.LabelControl myNum;
        private DevExpress.XtraEditors.SimpleButton imprimer;
        private System.Windows.Forms.ContextMenuStrip clicDroit;
        private System.Windows.Forms.ToolStripMenuItem détaillerToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton fermer;
    }
}