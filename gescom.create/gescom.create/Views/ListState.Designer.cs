namespace gescom.create.Views
{
    partial class ListState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListState));
            this.diviseurVertical = new DevExpress.XtraEditors.SplitContainerControl();
            this.diviseurHorizontal = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarVrai = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarStock = new DevExpress.XtraNavBar.NavBarGroup();
            this.comItem = new DevExpress.XtraNavBar.NavBarItem();
            this.stagItem = new DevExpress.XtraNavBar.NavBarItem();
            this.ruptItem = new DevExpress.XtraNavBar.NavBarItem();
            this.inventItem = new DevExpress.XtraNavBar.NavBarItem();
            this.alertItem = new DevExpress.XtraNavBar.NavBarItem();
            this.dispoItem = new DevExpress.XtraNavBar.NavBarItem();
            this.diviseurCentre = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridActions = new DevExpress.XtraGrid.GridControl();
            this.clicDroit = new System.Windows.Forms.ContextMenuStrip();
            this.créationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grilleView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coVol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colErr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fermer = new DevExpress.XtraEditors.SimpleButton();
            this.nouveau = new DevExpress.XtraEditors.SimpleButton();
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
            this.diviseurVertical.IsSplitterFixed = true;
            this.diviseurVertical.Location = new System.Drawing.Point(0, 0);
            this.diviseurVertical.Name = "diviseurVertical";
            this.diviseurVertical.Panel1.Controls.Add(this.diviseurHorizontal);
            this.diviseurVertical.Panel1.Text = "Panel1";
            this.diviseurVertical.Panel2.Controls.Add(this.fermer);
            this.diviseurVertical.Panel2.Controls.Add(this.nouveau);
            this.diviseurVertical.Panel2.Controls.Add(this.myNum);
            this.diviseurVertical.Panel2.Controls.Add(this.imprimer);
            this.diviseurVertical.Panel2.Text = "Panel2";
            this.diviseurVertical.Size = new System.Drawing.Size(1803, 392);
            this.diviseurVertical.SplitterPosition = 342;
            this.diviseurVertical.TabIndex = 0;
            this.diviseurVertical.Text = "splitContainerControl1";
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
            this.diviseurHorizontal.Size = new System.Drawing.Size(1803, 342);
            this.diviseurHorizontal.SplitterPosition = 122;
            this.diviseurHorizontal.TabIndex = 0;
            this.diviseurHorizontal.Text = "splitContainerControl1";
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
            this.comItem});
            this.navBarVrai.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl;
            this.navBarVrai.Location = new System.Drawing.Point(0, 0);
            this.navBarVrai.LookAndFeel.SkinName = "VS2010";
            this.navBarVrai.LookAndFeel.UseDefaultLookAndFeel = false;
            this.navBarVrai.Name = "navBarVrai";
            this.navBarVrai.OptionsNavPane.ExpandedWidth = 122;
            this.navBarVrai.Size = new System.Drawing.Size(122, 342);
            this.navBarVrai.TabIndex = 0;
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
            new DevExpress.XtraNavBar.NavBarItemLink(this.inventItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.alertItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.dispoItem)});
            this.navBarStock.Name = "navBarStock";
            // 
            // comItem
            // 
            this.comItem.Caption = "A commander";
            this.comItem.Name = "comItem";
            this.comItem.SmallImage = global::gescom.create.Properties.Resources.achat;
            this.comItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comItem_LinkClicked);
            // 
            // stagItem
            // 
            this.stagItem.Caption = "Stagnation";
            this.stagItem.Name = "stagItem";
            this.stagItem.SmallImage = global::gescom.create.Properties.Resources.stagnation;
            this.stagItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.stagItem_LinkClicked);
            // 
            // ruptItem
            // 
            this.ruptItem.Caption = "Rupture";
            this.ruptItem.Name = "ruptItem";
            this.ruptItem.SmallImage = global::gescom.create.Properties.Resources.rupture;
            this.ruptItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ruptItem_LinkClicked);
            // 
            // inventItem
            // 
            this.inventItem.Caption = "Inventaire";
            this.inventItem.Name = "inventItem";
            this.inventItem.SmallImage = global::gescom.create.Properties.Resources.inventaire;
            this.inventItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.inventItem_LinkClicked);
            // 
            // alertItem
            // 
            this.alertItem.Caption = "Alerte";
            this.alertItem.Name = "alertItem";
            this.alertItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("alertItem.SmallImage")));
            this.alertItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.alertItem_LinkClicked);
            // 
            // dispoItem
            // 
            this.dispoItem.Caption = "Disponible";
            this.dispoItem.Name = "dispoItem";
            this.dispoItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("dispoItem.SmallImage")));
            this.dispoItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.dispoItem_LinkClicked);
            // 
            // diviseurCentre
            // 
            this.diviseurCentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diviseurCentre.Location = new System.Drawing.Point(0, 0);
            this.diviseurCentre.Name = "diviseurCentre";
            this.diviseurCentre.Panel1.Controls.Add(this.gridActions);
            this.diviseurCentre.Panel1.Text = "Panel1";
            this.diviseurCentre.Panel2.Text = "Panel2";
            this.diviseurCentre.Size = new System.Drawing.Size(1669, 342);
            this.diviseurCentre.SplitterPosition = 1651;
            this.diviseurCentre.TabIndex = 0;
            this.diviseurCentre.Text = "splitContainerControl1";
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
            this.gridActions.Size = new System.Drawing.Size(1651, 342);
            this.gridActions.TabIndex = 1;
            this.gridActions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grilleView});
            this.gridActions.DoubleClick += new System.EventHandler(this.gridActions_DoubleClick);
            // 
            // clicDroit
            // 
            this.clicDroit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créationToolStripMenuItem,
            this.comparerToolStripMenuItem});
            this.clicDroit.Name = "clicDroit";
            this.clicDroit.Size = new System.Drawing.Size(191, 48);
            // 
            // créationToolStripMenuItem
            // 
            this.créationToolStripMenuItem.Name = "créationToolStripMenuItem";
            this.créationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.créationToolStripMenuItem.Text = "&Création article";
            this.créationToolStripMenuItem.Click += new System.EventHandler(this.créationToolStripMenuItem_Click);
            // 
            // comparerToolStripMenuItem
            // 
            this.comparerToolStripMenuItem.Name = "comparerToolStripMenuItem";
            this.comparerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.comparerToolStripMenuItem.Text = "&Modification générale";
            this.comparerToolStripMenuItem.Click += new System.EventHandler(this.comparerToolStripMenuItem_Click);
            // 
            // grilleView
            // 
            this.grilleView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colName,
            this.colPrix,
            this.colStock,
            this.colEst,
            this.colPerv,
            this.colPref,
            this.colMag,
            this.colCa,
            this.colCv,
            this.colUnt,
            this.coVol,
            this.colreb,
            this.colErr,
            this.colAv,
            this.coloF,
            this.coloT});
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
            // colCode
            // 
            this.colCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCode.Caption = "CODE";
            this.colCode.DisplayFormat.FormatString = "n0";
            this.colCode.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCode.FieldName = "Codage";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.FixedWidth = true;
            this.colCode.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Codage", "{0:n0}")});
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 59;
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.Caption = "DESIGNATION";
            this.colName.FieldName = "Designation";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.FixedWidth = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 307;
            // 
            // colPrix
            // 
            this.colPrix.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrix.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrix.Caption = "PRIX DETAIL";
            this.colPrix.DisplayFormat.FormatString = "n0";
            this.colPrix.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrix.FieldName = "PDetail";
            this.colPrix.Name = "colPrix";
            this.colPrix.OptionsColumn.FixedWidth = true;
            this.colPrix.Visible = true;
            this.colPrix.VisibleIndex = 2;
            // 
            // colStock
            // 
            this.colStock.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon;
            this.colStock.AppearanceCell.Options.UseBackColor = true;
            this.colStock.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock.Caption = "DISPO";
            this.colStock.DisplayFormat.FormatString = "n0";
            this.colStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colStock.FieldName = "QStock";
            this.colStock.Name = "colStock";
            this.colStock.OptionsColumn.AllowFocus = false;
            this.colStock.OptionsColumn.FixedWidth = true;
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 3;
            // 
            // colEst
            // 
            this.colEst.AppearanceHeader.Options.UseTextOptions = true;
            this.colEst.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEst.Caption = "QT ESTIME";
            this.colEst.DisplayFormat.FormatString = "n0";
            this.colEst.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEst.FieldName = "QEstime";
            this.colEst.Name = "colEst";
            this.colEst.OptionsColumn.AllowFocus = false;
            this.colEst.OptionsColumn.FixedWidth = true;
            this.colEst.Visible = true;
            this.colEst.VisibleIndex = 4;
            // 
            // colPerv
            // 
            this.colPerv.AppearanceHeader.Options.UseTextOptions = true;
            this.colPerv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPerv.Caption = "PRIX ESTIME";
            this.colPerv.DisplayFormat.FormatString = "n0";
            this.colPerv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPerv.FieldName = "PEstime";
            this.colPerv.Name = "colPerv";
            this.colPerv.OptionsColumn.AllowFocus = false;
            this.colPerv.OptionsColumn.FixedWidth = true;
            this.colPerv.Visible = true;
            this.colPerv.VisibleIndex = 5;
            // 
            // colPref
            // 
            this.colPref.AppearanceHeader.Options.UseTextOptions = true;
            this.colPref.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPref.Caption = "FOURNISSEUR";
            this.colPref.FieldName = "Frs";
            this.colPref.Name = "colPref";
            this.colPref.OptionsColumn.FixedWidth = true;
            this.colPref.Visible = true;
            this.colPref.VisibleIndex = 6;
            this.colPref.Width = 109;
            // 
            // colMag
            // 
            this.colMag.AppearanceHeader.Options.UseTextOptions = true;
            this.colMag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMag.Caption = "PREFERENCE";
            this.colMag.FieldName = "Magpref";
            this.colMag.Name = "colMag";
            this.colMag.OptionsColumn.FixedWidth = true;
            this.colMag.Visible = true;
            this.colMag.VisibleIndex = 7;
            this.colMag.Width = 113;
            // 
            // colCa
            // 
            this.colCa.AppearanceHeader.Options.UseTextOptions = true;
            this.colCa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCa.Caption = "CUMUL ACHAT";
            this.colCa.DisplayFormat.FormatString = "n0";
            this.colCa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCa.FieldName = "Qachat";
            this.colCa.Name = "colCa";
            this.colCa.OptionsColumn.AllowFocus = false;
            this.colCa.OptionsColumn.FixedWidth = true;
            this.colCa.Visible = true;
            this.colCa.VisibleIndex = 8;
            this.colCa.Width = 92;
            // 
            // colCv
            // 
            this.colCv.AppearanceHeader.Options.UseTextOptions = true;
            this.colCv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCv.Caption = "CUMUL VENTE";
            this.colCv.DisplayFormat.FormatString = "n0";
            this.colCv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCv.FieldName = "Qvente";
            this.colCv.Name = "colCv";
            this.colCv.OptionsColumn.AllowFocus = false;
            this.colCv.OptionsColumn.FixedWidth = true;
            this.colCv.Visible = true;
            this.colCv.VisibleIndex = 9;
            this.colCv.Width = 96;
            // 
            // colUnt
            // 
            this.colUnt.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnt.Caption = "UNITE";
            this.colUnt.FieldName = "Unite";
            this.colUnt.Name = "colUnt";
            this.colUnt.OptionsColumn.FixedWidth = true;
            this.colUnt.Visible = true;
            this.colUnt.VisibleIndex = 14;
            this.colUnt.Width = 60;
            // 
            // coVol
            // 
            this.coVol.AppearanceHeader.Options.UseTextOptions = true;
            this.coVol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coVol.Caption = "CUMUL VOL";
            this.coVol.DisplayFormat.FormatString = "n0";
            this.coVol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coVol.FieldName = "Qvol";
            this.coVol.Name = "coVol";
            this.coVol.OptionsColumn.AllowFocus = false;
            this.coVol.OptionsColumn.FixedWidth = true;
            this.coVol.Visible = true;
            this.coVol.VisibleIndex = 10;
            this.coVol.Width = 95;
            // 
            // colreb
            // 
            this.colreb.AppearanceHeader.Options.UseTextOptions = true;
            this.colreb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colreb.Caption = "CUMUL REBUT";
            this.colreb.DisplayFormat.FormatString = "n0";
            this.colreb.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colreb.FieldName = "Qdefect";
            this.colreb.Name = "colreb";
            this.colreb.OptionsColumn.AllowFocus = false;
            this.colreb.OptionsColumn.FixedWidth = true;
            this.colreb.Visible = true;
            this.colreb.VisibleIndex = 11;
            this.colreb.Width = 91;
            // 
            // colErr
            // 
            this.colErr.AppearanceHeader.Options.UseTextOptions = true;
            this.colErr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colErr.Caption = "CUMUL ERREUR";
            this.colErr.DisplayFormat.FormatString = "n0";
            this.colErr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colErr.FieldName = "Qercpt";
            this.colErr.Name = "colErr";
            this.colErr.OptionsColumn.AllowFocus = false;
            this.colErr.OptionsColumn.FixedWidth = true;
            this.colErr.Visible = true;
            this.colErr.VisibleIndex = 13;
            this.colErr.Width = 93;
            // 
            // colAv
            // 
            this.colAv.AppearanceHeader.Options.UseTextOptions = true;
            this.colAv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAv.Caption = "CUMUL AVOIR";
            this.colAv.DisplayFormat.FormatString = "n0";
            this.colAv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAv.FieldName = "Qavoir";
            this.colAv.Name = "colAv";
            this.colAv.OptionsColumn.AllowFocus = false;
            this.colAv.OptionsColumn.FixedWidth = true;
            this.colAv.Visible = true;
            this.colAv.VisibleIndex = 12;
            this.colAv.Width = 91;
            // 
            // coloF
            // 
            this.coloF.AppearanceHeader.Options.UseTextOptions = true;
            this.coloF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coloF.Caption = "FORMEL";
            this.coloF.FieldName = "Formel";
            this.coloF.Name = "coloF";
            this.coloF.OptionsColumn.AllowFocus = false;
            this.coloF.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Formel", "{0:n0}")});
            this.coloF.Visible = true;
            this.coloF.VisibleIndex = 16;
            this.coloF.Width = 48;
            // 
            // coloT
            // 
            this.coloT.AppearanceHeader.Options.UseTextOptions = true;
            this.coloT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coloT.Caption = "TAXABLE";
            this.coloT.FieldName = "Taxed";
            this.coloT.Name = "coloT";
            this.coloT.OptionsColumn.AllowFocus = false;
            this.coloT.OptionsColumn.FixedWidth = true;
            this.coloT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Taxed", "{0:n0}")});
            this.coloT.Visible = true;
            this.coloT.VisibleIndex = 15;
            this.coloT.Width = 56;
            // 
            // fermer
            // 
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fermer.Location = new System.Drawing.Point(1692, 2);
            this.fermer.LookAndFeel.SkinName = "Office 2013";
            this.fermer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(70, 26);
            this.fermer.TabIndex = 7;
            this.fermer.Text = "&Fermer";
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // nouveau
            // 
            this.nouveau.Location = new System.Drawing.Point(1532, 2);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(70, 26);
            this.nouveau.TabIndex = 6;
            this.nouveau.Text = "&Nouveau";
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // myNum
            // 
            this.myNum.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.myNum.Location = new System.Drawing.Point(205, 11);
            this.myNum.Name = "myNum";
            this.myNum.Size = new System.Drawing.Size(6, 13);
            this.myNum.TabIndex = 5;
            this.myNum.Text = "0";
            // 
            // imprimer
            // 
            this.imprimer.Location = new System.Drawing.Point(1612, 2);
            this.imprimer.LookAndFeel.SkinName = "Office 2013";
            this.imprimer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(70, 26);
            this.imprimer.TabIndex = 3;
            this.imprimer.Text = "Im&primer";
            this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
            // 
            // ListState
            // 
            this.AcceptButton = this.nouveau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fermer;
            this.ClientSize = new System.Drawing.Size(1803, 392);
            this.Controls.Add(this.diviseurVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "ListState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETAT DE PRODUITS";
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
        private DevExpress.XtraGrid.GridControl gridActions;
        private DevExpress.XtraGrid.Views.Grid.GridView grilleView;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrix;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colEst;
        private DevExpress.XtraGrid.Columns.GridColumn colPerv;
        private DevExpress.XtraGrid.Columns.GridColumn colPref;
        private DevExpress.XtraGrid.Columns.GridColumn colCa;
        private DevExpress.XtraGrid.Columns.GridColumn colCv;
        private DevExpress.XtraGrid.Columns.GridColumn colUnt;
        private DevExpress.XtraEditors.SimpleButton imprimer;
        private DevExpress.XtraEditors.LabelControl myNum;
        private System.Windows.Forms.ContextMenuStrip clicDroit;
        private System.Windows.Forms.ToolStripMenuItem créationToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colMag;
        private System.Windows.Forms.ToolStripMenuItem comparerToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn coVol;
        private DevExpress.XtraGrid.Columns.GridColumn colreb;
        private DevExpress.XtraGrid.Columns.GridColumn colErr;
        private DevExpress.XtraEditors.SimpleButton nouveau;
        private DevExpress.XtraGrid.Columns.GridColumn colAv;
        private DevExpress.XtraGrid.Columns.GridColumn coloF;
        private DevExpress.XtraGrid.Columns.GridColumn coloT;
        private DevExpress.XtraEditors.SimpleButton fermer;
    }
}