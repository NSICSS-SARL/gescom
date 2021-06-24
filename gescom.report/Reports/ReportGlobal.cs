using gescom.data.Models;

namespace gescom.report.Reports
{
    public partial class ReportGlobal : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportGlobal()
        {
            InitializeComponent();
        }

        public ReportGlobal(int index)
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
            switch (index)
            {
                case 0:
                    titreArticle.Text = "LISTE CATEGORIES";
                    var familles = FamilleHelpers.GetList();
                    DataSource = familles;
                    numero.DataBindings.Add("Text", familles, "Rang");
                    code.DataBindings.Add("Text", familles, "Code");
                    libelles.DataBindings.Add("Text", familles, "Nom");
                    break;

                case 1:
                    titreArticle.Text = "LISTE UNITES";
                    var unites = UniteHelpers.GetList();
                    DataSource = unites;
                    numero.DataBindings.Add("Text", unites, "Rang");
                    code.DataBindings.Add("Text", unites, "Code");
                    libelles.DataBindings.Add("Text", unites, "Nom");
                    break;

                case 2:
                    titreArticle.Text = "LISTE EMPLACEMENT";
                    var places = PlaceHelpers.GetList();
                    DataSource = places;
                    numero.DataBindings.Add("Text", places, "Rang");
                    code.DataBindings.Add("Text", places, "Code");
                    libelles.DataBindings.Add("Text", places, "Nom");
                    break;
            }
        }
    }
}