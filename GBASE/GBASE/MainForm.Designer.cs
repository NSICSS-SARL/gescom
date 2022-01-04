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
            this.buttonNormal = new DevExpress.XtraBars.BarButtonItem();
            this.destockBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Accueil = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.basePage = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.resumePage = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageActe = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tiersPage = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
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
            this.buttonNormal,
            this.destockBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 34;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Accueil});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1612, 158);
            // 
            // buttonArticle
            // 
            this.buttonArticle.Caption = "Articles";
            this.buttonArticle.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonArticle.Id = 1;
            this.buttonArticle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonArticle.ImageOptions.Image")));
            this.buttonArticle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonArticle.ImageOptions.LargeImage")));
            this.buttonArticle.Name = "buttonArticle";
            this.buttonArticle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonArticle_ItemClick);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Caption = "Clients";
            this.buttonCustomer.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonCustomer.Id = 2;
            this.buttonCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonCustomer.ImageOptions.Image")));
            this.buttonCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonCustomer.ImageOptions.LargeImage")));
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCustomer_ItemClick);
            // 
            // buttonVendor
            // 
            this.buttonVendor.Caption = "Fournisseurs";
            this.buttonVendor.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonVendor.Id = 3;
            this.buttonVendor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonVendor.ImageOptions.Image")));
            this.buttonVendor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonVendor.ImageOptions.LargeImage")));
            this.buttonVendor.Name = "buttonVendor";
            this.buttonVendor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonVendor_ItemClick);
            // 
            // buttonUnite
            // 
            this.buttonUnite.Caption = "Unités";
            this.buttonUnite.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonUnite.Id = 4;
            this.buttonUnite.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonUnite.ImageOptions.Image")));
            this.buttonUnite.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonUnite.ImageOptions.LargeImage")));
            this.buttonUnite.Name = "buttonUnite";
            this.buttonUnite.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonUnite_ItemClick);
            // 
            // buttonFamille
            // 
            this.buttonFamille.Caption = "Catégories";
            this.buttonFamille.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonFamille.Id = 5;
            this.buttonFamille.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonFamille.ImageOptions.Image")));
            this.buttonFamille.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonFamille.ImageOptions.LargeImage")));
            this.buttonFamille.Name = "buttonFamille";
            this.buttonFamille.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonFamille_ItemClick);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Caption = "Informations";
            this.buttonInfo.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonInfo.Id = 6;
            this.buttonInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo.ImageOptions.Image")));
            this.buttonInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonInfo.ImageOptions.LargeImage")));
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonInfo_ItemClick);
            // 
            // buttonPlace
            // 
            this.buttonPlace.Caption = "Emplacements";
            this.buttonPlace.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonPlace.Id = 7;
            this.buttonPlace.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlace.ImageOptions.Image")));
            this.buttonPlace.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonPlace.ImageOptions.LargeImage")));
            this.buttonPlace.Name = "buttonPlace";
            this.buttonPlace.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonPlace_ItemClick);
            // 
            // buttonJournal
            // 
            this.buttonJournal.Caption = "Journal";
            this.buttonJournal.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonJournal.Id = 8;
            this.buttonJournal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonJournal.ImageOptions.Image")));
            this.buttonJournal.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonJournal.ImageOptions.LargeImage")));
            this.buttonJournal.Name = "buttonJournal";
            this.buttonJournal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonJournal_ItemClick);
            // 
            // buttonStock
            // 
            this.buttonStock.Caption = "Disponibilité";
            this.buttonStock.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonStock.Id = 9;
            this.buttonStock.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonStock.ImageOptions.Image")));
            this.buttonStock.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonStock.ImageOptions.LargeImage")));
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonStock_ItemClick);
            // 
            // buttonRecap
            // 
            this.buttonRecap.Caption = "Recapitulations";
            this.buttonRecap.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonRecap.Id = 10;
            this.buttonRecap.ImageOptions.DisabledLargeImage = global::GBASE.Properties.Resources.shipping8;
            this.buttonRecap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRecap.ImageOptions.Image")));
            this.buttonRecap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonRecap.ImageOptions.LargeImage")));
            this.buttonRecap.Name = "buttonRecap";
            this.buttonRecap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonRecap_ItemClick);
            // 
            // buttonCommande
            // 
            this.buttonCommande.Caption = "Commande";
            this.buttonCommande.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonCommande.Id = 11;
            this.buttonCommande.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonCommande.ImageOptions.Image")));
            this.buttonCommande.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonCommande.ImageOptions.LargeImage")));
            this.buttonCommande.Name = "buttonCommande";
            this.buttonCommande.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCommande_ItemClick);
            // 
            // buttonCaisse
            // 
            this.buttonCaisse.Caption = "Caisse";
            this.buttonCaisse.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonCaisse.Id = 13;
            this.buttonCaisse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonCaisse.ImageOptions.Image")));
            this.buttonCaisse.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonCaisse.ImageOptions.LargeImage")));
            this.buttonCaisse.Name = "buttonCaisse";
            this.buttonCaisse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCaisse_ItemClick);
            // 
            // createButton
            // 
            this.createButton.Caption = "Produits";
            this.createButton.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.createButton.Id = 14;
            this.createButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("createButton.ImageOptions.Image")));
            this.createButton.Name = "createButton";
            // 
            // buttonCompter
            // 
            this.buttonCompter.Caption = "Inventaire-Comptage";
            this.buttonCompter.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonCompter.Id = 15;
            this.buttonCompter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonCompter.ImageOptions.Image")));
            this.buttonCompter.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonCompter.ImageOptions.LargeImage")));
            this.buttonCompter.Name = "buttonCompter";
            this.buttonCompter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCompter_ItemClick);
            // 
            // buttonEntree
            // 
            this.buttonEntree.Caption = "Entrée";
            this.buttonEntree.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonEntree.Id = 21;
            this.buttonEntree.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEntree.ImageOptions.Image")));
            this.buttonEntree.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonEntree.ImageOptions.LargeImage")));
            this.buttonEntree.Name = "buttonEntree";
            this.buttonEntree.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEntree_ItemClick);
            // 
            // buttonAvoir
            // 
            this.buttonAvoir.Caption = "Avoir";
            this.buttonAvoir.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonAvoir.Id = 22;
            this.buttonAvoir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAvoir.ImageOptions.Image")));
            this.buttonAvoir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonAvoir.ImageOptions.LargeImage")));
            this.buttonAvoir.Name = "buttonAvoir";
            this.buttonAvoir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAvoir_ItemClick);
            // 
            // buttonComptage
            // 
            this.buttonComptage.Caption = "Erreur comptage";
            this.buttonComptage.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonComptage.Id = 23;
            this.buttonComptage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonComptage.ImageOptions.Image")));
            this.buttonComptage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonComptage.ImageOptions.LargeImage")));
            this.buttonComptage.Name = "buttonComptage";
            this.buttonComptage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonComptage_ItemClick);
            // 
            // buttonDefect
            // 
            this.buttonDefect.Caption = "Rebut defection";
            this.buttonDefect.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonDefect.Id = 24;
            this.buttonDefect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonDefect.ImageOptions.Image")));
            this.buttonDefect.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonDefect.ImageOptions.LargeImage")));
            this.buttonDefect.Name = "buttonDefect";
            this.buttonDefect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonDefect_ItemClick);
            // 
            // buttonVol
            // 
            this.buttonVol.Caption = "Rebut vol";
            this.buttonVol.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonVol.Id = 25;
            this.buttonVol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonVol.ImageOptions.Image")));
            this.buttonVol.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonVol.ImageOptions.LargeImage")));
            this.buttonVol.Name = "buttonVol";
            this.buttonVol.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonVol_ItemClick);
            // 
            // buttonWorker
            // 
            this.buttonWorker.Caption = "Personnels";
            this.buttonWorker.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonWorker.Id = 26;
            this.buttonWorker.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonWorker.ImageOptions.Image")));
            this.buttonWorker.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonWorker.ImageOptions.LargeImage")));
            this.buttonWorker.Name = "buttonWorker";
            this.buttonWorker.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonWorker_ItemClick);
            // 
            // buttonPrime
            // 
            this.buttonPrime.Caption = "Primes";
            this.buttonPrime.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonPrime.Id = 27;
            this.buttonPrime.ImageOptions.LargeImage = global::GBASE.Properties.Resources.mone;
            this.buttonPrime.Name = "buttonPrime";
            // 
            // buttonTaxe
            // 
            this.buttonTaxe.Caption = "Déclaration";
            this.buttonTaxe.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonTaxe.Id = 28;
            this.buttonTaxe.ImageOptions.LargeImage = global::GBASE.Properties.Resources.devis;
            this.buttonTaxe.Name = "buttonTaxe";
            this.buttonTaxe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonTaxe_ItemClick);
            // 
            // buttonDemande
            // 
            this.buttonDemande.Caption = "Demande";
            this.buttonDemande.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonDemande.Id = 29;
            this.buttonDemande.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonDemande.ImageOptions.Image")));
            this.buttonDemande.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonDemande.ImageOptions.LargeImage")));
            this.buttonDemande.Name = "buttonDemande";
            this.buttonDemande.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonDemande_ItemClick);
            // 
            // buttonVente
            // 
            this.buttonVente.Caption = "Vente";
            this.buttonVente.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonVente.Id = 30;
            this.buttonVente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonVente.ImageOptions.Image")));
            this.buttonVente.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonVente.ImageOptions.LargeImage")));
            this.buttonVente.Name = "buttonVente";
            this.buttonVente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonVente_ItemClick);
            // 
            // buttonGrave
            // 
            this.buttonGrave.Caption = "CA";
            this.buttonGrave.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonGrave.Id = 31;
            this.buttonGrave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonGrave.ImageOptions.Image")));
            this.buttonGrave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonGrave.ImageOptions.LargeImage")));
            this.buttonGrave.Name = "buttonGrave";
            this.buttonGrave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonFormel_ItemClick);
            // 
            // buttonNormal
            // 
            this.buttonNormal.Caption = "Normalisme";
            this.buttonNormal.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.buttonNormal.Enabled = false;
            this.buttonNormal.Id = 32;
            this.buttonNormal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonNormal.ImageOptions.Image")));
            this.buttonNormal.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonNormal.ImageOptions.LargeImage")));
            this.buttonNormal.Name = "buttonNormal";
            this.buttonNormal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonNormal_ItemClick);
            // 
            // destockBtn
            // 
            this.destockBtn.Caption = "Destockage";
            this.destockBtn.Id = 33;
            this.destockBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("destockBtn.ImageOptions.Image")));
            this.destockBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("destockBtn.ImageOptions.LargeImage")));
            this.destockBtn.Name = "destockBtn";
            this.destockBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.destockBtn_ItemClick);
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
            this.resumePage.ItemLinks.Add(this.buttonCommande);
            this.resumePage.Name = "resumePage";
            this.resumePage.Text = "RECAPITULATION";
            // 
            // pageActe
            // 
            this.pageActe.ItemLinks.Add(this.buttonComptage);
            this.pageActe.ItemLinks.Add(this.buttonDefect);
            this.pageActe.ItemLinks.Add(this.destockBtn);
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
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 360);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainForm.IconOptions.Icon")));
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
        private DevExpress.XtraBars.BarButtonItem destockBtn;
    }
}

