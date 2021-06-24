namespace gescom.backup
{
    partial class FrmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackup));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.grille = new DevExpress.XtraGrid.GridControl();
            this.Vue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRmk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.myNum = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vue)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.grille);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.myNum);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1486, 521);
            this.splitContainerControl1.SplitterPosition = 485;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // grille
            // 
            this.grille.Cursor = System.Windows.Forms.Cursors.Default;
            this.grille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grille.Location = new System.Drawing.Point(0, 0);
            this.grille.MainView = this.Vue;
            this.grille.Name = "grille";
            this.grille.Size = new System.Drawing.Size(1486, 485);
            this.grille.TabIndex = 0;
            this.grille.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Vue});
            // 
            // Vue
            // 
            this.Vue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCode,
            this.colReference,
            this.colNom,
            this.colQuantite,
            this.colPrix,
            this.colUnite,
            this.colRmk});
            this.Vue.GridControl = this.grille;
            this.Vue.Name = "Vue";
            this.Vue.OptionsFind.AlwaysVisible = true;
            this.Vue.OptionsFind.FindNullPrompt = "";
            this.Vue.OptionsView.ColumnAutoWidth = false;
            this.Vue.OptionsView.ShowAutoFilterRow = true;
            this.Vue.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.Vue.OptionsView.ShowFooter = true;
            this.Vue.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.AppearanceCell.Options.UseTextOptions = true;
            this.colId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.Caption = "CODE";
            this.colId.FieldName = "Fcode";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowFocus = false;
            this.colId.OptionsColumn.FixedWidth = true;
            this.colId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", "{0:n0}")});
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 82;
            // 
            // colCode
            // 
            this.colCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCode.Caption = "EMPLACEMENT";
            this.colCode.FieldName = "Place";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.AllowFocus = false;
            this.colCode.OptionsColumn.FixedWidth = true;
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 137;
            // 
            // colReference
            // 
            this.colReference.AppearanceHeader.Options.UseTextOptions = true;
            this.colReference.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReference.Caption = "DESIGNATION";
            this.colReference.FieldName = "Designation";
            this.colReference.Name = "colReference";
            this.colReference.OptionsColumn.AllowFocus = false;
            this.colReference.OptionsColumn.FixedWidth = true;
            this.colReference.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.BeginsWith;
            this.colReference.Visible = true;
            this.colReference.VisibleIndex = 2;
            this.colReference.Width = 535;
            // 
            // colNom
            // 
            this.colNom.AppearanceHeader.Options.UseTextOptions = true;
            this.colNom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNom.Caption = "NOM/TICKET";
            this.colNom.FieldName = "Refers";
            this.colNom.Name = "colNom";
            this.colNom.OptionsColumn.AllowFocus = false;
            this.colNom.OptionsColumn.FixedWidth = true;
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 3;
            this.colNom.Width = 209;
            // 
            // colQuantite
            // 
            this.colQuantite.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantite.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQuantite.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantite.Caption = "DISPONIBLE";
            this.colQuantite.DisplayFormat.FormatString = "n0";
            this.colQuantite.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantite.FieldName = "QStock";
            this.colQuantite.Name = "colQuantite";
            this.colQuantite.OptionsColumn.AllowFocus = false;
            this.colQuantite.OptionsColumn.FixedWidth = true;
            this.colQuantite.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colQuantite.Visible = true;
            this.colQuantite.VisibleIndex = 6;
            this.colQuantite.Width = 81;
            // 
            // colPrix
            // 
            this.colPrix.AppearanceCell.Options.UseTextOptions = true;
            this.colPrix.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPrix.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrix.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrix.Caption = "PRIX";
            this.colPrix.DisplayFormat.FormatString = "n0";
            this.colPrix.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrix.FieldName = "PDetail";
            this.colPrix.Name = "colPrix";
            this.colPrix.OptionsColumn.AllowFocus = false;
            this.colPrix.OptionsColumn.FixedWidth = true;
            this.colPrix.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colPrix.Visible = true;
            this.colPrix.VisibleIndex = 4;
            this.colPrix.Width = 104;
            // 
            // colUnite
            // 
            this.colUnite.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnite.Caption = "UNITE";
            this.colUnite.FieldName = "Unite";
            this.colUnite.Name = "colUnite";
            this.colUnite.OptionsColumn.AllowFocus = false;
            this.colUnite.OptionsColumn.FixedWidth = true;
            this.colUnite.Visible = true;
            this.colUnite.VisibleIndex = 5;
            this.colUnite.Width = 97;
            // 
            // colRmk
            // 
            this.colRmk.AppearanceHeader.Options.UseTextOptions = true;
            this.colRmk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRmk.Caption = "REMARQUE";
            this.colRmk.FieldName = "Observation";
            this.colRmk.Name = "colRmk";
            this.colRmk.OptionsColumn.AllowFocus = false;
            this.colRmk.OptionsColumn.FixedWidth = true;
            this.colRmk.Visible = true;
            this.colRmk.VisibleIndex = 7;
            this.colRmk.Width = 201;
            // 
            // myNum
            // 
            this.myNum.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.myNum.Appearance.Options.UseForeColor = true;
            this.myNum.Location = new System.Drawing.Point(122, 6);
            this.myNum.Name = "myNum";
            this.myNum.Size = new System.Drawing.Size(6, 13);
            this.myNum.TabIndex = 0;
            this.myNum.Text = "0";
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 521);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sauvegarde du ";
            this.Activated += new System.EventHandler(this.FrmBackup_Activated);
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.LabelControl myNum;
        private DevExpress.XtraGrid.GridControl grille;
        private DevExpress.XtraGrid.Views.Grid.GridView Vue;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colReference;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantite;
        private DevExpress.XtraGrid.Columns.GridColumn colPrix;
        private DevExpress.XtraGrid.Columns.GridColumn colUnite;
        private DevExpress.XtraGrid.Columns.GridColumn colRmk;

    }
}

