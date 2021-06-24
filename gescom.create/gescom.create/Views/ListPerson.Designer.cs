namespace gescom.create.Views
{
    partial class ListPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPerson));
            this.conteneur = new DevExpress.XtraEditors.SplitContainerControl();
            this.diviseurControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.personGrid = new DevExpress.XtraGrid.GridControl();
            this.detailStrip = new System.Windows.Forms.ContextMenuStrip();
            this.détailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.règlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVille = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FML = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClasse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imprimer = new DevExpress.XtraEditors.SimpleButton();
            this.numero = new DevExpress.XtraEditors.LabelControl();
            this.fermer = new DevExpress.XtraEditors.SimpleButton();
            this.nouveau = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.conteneur)).BeginInit();
            this.conteneur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diviseurControl)).BeginInit();
            this.diviseurControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personGrid)).BeginInit();
            this.detailStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personView)).BeginInit();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteneur.Horizontal = false;
            this.conteneur.IsSplitterFixed = true;
            this.conteneur.Location = new System.Drawing.Point(0, 0);
            this.conteneur.Name = "conteneur";
            this.conteneur.Panel1.Controls.Add(this.diviseurControl);
            this.conteneur.Panel1.Text = "Panel1";
            this.conteneur.Panel2.Controls.Add(this.imprimer);
            this.conteneur.Panel2.Controls.Add(this.numero);
            this.conteneur.Panel2.Controls.Add(this.fermer);
            this.conteneur.Panel2.Controls.Add(this.nouveau);
            this.conteneur.Panel2.Text = "Panel2";
            this.conteneur.Size = new System.Drawing.Size(1235, 405);
            this.conteneur.SplitterPosition = 359;
            this.conteneur.TabIndex = 1;
            this.conteneur.Text = "splitContainerControl1";
            // 
            // diviseurControl
            // 
            this.diviseurControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diviseurControl.IsSplitterFixed = true;
            this.diviseurControl.Location = new System.Drawing.Point(0, 0);
            this.diviseurControl.Name = "diviseurControl";
            this.diviseurControl.Panel1.Controls.Add(this.personGrid);
            this.diviseurControl.Panel1.Text = "Panel1";
            this.diviseurControl.Panel2.Text = "Panel2";
            this.diviseurControl.Size = new System.Drawing.Size(1235, 359);
            this.diviseurControl.SplitterPosition = 1223;
            this.diviseurControl.TabIndex = 0;
            this.diviseurControl.Text = "splitContainerControl1";
            // 
            // personGrid
            // 
            this.personGrid.ContextMenuStrip = this.detailStrip;
            this.personGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.personGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personGrid.Location = new System.Drawing.Point(0, 0);
            this.personGrid.LookAndFeel.SkinName = "Office 2013";
            this.personGrid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.personGrid.MainView = this.personView;
            this.personGrid.Name = "personGrid";
            this.personGrid.Size = new System.Drawing.Size(1223, 359);
            this.personGrid.TabIndex = 1;
            this.personGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.personView});
            this.personGrid.DoubleClick += new System.EventHandler(this.personGrid_DoubleClick);
            // 
            // detailStrip
            // 
            this.detailStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.détailToolStripMenuItem,
            this.règlerToolStripMenuItem});
            this.detailStrip.Name = "detailStrip";
            this.detailStrip.Size = new System.Drawing.Size(108, 48);
            // 
            // détailToolStripMenuItem
            // 
            this.détailToolStripMenuItem.Name = "détailToolStripMenuItem";
            this.détailToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.détailToolStripMenuItem.Text = "&Détail";
            this.détailToolStripMenuItem.Click += new System.EventHandler(this.détailToolStripMenuItem_Click);
            // 
            // règlerToolStripMenuItem
            // 
            this.règlerToolStripMenuItem.Name = "règlerToolStripMenuItem";
            this.règlerToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.règlerToolStripMenuItem.Text = "&Règler";
            this.règlerToolStripMenuItem.Click += new System.EventHandler(this.règlerToolStripMenuItem_Click);
            // 
            // personView
            // 
            this.personView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNom,
            this.colAdr,
            this.colVille,
            this.colTel,
            this.colGros,
            this.FML,
            this.colLocal,
            this.colClasse});
            this.personView.GridControl = this.personGrid;
            this.personView.Name = "personView";
            this.personView.OptionsFilter.AllowFilterEditor = false;
            this.personView.OptionsFind.AlwaysVisible = true;
            this.personView.OptionsFind.FindNullPrompt = "";
            this.personView.OptionsView.ShowAutoFilterRow = true;
            this.personView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.personView.OptionsView.ShowFooter = true;
            this.personView.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowFocus = false;
            this.colId.OptionsColumn.FixedWidth = true;
            this.colId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 86;
            // 
            // colNom
            // 
            this.colNom.AppearanceHeader.Options.UseTextOptions = true;
            this.colNom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNom.Caption = "NOMS OU RAISON SOCIALE";
            this.colNom.FieldName = "Nom";
            this.colNom.Name = "colNom";
            this.colNom.OptionsColumn.AllowFocus = false;
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 2;
            this.colNom.Width = 245;
            // 
            // colAdr
            // 
            this.colAdr.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdr.Caption = "ADRESSE";
            this.colAdr.FieldName = "Adresse";
            this.colAdr.Name = "colAdr";
            this.colAdr.OptionsColumn.AllowFocus = false;
            this.colAdr.OptionsColumn.FixedWidth = true;
            this.colAdr.Visible = true;
            this.colAdr.VisibleIndex = 3;
            this.colAdr.Width = 212;
            // 
            // colVille
            // 
            this.colVille.AppearanceHeader.Options.UseTextOptions = true;
            this.colVille.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVille.Caption = "VILLE";
            this.colVille.FieldName = "Ville";
            this.colVille.Name = "colVille";
            this.colVille.OptionsColumn.AllowFocus = false;
            this.colVille.OptionsColumn.FixedWidth = true;
            this.colVille.Visible = true;
            this.colVille.VisibleIndex = 5;
            this.colVille.Width = 129;
            // 
            // colTel
            // 
            this.colTel.AppearanceHeader.Options.UseTextOptions = true;
            this.colTel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTel.Caption = "TELEPHONE";
            this.colTel.FieldName = "Tel1";
            this.colTel.Name = "colTel";
            this.colTel.OptionsColumn.AllowFocus = false;
            this.colTel.OptionsColumn.FixedWidth = true;
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 6;
            this.colTel.Width = 118;
            // 
            // colGros
            // 
            this.colGros.AppearanceHeader.Options.UseTextOptions = true;
            this.colGros.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGros.Caption = "TYPE";
            this.colGros.DisplayFormat.FormatString = "n0";
            this.colGros.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGros.FieldName = "LitteralType";
            this.colGros.Name = "colGros";
            this.colGros.OptionsColumn.AllowFocus = false;
            this.colGros.OptionsColumn.FixedWidth = true;
            this.colGros.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Prime", "{0:n0}")});
            this.colGros.Visible = true;
            this.colGros.VisibleIndex = 7;
            // 
            // FML
            // 
            this.FML.AppearanceHeader.Options.UseTextOptions = true;
            this.FML.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FML.Caption = "FORMEL";
            this.FML.FieldName = "IsFormel";
            this.FML.Name = "FML";
            this.FML.OptionsColumn.AllowFocus = false;
            this.FML.OptionsColumn.FixedWidth = true;
            this.FML.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.FML.Visible = true;
            this.FML.VisibleIndex = 8;
            this.FML.Width = 77;
            // 
            // colLocal
            // 
            this.colLocal.AppearanceHeader.Options.UseTextOptions = true;
            this.colLocal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLocal.Caption = "LOCALITE";
            this.colLocal.FieldName = "Localite";
            this.colLocal.Name = "colLocal";
            this.colLocal.OptionsColumn.AllowEdit = false;
            this.colLocal.OptionsColumn.AllowFocus = false;
            this.colLocal.OptionsColumn.FixedWidth = true;
            this.colLocal.Visible = true;
            this.colLocal.VisibleIndex = 4;
            // 
            // colClasse
            // 
            this.colClasse.AppearanceCell.Options.UseTextOptions = true;
            this.colClasse.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClasse.AppearanceHeader.Options.UseTextOptions = true;
            this.colClasse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClasse.Caption = "CLASSEUR";
            this.colClasse.FieldName = "Code";
            this.colClasse.Name = "colClasse";
            this.colClasse.OptionsColumn.AllowEdit = false;
            this.colClasse.OptionsColumn.AllowFocus = false;
            this.colClasse.OptionsColumn.FixedWidth = true;
            this.colClasse.Visible = true;
            this.colClasse.VisibleIndex = 1;
            // 
            // imprimer
            // 
            this.imprimer.Location = new System.Drawing.Point(932, 0);
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(75, 23);
            this.imprimer.TabIndex = 4;
            this.imprimer.Text = "Im&primer";
            this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
            // 
            // numero
            // 
            this.numero.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.numero.Location = new System.Drawing.Point(87, 5);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(6, 13);
            this.numero.TabIndex = 3;
            this.numero.Text = "0";
            // 
            // fermer
            // 
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fermer.Location = new System.Drawing.Point(1099, 0);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 1;
            this.fermer.Text = "&Fermer";
            // 
            // nouveau
            // 
            this.nouveau.Location = new System.Drawing.Point(1016, 0);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(75, 23);
            this.nouveau.TabIndex = 0;
            this.nouveau.Text = "&Nouveau";
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // ListPerson
            // 
            this.AcceptButton = this.nouveau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fermer;
            this.ClientSize = new System.Drawing.Size(1235, 405);
            this.Controls.Add(this.conteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "ListPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListPerson";
            this.Activated += new System.EventHandler(this.ListPerson_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.conteneur)).EndInit();
            this.conteneur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diviseurControl)).EndInit();
            this.diviseurControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personGrid)).EndInit();
            this.detailStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl conteneur;
        private DevExpress.XtraEditors.SimpleButton fermer;
        private DevExpress.XtraEditors.SimpleButton nouveau;
        private DevExpress.XtraEditors.LabelControl numero;
        private DevExpress.XtraEditors.SplitContainerControl diviseurControl;
        private DevExpress.XtraGrid.GridControl personGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView personView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn colAdr;
        private DevExpress.XtraGrid.Columns.GridColumn colVille;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraEditors.SimpleButton imprimer;
        private System.Windows.Forms.ContextMenuStrip detailStrip;
        private System.Windows.Forms.ToolStripMenuItem détailToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colGros;
        private System.Windows.Forms.ToolStripMenuItem règlerToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn FML;
        private DevExpress.XtraGrid.Columns.GridColumn colLocal;
        private DevExpress.XtraGrid.Columns.GridColumn colClasse;
    }
}