using gescom.data.Models;

namespace gescom.report.Reports
{
    public partial class ReportPerson : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportPerson()
        {
            InitializeComponent();
        }

        public ReportPerson(int index)
        {
            InitializeComponent();
            Init(index);
        }

        private void Init(int index)
        {
            var p = PersonHelpers.Get(1);
            noms.Text = p.Nom;
            activite.Text = p.Activite;
            adresse.Text = p.Adresse;
            domicile.Text = p.Adresse;
            complement.Text = p.Complement;
            switch (index)
            {
                case 1:
                    titreArticle.Text = "LISTE FOURNISSEUR";
                    var vendors = PersonHelpers.GetBrutVendors();
                    DataSource = vendors;
                    numero.DataBindings.Add("Text", vendors, "Rang");
                    nom.DataBindings.Add("Text", vendors, "Nom");
                    adresse.DataBindings.Add("Text", vendors, "Adresse");
                    telephone.DataBindings.Add("Text", vendors, "Tel1");
                    ville.DataBindings.Add("Text", vendors, "Ville");
                    break;

                case 2:
                    titreArticle.Text = "LISTE CLIENT";
                    var custs = PersonHelpers.GetBrutCustomers();
                    DataSource = custs;
                    //typo.DataBindings.Add("Text", custs, "LitteralType");
                    numero.DataBindings.Add("Text", custs, "Rang");
                    nom.DataBindings.Add("Text", custs, "Nom");
                    adresse.DataBindings.Add("Text", custs, "Adresse");
                    telephone.DataBindings.Add("Text", custs, "Tel1");
                    ville.DataBindings.Add("Text", custs, "Ville");
                    break;

                case 3:
                    titreArticle.Text = "LISTE PERSONNEL";
                    var workers = PersonHelpers.GetBrutWorkers();
                    DataSource = workers;
                    numero.DataBindings.Add("Text", workers, "Rang");
                    nom.DataBindings.Add("Text", workers, "Nom");
                    adresse.DataBindings.Add("Text", workers, "Adresse");
                    telephone.DataBindings.Add("Text", workers, "Tel1");
                    ville.DataBindings.Add("Text", workers, "Ville");
                    break;
            }
        }
    }
}