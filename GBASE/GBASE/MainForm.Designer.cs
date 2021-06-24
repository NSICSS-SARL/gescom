namespace GBASE
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.buttonArticle = new DevExpress.XtraBars.BarButtonItem();
            this.buttonCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.buttonVendor = new DevExpress.XtraBars.BarButtonItem();
            this.buttonUnite = new DevExpress.XtraBars.BarButtonItem();
            this.buttonFamille = new DevExpress.XtraBars.BarButtonItem();
            this.buttonInfo = new DevExpress.XtraBars.BarButtonItem();
            this.buttonPlace = new DevExpress.XtraBars.BarButtonItem();
            this.buttonJournal = new DevExpress.XtraBars.BarButtonItem();
            this.buttonStock = new DevExpress.XtraBars.BarButtonItem();
            this.buttonRecap = new DevExpress.XtraBars.BarButtonItem();
            this.buttonCommande = new DevExpress.XtraBars.BarButtonItem();
            this.buttonCaisse = new DevExpress.XtraBars.BarButtonItem();
            this.createButton = new DevExpress.XtraBars.BarButtonItem();
            this.buttonCompter = new DevExpress.XtraBars.BarButtonItem();
            this.buttonEntree = new DevExpress.XtraBars.BarButtonItem();
            this.buttonAvoir = new DevExpress.XtraBars.BarButtonItem();
            this.buttonComptage = new DevExpress.XtraBars.BarButtonItem();
            this.buttonDefect = new DevExpress.XtraBars.BarButtonItem();
            this.buttonVol = new DevExpress.XtraBars.BarButtonItem();
            this.buttonWorker = new DevExpress.XtraBars.BarButtonItem();
            this.buttonPrime = new DevExpress.XtraBars.BarButtonItem();
            this.buttonTaxe = new DevExpress.XtraBars.BarButtonItem();
            this.buttonDemande = new DevExpress.XtraBars.BarButtonItem();
            this.buttonVente = new DevExpress.XtraBars.BarButtonItem();
            this.buttonGrave = new DevExpress.XtraBars.BarButtonItem();
            this.Accueil = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.basePage = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.resumePage = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageActe = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tiersPage = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.buttonNormal = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.buttonArticle,
            this.buttonCustomer,
            this.buttonVendor,
            this.buttonUnite,
            this.buttonFamille,
            this.buttonInfo,
            this.buttonPlace,
            this.buttonJournal,
            this.buttonStock,
            this.buttonRecap,
            this.buttonCommande,
            this.buttonCaisse,
            this.createButton,
            this.buttonCompter,
            this.buttonEntree,
            this.buttonAvoir,
            this.buttonComptage,
            this.buttonDefect,
            this.buttonVol,
            this.buttonWorker,
            this.buttonPrime,
            this.buttonTaxe,
            this.buttonDemande,
            this.buttonVente,
            this.buttonGrave,
            this.buttonNormal});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 33;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Accueil});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1612, 144);
            // 
            // buttonArticle
            // 
            this.buttonArticle.Caption = "Articles";
            this.buttonArticle.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonArticle.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonArticle.Glyph")));
            this.buttonArticle.Id = 1;
            this.buttonArticle.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonArticle.LargeGlyph")));
            this.buttonArticle.Name = "buttonArticle";
            this.buttonArticle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonArticle_ItemClick);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Caption = "Clients";
            this.buttonCustomer.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonCustomer.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonCustomer.Glyph")));
            this.buttonCustomer.Id = 2;
            this.buttonCustomer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonCustomer.LargeGlyph")));
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCustomer_ItemClick);
            // 
            // buttonVendor
            // 
            this.buttonVendor.Caption = "Fournisseurs";
            this.buttonVendor.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonVendor.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonVendor.Glyph")));
            this.buttonVendor.Id = 3;
            this.buttonVendor.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonVendor.LargeGlyph")));
            this.buttonVendor.Name = "buttonVendor";
            this.buttonVendor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonVendor_ItemClick);
            // 
            // buttonUnite
            // 
            this.buttonUnite.Caption = "Unités";
            this.buttonUnite.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonUnite.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonUnite.Glyph")));
            this.buttonUnite.Id = 4;
            this.buttonUnite.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonUnite.LargeGlyph")));
            this.buttonUnite.Name = "buttonUnite";
            this.buttonUnite.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonUnite_ItemClick);
            // 
            // buttonFamille
            // 
            this.buttonFamille.Caption = "Catégories";
            this.buttonFamille.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonFamille.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonFamille.Glyph")));
            this.buttonFamille.Id = 5;
            this.buttonFamille.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonFamille.LargeGlyph")));
            this.buttonFamille.Name = "buttonFamille";
            this.buttonFamille.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonFamille_ItemClick);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Caption = "Informations";
            this.buttonInfo.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonInfo.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonInfo.Glyph")));
            this.buttonInfo.Id = 6;
            this.buttonInfo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonInfo.LargeGlyph")));
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonInfo_ItemClick);
            // 
            // buttonPlace
            // 
            this.buttonPlace.Caption = "Emplacements";
            this.buttonPlace.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonPlace.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonPlace.Glyph")));
            this.buttonPlace.Id = 7;
            this.buttonPlace.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonPlace.LargeGlyph")));
            this.buttonPlace.Name = "buttonPlace";
            this.buttonPlace.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonPlace_ItemClick);
            // 
            // buttonJournal
            // 
            this.buttonJournal.Caption = "Journal";
            this.buttonJournal.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonJournal.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonJournal.Glyph")));
            this.buttonJournal.Id = 8;
            this.buttonJournal.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonJournal.LargeGlyph")));
            this.buttonJournal.Name = "buttonJournal";
            this.buttonJournal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonJournal_ItemClick);
            // 
            // buttonStock
            // 
            this.buttonStock.Caption = "Disponibilité";
            this.buttonStock.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonStock.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonStock.Glyph")));
            this.buttonStock.Id = 9;
            this.buttonStock.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonStock.LargeGlyph")));
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonStock_ItemClick);
            // 
            // buttonRecap
            // 
            this.buttonRecap.Caption = "Recapitulations";
            this.buttonRecap.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonRecap.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonRecap.Glyph")));
            this.buttonRecap.Id = 10;
            this.buttonRecap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonRecap.LargeGlyph")));
            this.buttonRecap.LargeGlyphDisabled = global::GBASE.Properties.Resources.shipping8;
            this.buttonRecap.Name = "buttonRecap";
            this.buttonRecap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonRecap_ItemClick);
            // 
            // buttonCommande
            // 
            this.buttonCommande.Caption = "Commande";
            this.buttonCommande.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonCommande.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonCommande.Glyph")));
            this.buttonCommande.Id = 11;
            this.buttonCommande.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonCommande.LargeGlyph")));
            this.buttonCommande.Name = "buttonCommande";
            this.buttonCommande.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCommande_ItemClick);
            // 
            // buttonCaisse
            // 
            this.buttonCaisse.Caption = "Caisse";
            this.buttonCaisse.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonCaisse.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonCaisse.Glyph")));
            this.buttonCaisse.Id = 13;
            this.buttonCaisse.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonCaisse.LargeGlyph")));
            this.buttonCaisse.Name = "buttonCaisse";
            this.buttonCaisse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCaisse_ItemClick);
            // 
            // createButton
            // 
            this.createButton.Caption = "Produits";
            this.createButton.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.createButton.Glyph = ((System.Drawing.Image)(resources.GetObject("createButton.Glyph")));
            this.createButton.Id = 14;
            this.createButton.Name = "createButton";
            // 
            // buttonCompter
            // 
            this.buttonCompter.Caption = "Inventaire-Comptage";
            this.buttonCompter.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonCompter.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonCompter.Glyph")));
            this.buttonCompter.Id = 15;
            this.buttonCompter.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonCompter.LargeGlyph")));
            this.buttonCompter.Name = "buttonCompter";
            this.buttonCompter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCompter_ItemClick);
            // 
            // buttonEntree
            // 
            this.buttonEntree.Caption = "Entrée";
            this.buttonEntree.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonEntree.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonEntree.Glyph")));
            this.buttonEntree.Id = 21;
            this.buttonEntree.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonEntree.LargeGlyph")));
            this.buttonEntree.Name = "buttonEntree";
            this.buttonEntree.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEntree_ItemClick);
            // 
            // buttonAvoir
            // 
            this.buttonAvoir.Caption = "Avoir";
            this.buttonAvoir.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonAvoir.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonAvoir.Glyph")));
            this.buttonAvoir.Id = 22;
            this.buttonAvoir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonAvoir.LargeGlyph")));
            this.buttonAvoir.Name = "buttonAvoir";
            this.buttonAvoir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAvoir_ItemClick);
            // 
            // buttonComptage
            // 
            this.buttonComptage.Caption = "Erreur comptage";
            this.buttonComptage.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonComptage.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonComptage.Glyph")));
            this.buttonComptage.Id = 23;
            this.buttonComptage.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonComptage.LargeGlyph")));
            this.buttonComptage.Name = "buttonComptage";
            this.buttonComptage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonComptage_ItemClick);
            // 
            // buttonDefect
            // 
            this.buttonDefect.Caption = "Rebut defection";
            this.buttonDefect.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonDefect.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonDefect.Glyph")));
            this.buttonDefect.Id = 24;
            this.buttonDefect.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonDefect.LargeGlyph")));
            this.buttonDefect.Name = "buttonDefect";
            this.buttonDefect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonDefect_ItemClick);
            // 
            // buttonVol
            // 
            this.buttonVol.Caption = "Rebut vol";
            this.buttonVol.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonVol.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonVol.Glyph")));
            this.buttonVol.Id = 25;
            this.buttonVol.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonVol.LargeGlyph")));
            this.buttonVol.Name = "buttonVol";
            this.buttonVol.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonVol_ItemClick);
            // 
            // buttonWorker
            // 
            this.buttonWorker.Caption = "Personnels";
            this.buttonWorker.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonWorker.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonWorker.Glyph")));
            this.buttonWorker.Id = 26;
            this.buttonWorker.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonWorker.LargeGlyph")));
            this.buttonWorker.Name = "buttonWorker";
            this.buttonWorker.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonWorker_ItemClick);
            // 
            // buttonPrime
            // 
            this.buttonPrime.Caption = "Primes";
            this.buttonPrime.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonPrime.Id = 27;
            this.buttonPrime.LargeGlyph = global::GBASE.Properties.Resources.mone;
            this.buttonPrime.Name = "buttonPrime";
            // 
            // buttonTaxe
            // 
            this.buttonTaxe.Caption = "Déclaration";
            this.buttonTaxe.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonTaxe.Id = 28;
            this.buttonTaxe.LargeGlyph = global::GBASE.Properties.Resources.devis;
            this.buttonTaxe.Name = "buttonTaxe";
            this.buttonTaxe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonTaxe_ItemClick);
            // 
            // buttonDemande
            // 
            this.buttonDemande.Caption = "Demande";
            this.buttonDemande.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonDemande.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonDemande.Glyph")));
            this.buttonDemande.Id = 29;
            this.buttonDemande.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonDemande.LargeGlyph")));
            this.buttonDemande.Name = "buttonDemande";
            this.buttonDemande.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonDemande_ItemClick);
            // 
            // buttonVente
            // 
            this.buttonVente.Caption = "Vente";
            this.buttonVente.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonVente.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonVente.Glyph")));
            this.buttonVente.Id = 30;
            this.buttonVente.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonVente.LargeGlyph")));
            this.buttonVente.Name = "buttonVente";
            this.buttonVente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonVente_ItemClick);
            // 
            // buttonGrave
            // 
            this.buttonGrave.Caption = "CA";
            this.buttonGrave.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonGrave.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonGrave.Glyph")));
            this.buttonGrave.Id = 31;
            this.buttonGrave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonGrave.LargeGlyph")));
            this.buttonGrave.Name = "buttonGrave";
            this.buttonGrave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonFormel_ItemClick);
            // 
            // Accueil
            // 
            this.Accueil.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.basePage,
            this.resumePage,
            this.pageActe,
            this.tiersPage});
            this.Accueil.Name = "Accueil";
            // 
            // basePage
            // 
            this.basePage.ItemLinks.Add(this.buttonArticle);
            this.basePage.ItemLinks.Add(this.buttonCustomer);
            this.basePage.ItemLinks.Add(this.buttonVendor);
            this.basePage.ItemLinks.Add(this.buttonWorker);
            this.basePage.ItemLinks.Add(this.buttonUnite);
            this.basePage.ItemLinks.Add(this.buttonFamille);
            this.basePage.ItemLinks.Add(this.buttonPlace);
            this.basePage.Name = "basePage";
            this.basePage.Text = "BASE";
            // 
            // resumePage
            // 
            this.resumePage.ItemLinks.Add(this.buttonRecap);
            this.resumePage.ItemLinks.Add(this.buttonJournal);
            this.resumePage.ItemLinks.Add(this.buttonStock);
            this.resumePage.ItemLinks.Add(this.buttonCaisse);
            this.resumePage.ItemLinks.Add(this.buttonCompter);
            this.resumePage.Name = "resumePage";
            this.resumePage.Text = "RECAPITULATION";
            // 
            // pageActe
            // 
            this.pageActe.ItemLinks.Add(this.buttonCommande);
            this.pageActe.ItemLinks.Add(this.buttonComptage);
            this.pageActe.ItemLinks.Add(this.buttonDefect);
            this.pageActe.ItemLinks.Add(this.buttonVol);
            this.pageActe.ItemLinks.Add(this.buttonAvoir);
            this.pageActe.ItemLinks.Add(this.buttonEntree);
            this.pageActe.ItemLinks.Add(this.buttonDemande);
            this.pageActe.ItemLinks.Add(this.buttonVente);
            this.pageActe.ItemLinks.Add(this.buttonInfo);
            this.pageActe.Name = "pageActe";
            this.pageActe.Text = "OPERATIONS";
            // 
            // tiersPage
            // 
            this.tiersPage.ItemLinks.Add(this.buttonNormal);
            this.tiersPage.ItemLinks.Add(this.buttonGrave);
            this.tiersPage.ItemLinks.Add(this.buttonTaxe);
            this.tiersPage.Name = "tiersPage";
            this.tiersPage.Text = "EXTERNES";
            // 
            // buttonNormal
            // 
            this.buttonNormal.Caption = "Normalisme";
            this.buttonNormal.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonNormal.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonNormal.Glyph")));
            this.buttonNormal.Id = 32;
            this.buttonNormal.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buttonNormal.LargeGlyph")));
            this.buttonNormal.Name = "buttonNormal";
            this.buttonNormal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonNormal_ItemClick);
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 360);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESCOM EVOLUTION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage Accueil;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup basePage;
        private DevExpress.XtraBars.BarButtonItem buttonArticle;
        private DevExpress.XtraBars.BarButtonItem buttonCustomer;
        private DevExpress.XtraBars.BarButtonItem buttonVendor;
        private DevExpress.XtraBars.BarButtonItem buttonUnite;
        private DevExpress.XtraBars.BarButtonItem buttonFamille;
        private DevExpress.XtraBars.BarButtonItem buttonInfo;
        private DevExpress.XtraBars.BarButtonItem buttonPlace;
        private DevExpress.XtraBars.BarButtonItem buttonJournal;
        private DevExpress.XtraBars.BarButtonItem buttonStock;
        private DevExpress.XtraBars.BarButtonItem buttonRecap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup resumePage;
        private DevExpress.XtraBars.BarButtonItem buttonCommande;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageActe;
        private DevExpress.XtraBars.BarButtonItem buttonCaisse;
        private DevExpress.XtraBars.BarButtonItem createButton;
        private DevExpress.XtraBars.BarButtonItem buttonCompter;
        private DevExpress.XtraBars.BarButtonItem buttonEntree;
        private DevExpress.XtraBars.BarButtonItem buttonAvoir;
        private DevExpress.XtraBars.BarButtonItem buttonComptage;
        private DevExpress.XtraBars.BarButtonItem buttonDefect;
        private DevExpress.XtraBars.BarButtonItem buttonVol;
        private DevExpress.XtraBars.BarButtonItem buttonWorker;
        private DevExpress.XtraBars.BarButtonItem buttonPrime;
        private DevExpress.XtraBars.BarButtonItem buttonTaxe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup tiersPage;
        private DevExpress.XtraBars.BarButtonItem buttonDemande;
        private DevExpress.XtraBars.BarButtonItem buttonVente;
        private DevExpress.XtraBars.BarButtonItem buttonGrave;
        private DevExpress.XtraBars.BarButtonItem buttonNormal;
    }
}

