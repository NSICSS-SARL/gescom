namespace gescom.@public
{
    partial class FrmPublic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPublic));
            this.gridActions = new DevExpress.XtraGrid.GridControl();
            this.grilleView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.catalogue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unite = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridActions
            // 
            this.gridActions.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridActions.Location = new System.Drawing.Point(0, 0);
            this.gridActions.LookAndFeel.SkinName = "Office 2013";
            this.gridActions.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridActions.MainView = this.grilleView;
            this.gridActions.Name = "gridActions";
            this.gridActions.Size = new System.Drawing.Size(984, 521);
            this.gridActions.TabIndex = 1;
            this.gridActions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grilleView});
            // 
            // grilleView
            // 
            this.grilleView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.code,
            this.reference,
            this.catalogue,
            this.nom,
            this.prix,
            this.unite});
            this.grilleView.GridControl = this.gridActions;
            this.grilleView.Name = "grilleView";
            this.grilleView.OptionsFilter.AllowFilterEditor = false;
            this.grilleView.OptionsFind.AlwaysVisible = true;
            this.grilleView.OptionsFind.FindNullPrompt = "";
            this.grilleView.OptionsView.ColumnAutoWidth = false;
            this.grilleView.OptionsView.ShowAutoFilterRow = true;
            this.grilleView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grilleView.OptionsView.ShowFooter = true;
            this.grilleView.OptionsView.ShowGroupPanel = false;
            // 
            // code
            // 
            this.code.AppearanceHeader.Options.UseTextOptions = true;
            this.code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.code.Caption = "CODE";
            this.code.FieldName = "Fcode";
            this.code.Name = "code";
            this.code.OptionsColumn.AllowFocus = false;
            this.code.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "RCode", "{0:n0}")});
            this.code.Visible = true;
            this.code.VisibleIndex = 0;
            this.code.Width = 80;
            // 
            // reference
            // 
            this.reference.AppearanceHeader.Options.UseTextOptions = true;
            this.reference.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.reference.Caption = "ETAT";
            this.reference.FieldName = "Dispo";
            this.reference.Name = "reference";
            this.reference.OptionsColumn.AllowFocus = false;
            this.reference.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.reference.Visible = true;
            this.reference.VisibleIndex = 4;
            this.reference.Width = 125;
            // 
            // catalogue
            // 
            this.catalogue.AppearanceHeader.Options.UseTextOptions = true;
            this.catalogue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.catalogue.Caption = "CATALOGUE";
            this.catalogue.FieldName = "Catalog";
            this.catalogue.Name = "catalogue";
            this.catalogue.OptionsColumn.AllowFocus = false;
            this.catalogue.Width = 104;
            // 
            // nom
            // 
            this.nom.AppearanceHeader.Options.UseTextOptions = true;
            this.nom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nom.Caption = "DESIGNATION";
            this.nom.FieldName = "Designation";
            this.nom.Name = "nom";
            this.nom.OptionsColumn.AllowFocus = false;
            this.nom.Visible = true;
            this.nom.VisibleIndex = 1;
            this.nom.Width = 540;
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
            this.prix.VisibleIndex = 2;
            this.prix.Width = 104;
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
            this.unite.VisibleIndex = 3;
            this.unite.Width = 97;
            // 
            // FrmPublic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.gridActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmPublic.IconOptions.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "FrmPublic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATALOGUE";
            ((System.ComponentModel.ISupportInitialize)(this.gridActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridActions;
        private DevExpress.XtraGrid.Views.Grid.GridView grilleView;
        private DevExpress.XtraGrid.Columns.GridColumn code;
        private DevExpress.XtraGrid.Columns.GridColumn reference;
        private DevExpress.XtraGrid.Columns.GridColumn catalogue;
        private DevExpress.XtraGrid.Columns.GridColumn nom;
        private DevExpress.XtraGrid.Columns.GridColumn prix;
        private DevExpress.XtraGrid.Columns.GridColumn unite;

    }
}

