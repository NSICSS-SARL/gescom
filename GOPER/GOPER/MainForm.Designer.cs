namespace GOPER
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pageSearch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rubanPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rubanOuf = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.recherche = new DevExpress.XtraBars.BarButtonItem();
            this.vente = new DevExpress.XtraBars.BarButtonItem();
            this.buttonEntre = new DevExpress.XtraBars.BarButtonItem();
            this.buttonAvoir = new DevExpress.XtraBars.BarButtonItem();
            this.buttonErreur = new DevExpress.XtraBars.BarButtonItem();
            this.buttonDefect = new DevExpress.XtraBars.BarButtonItem();
            this.buttonVol = new DevExpress.XtraBars.BarButtonItem();
            this.buttonCom = new DevExpress.XtraBars.BarButtonItem();
            this.rubanControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.rubanControl)).BeginInit();
            this.SuspendLayout();
            // 
            // pageSearch
            // 
            this.pageSearch.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.pageSearch.Name = "pageSearch";
            this.pageSearch.Text = "RECHERCHE";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // rubanPage
            // 
            this.rubanPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rubanOuf});
            this.rubanPage.Name = "rubanPage";
            // 
            // rubanOuf
            // 
            this.rubanOuf.ItemLinks.Add(this.recherche);
            this.rubanOuf.ItemLinks.Add(this.vente);
            this.rubanOuf.Name = "rubanOuf";
            // 
            // recherche
            // 
            this.recherche.Caption = "Recherche";
            this.recherche.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.recherche.Id = 1;
            this.recherche.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("recherche.ImageOptions.Image")));
            this.recherche.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("recherche.ImageOptions.LargeImage")));
            this.recherche.Name = "recherche";
            this.recherche.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSearch_ItemClick);
            // 
            // vente
            // 
            this.vente.Caption = "Vente";
            this.vente.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.vente.Enabled = false;
            this.vente.Id = 5;
            this.vente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("vente.ImageOptions.Image")));
            this.vente.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("vente.ImageOptions.LargeImage")));
            this.vente.Name = "vente";
            this.vente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonVente_ItemClick);
            // 
            // buttonEntre
            // 
            this.buttonEntre.Caption = "Entrée";
            this.buttonEntre.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonEntre.Id = 3;
            this.buttonEntre.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEntre.ImageOptions.Image")));
            this.buttonEntre.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonEntre.ImageOptions.LargeImage")));
            this.buttonEntre.Name = "buttonEntre";
            // 
            // buttonAvoir
            // 
            this.buttonAvoir.Caption = "Avoir";
            this.buttonAvoir.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonAvoir.Id = 4;
            this.buttonAvoir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAvoir.ImageOptions.Image")));
            this.buttonAvoir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonAvoir.ImageOptions.LargeImage")));
            this.buttonAvoir.Name = "buttonAvoir";
            // 
            // buttonErreur
            // 
            this.buttonErreur.Caption = "Erreur comptage";
            this.buttonErreur.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonErreur.Id = 6;
            this.buttonErreur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonErreur.ImageOptions.Image")));
            this.buttonErreur.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonErreur.ImageOptions.LargeImage")));
            this.buttonErreur.Name = "buttonErreur";
            // 
            // buttonDefect
            // 
            this.buttonDefect.Caption = "Défection";
            this.buttonDefect.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonDefect.Id = 7;
            this.buttonDefect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonDefect.ImageOptions.Image")));
            this.buttonDefect.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonDefect.ImageOptions.LargeImage")));
            this.buttonDefect.Name = "buttonDefect";
            // 
            // buttonVol
            // 
            this.buttonVol.Caption = "Disparition";
            this.buttonVol.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonVol.Id = 8;
            this.buttonVol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonVol.ImageOptions.Image")));
            this.buttonVol.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonVol.ImageOptions.LargeImage")));
            this.buttonVol.Name = "buttonVol";
            // 
            // buttonCom
            // 
            this.buttonCom.Caption = "Commande";
            this.buttonCom.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonCom.Id = 9;
            this.buttonCom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonCom.ImageOptions.Image")));
            this.buttonCom.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonCom.ImageOptions.LargeImage")));
            this.buttonCom.Name = "buttonCom";
            // 
            // rubanControl
            // 
            this.rubanControl.ExpandCollapseItem.Id = 0;
            this.rubanControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rubanControl.ExpandCollapseItem,
            this.rubanControl.SearchEditItem,
            this.recherche,
            this.buttonEntre,
            this.buttonAvoir,
            this.vente,
            this.buttonErreur,
            this.buttonDefect,
            this.buttonVol,
            this.buttonCom});
            this.rubanControl.Location = new System.Drawing.Point(0, 0);
            this.rubanControl.MaxItemId = 15;
            this.rubanControl.Name = "rubanControl";
            this.rubanControl.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.rubanControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rubanPage});
            this.rubanControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.rubanControl.Size = new System.Drawing.Size(303, 158);
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 222);
            this.Controls.Add(this.rubanControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainForm.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.rubanControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURATION";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.rubanControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageSearch;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rubanPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rubanOuf;
        private DevExpress.XtraBars.BarButtonItem recherche;
        private DevExpress.XtraBars.BarButtonItem vente;
        private DevExpress.XtraBars.BarButtonItem buttonEntre;
        private DevExpress.XtraBars.BarButtonItem buttonAvoir;
        private DevExpress.XtraBars.BarButtonItem buttonErreur;
        private DevExpress.XtraBars.BarButtonItem buttonDefect;
        private DevExpress.XtraBars.BarButtonItem buttonVol;
        private DevExpress.XtraBars.BarButtonItem buttonCom;
        private DevExpress.XtraBars.Ribbon.RibbonControl rubanControl;
    }
}

