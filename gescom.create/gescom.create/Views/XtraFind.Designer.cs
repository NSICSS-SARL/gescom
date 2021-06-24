namespace gescom.create.Views
{
    partial class XtraFind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFind));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridActions = new DevExpress.XtraGrid.GridControl();
            this.clicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.remarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grilleView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.place = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.disponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.myNum = new DevExpress.XtraEditors.LabelControl();
            this.fermer = new DevExpress.XtraEditors.SimpleButton();
            this.nouveau = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.gridActions);
            this.splitContainerControl1.Panel1.Controls.Add(this.myNum);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.fermer);
            this.splitContainerControl1.Panel2.Controls.Add(this.nouveau);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1120, 521);
            this.splitContainerControl1.SplitterPosition = 478;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
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
            this.gridActions.Size = new System.Drawing.Size(1120, 478);
            this.gridActions.TabIndex = 0;
            this.gridActions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grilleView});
            this.gridActions.DoubleClick += new System.EventHandler(this.gridActions_DoubleClick);
            // 
            // clicDroit
            // 
            this.clicDroit.Enabled = false;
            this.clicDroit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remarqueToolStripMenuItem});
            this.clicDroit.Name = "clicDroit";
            this.clicDroit.Size = new System.Drawing.Size(129, 26);
            // 
            // remarqueToolStripMenuItem
            // 
            this.remarqueToolStripMenuItem.Enabled = false;
            this.remarqueToolStripMenuItem.Name = "remarqueToolStripMenuItem";
            this.remarqueToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.remarqueToolStripMenuItem.Text = "Re&marque";
            this.remarqueToolStripMenuItem.Click += new System.EventHandler(this.remarqueToolStripMenuItem_Click);
            // 
            // grilleView
            // 
            this.grilleView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.code,
            this.place,
            this.nom,
            this.prix,
            this.unite,
            this.disponible});
            this.grilleView.GridControl = this.gridActions;
            this.grilleView.Name = "grilleView";
            this.grilleView.OptionsFilter.AllowFilterEditor = false;
            this.grilleView.OptionsFind.AlwaysVisible = true;
            this.grilleView.OptionsFind.FindNullPrompt = "";
            this.grilleView.OptionsView.ShowAutoFilterRow = true;
            this.grilleView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grilleView.OptionsView.ShowFooter = true;
            this.grilleView.OptionsView.ShowGroupPanel = false;
            // 
            // code
            // 
            this.code.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.code.AppearanceCell.Options.UseBackColor = true;
            this.code.AppearanceHeader.Options.UseTextOptions = true;
            this.code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.code.Caption = "CODE";
            this.code.FieldName = "Fcode";
            this.code.Name = "code";
            this.code.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Fcode", "{0:n0}")});
            this.code.Visible = true;
            this.code.VisibleIndex = 1;
            this.code.Width = 121;
            // 
            // place
            // 
            this.place.AppearanceHeader.Options.UseTextOptions = true;
            this.place.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.place.Caption = "EMPLACEMENT";
            this.place.FieldName = "Place";
            this.place.Name = "place";
            this.place.Visible = true;
            this.place.VisibleIndex = 0;
            this.place.Width = 217;
            // 
            // nom
            // 
            this.nom.AppearanceHeader.Options.UseTextOptions = true;
            this.nom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nom.Caption = "DESIGNATION";
            this.nom.FieldName = "Designation";
            this.nom.Name = "nom";
            this.nom.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.BeginsWith;
            this.nom.Visible = true;
            this.nom.VisibleIndex = 2;
            this.nom.Width = 949;
            // 
            // prix
            // 
            this.prix.AppearanceHeader.Options.UseTextOptions = true;
            this.prix.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.prix.Caption = "PRIX";
            this.prix.DisplayFormat.FormatString = "n0";
            this.prix.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.prix.FieldName = "PDetail";
            this.prix.Name = "prix";
            this.prix.OptionsColumn.AllowFocus = false;
            this.prix.Visible = true;
            this.prix.VisibleIndex = 4;
            this.prix.Width = 211;
            // 
            // unite
            // 
            this.unite.AppearanceHeader.Options.UseTextOptions = true;
            this.unite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unite.Caption = "UNITE";
            this.unite.FieldName = "Unite";
            this.unite.Name = "unite";
            this.unite.OptionsColumn.AllowFocus = false;
            this.unite.Visible = true;
            this.unite.VisibleIndex = 5;
            this.unite.Width = 147;
            // 
            // disponible
            // 
            this.disponible.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon;
            this.disponible.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disponible.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.disponible.AppearanceCell.Options.UseBackColor = true;
            this.disponible.AppearanceCell.Options.UseFont = true;
            this.disponible.AppearanceCell.Options.UseForeColor = true;
            this.disponible.AppearanceHeader.Options.UseTextOptions = true;
            this.disponible.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.disponible.Caption = "DISPONIBLE";
            this.disponible.DisplayFormat.FormatString = "n0";
            this.disponible.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.disponible.FieldName = "QStock";
            this.disponible.Name = "disponible";
            this.disponible.OptionsColumn.AllowFocus = false;
            this.disponible.Visible = true;
            this.disponible.VisibleIndex = 3;
            this.disponible.Width = 138;
            // 
            // myNum
            // 
            this.myNum.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.myNum.Appearance.Options.UseForeColor = true;
            this.myNum.Location = new System.Drawing.Point(675, 22);
            this.myNum.Name = "myNum";
            this.myNum.Size = new System.Drawing.Size(6, 13);
            this.myNum.TabIndex = 0;
            this.myNum.Text = "0";
            // 
            // fermer
            // 
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fermer.Location = new System.Drawing.Point(1232, 8);
            this.fermer.LookAndFeel.SkinName = "Office 2013";
            this.fermer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 2;
            this.fermer.Text = "&Fermer";
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // nouveau
            // 
            this.nouveau.Enabled = false;
            this.nouveau.Location = new System.Drawing.Point(1151, 8);
            this.nouveau.LookAndFeel.SkinName = "Office 2013";
            this.nouveau.LookAndFeel.UseDefaultLookAndFeel = false;
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(75, 23);
            this.nouveau.TabIndex = 1;
            this.nouveau.Text = "&Nouveau";
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // XtraFind
            // 
            this.AcceptButton = this.nouveau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fermer;
            this.ClientSize = new System.Drawing.Size(1120, 521);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.Name = "XtraFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RECHERCHE";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridActions)).EndInit();
            this.clicDroit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilleView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridActions;
        private DevExpress.XtraGrid.Views.Grid.GridView grilleView;
        private DevExpress.XtraGrid.Columns.GridColumn code;
        private DevExpress.XtraGrid.Columns.GridColumn place;
        private DevExpress.XtraGrid.Columns.GridColumn prix;
        private DevExpress.XtraGrid.Columns.GridColumn unite;
        private DevExpress.XtraGrid.Columns.GridColumn disponible;
        private DevExpress.XtraEditors.LabelControl myNum;
        private System.Windows.Forms.ContextMenuStrip clicDroit;
        private System.Windows.Forms.ToolStripMenuItem remarqueToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton nouveau;
        private DevExpress.XtraEditors.SimpleButton fermer;
        public DevExpress.XtraGrid.Columns.GridColumn nom;
    }
}