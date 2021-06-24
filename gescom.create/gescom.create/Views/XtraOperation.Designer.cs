namespace gescom.create.Views
{
    partial class XtraOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraOperation));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridActions = new DevExpress.XtraGrid.GridControl();
            this.clicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.créationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grilleView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.codage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCateg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.place = new DevExpress.XtraGrid.Columns.GridColumn();
            this.designation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pachat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pdetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAchat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colErreur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDefect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvoir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDispo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCatal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col2Nom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coLocal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAtt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRupt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteCom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataArriv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Catalan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.valeursto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMtEstime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.myNum = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
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
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridActions);
            this.splitContainerControl1.Panel1.Controls.Add(this.myNum);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButton2);
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1908, 861);
            this.splitContainerControl1.SplitterPosition = 34;
            this.splitContainerControl1.TabIndex = 1;
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
            this.gridActions.Size = new System.Drawing.Size(1908, 815);
            this.gridActions.TabIndex = 3;
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
            this.codage,
            this.colCateg,
            this.place,
            this.designation,
            this.pachat,
            this.pdetail,
            this.colAchat,
            this.colVente,
            this.colEntre,
            this.colErreur,
            this.colDefect,
            this.colAvoir,
            this.colDispo,
            this.colQtest,
            this.colQte,
            this.colUnite,
            this.colPest,
            this.colPref,
            this.colInfo,
            this.colCatal,
            this.col2Nom,
            this.coLocal,
            this.colCder,
            this.colAtt,
            this.colRupt,
            this.colStop,
            this.DateFact,
            this.NoteCom,
            this.DataArriv,
            this.Catalan,
            this.valeursto,
            this.colMtEstime});
            this.grilleView.GridControl = this.gridActions;
            this.grilleView.Name = "grilleView";
            this.grilleView.OptionsFilter.AllowFilterEditor = false;
            this.grilleView.OptionsFind.AlwaysVisible = true;
            this.grilleView.OptionsFind.FindNullPrompt = "";
            this.grilleView.OptionsView.ShowAutoFilterRow = true;
            this.grilleView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grilleView.OptionsView.ShowFooter = true;
            this.grilleView.OptionsView.ShowGroupPanel = false;
            this.grilleView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grilleView_CellValueChanged);
            // 
            // codage
            // 
            this.codage.AppearanceHeader.Options.UseTextOptions = true;
            this.codage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.codage.Caption = "CODE";
            this.codage.FieldName = "SupCode";
            this.codage.Name = "codage";
            this.codage.Visible = true;
            this.codage.VisibleIndex = 0;
            this.codage.Width = 38;
            // 
            // colCateg
            // 
            this.colCateg.AppearanceHeader.Options.UseTextOptions = true;
            this.colCateg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCateg.Caption = "FAMILLE";
            this.colCateg.FieldName = "Categorie";
            this.colCateg.Name = "colCateg";
            this.colCateg.Visible = true;
            this.colCateg.VisibleIndex = 2;
            this.colCateg.Width = 51;
            // 
            // place
            // 
            this.place.AppearanceHeader.Options.UseTextOptions = true;
            this.place.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.place.Caption = "PLACE";
            this.place.FieldName = "Place";
            this.place.Name = "place";
            this.place.Visible = true;
            this.place.VisibleIndex = 1;
            this.place.Width = 65;
            // 
            // designation
            // 
            this.designation.AppearanceHeader.Options.UseTextOptions = true;
            this.designation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.designation.Caption = "DESIGNATION";
            this.designation.FieldName = "Designation";
            this.designation.Name = "designation";
            this.designation.Visible = true;
            this.designation.VisibleIndex = 3;
            this.designation.Width = 65;
            // 
            // pachat
            // 
            this.pachat.AppearanceHeader.Options.UseTextOptions = true;
            this.pachat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pachat.Caption = "P. ACHAT";
            this.pachat.DisplayFormat.FormatString = "n0";
            this.pachat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pachat.FieldName = "Pachat";
            this.pachat.Name = "pachat";
            this.pachat.OptionsColumn.AllowFocus = false;
            this.pachat.Visible = true;
            this.pachat.VisibleIndex = 4;
            this.pachat.Width = 66;
            // 
            // pdetail
            // 
            this.pdetail.AppearanceHeader.Options.UseTextOptions = true;
            this.pdetail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pdetail.Caption = "P. VENTE";
            this.pdetail.DisplayFormat.FormatString = "n0";
            this.pdetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pdetail.FieldName = "PDetail";
            this.pdetail.Name = "pdetail";
            this.pdetail.OptionsColumn.AllowFocus = false;
            this.pdetail.Visible = true;
            this.pdetail.VisibleIndex = 5;
            this.pdetail.Width = 66;
            // 
            // colAchat
            // 
            this.colAchat.AppearanceHeader.Options.UseTextOptions = true;
            this.colAchat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAchat.Caption = "CUMUL ACHAT";
            this.colAchat.DisplayFormat.FormatString = "n0";
            this.colAchat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAchat.FieldName = "Qachat";
            this.colAchat.Name = "colAchat";
            this.colAchat.OptionsColumn.AllowFocus = false;
            this.colAchat.Visible = true;
            this.colAchat.VisibleIndex = 6;
            this.colAchat.Width = 66;
            // 
            // colVente
            // 
            this.colVente.AppearanceHeader.Options.UseTextOptions = true;
            this.colVente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVente.Caption = "CUMUL VENTE";
            this.colVente.DisplayFormat.FormatString = "n0";
            this.colVente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVente.FieldName = "Qvente";
            this.colVente.Name = "colVente";
            this.colVente.OptionsColumn.AllowFocus = false;
            this.colVente.Visible = true;
            this.colVente.VisibleIndex = 7;
            this.colVente.Width = 66;
            // 
            // colEntre
            // 
            this.colEntre.AppearanceHeader.Options.UseTextOptions = true;
            this.colEntre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEntre.Caption = "CUMUL VOL";
            this.colEntre.DisplayFormat.FormatString = "n0";
            this.colEntre.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEntre.FieldName = "Qvol";
            this.colEntre.Name = "colEntre";
            this.colEntre.OptionsColumn.AllowFocus = false;
            this.colEntre.Visible = true;
            this.colEntre.VisibleIndex = 8;
            this.colEntre.Width = 66;
            // 
            // colErreur
            // 
            this.colErreur.AppearanceHeader.Options.UseTextOptions = true;
            this.colErreur.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colErreur.Caption = "ERR. ENTREE";
            this.colErreur.DisplayFormat.FormatString = "n0";
            this.colErreur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colErreur.FieldName = "Qercpt";
            this.colErreur.Name = "colErreur";
            this.colErreur.OptionsColumn.AllowFocus = false;
            this.colErreur.Visible = true;
            this.colErreur.VisibleIndex = 9;
            this.colErreur.Width = 66;
            // 
            // colDefect
            // 
            this.colDefect.AppearanceHeader.Options.UseTextOptions = true;
            this.colDefect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDefect.Caption = "CUMUL DEFECT";
            this.colDefect.DisplayFormat.FormatString = "n0";
            this.colDefect.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDefect.FieldName = "Qdefect";
            this.colDefect.Name = "colDefect";
            this.colDefect.OptionsColumn.AllowFocus = false;
            this.colDefect.Visible = true;
            this.colDefect.VisibleIndex = 10;
            this.colDefect.Width = 70;
            // 
            // colAvoir
            // 
            this.colAvoir.AppearanceHeader.Options.UseTextOptions = true;
            this.colAvoir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAvoir.Caption = "CUMUL AVOIR";
            this.colAvoir.DisplayFormat.FormatString = "n0";
            this.colAvoir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAvoir.FieldName = "Qavoir";
            this.colAvoir.Name = "colAvoir";
            this.colAvoir.OptionsColumn.AllowFocus = false;
            this.colAvoir.Visible = true;
            this.colAvoir.VisibleIndex = 11;
            this.colAvoir.Width = 66;
            // 
            // colDispo
            // 
            this.colDispo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colDispo.AppearanceCell.Options.UseBackColor = true;
            this.colDispo.AppearanceHeader.Options.UseTextOptions = true;
            this.colDispo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDispo.Caption = "DISPONIBLE";
            this.colDispo.DisplayFormat.FormatString = "n0";
            this.colDispo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDispo.FieldName = "QStock";
            this.colDispo.Name = "colDispo";
            this.colDispo.OptionsColumn.AllowFocus = false;
            this.colDispo.Visible = true;
            this.colDispo.VisibleIndex = 12;
            this.colDispo.Width = 66;
            // 
            // colQtest
            // 
            this.colQtest.AppearanceHeader.Options.UseTextOptions = true;
            this.colQtest.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtest.Caption = "QT ESTIME";
            this.colQtest.DisplayFormat.FormatString = "n0";
            this.colQtest.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQtest.FieldName = "QEstime";
            this.colQtest.Name = "colQtest";
            this.colQtest.OptionsColumn.AllowFocus = false;
            this.colQtest.Visible = true;
            this.colQtest.VisibleIndex = 14;
            this.colQtest.Width = 66;
            // 
            // colQte
            // 
            this.colQte.AppearanceHeader.Options.UseTextOptions = true;
            this.colQte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQte.Caption = "COMMANDEZ";
            this.colQte.DisplayFormat.FormatString = "n0";
            this.colQte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQte.FieldName = "Commander";
            this.colQte.Name = "colQte";
            this.colQte.Visible = true;
            this.colQte.VisibleIndex = 16;
            this.colQte.Width = 64;
            // 
            // colUnite
            // 
            this.colUnite.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnite.Caption = "UNITE";
            this.colUnite.FieldName = "Unite";
            this.colUnite.Name = "colUnite";
            this.colUnite.Visible = true;
            this.colUnite.VisibleIndex = 17;
            this.colUnite.Width = 64;
            // 
            // colPest
            // 
            this.colPest.AppearanceHeader.Options.UseTextOptions = true;
            this.colPest.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPest.Caption = "PRIX FRNS";
            this.colPest.DisplayFormat.FormatString = "n0";
            this.colPest.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPest.FieldName = "PEstime";
            this.colPest.Name = "colPest";
            this.colPest.OptionsColumn.AllowFocus = false;
            this.colPest.Visible = true;
            this.colPest.VisibleIndex = 13;
            this.colPest.Width = 66;
            // 
            // colPref
            // 
            this.colPref.AppearanceHeader.Options.UseTextOptions = true;
            this.colPref.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPref.Caption = "FRS PREF";
            this.colPref.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPref.FieldName = "Magpref";
            this.colPref.Name = "colPref";
            this.colPref.Visible = true;
            this.colPref.VisibleIndex = 19;
            this.colPref.Width = 78;
            // 
            // colInfo
            // 
            this.colInfo.AppearanceHeader.Options.UseTextOptions = true;
            this.colInfo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInfo.Caption = "INFO";
            this.colInfo.FieldName = "StateCommande";
            this.colInfo.Name = "colInfo";
            this.colInfo.OptionsColumn.AllowFocus = false;
            this.colInfo.Visible = true;
            this.colInfo.VisibleIndex = 20;
            this.colInfo.Width = 49;
            // 
            // colCatal
            // 
            this.colCatal.Caption = "UNITE FRNS";
            this.colCatal.FieldName = "Catalog";
            this.colCatal.Name = "colCatal";
            this.colCatal.Visible = true;
            this.colCatal.VisibleIndex = 18;
            this.colCatal.Width = 49;
            // 
            // col2Nom
            // 
            this.col2Nom.AppearanceHeader.Options.UseTextOptions = true;
            this.col2Nom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col2Nom.Caption = "NOM FRNS";
            this.col2Nom.FieldName = "Nomfrns";
            this.col2Nom.Name = "col2Nom";
            this.col2Nom.Visible = true;
            this.col2Nom.VisibleIndex = 21;
            this.col2Nom.Width = 49;
            // 
            // coLocal
            // 
            this.coLocal.AppearanceHeader.Options.UseTextOptions = true;
            this.coLocal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coLocal.Caption = "LOCALITE";
            this.coLocal.FieldName = "Localite";
            this.coLocal.Name = "coLocal";
            this.coLocal.Visible = true;
            this.coLocal.VisibleIndex = 22;
            this.coLocal.Width = 49;
            // 
            // colCder
            // 
            this.colCder.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.colCder.AppearanceCell.Options.UseForeColor = true;
            this.colCder.AppearanceHeader.ForeColor = System.Drawing.Color.Blue;
            this.colCder.AppearanceHeader.Options.UseForeColor = true;
            this.colCder.AppearanceHeader.Options.UseTextOptions = true;
            this.colCder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCder.Caption = "CMD";
            this.colCder.FieldName = "Etat0";
            this.colCder.Name = "colCder";
            this.colCder.OptionsColumn.AllowEdit = false;
            this.colCder.OptionsColumn.AllowFocus = false;
            this.colCder.Visible = true;
            this.colCder.VisibleIndex = 23;
            this.colCder.Width = 49;
            // 
            // colAtt
            // 
            this.colAtt.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colAtt.AppearanceCell.Options.UseForeColor = true;
            this.colAtt.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colAtt.AppearanceHeader.Options.UseForeColor = true;
            this.colAtt.AppearanceHeader.Options.UseTextOptions = true;
            this.colAtt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAtt.Caption = "EN TT";
            this.colAtt.FieldName = "Etat1";
            this.colAtt.Name = "colAtt";
            this.colAtt.OptionsColumn.AllowEdit = false;
            this.colAtt.OptionsColumn.AllowFocus = false;
            this.colAtt.Visible = true;
            this.colAtt.VisibleIndex = 24;
            this.colAtt.Width = 49;
            // 
            // colRupt
            // 
            this.colRupt.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colRupt.AppearanceCell.Options.UseForeColor = true;
            this.colRupt.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colRupt.AppearanceHeader.Options.UseForeColor = true;
            this.colRupt.AppearanceHeader.Options.UseTextOptions = true;
            this.colRupt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRupt.Caption = "RUPT";
            this.colRupt.FieldName = "Epuise";
            this.colRupt.Name = "colRupt";
            this.colRupt.OptionsColumn.AllowEdit = false;
            this.colRupt.OptionsColumn.AllowFocus = false;
            this.colRupt.Visible = true;
            this.colRupt.VisibleIndex = 25;
            this.colRupt.Width = 49;
            // 
            // colStop
            // 
            this.colStop.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colStop.AppearanceCell.Options.UseForeColor = true;
            this.colStop.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colStop.AppearanceHeader.Options.UseForeColor = true;
            this.colStop.AppearanceHeader.Options.UseTextOptions = true;
            this.colStop.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStop.Caption = "STOP";
            this.colStop.FieldName = "Arret";
            this.colStop.Name = "colStop";
            this.colStop.Visible = true;
            this.colStop.VisibleIndex = 26;
            this.colStop.Width = 49;
            // 
            // DateFact
            // 
            this.DateFact.Caption = "DATE-FACTURE";
            this.DateFact.FieldName = "T1";
            this.DateFact.Name = "DateFact";
            this.DateFact.Visible = true;
            this.DateFact.VisibleIndex = 28;
            this.DateFact.Width = 49;
            // 
            // NoteCom
            // 
            this.NoteCom.Caption = "NOTE/COMMANDE";
            this.NoteCom.FieldName = "Remark";
            this.NoteCom.Name = "NoteCom";
            this.NoteCom.Visible = true;
            this.NoteCom.VisibleIndex = 27;
            this.NoteCom.Width = 49;
            // 
            // DataArriv
            // 
            this.DataArriv.Caption = "DATE-ARRIVEE";
            this.DataArriv.FieldName = "B1";
            this.DataArriv.Name = "DataArriv";
            this.DataArriv.Visible = true;
            this.DataArriv.VisibleIndex = 29;
            this.DataArriv.Width = 49;
            // 
            // Catalan
            // 
            this.Catalan.Caption = "CATALOGUE";
            this.Catalan.FieldName = "Catalog";
            this.Catalan.Name = "Catalan";
            this.Catalan.Visible = true;
            this.Catalan.VisibleIndex = 30;
            this.Catalan.Width = 49;
            // 
            // valeursto
            // 
            this.valeursto.Caption = "VALSTOCK";
            this.valeursto.DisplayFormat.FormatString = "n0";
            this.valeursto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.valeursto.FieldName = "Vstock";
            this.valeursto.Name = "valeursto";
            this.valeursto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Vstock", "{0:n0}")});
            this.valeursto.Visible = true;
            this.valeursto.VisibleIndex = 31;
            this.valeursto.Width = 80;
            // 
            // colMtEstime
            // 
            this.colMtEstime.Caption = "MT ESTIME";
            this.colMtEstime.DisplayFormat.FormatString = "n0";
            this.colMtEstime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMtEstime.FieldName = "colMtEstime";
            this.colMtEstime.Name = "colMtEstime";
            this.colMtEstime.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colMtEstime", "{0:n0}")});
            this.colMtEstime.UnboundExpression = "[PEstime] * [QEstime]";
            this.colMtEstime.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colMtEstime.Visible = true;
            this.colMtEstime.VisibleIndex = 15;
            this.colMtEstime.Width = 64;
            // 
            // myNum
            // 
            this.myNum.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.myNum.Appearance.Options.UseForeColor = true;
            this.myNum.Location = new System.Drawing.Point(771, 12);
            this.myNum.Name = "myNum";
            this.myNum.Size = new System.Drawing.Size(6, 13);
            this.myNum.TabIndex = 1;
            this.myNum.Text = "0";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(1655, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "&Fermer";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1561, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Enregi&trer";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // XtraOperation
            // 
            this.AcceptButton = this.simpleButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 861);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMMANDE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.XtraOperation_Activated);
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
        private DevExpress.XtraGrid.Columns.GridColumn codage;
        private DevExpress.XtraGrid.Columns.GridColumn colCateg;
        private DevExpress.XtraGrid.Columns.GridColumn place;
        private DevExpress.XtraGrid.Columns.GridColumn designation;
        private DevExpress.XtraGrid.Columns.GridColumn pachat;
        private DevExpress.XtraGrid.Columns.GridColumn pdetail;
        private DevExpress.XtraGrid.Columns.GridColumn colAchat;
        private DevExpress.XtraGrid.Columns.GridColumn colVente;
        private DevExpress.XtraGrid.Columns.GridColumn colEntre;
        private DevExpress.XtraGrid.Columns.GridColumn colErreur;
        private DevExpress.XtraGrid.Columns.GridColumn colDefect;
        private DevExpress.XtraGrid.Columns.GridColumn colAvoir;
        private DevExpress.XtraGrid.Columns.GridColumn colDispo;
        private DevExpress.XtraGrid.Columns.GridColumn colQtest;
        private DevExpress.XtraGrid.Columns.GridColumn colQte;
        private DevExpress.XtraGrid.Columns.GridColumn colUnite;
        private DevExpress.XtraGrid.Columns.GridColumn colPest;
        private DevExpress.XtraGrid.Columns.GridColumn colPref;
        private DevExpress.XtraEditors.LabelControl myNum;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private System.Windows.Forms.ContextMenuStrip clicDroit;
        private System.Windows.Forms.ToolStripMenuItem créationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparerToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colCatal;
        private DevExpress.XtraGrid.Columns.GridColumn col2Nom;
        private DevExpress.XtraGrid.Columns.GridColumn coLocal;
        private DevExpress.XtraGrid.Columns.GridColumn colCder;
        private DevExpress.XtraGrid.Columns.GridColumn colAtt;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn colRupt;
        private DevExpress.XtraGrid.Columns.GridColumn colStop;
        private DevExpress.XtraGrid.Columns.GridColumn DateFact;
        private DevExpress.XtraGrid.Columns.GridColumn NoteCom;
        private DevExpress.XtraGrid.Columns.GridColumn DataArriv;
        private DevExpress.XtraGrid.Columns.GridColumn Catalan;
        private DevExpress.XtraGrid.Columns.GridColumn valeursto;
        private DevExpress.XtraGrid.Columns.GridColumn colMtEstime;
    }
}