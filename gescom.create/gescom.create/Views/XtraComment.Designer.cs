namespace gescom.create.Views
{
    partial class XtraComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraComment));
            this.gridActions = new DevExpress.XtraGrid.GridControl();
            this.clicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.créationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grilleView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OtherInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReponse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComptage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLocal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFrName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colopAch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRUPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Familier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RefCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cataCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMtestime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coLumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlacer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSign = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFourniss = new DevExpress.XtraGrid.Columns.GridColumn();
            this.myNum = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridActions)).BeginInit();
            this.clicDroit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilleView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridActions
            // 
            this.gridActions.ContextMenuStrip = this.clicDroit;
            this.gridActions.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridActions.Location = new System.Drawing.Point(0, 0);
            this.gridActions.LookAndFeel.SkinName = "Office 2013";
            this.gridActions.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridActions.MainView = this.grilleView;
            this.gridActions.Name = "gridActions";
            this.gridActions.Size = new System.Drawing.Size(1908, 950);
            this.gridActions.TabIndex = 2;
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
            this.colPlace,
            this.colName,
            this.colPrix,
            this.colStock,
            this.colEst,
            this.colPerv,
            this.OtherInfo,
            this.colMag,
            this.colCa,
            this.colCv,
            this.colUnt,
            this.colUF,
            this.colDate,
            this.colMessage,
            this.colReponse,
            this.colQte,
            this.colComptage,
            this.colB1,
            this.colB2,
            this.colRem,
            this.colRq,
            this.colObs,
            this.gridComment,
            this.gridLocal,
            this.colFrName,
            this.colVoir,
            this.colPrice,
            this.colopAch,
            this.colCMD,
            this.colTT,
            this.colRUPT,
            this.colSTOP,
            this.Familier,
            this.RefCol,
            this.cataCol,
            this.colMtestime,
            this.coLumn,
            this.gridColCheck,
            this.colPlacer,
            this.colVerif,
            this.colState,
            this.colVers,
            this.colSign,
            this.colProj,
            this.colACA,
            this.colComm,
            this.colFourniss});
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
            this.colCode.AppearanceCell.BackColor = System.Drawing.Color.LightYellow;
            this.colCode.AppearanceCell.Options.UseBackColor = true;
            this.colCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCode.Caption = "CODE";
            this.colCode.DisplayFormat.FormatString = "n0";
            this.colCode.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCode.FieldName = "SupCode";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.FixedWidth = true;
            this.colCode.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Codage", "{0:n0}")});
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 7;
            // 
            // colPlace
            // 
            this.colPlace.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlace.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlace.Caption = "PLACE";
            this.colPlace.FieldName = "Place";
            this.colPlace.Name = "colPlace";
            this.colPlace.Visible = true;
            this.colPlace.VisibleIndex = 8;
            this.colPlace.Width = 100;
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.Caption = "DESIGNATION";
            this.colName.FieldName = "Designation";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 9;
            this.colName.Width = 300;
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
            this.colPrix.Visible = true;
            this.colPrix.VisibleIndex = 12;
            // 
            // colStock
            // 
            this.colStock.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon;
            this.colStock.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStock.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.colStock.AppearanceCell.Options.UseBackColor = true;
            this.colStock.AppearanceCell.Options.UseFont = true;
            this.colStock.AppearanceCell.Options.UseForeColor = true;
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
            this.colStock.VisibleIndex = 15;
            this.colStock.Width = 59;
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
            this.colEst.Visible = true;
            this.colEst.VisibleIndex = 33;
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
            this.colPerv.Visible = true;
            this.colPerv.VisibleIndex = 35;
            // 
            // OtherInfo
            // 
            this.OtherInfo.AppearanceHeader.Options.UseTextOptions = true;
            this.OtherInfo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.OtherInfo.Caption = "PASS";
            this.OtherInfo.FieldName = "OtherInfo";
            this.OtherInfo.Name = "OtherInfo";
            this.OtherInfo.Visible = true;
            this.OtherInfo.VisibleIndex = 43;
            this.OtherInfo.Width = 83;
            // 
            // colMag
            // 
            this.colMag.AppearanceHeader.Options.UseTextOptions = true;
            this.colMag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMag.Caption = "FOURNISSEUR";
            this.colMag.FieldName = "Magpref";
            this.colMag.Name = "colMag";
            this.colMag.Visible = true;
            this.colMag.VisibleIndex = 31;
            this.colMag.Width = 106;
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
            this.colCa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qachat", "{0:n0}")});
            this.colCa.Visible = true;
            this.colCa.VisibleIndex = 13;
            this.colCa.Width = 82;
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
            this.colCv.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qvente", "{0:n0}")});
            this.colCv.Visible = true;
            this.colCv.VisibleIndex = 14;
            this.colCv.Width = 85;
            // 
            // colUnt
            // 
            this.colUnt.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnt.Caption = "UNITE";
            this.colUnt.FieldName = "Unite";
            this.colUnt.Name = "colUnt";
            this.colUnt.Visible = true;
            this.colUnt.VisibleIndex = 16;
            this.colUnt.Width = 60;
            // 
            // colUF
            // 
            this.colUF.AppearanceHeader.Options.UseTextOptions = true;
            this.colUF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUF.Caption = "UNITE FRNS";
            this.colUF.FieldName = "UNT_FRNS";
            this.colUF.Name = "colUF";
            this.colUF.Visible = true;
            this.colUF.VisibleIndex = 34;
            // 
            // colDate
            // 
            this.colDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate.Caption = "DATE-FACTURE";
            this.colDate.FieldName = "T1";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 19;
            this.colDate.Width = 68;
            // 
            // colMessage
            // 
            this.colMessage.AppearanceHeader.Options.UseTextOptions = true;
            this.colMessage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMessage.Caption = "MESSAGE";
            this.colMessage.FieldName = "S1";
            this.colMessage.Name = "colMessage";
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 27;
            this.colMessage.Width = 154;
            // 
            // colReponse
            // 
            this.colReponse.AppearanceHeader.Options.UseTextOptions = true;
            this.colReponse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReponse.Caption = "REPONSE";
            this.colReponse.FieldName = "S2";
            this.colReponse.Name = "colReponse";
            this.colReponse.Visible = true;
            this.colReponse.VisibleIndex = 28;
            this.colReponse.Width = 135;
            // 
            // colQte
            // 
            this.colQte.AppearanceHeader.Options.UseTextOptions = true;
            this.colQte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQte.Caption = "Qté-Achat";
            this.colQte.DisplayFormat.FormatString = "n0";
            this.colQte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQte.FieldName = "Q1";
            this.colQte.Name = "colQte";
            this.colQte.Visible = true;
            this.colQte.VisibleIndex = 29;
            // 
            // colComptage
            // 
            this.colComptage.AppearanceHeader.Options.UseTextOptions = true;
            this.colComptage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colComptage.Caption = "COMPTAGE";
            this.colComptage.DisplayFormat.FormatString = "n0";
            this.colComptage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colComptage.FieldName = "Q2";
            this.colComptage.Name = "colComptage";
            this.colComptage.Visible = true;
            this.colComptage.VisibleIndex = 30;
            // 
            // colB1
            // 
            this.colB1.AppearanceHeader.Options.UseTextOptions = true;
            this.colB1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB1.Caption = "Date arrivée";
            this.colB1.FieldName = "B1";
            this.colB1.Name = "colB1";
            this.colB1.Visible = true;
            this.colB1.VisibleIndex = 20;
            // 
            // colB2
            // 
            this.colB2.AppearanceHeader.Options.UseTextOptions = true;
            this.colB2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB2.Caption = "TRANSPORTEUR";
            this.colB2.FieldName = "B2";
            this.colB2.Name = "colB2";
            this.colB2.Visible = true;
            this.colB2.VisibleIndex = 44;
            this.colB2.Width = 91;
            // 
            // colRem
            // 
            this.colRem.AppearanceHeader.Options.UseTextOptions = true;
            this.colRem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRem.Caption = "NOTE/COMMANDE";
            this.colRem.FieldName = "Remark";
            this.colRem.Name = "colRem";
            this.colRem.Visible = true;
            this.colRem.VisibleIndex = 17;
            // 
            // colRq
            // 
            this.colRq.AppearanceHeader.Options.UseTextOptions = true;
            this.colRq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRq.Caption = "OBSERVATION";
            this.colRq.FieldName = "Remarque";
            this.colRq.Name = "colRq";
            this.colRq.Visible = true;
            this.colRq.VisibleIndex = 18;
            // 
            // colObs
            // 
            this.colObs.AppearanceHeader.Options.UseTextOptions = true;
            this.colObs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colObs.Caption = "COMMENTAIRE";
            this.colObs.FieldName = "Observation";
            this.colObs.Name = "colObs";
            this.colObs.Visible = true;
            this.colObs.VisibleIndex = 38;
            // 
            // gridComment
            // 
            this.gridComment.AppearanceHeader.Options.UseTextOptions = true;
            this.gridComment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridComment.Caption = "VALSTOCK";
            this.gridComment.DisplayFormat.FormatString = "n0";
            this.gridComment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridComment.FieldName = "Vstock";
            this.gridComment.Name = "gridComment";
            this.gridComment.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Vstock", "TOTAL={0:n0}")});
            this.gridComment.Visible = true;
            this.gridComment.VisibleIndex = 47;
            // 
            // gridLocal
            // 
            this.gridLocal.AppearanceHeader.Options.UseTextOptions = true;
            this.gridLocal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLocal.Caption = "LOCALITE";
            this.gridLocal.FieldName = "Localite";
            this.gridLocal.Name = "gridLocal";
            this.gridLocal.Visible = true;
            this.gridLocal.VisibleIndex = 46;
            // 
            // colFrName
            // 
            this.colFrName.AppearanceHeader.Options.UseTextOptions = true;
            this.colFrName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFrName.Caption = "DESIGN FOURNISSEUR";
            this.colFrName.FieldName = "Nomfrns";
            this.colFrName.Name = "colFrName";
            this.colFrName.Visible = true;
            this.colFrName.VisibleIndex = 32;
            // 
            // colVoir
            // 
            this.colVoir.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colVoir.AppearanceCell.Options.UseBackColor = true;
            this.colVoir.AppearanceHeader.Options.UseTextOptions = true;
            this.colVoir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVoir.Caption = "A PRIX";
            this.colVoir.FieldName = "VoirPrix";
            this.colVoir.Name = "colVoir";
            this.colVoir.Visible = true;
            this.colVoir.VisibleIndex = 24;
            // 
            // colPrice
            // 
            this.colPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colPrice.AppearanceCell.Options.UseBackColor = true;
            this.colPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrice.Caption = "A ENTRER";
            this.colPrice.FieldName = "VoirEntre";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 25;
            // 
            // colopAch
            // 
            this.colopAch.AppearanceHeader.Options.UseTextOptions = true;
            this.colopAch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colopAch.Caption = "PRIX ACHAT";
            this.colopAch.DisplayFormat.FormatString = "n0";
            this.colopAch.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colopAch.FieldName = "Pachat";
            this.colopAch.Name = "colopAch";
            this.colopAch.Visible = true;
            this.colopAch.VisibleIndex = 11;
            // 
            // colCMD
            // 
            this.colCMD.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colCMD.AppearanceCell.Options.UseForeColor = true;
            this.colCMD.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colCMD.AppearanceHeader.Options.UseForeColor = true;
            this.colCMD.AppearanceHeader.Options.UseTextOptions = true;
            this.colCMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCMD.Caption = "MdH";
            this.colCMD.FieldName = "Etat0";
            this.colCMD.Name = "colCMD";
            this.colCMD.OptionsColumn.AllowEdit = false;
            this.colCMD.OptionsColumn.AllowFocus = false;
            this.colCMD.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colCMD.Visible = true;
            this.colCMD.VisibleIndex = 39;
            // 
            // colTT
            // 
            this.colTT.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colTT.AppearanceCell.Options.UseForeColor = true;
            this.colTT.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colTT.AppearanceHeader.Options.UseForeColor = true;
            this.colTT.AppearanceHeader.Options.UseTextOptions = true;
            this.colTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTT.Caption = "IMMEDIAT";
            this.colTT.FieldName = "VoirPrior";
            this.colTT.Name = "colTT";
            this.colTT.OptionsColumn.AllowEdit = false;
            this.colTT.OptionsColumn.AllowFocus = false;
            this.colTT.Visible = true;
            this.colTT.VisibleIndex = 22;
            // 
            // colRUPT
            // 
            this.colRUPT.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colRUPT.AppearanceCell.Options.UseForeColor = true;
            this.colRUPT.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colRUPT.AppearanceHeader.Options.UseForeColor = true;
            this.colRUPT.AppearanceHeader.Options.UseTextOptions = true;
            this.colRUPT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRUPT.Caption = "RUPT";
            this.colRUPT.FieldName = "Epuise";
            this.colRUPT.Name = "colRUPT";
            this.colRUPT.OptionsColumn.AllowEdit = false;
            this.colRUPT.OptionsColumn.AllowFocus = false;
            this.colRUPT.Visible = true;
            this.colRUPT.VisibleIndex = 41;
            // 
            // colSTOP
            // 
            this.colSTOP.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colSTOP.AppearanceCell.Options.UseForeColor = true;
            this.colSTOP.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colSTOP.AppearanceHeader.Options.UseForeColor = true;
            this.colSTOP.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTOP.Caption = "STOP";
            this.colSTOP.FieldName = "Arret";
            this.colSTOP.Name = "colSTOP";
            this.colSTOP.OptionsColumn.AllowEdit = false;
            this.colSTOP.OptionsColumn.AllowFocus = false;
            this.colSTOP.Visible = true;
            this.colSTOP.VisibleIndex = 42;
            // 
            // Familier
            // 
            this.Familier.AppearanceHeader.Options.UseTextOptions = true;
            this.Familier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Familier.Caption = "FAMILLE";
            this.Familier.FieldName = "Categorie";
            this.Familier.Name = "Familier";
            this.Familier.Visible = true;
            this.Familier.VisibleIndex = 45;
            // 
            // RefCol
            // 
            this.RefCol.AppearanceHeader.Options.UseTextOptions = true;
            this.RefCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RefCol.Caption = "REFERENCE";
            this.RefCol.FieldName = "Refuse";
            this.RefCol.Name = "RefCol";
            this.RefCol.Visible = true;
            this.RefCol.VisibleIndex = 37;
            // 
            // cataCol
            // 
            this.cataCol.AppearanceHeader.Options.UseTextOptions = true;
            this.cataCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cataCol.Caption = "CATALOGUE";
            this.cataCol.FieldName = "CATALOG";
            this.cataCol.Name = "cataCol";
            this.cataCol.Visible = true;
            this.cataCol.VisibleIndex = 21;
            // 
            // colMtestime
            // 
            this.colMtestime.AppearanceHeader.Options.UseTextOptions = true;
            this.colMtestime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMtestime.Caption = "MT ESTIME";
            this.colMtestime.DisplayFormat.FormatString = "n0";
            this.colMtestime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMtestime.FieldName = "colMtestime";
            this.colMtestime.Name = "colMtestime";
            this.colMtestime.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colMtestime", "{0:n0}")});
            this.colMtestime.UnboundExpression = "[PEstime] * [QEstime]";
            this.colMtestime.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colMtestime.Visible = true;
            this.colMtestime.VisibleIndex = 36;
            // 
            // coLumn
            // 
            this.coLumn.AppearanceCell.BackColor = System.Drawing.Color.Azure;
            this.coLumn.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coLumn.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.coLumn.AppearanceCell.Options.UseBackColor = true;
            this.coLumn.AppearanceCell.Options.UseFont = true;
            this.coLumn.AppearanceCell.Options.UseForeColor = true;
            this.coLumn.AppearanceCell.Options.UseTextOptions = true;
            this.coLumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coLumn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coLumn.AppearanceHeader.Options.UseTextOptions = true;
            this.coLumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coLumn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coLumn.Caption = "MSQ";
            this.coLumn.DisplayFormat.FormatString = "n0";
            this.coLumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coLumn.FieldName = "L";
            this.coLumn.Name = "coLumn";
            this.coLumn.OptionsColumn.AllowEdit = false;
            this.coLumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "L", "{0}")});
            this.coLumn.Visible = true;
            this.coLumn.VisibleIndex = 3;
            this.coLumn.Width = 41;
            // 
            // gridColCheck
            // 
            this.gridColCheck.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.gridColCheck.AppearanceCell.Options.UseForeColor = true;
            this.gridColCheck.AppearanceCell.Options.UseTextOptions = true;
            this.gridColCheck.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColCheck.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColCheck.AppearanceHeader.ForeColor = System.Drawing.Color.Blue;
            this.gridColCheck.AppearanceHeader.Options.UseForeColor = true;
            this.gridColCheck.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColCheck.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColCheck.Caption = "TMdH";
            this.gridColCheck.FieldName = "CheckCommande";
            this.gridColCheck.Name = "gridColCheck";
            this.gridColCheck.Visible = true;
            this.gridColCheck.VisibleIndex = 40;
            this.gridColCheck.Width = 53;
            // 
            // colPlacer
            // 
            this.colPlacer.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlacer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlacer.Caption = "A PLACER";
            this.colPlacer.FieldName = "VoirPlace";
            this.colPlacer.Name = "colPlacer";
            this.colPlacer.Visible = true;
            this.colPlacer.VisibleIndex = 26;
            // 
            // colVerif
            // 
            this.colVerif.AppearanceHeader.Options.UseTextOptions = true;
            this.colVerif.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVerif.Caption = "A VERIFIER";
            this.colVerif.FieldName = "VoirVerif";
            this.colVerif.Name = "colVerif";
            this.colVerif.Visible = true;
            this.colVerif.VisibleIndex = 23;
            // 
            // colState
            // 
            this.colState.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.colState.AppearanceCell.Options.UseForeColor = true;
            this.colState.AppearanceHeader.ForeColor = System.Drawing.Color.Green;
            this.colState.AppearanceHeader.Options.UseForeColor = true;
            this.colState.AppearanceHeader.Options.UseTextOptions = true;
            this.colState.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colState.Caption = "S.PDT";
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 4;
            this.colState.Width = 46;
            // 
            // colVers
            // 
            this.colVers.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.colVers.AppearanceCell.Options.UseForeColor = true;
            this.colVers.AppearanceHeader.Options.UseTextOptions = true;
            this.colVers.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVers.Caption = "CO DESIGNATION";
            this.colVers.FieldName = "Nomvers";
            this.colVers.Name = "colVers";
            this.colVers.Visible = true;
            this.colVers.VisibleIndex = 10;
            // 
            // colSign
            // 
            this.colSign.AppearanceHeader.Options.UseTextOptions = true;
            this.colSign.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSign.Caption = "ALERTE-V";
            this.colSign.FieldName = "AlertVte";
            this.colSign.Name = "colSign";
            this.colSign.Visible = true;
            this.colSign.VisibleIndex = 0;
            this.colSign.Width = 61;
            // 
            // colProj
            // 
            this.colProj.AppearanceHeader.Options.UseTextOptions = true;
            this.colProj.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProj.Caption = "ALERTE-C";
            this.colProj.FieldName = "AlertCom";
            this.colProj.Name = "colProj";
            this.colProj.Visible = true;
            this.colProj.VisibleIndex = 2;
            this.colProj.Width = 66;
            // 
            // colACA
            // 
            this.colACA.Caption = "ALERTE-A";
            this.colACA.FieldName = "AlertAch";
            this.colACA.Name = "colACA";
            this.colACA.Visible = true;
            this.colACA.VisibleIndex = 1;
            this.colACA.Width = 61;
            // 
            // colComm
            // 
            this.colComm.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colComm.AppearanceCell.Options.UseForeColor = true;
            this.colComm.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colComm.AppearanceHeader.Options.UseForeColor = true;
            this.colComm.Caption = "S.CMD";
            this.colComm.FieldName = "Commerce";
            this.colComm.Name = "colComm";
            this.colComm.Visible = true;
            this.colComm.VisibleIndex = 5;
            this.colComm.Width = 42;
            // 
            // colFourniss
            // 
            this.colFourniss.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.colFourniss.AppearanceCell.Options.UseForeColor = true;
            this.colFourniss.AppearanceHeader.ForeColor = System.Drawing.Color.Blue;
            this.colFourniss.AppearanceHeader.Options.UseForeColor = true;
            this.colFourniss.Caption = "S.FRNS";
            this.colFourniss.FieldName = "Fournisseur";
            this.colFourniss.Name = "colFourniss";
            this.colFourniss.Visible = true;
            this.colFourniss.VisibleIndex = 6;
            this.colFourniss.Width = 42;
            // 
            // myNum
            // 
            this.myNum.Appearance.BackColor = System.Drawing.Color.White;
            this.myNum.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.myNum.Appearance.Options.UseBackColor = true;
            this.myNum.Appearance.Options.UseForeColor = true;
            this.myNum.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.myNum.Location = new System.Drawing.Point(505, 349);
            this.myNum.Name = "myNum";
            this.myNum.Size = new System.Drawing.Size(6, 13);
            this.myNum.TabIndex = 6;
            this.myNum.Text = "0";
            // 
            // XtraComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 961);
            this.Controls.Add(this.myNum);
            this.Controls.Add(this.gridActions);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraComment.IconOptions.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraComment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTAIRE-COMPTAGE";
            this.Activated += new System.EventHandler(this.XtraComment_Activated);
            this.Load += new System.EventHandler(this.XtraComment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridActions)).EndInit();
            this.clicDroit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilleView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridActions;
        private DevExpress.XtraGrid.Views.Grid.GridView grilleView;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrix;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colEst;
        private DevExpress.XtraGrid.Columns.GridColumn colPerv;
        private DevExpress.XtraGrid.Columns.GridColumn OtherInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colMag;
        private DevExpress.XtraGrid.Columns.GridColumn colCa;
        private DevExpress.XtraGrid.Columns.GridColumn colCv;
        private DevExpress.XtraGrid.Columns.GridColumn colUnt;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colReponse;
        private DevExpress.XtraGrid.Columns.GridColumn colQte;
        private DevExpress.XtraGrid.Columns.GridColumn colComptage;
        private DevExpress.XtraEditors.LabelControl myNum;
        private DevExpress.XtraGrid.Columns.GridColumn colPlace;
        private DevExpress.XtraGrid.Columns.GridColumn colB1;
        private DevExpress.XtraGrid.Columns.GridColumn colB2;
        private System.Windows.Forms.ContextMenuStrip clicDroit;
        private System.Windows.Forms.ToolStripMenuItem créationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparerToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colUF;
        private DevExpress.XtraGrid.Columns.GridColumn colRem;
        private DevExpress.XtraGrid.Columns.GridColumn colRq;
        private DevExpress.XtraGrid.Columns.GridColumn colObs;
        private DevExpress.XtraGrid.Columns.GridColumn gridComment;
        private DevExpress.XtraGrid.Columns.GridColumn gridLocal;
        private DevExpress.XtraGrid.Columns.GridColumn colFrName;
        private DevExpress.XtraGrid.Columns.GridColumn colVoir;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colopAch;
        private DevExpress.XtraGrid.Columns.GridColumn colCMD;
        private DevExpress.XtraGrid.Columns.GridColumn colTT;
        private DevExpress.XtraGrid.Columns.GridColumn colRUPT;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOP;
        private DevExpress.XtraGrid.Columns.GridColumn Familier;
        private DevExpress.XtraGrid.Columns.GridColumn RefCol;
        private DevExpress.XtraGrid.Columns.GridColumn cataCol;
        private DevExpress.XtraGrid.Columns.GridColumn colMtestime;
        private DevExpress.XtraGrid.Columns.GridColumn coLumn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colPlacer;
        private DevExpress.XtraGrid.Columns.GridColumn colVerif;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colVers;
        private DevExpress.XtraGrid.Columns.GridColumn colSign;
        private DevExpress.XtraGrid.Columns.GridColumn colProj;
        private DevExpress.XtraGrid.Columns.GridColumn colACA;
        private DevExpress.XtraGrid.Columns.GridColumn colComm;
        private DevExpress.XtraGrid.Columns.GridColumn colFourniss;
    }
}