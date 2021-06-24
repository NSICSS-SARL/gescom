namespace gescom.create.Views
{
    partial class XtraFiche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFiche));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.creer = new DevExpress.XtraEditors.SimpleButton();
            this.myNum = new DevExpress.XtraEditors.LabelControl();
            this.fermer = new DevExpress.XtraEditors.SimpleButton();
            this.imprimer = new DevExpress.XtraEditors.SimpleButton();
            this.grillage = new DevExpress.XtraGrid.GridControl();
            this.detailStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filtrage = new System.Windows.Forms.ToolStripMenuItem();
            this.grilleVue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillage)).BeginInit();
            this.detailStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilleVue)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.creer);
            this.splitContainerControl1.Panel1.Controls.Add(this.myNum);
            this.splitContainerControl1.Panel1.Controls.Add(this.fermer);
            this.splitContainerControl1.Panel1.Controls.Add(this.imprimer);
            this.splitContainerControl1.Panel1.Controls.Add(this.grillage);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1140, 472);
            this.splitContainerControl1.SplitterPosition = 1117;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // creer
            // 
            this.creer.Location = new System.Drawing.Point(850, 436);
            this.creer.Name = "creer";
            this.creer.Size = new System.Drawing.Size(75, 25);
            this.creer.TabIndex = 9;
            this.creer.Text = "&Débit/Crédit";
           this.creer.Click += new System.EventHandler(this.creer_Click);              
            // 
            // myNum
            // 
            this.myNum.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.myNum.Location = new System.Drawing.Point(305, 434);
            this.myNum.Name = "myNum";
            this.myNum.Size = new System.Drawing.Size(6, 13);
            this.myNum.TabIndex = 8;
            this.myNum.Text = "0";
            // 
            // fermer
            // 
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fermer.Location = new System.Drawing.Point(1016, 434);
            this.fermer.LookAndFeel.SkinName = "Office 2013";
            this.fermer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(77, 26);
            this.fermer.TabIndex = 7;
            this.fermer.Text = "&Fermer";
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // imprimer
            // 
            this.imprimer.Location = new System.Drawing.Point(931, 435);
            this.imprimer.LookAndFeel.SkinName = "Office 2013";
            this.imprimer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(77, 26);
            this.imprimer.TabIndex = 6;
            this.imprimer.Text = "Im&primer";
          this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
            // 
            // grillage
            // 
            this.grillage.ContextMenuStrip = this.detailStrip;
            this.grillage.Cursor = System.Windows.Forms.Cursors.Default;
            this.grillage.Dock = System.Windows.Forms.DockStyle.Top;
            this.grillage.Location = new System.Drawing.Point(0, 0);
            this.grillage.MainView = this.grilleVue;
            this.grillage.Name = "grillage";
            this.grillage.Size = new System.Drawing.Size(1117, 422);
            this.grillage.TabIndex = 3;
            this.grillage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grilleVue});
            this.grillage.DoubleClick += new System.EventHandler(this.grillage_DoubleClick);
            // 
            // detailStrip
            // 
            this.detailStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrage});
            this.detailStrip.Name = "detailStrip";
            this.detailStrip.Size = new System.Drawing.Size(105, 26);
            // 
            // filtrage
            // 
            this.filtrage.Name = "filtrage";
            this.filtrage.Size = new System.Drawing.Size(104, 22);
            this.filtrage.Text = "&Filtrer";
            this.filtrage.Click += new System.EventHandler(this.filtrage_Click);
            // 
            // grilleVue
            // 
            this.grilleVue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colGate,
            this.colTask,
            this.colRef,
            this.colPaie,
            this.colDebit,
            this.colCredit});
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
            this.colId.Width = 83;
            // 
            // colGate
            // 
            this.colGate.AppearanceHeader.Options.UseTextOptions = true;
            this.colGate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGate.Caption = "DATE";
            this.colGate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colGate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colGate.FieldName = "Datum";
            this.colGate.Name = "colGate";
            this.colGate.OptionsColumn.AllowFocus = false;
            this.colGate.OptionsColumn.FixedWidth = true;
            this.colGate.Visible = true;
            this.colGate.VisibleIndex = 1;
            this.colGate.Width = 100;
            // 
            // colTask
            // 
            this.colTask.AppearanceCell.Options.UseTextOptions = true;
            this.colTask.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTask.AppearanceHeader.Options.UseTextOptions = true;
            this.colTask.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTask.Caption = "TACHE";
            this.colTask.FieldName = "Tache";
            this.colTask.Name = "colTask";
            this.colTask.OptionsColumn.AllowFocus = false;
            this.colTask.OptionsColumn.FixedWidth = true;
            this.colTask.Visible = true;
            this.colTask.VisibleIndex = 2;
            // 
            // colRef
            // 
            this.colRef.AppearanceHeader.Options.UseTextOptions = true;
            this.colRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRef.Caption = "REFERENCE";
            this.colRef.FieldName = "Refce";
            this.colRef.Name = "colRef";
            this.colRef.OptionsColumn.AllowFocus = false;
            this.colRef.OptionsColumn.FixedWidth = true;
            this.colRef.Visible = true;
            this.colRef.VisibleIndex = 3;
            this.colRef.Width = 134;
            // 
            // colPaie
            // 
            this.colPaie.AppearanceHeader.Options.UseTextOptions = true;
            this.colPaie.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPaie.Caption = "LIBELLES";
            this.colPaie.FieldName = "Libelle";
            this.colPaie.Name = "colPaie";
            this.colPaie.OptionsColumn.AllowFocus = false;
            this.colPaie.OptionsColumn.FixedWidth = true;
            this.colPaie.Visible = true;
            this.colPaie.VisibleIndex = 4;
            this.colPaie.Width = 486;
            // 
            // colDebit
            // 
            this.colDebit.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebit.Caption = "DEBIT";
            this.colDebit.DisplayFormat.FormatString = "n0";
            this.colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDebit.FieldName = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.OptionsColumn.AllowFocus = false;
            this.colDebit.OptionsColumn.AllowSize = false;
            this.colDebit.OptionsColumn.FixedWidth = true;
            this.colDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit", "{0:n0}")});
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 5;
            this.colDebit.Width = 100;
            // 
            // colCredit
            // 
            this.colCredit.AppearanceHeader.Options.UseTextOptions = true;
            this.colCredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCredit.Caption = "CREDIT";
            this.colCredit.DisplayFormat.FormatString = "n0";
            this.colCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCredit.FieldName = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.OptionsColumn.AllowFocus = false;
            this.colCredit.OptionsColumn.AllowSize = false;
            this.colCredit.OptionsColumn.FixedWidth = true;
            this.colCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit", "{0:n0}")});
            this.colCredit.Visible = true;
            this.colCredit.VisibleIndex = 6;
            this.colCredit.Width = 100;
            // 
            // XtraFiche
            // 
            this.AcceptButton = this.creer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fermer;
            this.ClientSize = new System.Drawing.Size(1140, 472);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraFiche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FICHE";
           this.Activated += new System.EventHandler(this.XtraFiche_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillage)).EndInit();
            this.detailStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilleVue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl grillage;
        private DevExpress.XtraGrid.Views.Grid.GridView grilleVue;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colRef;
        private DevExpress.XtraGrid.Columns.GridColumn colPaie;
        private DevExpress.XtraGrid.Columns.GridColumn colDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colGate;
        private DevExpress.XtraGrid.Columns.GridColumn colTask;
        private DevExpress.XtraEditors.SimpleButton fermer;
        private DevExpress.XtraEditors.SimpleButton imprimer;
        private System.Windows.Forms.ContextMenuStrip detailStrip;
        private System.Windows.Forms.ToolStripMenuItem filtrage;
        private DevExpress.XtraEditors.LabelControl myNum;
        private DevExpress.XtraEditors.SimpleButton creer;

    }
}