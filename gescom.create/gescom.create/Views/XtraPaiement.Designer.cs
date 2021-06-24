namespace gescom.create.Views
{
    partial class XtraPaiement
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraPaiement));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.grillage = new DevExpress.XtraGrid.GridControl();
            this.Vue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Down = new DevExpress.XtraEditors.GroupControl();
            this.Rendu = new DevExpress.XtraEditors.LabelControl();
            this.Percu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Montant = new DevExpress.XtraEditors.LabelControl();
            this.Nom = new DevExpress.XtraEditors.LabelControl();
            this.Numero = new DevExpress.XtraEditors.LabelControl();
            this.myMontant = new DevExpress.XtraEditors.LabelControl();
            this.encaisse = new DevExpress.XtraEditors.SimpleButton();
            this.rafraiche = new DevExpress.XtraEditors.SimpleButton();
            this.myNum = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Down)).BeginInit();
            this.Down.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Percu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.myMontant);
            this.splitContainerControl1.Panel2.Controls.Add(this.encaisse);
            this.splitContainerControl1.Panel2.Controls.Add(this.rafraiche);
            this.splitContainerControl1.Panel2.Controls.Add(this.myNum);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1110, 554);
            this.splitContainerControl1.SplitterPosition = 478;
            this.splitContainerControl1.TabIndex = 0;
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
            this.splitContainerControl2.Panel2.Controls.Add(this.Down);
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1110, 478);
            this.splitContainerControl2.SplitterPosition = 259;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // grillage
            // 
            this.grillage.Cursor = System.Windows.Forms.Cursors.Default;
            this.grillage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grillage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.RelationName = "Level1";
            this.grillage.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grillage.Location = new System.Drawing.Point(0, 0);
            this.grillage.MainView = this.Vue;
            this.grillage.Name = "grillage";
            this.grillage.Size = new System.Drawing.Size(259, 478);
            this.grillage.TabIndex = 0;
            this.grillage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Vue});
            this.grillage.Click += new System.EventHandler(this.grillage_Click);
            this.grillage.DoubleClick += new System.EventHandler(this.grillage_DoubleClick);
            // 
            // Vue
            // 
            this.Vue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colHeure});
            this.Vue.GridControl = this.grillage;
            this.Vue.Name = "Vue";
            this.Vue.OptionsView.ShowAutoFilterRow = true;
            this.Vue.OptionsView.ShowFooter = true;
            this.Vue.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.Caption = "ID";
            this.colId.DisplayFormat.FormatString = "n0";
            this.colId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowFocus = false;
            this.colId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", "{0:n0}")});
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 129;
            // 
            // colHeure
            // 
            this.colHeure.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHeure.AppearanceCell.Options.UseFont = true;
            this.colHeure.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHeure.AppearanceHeader.Options.UseFont = true;
            this.colHeure.AppearanceHeader.Options.UseTextOptions = true;
            this.colHeure.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHeure.Caption = "HEURE";
            this.colHeure.DisplayFormat.FormatString = "HH:mm";
            this.colHeure.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colHeure.FieldName = "Datum";
            this.colHeure.Name = "colHeure";
            this.colHeure.OptionsColumn.AllowFocus = false;
            this.colHeure.Visible = true;
            this.colHeure.VisibleIndex = 1;
            this.colHeure.Width = 109;
            // 
            // Down
            // 
            this.Down.Controls.Add(this.Rendu);
            this.Down.Controls.Add(this.Percu);
            this.Down.Controls.Add(this.labelControl2);
            this.Down.Controls.Add(this.labelControl1);
            this.Down.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Down.Location = new System.Drawing.Point(0, 273);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(839, 205);
            this.Down.TabIndex = 1;
            // 
            // Rendu
            // 
            this.Rendu.Appearance.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rendu.Appearance.ForeColor = System.Drawing.Color.Red;
            this.Rendu.Appearance.Options.UseFont = true;
            this.Rendu.Appearance.Options.UseForeColor = true;
            this.Rendu.Location = new System.Drawing.Point(412, 120);
            this.Rendu.Name = "Rendu";
            this.Rendu.Size = new System.Drawing.Size(0, 77);
            this.Rendu.TabIndex = 3;
            // 
            // Percu
            // 
            this.Percu.Location = new System.Drawing.Point(402, 22);
            this.Percu.Name = "Percu";
            this.Percu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percu.Properties.Appearance.Options.UseFont = true;
            this.Percu.Size = new System.Drawing.Size(301, 84);
            this.Percu.TabIndex = 2;
            this.Percu.EditValueChanged += new System.EventHandler(this.Percu_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(136, 129);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(223, 58);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "A RENDRE";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(136, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(224, 58);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "PAIEMENT";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Montant);
            this.groupControl1.Controls.Add(this.Nom);
            this.groupControl1.Controls.Add(this.Numero);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(839, 257);
            this.groupControl1.TabIndex = 0;
            // 
            // Montant
            // 
            this.Montant.Appearance.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Montant.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.Montant.Appearance.Options.UseFont = true;
            this.Montant.Appearance.Options.UseForeColor = true;
            this.Montant.Location = new System.Drawing.Point(44, 165);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(0, 77);
            this.Montant.TabIndex = 2;
            // 
            // Nom
            // 
            this.Nom.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Appearance.Options.UseFont = true;
            this.Nom.Location = new System.Drawing.Point(44, 91);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(0, 58);
            this.Nom.TabIndex = 1;
            // 
            // Numero
            // 
            this.Numero.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Appearance.Options.UseFont = true;
            this.Numero.Location = new System.Drawing.Point(44, 16);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(0, 58);
            this.Numero.TabIndex = 0;
            // 
            // myMontant
            // 
            this.myMontant.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myMontant.Appearance.Options.UseForeColor = true;
            this.myMontant.Location = new System.Drawing.Point(414, 12);
            this.myMontant.Name = "myMontant";
            this.myMontant.Size = new System.Drawing.Size(6, 13);
            this.myMontant.TabIndex = 5;
            this.myMontant.Text = "0";
            // 
            // encaisse
            // 
            this.encaisse.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encaisse.Appearance.Options.UseFont = true;
            this.encaisse.Enabled = false;
            this.encaisse.Location = new System.Drawing.Point(853, 7);
            this.encaisse.Name = "encaisse";
            this.encaisse.Size = new System.Drawing.Size(120, 45);
            this.encaisse.TabIndex = 4;
            this.encaisse.Text = "En&caisser";
            this.encaisse.Click += new System.EventHandler(this.encaisse_Click);
            // 
            // rafraiche
            // 
            this.rafraiche.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rafraiche.Appearance.Options.UseFont = true;
            this.rafraiche.Location = new System.Drawing.Point(702, 6);
            this.rafraiche.Name = "rafraiche";
            this.rafraiche.Size = new System.Drawing.Size(121, 45);
            this.rafraiche.TabIndex = 3;
            this.rafraiche.Text = "&Entrez";
            this.rafraiche.Click += new System.EventHandler(this.rafraiche_Click);
            // 
            // myNum
            // 
            this.myNum.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.myNum.Appearance.Options.UseForeColor = true;
            this.myNum.Location = new System.Drawing.Point(47, 7);
            this.myNum.Name = "myNum";
            this.myNum.Size = new System.Drawing.Size(6, 13);
            this.myNum.TabIndex = 2;
            this.myNum.Text = "0";
            // 
            // XtraPaiement
            // 
            this.AcceptButton = this.encaisse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 554);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraPaiement";
            this.Text = "REGLEMENT";
            this.Activated += new System.EventHandler(this.XtraPaiement_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Down)).EndInit();
            this.Down.ResumeLayout(false);
            this.Down.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Percu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl grillage;
        private DevExpress.XtraGrid.Views.Grid.GridView Vue;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl Numero;
        private DevExpress.XtraEditors.LabelControl Montant;
        private DevExpress.XtraEditors.LabelControl Nom;
        private DevExpress.XtraEditors.LabelControl myNum;
        private DevExpress.XtraEditors.GroupControl Down;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl Rendu;
        private DevExpress.XtraEditors.TextEdit Percu;
        private DevExpress.XtraEditors.SimpleButton rafraiche;
        private DevExpress.XtraEditors.SimpleButton encaisse;
        private DevExpress.XtraEditors.LabelControl myMontant;
        private DevExpress.XtraGrid.Columns.GridColumn colHeure;
    }
}