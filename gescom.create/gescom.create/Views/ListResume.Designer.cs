namespace gescom.create.Views
{
    partial class ListResume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListResume));
            this.diviseurVertical = new DevExpress.XtraEditors.SplitContainerControl();
            this.diviseurHorizontal = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarVrai = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarStock = new DevExpress.XtraNavBar.NavBarGroup();
            this.comItem = new DevExpress.XtraNavBar.NavBarItem();
            this.stagItem = new DevExpress.XtraNavBar.NavBarItem();
            this.ruptItem = new DevExpress.XtraNavBar.NavBarItem();
            this.rebDefItem = new DevExpress.XtraNavBar.NavBarItem();
            this.inventItem = new DevExpress.XtraNavBar.NavBarItem();
            this.alertItem = new DevExpress.XtraNavBar.NavBarItem();
            this.dispoItem = new DevExpress.XtraNavBar.NavBarItem();
            this.rebComptage = new DevExpress.XtraNavBar.NavBarItem();
            this.diviseurCentre = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridActions = new DevExpress.XtraGrid.GridControl();
            this.clicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.détaillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grilleView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTache = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fermer = new DevExpress.XtraEditors.SimpleButton();
            this.myNum = new DevExpress.XtraEditors.LabelControl();
            this.imprimer = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.diviseurVertical)).BeginInit();
            this.diviseurVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diviseurHorizontal)).BeginInit();
            this.diviseurHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarVrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diviseurCentre)).BeginInit();
            this.diviseurCentre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridActions)).BeginInit();
            this.clicDroit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilleView)).BeginInit();
            this.SuspendLayout();
            // 
            // diviseurVertical
            // 
            this.diviseurVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diviseurVertical.Horizontal = false;
            this.diviseurVertical.Location = new System.Drawing.Point(0, 0);
            this.diviseurVertical.Name = "diviseurVertical";
            this.diviseurVertical.Panel1.Controls.Add(this.diviseurHorizontal);
            this.diviseurVertical.Panel1.Text = "Panel1";
            this.diviseurVertical.Panel2.Controls.Add(this.fermer);
            this.diviseurVertical.Panel2.Controls.Add(this.myNum);
            this.diviseurVertical.Panel2.Controls.Add(this.imprimer);
            this.diviseurVertical.Panel2.Text = "Panel2";
            this.diviseurVertical.Size = new System.Drawing.Size(1008, 473);
            this.diviseurVertical.SplitterPosition = 425;
            this.diviseurVertical.TabIndex = 0;
            // 
            // diviseurHorizontal
            // 
            this.diviseurHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diviseurHorizontal.IsSplitterFixed = true;
            this.diviseurHorizontal.Location = new System.Drawing.Point(0, 0);
            this.diviseurHorizontal.Name = "diviseurHorizontal";
            this.diviseurHorizontal.Panel1.Controls.Add(this.navBarVrai);
            this.diviseurHorizontal.Panel1.Text = "Panel1";
            this.diviseurHorizontal.Panel2.Controls.Add(this.diviseurCentre);
            this.diviseurHorizontal.Panel2.Text = "Panel2";
            this.diviseurHorizontal.Size = new System.Drawing.Size(1008, 425);
            this.diviseurHorizontal.SplitterPosition = 153;
            this.diviseurHorizontal.TabIndex = 0;
            // 
            // navBarVrai
            // 
            this.navBarVrai.ActiveGroup = this.navBarStock;
            this.navBarVrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarVrai.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarStock});
            this.navBarVrai.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.dispoItem,
            this.alertItem,
            this.inventItem,
            this.ruptItem,
            this.stagItem,
            this.comItem,
            this.rebDefItem,
            this.rebComptage});
            this.navBarVrai.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl;
            this.navBarVrai.Location = new System.Drawing.Point(0, 0);
            this.navBarVrai.LookAndFeel.SkinName = "VS2010";
            this.navBarVrai.LookAndFeel.UseDefaultLookAndFeel = false;
            this.navBarVrai.Name = "navBarVrai";
            this.navBarVrai.OptionsNavPane.ExpandedWidth = 153;
            this.navBarVrai.Size = new System.Drawing.Size(153, 425);
            this.navBarVrai.TabIndex = 1;
            this.navBarVrai.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("VS2010");
            // 
            // navBarStock
            // 
            this.navBarStock.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.navBarStock.Caption = "";
            this.navBarStock.Expanded = true;
            this.navBarStock.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList;
            this.navBarStock.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.comItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.stagItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ruptItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.rebDefItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.inventItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.alertItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.dispoItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.rebComptage)});
            this.navBarStock.Name = "navBarStock";
            // 
            // comItem
            // 
            this.comItem.Caption = "Entrée";
            this.comItem.Name = "comItem";
            this.comItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("comItem.SmallImage")));
            this.comItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comItem_LinkClicked);
            // 
            // stagItem
            // 
            this.stagItem.Caption = "Avoir";
            this.stagItem.Name = "stagItem";
            this.stagItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("stagItem.SmallImage")));
            this.stagItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.stagItem_LinkClicked);
            // 
            // ruptItem
            // 
            this.ruptItem.Caption = "Commande";
            this.ruptItem.Name = "ruptItem";
            this.ruptItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ruptItem.SmallImage")));
            this.ruptItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ruptItem_LinkClicked);
            // 
            // rebDefItem
            // 
            this.rebDefItem.Caption = "Rebut défection";
            this.rebDefItem.Name = "rebDefItem";
            this.rebDefItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("rebDefItem.SmallImage")));
            this.rebDefItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.rebDefItem_LinkClicked);
            // 
            // inventItem
            // 
            this.inventItem.Caption = "Rebut Vol";
            this.inventItem.Name = "inventItem";
            this.inventItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("inventItem.SmallImage")));
            this.inventItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.inventItem_LinkClicked);
            // 
            // alertItem
            // 
            this.alertItem.Caption = "Erreur de comptage";
            this.alertItem.Name = "alertItem";
            this.alertItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("alertItem.SmallImage")));
            this.alertItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.alertItem_LinkClicked);
            // 
            // dispoItem
            // 
            this.dispoItem.Caption = "Vente";
            this.dispoItem.Name = "dispoItem";
            this.dispoItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("dispoItem.SmallImage")));
            this.dispoItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.dispoItem_LinkClicked);
            // 
            // rebComptage
            // 
            this.rebComptage.Caption = "Comptage";
            this.rebComptage.Name = "rebComptage";
            this.rebComptage.SmallImage = ((System.Drawing.Image)(resources.GetObject("rebComptage.SmallImage")));
            this.rebComptage.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.rebComptage_LinkClicked);
            // 
            // diviseurCentre
            // 
            this.diviseurCentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diviseurCentre.IsSplitterFixed = true;
            this.diviseurCentre.Location = new System.Drawing.Point(0, 0);
            this.diviseurCentre.Name = "diviseurCentre";
            this.diviseurCentre.Panel1.Controls.Add(this.gridActions);
            this.diviseurCentre.Panel1.Text = "Panel1";
            this.diviseurCentre.Panel2.Text = "Panel2";
            this.diviseurCentre.Size = new System.Drawing.Size(843, 425);
            this.diviseurCentre.SplitterPosition = 823;
            this.diviseurCentre.TabIndex = 1;
            this.diviseurCentre.Text = "splitContainerControl1";
            // 
            // gridActions
            // 
            this.gridActions.ContextMenuStrip = this.clicDroit;
            this.gridActions.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridActions.Location = new System.Drawing.Point(0, 0);
            this.gridActions.MainView = this.grilleView;
            this.gridActions.Name = "gridActions";
            this.gridActions.Size = new System.Drawing.Size(823, 425);
            this.gridActions.TabIndex = 2;
            this.gridActions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grilleView});
            this.gridActions.DoubleClick += new System.EventHandler(this.gridActions_DoubleClick);
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
            // grilleView
            // 
            this.grilleView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTache,
            this.colOp,
            this.colNom,
            this.colVal});
            this.grilleView.GridControl = this.gridActions;
            this.grilleView.Name = "grilleView";
            this.grilleView.OptionsFilter.AllowFilterEditor = false;
            this.grilleView.OptionsFind.AlwaysVisible = true;
            this.grilleView.OptionsFind.FindNullPrompt = "";
            this.grilleView.OptionsView.ColumnAutoWidth = false;
            this.grilleView.OptionsView.ShowAutoFilterRow = true;
            this.grilleView.OptionsView.ShowFooter = true;
            this.grilleView.OptionsView.ShowGroupPanel = false;
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
            this.colTache.OptionsColumn.FixedWidth = true;
            this.colTache.Visible = true;
            this.colTache.VisibleIndex = 1;
            this.colTache.Width = 72;
            // 
            // colOp
            // 
            this.colOp.AppearanceHeader.Options.UseTextOptions = true;
            this.colOp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOp.Caption = "REFERENCE";
            this.colOp.FieldName = "Info";
            this.colOp.Name = "colOp";
            this.colOp.OptionsColumn.AllowFocus = false;
            this.colOp.OptionsColumn.FixedWidth = true;
            this.colOp.Visible = true;
            this.colOp.VisibleIndex = 2;
            this.colOp.Width = 220;
            // 
            // colNom
            // 
            this.colNom.AppearanceHeader.Options.UseTextOptions = true;
            this.colNom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNom.Caption = "NOMS OU RAISON SOCIALE";
            this.colNom.FieldName = "PersonName";
            this.colNom.Name = "colNom";
            this.colNom.OptionsColumn.AllowFocus = false;
            this.colNom.OptionsColumn.FixedWidth = true;
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 3;
            this.colNom.Width = 290;
            // 
            // colVal
            // 
            this.colVal.AppearanceHeader.Options.UseTextOptions = true;
            this.colVal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVal.Caption = "MONTANT";
            this.colVal.DisplayFormat.FormatString = "n0";
            this.colVal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVal.FieldName = "Montant";
            this.colVal.Name = "colVal";
            this.colVal.OptionsColumn.AllowFocus = false;
            this.colVal.OptionsColumn.FixedWidth = true;
            this.colVal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Montant", "{0:n0}")});
            this.colVal.Visible = true;
            this.colVal.VisibleIndex = 4;
            this.colVal.Width = 125;
            // 
            // fermer
            // 
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fermer.Location = new System.Drawing.Point(884, 0);
            this.fermer.LookAndFeel.SkinName = "Office 2013";
            this.fermer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(77, 26);
            this.fermer.TabIndex = 5;
            this.fermer.Text = "&Fermer";
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // myNum
            // 
            this.myNum.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.myNum.Location = new System.Drawing.Point(33, 9);
            this.myNum.Name = "myNum";
            this.myNum.Size = new System.Drawing.Size(6, 13);
            this.myNum.TabIndex = 4;
            this.myNum.Text = "0";
            // 
            // imprimer
            // 
            this.imprimer.Location = new System.Drawing.Point(796, 0);
            this.imprimer.LookAndFeel.SkinName = "Office 2013";
            this.imprimer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(77, 26);
            this.imprimer.TabIndex = 3;
            this.imprimer.Text = "Im&primer";
            this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
            // 
            // ListResume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fermer;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.Controls.Add(this.diviseurVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "ListResume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESUMES";
            this.Activated += new System.EventHandler(this.ListResume_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.diviseurVertical)).EndInit();
            this.diviseurVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diviseurHorizontal)).EndInit();
            this.diviseurHorizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarVrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diviseurCentre)).EndInit();
            this.diviseurCentre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridActions)).EndInit();
            this.clicDroit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilleView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl diviseurVertical;
        private DevExpress.XtraEditors.SplitContainerControl diviseurHorizontal;
        private DevExpress.XtraNavBar.NavBarControl navBarVrai;
        private DevExpress.XtraNavBar.NavBarGroup navBarStock;
        private DevExpress.XtraNavBar.NavBarItem comItem;
        private DevExpress.XtraNavBar.NavBarItem stagItem;
        private DevExpress.XtraNavBar.NavBarItem ruptItem;
        private DevExpress.XtraNavBar.NavBarItem inventItem;
        private DevExpress.XtraNavBar.NavBarItem alertItem;
        private DevExpress.XtraNavBar.NavBarItem dispoItem;
        private DevExpress.XtraEditors.SplitContainerControl diviseurCentre;
        private DevExpress.XtraEditors.SimpleButton imprimer;
        private DevExpress.XtraGrid.GridControl gridActions;
        private DevExpress.XtraGrid.Views.Grid.GridView grilleView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTache;
        private DevExpress.XtraGrid.Columns.GridColumn colOp;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn colVal;
        private DevExpress.XtraNavBar.NavBarItem rebDefItem;
        private DevExpress.XtraNavBar.NavBarItem rebComptage;
        private System.Windows.Forms.ContextMenuStrip clicDroit;
        private System.Windows.Forms.ToolStripMenuItem détaillerToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl myNum;
        private DevExpress.XtraEditors.SimpleButton fermer;
    }
}