namespace gescom.create.Views
{
    partial class XtraOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraOrder));
            this.gridActions = new DevExpress.XtraGrid.GridControl();
            this.clicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grilleView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.obs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.place = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rmq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliPr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.disponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQ1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQ2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridRapide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colomL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlacer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPtArr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.myNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridActions)).BeginInit();
            this.clicDroit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilleView)).BeginInit();
            this.SuspendLayout();
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
            this.gridActions.Size = new System.Drawing.Size(1908, 521);
            this.gridActions.TabIndex = 1;
            this.gridActions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grilleView});
            this.gridActions.DoubleClick += new System.EventHandler(this.gridActions_DoubleClick);
            // 
            // clicDroit
            // 
            this.clicDroit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifStripMenuItem});
            this.clicDroit.Name = "clicDroit";
            this.clicDroit.Size = new System.Drawing.Size(143, 26);
            // 
            // modifStripMenuItem
            // 
            this.modifStripMenuItem.Name = "modifStripMenuItem";
            this.modifStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.modifStripMenuItem.Text = "&Modification";
            this.modifStripMenuItem.Click += new System.EventHandler(this.modifStripMenuItem_Click);
            // 
            // grilleView
            // 
            this.grilleView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.code,
            this.obs,
            this.place,
            this.rmq,
            this.nom,
            this.coliPr,
            this.prix,
            this.unite,
            this.disponible,
            this.colQ1,
            this.colQ2,
            this.colB2,
            this.colEnt,
            this.gridRapide,
            this.colomL,
            this.colPlacer,
            this.colVerif,
            this.gridC5,
            this.colCPtArr,
            this.colInter});
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
            this.code.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.code.Width = 60;
            // 
            // obs
            // 
            this.obs.AppearanceHeader.Options.UseTextOptions = true;
            this.obs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.obs.Caption = "DATE";
            this.obs.FieldName = "B1";
            this.obs.Name = "obs";
            this.obs.Visible = true;
            this.obs.VisibleIndex = 7;
            this.obs.Width = 89;
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
            this.place.Width = 140;
            // 
            // rmq
            // 
            this.rmq.AppearanceHeader.Options.UseTextOptions = true;
            this.rmq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rmq.Caption = "REPONSE";
            this.rmq.FieldName = "S2";
            this.rmq.Name = "rmq";
            this.rmq.Visible = true;
            this.rmq.VisibleIndex = 19;
            this.rmq.Width = 215;
            // 
            // nom
            // 
            this.nom.AppearanceHeader.Options.UseTextOptions = true;
            this.nom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nom.Caption = "DESIGNATION";
            this.nom.FieldName = "Designation";
            this.nom.Name = "nom";
            this.nom.Visible = true;
            this.nom.VisibleIndex = 2;
            this.nom.Width = 457;
            // 
            // coliPr
            // 
            this.coliPr.AppearanceHeader.Options.UseTextOptions = true;
            this.coliPr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coliPr.Caption = "A PRIX";
            this.coliPr.FieldName = "VoirPrix";
            this.coliPr.Name = "coliPr";
            this.coliPr.Visible = true;
            this.coliPr.VisibleIndex = 16;
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
            this.prix.VisibleIndex = 3;
            this.prix.Width = 87;
            // 
            // unite
            // 
            this.unite.AppearanceHeader.Options.UseTextOptions = true;
            this.unite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unite.Caption = "Uté";
            this.unite.FieldName = "Unite";
            this.unite.Name = "unite";
            this.unite.Visible = true;
            this.unite.VisibleIndex = 5;
            this.unite.Width = 72;
            // 
            // disponible
            // 
            this.disponible.AppearanceCell.BackColor = System.Drawing.Color.Cornsilk;
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
            this.disponible.VisibleIndex = 4;
            this.disponible.Width = 86;
            // 
            // colQ1
            // 
            this.colQ1.AppearanceCell.BackColor = System.Drawing.Color.LightCyan;
            this.colQ1.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.colQ1.AppearanceCell.Options.UseBackColor = true;
            this.colQ1.AppearanceCell.Options.UseForeColor = true;
            this.colQ1.AppearanceHeader.Options.UseTextOptions = true;
            this.colQ1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQ1.Caption = "Qté-Arrivage";
            this.colQ1.DisplayFormat.FormatString = "n0";
            this.colQ1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQ1.FieldName = "Q4";
            this.colQ1.Name = "colQ1";
            this.colQ1.OptionsColumn.AllowFocus = false;
            this.colQ1.Visible = true;
            this.colQ1.VisibleIndex = 9;
            this.colQ1.Width = 79;
            // 
            // colQ2
            // 
            this.colQ2.AppearanceCell.BackColor = System.Drawing.Color.FloralWhite;
            this.colQ2.AppearanceCell.Options.UseBackColor = true;
            this.colQ2.AppearanceHeader.Options.UseTextOptions = true;
            this.colQ2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQ2.Caption = "Qté-Interne";
            this.colQ2.DisplayFormat.FormatString = "n0";
            this.colQ2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQ2.FieldName = "Q6";
            this.colQ2.Name = "colQ2";
            this.colQ2.OptionsColumn.AllowFocus = false;
            this.colQ2.Visible = true;
            this.colQ2.VisibleIndex = 12;
            this.colQ2.Width = 68;
            // 
            // colB2
            // 
            this.colB2.AppearanceHeader.Options.UseTextOptions = true;
            this.colB2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB2.Caption = "TRANSPORTEUR";
            this.colB2.FieldName = "B2";
            this.colB2.Name = "colB2";
            this.colB2.Visible = true;
            this.colB2.VisibleIndex = 18;
            this.colB2.Width = 156;
            // 
            // colEnt
            // 
            this.colEnt.AppearanceHeader.Options.UseTextOptions = true;
            this.colEnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEnt.Caption = "A ENTRER";
            this.colEnt.FieldName = "VoirEntre";
            this.colEnt.Name = "colEnt";
            this.colEnt.Visible = true;
            this.colEnt.VisibleIndex = 6;
            // 
            // gridRapide
            // 
            this.gridRapide.AppearanceHeader.Options.UseTextOptions = true;
            this.gridRapide.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridRapide.Caption = "IMMEDIAT";
            this.gridRapide.FieldName = "VoirPrior";
            this.gridRapide.Name = "gridRapide";
            this.gridRapide.OptionsColumn.AllowEdit = false;
            this.gridRapide.Visible = true;
            this.gridRapide.VisibleIndex = 14;
            // 
            // colomL
            // 
            this.colomL.AppearanceCell.BackColor = System.Drawing.Color.LightCyan;
            this.colomL.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colomL.AppearanceCell.Options.UseBackColor = true;
            this.colomL.AppearanceCell.Options.UseFont = true;
            this.colomL.AppearanceCell.Options.UseTextOptions = true;
            this.colomL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colomL.AppearanceHeader.Options.UseTextOptions = true;
            this.colomL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colomL.Caption = "Ent Fact.";
            this.colomL.FieldName = "CMD";
            this.colomL.Name = "colomL";
            this.colomL.Visible = true;
            this.colomL.VisibleIndex = 8;
            this.colomL.Width = 64;
            // 
            // colPlacer
            // 
            this.colPlacer.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlacer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlacer.Caption = "A PLACER";
            this.colPlacer.FieldName = "VoirPlace";
            this.colPlacer.Name = "colPlacer";
            this.colPlacer.Visible = true;
            this.colPlacer.VisibleIndex = 17;
            // 
            // colVerif
            // 
            this.colVerif.AppearanceHeader.Options.UseTextOptions = true;
            this.colVerif.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVerif.Caption = "A VERIFIER";
            this.colVerif.FieldName = "VoirVerif";
            this.colVerif.Name = "colVerif";
            this.colVerif.Visible = true;
            this.colVerif.VisibleIndex = 15;
            // 
            // gridC5
            // 
            this.gridC5.AppearanceCell.BackColor = System.Drawing.Color.FloralWhite;
            this.gridC5.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridC5.AppearanceCell.Options.UseBackColor = true;
            this.gridC5.AppearanceCell.Options.UseFont = true;
            this.gridC5.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.gridC5.AppearanceHeader.Options.UseBackColor = true;
            this.gridC5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridC5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridC5.Caption = "Ent interne";
            this.gridC5.FieldName = "C5";
            this.gridC5.Name = "gridC5";
            this.gridC5.Visible = true;
            this.gridC5.VisibleIndex = 11;
            this.gridC5.Width = 67;
            // 
            // colCPtArr
            // 
            this.colCPtArr.AppearanceCell.BackColor = System.Drawing.Color.LightCyan;
            this.colCPtArr.AppearanceCell.Options.UseBackColor = true;
            this.colCPtArr.AppearanceHeader.Options.UseTextOptions = true;
            this.colCPtArr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCPtArr.Caption = "Count-Arr";
            this.colCPtArr.FieldName = "H4";
            this.colCPtArr.Name = "colCPtArr";
            this.colCPtArr.Visible = true;
            this.colCPtArr.VisibleIndex = 10;
            // 
            // colInter
            // 
            this.colInter.AppearanceCell.BackColor = System.Drawing.Color.FloralWhite;
            this.colInter.AppearanceCell.Options.UseBackColor = true;
            this.colInter.AppearanceHeader.Options.UseTextOptions = true;
            this.colInter.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInter.Caption = "Count-Inter";
            this.colInter.FieldName = "H6";
            this.colInter.Name = "colInter";
            this.colInter.Visible = true;
            this.colInter.VisibleIndex = 13;
            // 
            // myNum
            // 
            this.myNum.AutoSize = true;
            this.myNum.ForeColor = System.Drawing.Color.White;
            this.myNum.Location = new System.Drawing.Point(656, 485);
            this.myNum.Name = "myNum";
            this.myNum.Size = new System.Drawing.Size(35, 13);
            this.myNum.TabIndex = 3;
            this.myNum.Text = "label1";
            // 
            // XtraOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 521);
            this.Controls.Add(this.myNum);
            this.Controls.Add(this.gridActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraOrder.IconOptions.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTAIRE-COMPTAGE";
            this.Activated += new System.EventHandler(this.XtraOrder_Activated);
            this.Load += new System.EventHandler(this.XtraOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridActions)).EndInit();
            this.clicDroit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilleView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridActions;
        private DevExpress.XtraGrid.Views.Grid.GridView grilleView;
        private DevExpress.XtraGrid.Columns.GridColumn code;
        private DevExpress.XtraGrid.Columns.GridColumn place;
        private DevExpress.XtraGrid.Columns.GridColumn obs;
        private DevExpress.XtraGrid.Columns.GridColumn nom;
        private DevExpress.XtraGrid.Columns.GridColumn prix;
        private DevExpress.XtraGrid.Columns.GridColumn unite;
        private DevExpress.XtraGrid.Columns.GridColumn disponible;
        private DevExpress.XtraGrid.Columns.GridColumn rmq;
        private DevExpress.XtraGrid.Columns.GridColumn colQ1;
        private DevExpress.XtraGrid.Columns.GridColumn colQ2;
        private System.Windows.Forms.ContextMenuStrip clicDroit;
        private DevExpress.XtraGrid.Columns.GridColumn colB2;
        private DevExpress.XtraGrid.Columns.GridColumn colEnt;
        private DevExpress.XtraGrid.Columns.GridColumn coliPr;
        private System.Windows.Forms.ToolStripMenuItem modifStripMenuItem;
        private System.Windows.Forms.Label myNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridRapide;
        private DevExpress.XtraGrid.Columns.GridColumn colomL;
        private DevExpress.XtraGrid.Columns.GridColumn colPlacer;
        private DevExpress.XtraGrid.Columns.GridColumn colVerif;
        private DevExpress.XtraGrid.Columns.GridColumn gridC5;
        private DevExpress.XtraGrid.Columns.GridColumn colCPtArr;
        private DevExpress.XtraGrid.Columns.GridColumn colInter;
    }
}