namespace gescom.create.Views
{
    partial class XtraCaisse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraCaisse));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.grillage = new DevExpress.XtraGrid.GridControl();
            this.clicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.détaillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grilleVue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTerm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesig = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMont = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHour = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fermer = new DevExpress.XtraEditors.SimpleButton();
            this.myNum = new DevExpress.XtraEditors.LabelControl();
            this.imprimer = new DevExpress.XtraEditors.SimpleButton();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.myNum);
            this.splitContainerControl1.Panel2.Controls.Add(this.imprimer);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1450, 538);
            this.splitContainerControl1.SplitterPosition = 490;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.grillage);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1450, 490);
            this.splitContainerControl2.SplitterPosition = 1437;
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
            this.grillage.Size = new System.Drawing.Size(1437, 490);
            this.grillage.TabIndex = 0;
            this.grillage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grilleVue});
            this.grillage.DoubleClick += new System.EventHandler(this.grillage_DoubleClick);
            // 
            // clicDroit
            // 
            this.clicDroit.Enabled = false;
            this.clicDroit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.détaillerToolStripMenuItem,
            this.annulerToolStripMenuItem});
            this.clicDroit.Name = "clicDroit";
            this.clicDroit.Size = new System.Drawing.Size(117, 48);
            // 
            // détaillerToolStripMenuItem
            // 
            this.détaillerToolStripMenuItem.Enabled = false;
            this.détaillerToolStripMenuItem.Name = "détaillerToolStripMenuItem";
            this.détaillerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.détaillerToolStripMenuItem.Text = "&Filtrer";
            this.détaillerToolStripMenuItem.Click += new System.EventHandler(this.détaillerToolStripMenuItem_Click);
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Enabled = false;
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.annulerToolStripMenuItem.Text = "&Annuler";
            this.annulerToolStripMenuItem.Click += new System.EventHandler(this.annulerToolStripMenuItem_Click);
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
            this.colGate,
            this.gridHour});
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
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", "{0:n0}")});
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 68;
            // 
            // colNom
            // 
            this.colNom.AppearanceHeader.Options.UseTextOptions = true;
            this.colNom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNom.Caption = "OPERATEUR";
            this.colNom.FieldName = "Operateur";
            this.colNom.Name = "colNom";
            this.colNom.OptionsColumn.AllowFocus = false;
            this.colNom.OptionsColumn.FixedWidth = true;
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 3;
            this.colNom.Width = 192;
            // 
            // colTerm
            // 
            this.colTerm.AppearanceHeader.Options.UseTextOptions = true;
            this.colTerm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTerm.Caption = "CAISSIER(E)";
            this.colTerm.FieldName = "Caissier";
            this.colTerm.Name = "colTerm";
            this.colTerm.OptionsColumn.AllowFocus = false;
            this.colTerm.OptionsColumn.FixedWidth = true;
            this.colTerm.Visible = true;
            this.colTerm.VisibleIndex = 4;
            this.colTerm.Width = 178;
            // 
            // colDesig
            // 
            this.colDesig.AppearanceHeader.Options.UseTextOptions = true;
            this.colDesig.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDesig.Caption = "NOMS";
            this.colDesig.FieldName = "Nom";
            this.colDesig.Name = "colDesig";
            this.colDesig.OptionsColumn.AllowFocus = false;
            this.colDesig.OptionsColumn.FixedWidth = true;
            this.colDesig.Visible = true;
            this.colDesig.VisibleIndex = 5;
            this.colDesig.Width = 292;
            // 
            // ColMont
            // 
            this.ColMont.AppearanceHeader.Options.UseTextOptions = true;
            this.ColMont.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColMont.Caption = "MONTANT";
            this.ColMont.DisplayFormat.FormatString = "n0";
            this.ColMont.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColMont.FieldName = "Montant";
            this.ColMont.Name = "ColMont";
            this.ColMont.OptionsColumn.AllowFocus = false;
            this.ColMont.OptionsColumn.FixedWidth = true;
            this.ColMont.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Montant", "VENTE={0:n0}")});
            this.ColMont.Visible = true;
            this.ColMont.VisibleIndex = 7;
            this.ColMont.Width = 165;
            // 
            // colPerc
            // 
            this.colPerc.AppearanceHeader.Options.UseTextOptions = true;
            this.colPerc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPerc.Caption = "PERCU";
            this.colPerc.DisplayFormat.FormatString = "n0";
            this.colPerc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPerc.FieldName = "Percu";
            this.colPerc.Name = "colPerc";
            this.colPerc.OptionsColumn.AllowFocus = false;
            this.colPerc.OptionsColumn.FixedWidth = true;
            this.colPerc.Visible = true;
            this.colPerc.VisibleIndex = 6;
            this.colPerc.Width = 181;
            // 
            // colRend
            // 
            this.colRend.AppearanceHeader.Options.UseTextOptions = true;
            this.colRend.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRend.Caption = "RENDU";
            this.colRend.DisplayFormat.FormatString = "n0";
            this.colRend.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRend.FieldName = "Rendu";
            this.colRend.Name = "colRend";
            this.colRend.OptionsColumn.AllowFocus = false;
            this.colRend.OptionsColumn.FixedWidth = true;
            this.colRend.Visible = true;
            this.colRend.VisibleIndex = 8;
            this.colRend.Width = 140;
            // 
            // colGate
            // 
            this.colGate.AppearanceHeader.Options.UseTextOptions = true;
            this.colGate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGate.Caption = "DATE";
            this.colGate.FieldName = "Paiement";
            this.colGate.Name = "colGate";
            this.colGate.OptionsColumn.AllowFocus = false;
            this.colGate.Visible = true;
            this.colGate.VisibleIndex = 1;
            this.colGate.Width = 104;
            // 
            // gridHour
            // 
            this.gridHour.AppearanceCell.Options.UseTextOptions = true;
            this.gridHour.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridHour.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridHour.AppearanceHeader.Options.UseTextOptions = true;
            this.gridHour.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridHour.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridHour.Caption = "HEURE";
            this.gridHour.DisplayFormat.FormatString = "t";
            this.gridHour.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridHour.FieldName = "Heure";
            this.gridHour.Name = "gridHour";
            this.gridHour.OptionsColumn.AllowFocus = false;
            this.gridHour.Visible = true;
            this.gridHour.VisibleIndex = 2;
            this.gridHour.Width = 79;
            // 
            // fermer
            // 
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fermer.Location = new System.Drawing.Point(1085, 0);
            this.fermer.LookAndFeel.SkinName = "Office 2013";
            this.fermer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 7;
            this.fermer.Text = "&Fermer";
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // myNum
            // 
            this.myNum.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.myNum.Appearance.Options.UseForeColor = true;
            this.myNum.Location = new System.Drawing.Point(594, 15);
            this.myNum.Name = "myNum";
            this.myNum.Size = new System.Drawing.Size(6, 13);
            this.myNum.TabIndex = 6;
            this.myNum.Text = "0";
            // 
            // imprimer
            // 
            this.imprimer.Location = new System.Drawing.Point(1001, 0);
            this.imprimer.LookAndFeel.SkinName = "Office 2013";
            this.imprimer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(75, 23);
            this.imprimer.TabIndex = 4;
            this.imprimer.Text = "Im&primer";
            this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
            // 
            // XtraCaisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fermer;
            this.ClientSize = new System.Drawing.Size(1450, 538);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraCaisse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAISSE";
            this.Activated += new System.EventHandler(this.XtraCaisse_Activated);
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
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn colTerm;
        private DevExpress.XtraGrid.Columns.GridColumn colDesig;
        private DevExpress.XtraGrid.Columns.GridColumn ColMont;
        private DevExpress.XtraGrid.Columns.GridColumn colPerc;
        private DevExpress.XtraGrid.Columns.GridColumn colRend;
        private DevExpress.XtraEditors.SimpleButton imprimer;
        private DevExpress.XtraEditors.LabelControl myNum;
        private System.Windows.Forms.ContextMenuStrip clicDroit;
        private System.Windows.Forms.ToolStripMenuItem détaillerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton fermer;
        private DevExpress.XtraGrid.Columns.GridColumn colGate;
        private DevExpress.XtraGrid.Columns.GridColumn gridHour;
    }
}