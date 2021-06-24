namespace gescom.create.Views
{
    partial class ListGlobal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListGlobal));
            this.conteneur = new DevExpress.XtraEditors.SplitContainerControl();
            this.diviseurCentre = new DevExpress.XtraEditors.SplitContainerControl();
            this.globalGrid = new DevExpress.XtraGrid.GridControl();
            this.detailStrip = new System.Windows.Forms.ContextMenuStrip();
            this.détailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnique = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imprimer = new DevExpress.XtraEditors.SimpleButton();
            this.numero = new DevExpress.XtraEditors.LabelControl();
            this.fermer = new DevExpress.XtraEditors.SimpleButton();
            this.nouveau = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.conteneur)).BeginInit();
            this.conteneur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diviseurCentre)).BeginInit();
            this.diviseurCentre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalGrid)).BeginInit();
            this.detailStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalView)).BeginInit();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteneur.Horizontal = false;
            this.conteneur.IsSplitterFixed = true;
            this.conteneur.Location = new System.Drawing.Point(0, 0);
            this.conteneur.Name = "conteneur";
            this.conteneur.Panel1.Controls.Add(this.diviseurCentre);
            this.conteneur.Panel1.Text = "Panel1";
            this.conteneur.Panel2.Controls.Add(this.imprimer);
            this.conteneur.Panel2.Controls.Add(this.numero);
            this.conteneur.Panel2.Controls.Add(this.fermer);
            this.conteneur.Panel2.Controls.Add(this.nouveau);
            this.conteneur.Panel2.Text = "Panel2";
            this.conteneur.Size = new System.Drawing.Size(610, 687);
            this.conteneur.SplitterPosition = 645;
            this.conteneur.TabIndex = 0;
            this.conteneur.Text = "splitContainerControl1";
            // 
            // diviseurCentre
            // 
            this.diviseurCentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diviseurCentre.IsSplitterFixed = true;
            this.diviseurCentre.Location = new System.Drawing.Point(0, 0);
            this.diviseurCentre.Name = "diviseurCentre";
            this.diviseurCentre.Panel1.Controls.Add(this.globalGrid);
            this.diviseurCentre.Panel1.Text = "Panel1";
            this.diviseurCentre.Panel2.Text = "Panel2";
            this.diviseurCentre.Size = new System.Drawing.Size(610, 645);
            this.diviseurCentre.SplitterPosition = 594;
            this.diviseurCentre.TabIndex = 0;
            this.diviseurCentre.Text = "splitContainerControl1";
            // 
            // globalGrid
            // 
            this.globalGrid.ContextMenuStrip = this.detailStrip;
            this.globalGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.globalGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.globalGrid.Location = new System.Drawing.Point(0, 0);
            this.globalGrid.LookAndFeel.SkinName = "Office 2013";
            this.globalGrid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.globalGrid.MainView = this.globalView;
            this.globalGrid.Name = "globalGrid";
            this.globalGrid.Size = new System.Drawing.Size(594, 645);
            this.globalGrid.TabIndex = 2;
            this.globalGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.globalView});
            this.globalGrid.DoubleClick += new System.EventHandler(this.globalGrid_DoubleClick);
            // 
            // detailStrip
            // 
            this.detailStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.détailToolStripMenuItem});
            this.detailStrip.Name = "detailStrip";
            this.detailStrip.Size = new System.Drawing.Size(105, 26);
            // 
            // détailToolStripMenuItem
            // 
            this.détailToolStripMenuItem.Name = "détailToolStripMenuItem";
            this.détailToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.détailToolStripMenuItem.Text = "&Détail";
            this.détailToolStripMenuItem.Click += new System.EventHandler(this.détailToolStripMenuItem_Click);
            // 
            // globalView
            // 
            this.globalView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCode,
            this.colTitle,
            this.colUnique});
            this.globalView.GridControl = this.globalGrid;
            this.globalView.Name = "globalView";
            this.globalView.OptionsFilter.AllowFilterEditor = false;
            this.globalView.OptionsFind.AlwaysVisible = true;
            this.globalView.OptionsFind.FindNullPrompt = "";
            this.globalView.OptionsView.ColumnAutoWidth = false;
            this.globalView.OptionsView.ShowAutoFilterRow = true;
            this.globalView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.globalView.OptionsView.ShowFooter = true;
            this.globalView.OptionsView.ShowGroupPanel = false;
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
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", "{0:n0}")});
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 78;
            // 
            // colCode
            // 
            this.colCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCode.Caption = "CODE";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.FixedWidth = true;
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 180;
            // 
            // colTitle
            // 
            this.colTitle.AppearanceHeader.Options.UseTextOptions = true;
            this.colTitle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTitle.Caption = "NOM";
            this.colTitle.FieldName = "Nom";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 2;
            this.colTitle.Width = 216;
            // 
            // colUnique
            // 
            this.colUnique.AppearanceCell.Options.UseTextOptions = true;
            this.colUnique.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnique.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnique.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnique.Caption = "OCCUPATION";
            this.colUnique.FieldName = "Full";
            this.colUnique.Name = "colUnique";
            this.colUnique.OptionsColumn.AllowEdit = false;
            this.colUnique.OptionsColumn.AllowFocus = false;
            this.colUnique.Visible = true;
            this.colUnique.VisibleIndex = 3;
            this.colUnique.Width = 86;
            // 
            // imprimer
            // 
            this.imprimer.Location = new System.Drawing.Point(329, 0);
            this.imprimer.LookAndFeel.SkinName = "Office 2013";
            this.imprimer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(75, 23);
            this.imprimer.TabIndex = 3;
            this.imprimer.Text = "Im&primer";
            this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
            // 
            // numero
            // 
            this.numero.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.numero.Location = new System.Drawing.Point(66, 6);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(6, 13);
            this.numero.TabIndex = 2;
            this.numero.Text = "0";
            // 
            // fermer
            // 
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fermer.Location = new System.Drawing.Point(494, 0);
            this.fermer.LookAndFeel.SkinName = "Office 2013";
            this.fermer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 1;
            this.fermer.Text = "&Fermer";
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // nouveau
            // 
            this.nouveau.Location = new System.Drawing.Point(412, 0);
            this.nouveau.LookAndFeel.SkinName = "Office 2013";
            this.nouveau.LookAndFeel.UseDefaultLookAndFeel = false;
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(75, 23);
            this.nouveau.TabIndex = 0;
            this.nouveau.Text = "&Nouveau";
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // ListGlobal
            // 
            this.AcceptButton = this.nouveau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fermer;
            this.ClientSize = new System.Drawing.Size(610, 687);
            this.Controls.Add(this.conteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "ListGlobal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListGlobal";
            ((System.ComponentModel.ISupportInitialize)(this.conteneur)).EndInit();
            this.conteneur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diviseurCentre)).EndInit();
            this.diviseurCentre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.globalGrid)).EndInit();
            this.detailStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.globalView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl conteneur;
        private DevExpress.XtraEditors.SimpleButton nouveau;
        private DevExpress.XtraEditors.SimpleButton fermer;
        private DevExpress.XtraEditors.LabelControl numero;
        private DevExpress.XtraEditors.SplitContainerControl diviseurCentre;
        private DevExpress.XtraGrid.GridControl globalGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView globalView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraEditors.SimpleButton imprimer;
        private System.Windows.Forms.ContextMenuStrip detailStrip;
        private System.Windows.Forms.ToolStripMenuItem détailToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colUnique;

    }
}