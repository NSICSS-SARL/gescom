using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using gescom.create.Models;

namespace GBASE
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonArticle_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.AdminSearch();
        }

        private void buttonCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.ListerCustomers();
        }

        private void buttonVendor_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.ListerVendors();
        }

        private void buttonUnite_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.ListerUnites();
        }

        private void buttonFamille_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.ListerFamilles();
        }

        private void buttonPlace_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.ListerPlaces();
        }

        private void buttonRecap_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.Resumer();
        }

        private void buttonJournal_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.DetailsPerPerson();
        }

        private void buttonStock_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.ViewStock();
        }

        private void buttonInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.AboutInfo();
        }

        private void buttonCommande_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.ActionCommande();
        }

        private void buttonCaisse_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.ListerCash();
        }

        private void buttonCompter_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.InventCompt();
        }

        private void buttonComptage_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.ErreurComptage();
        }

        private void buttonDefect_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.RebutDefection();
        }

        private void buttonVol_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.RebutVol();
        }

        private void buttonAvoir_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.RealiserAvoir();
        }

        private void buttonEntree_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.EffectuerEntree();
        }

        private void buttonWorker_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.ListerWorkers();
        }

        private void buttonTaxe_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.ListerDeclarations();
        }

        private void buttonVente_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.RealiserVente();
        }

        private void buttonDemande_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.RealiserSimulation();
        }

        private void buttonFormel_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.ShowFormalite();
        }

        private void buttonNormal_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.ShowFormels();
        }
    }
}