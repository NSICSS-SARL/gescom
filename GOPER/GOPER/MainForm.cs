using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using gescom.create.Models;

namespace GOPER
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();           
            comptage.Enabled = false;
            Init(1);
            CreateHelpers.Init();
        }

        public MainForm(int index)
        {
            InitializeComponent();
            comptage.Enabled = false;
            Init(index);
            CreateHelpers.Init();
        }

        public int Index { get; set; }

        private void buttonComp_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.Comparer();
        }

        private void buttonSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (Index)
            {
                default:
                    CreateHelpers.ParticularSearch();
                    break;

                case 3:
                    CreateHelpers.AdminSearch();
                    break;
            }
        }

        private void buttonVente_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Index != 2)
            { CreateHelpers.RealiserVente(); return; }
            CreateHelpers.RecapitulerCaisse();
        }

        private void encaisse_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.Encaisser();
        }

        private void Init(int index)
        {
            Index = index;
            switch (index)
            {
                case 2:
                    Text = @"INVENTAIRE COMPTAGE";
                    comptage.Enabled = true;
                    break;

                case 3:
                    Text = @"ADJOINTE";
                    comptage.Enabled = true;
                    barVueCaisse.Enabled = true;
                    vente.Enabled = true;
                    encaisse.Enabled = true;
                    vente.Caption = @"VENTE";
                    break;

                default:
                    Text = @"VENTE";
                    vente.Enabled = true;
                    vente.Caption = @"VENTE";
                    break;
            }
        }

        private void simulButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.RealiserSimulation();
        }

        private void barVueCaisse_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHelpers.ListerCash();
        }

        private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            CreateHelpers.InitSetup();
        }
    }
}