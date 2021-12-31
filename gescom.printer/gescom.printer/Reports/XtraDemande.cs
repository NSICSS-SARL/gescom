using System.Globalization;
using DevExpress.XtraReports.UI;
using gescom.data.Models;

namespace gescom.printer.Reports
{
    public partial class XtraDocument : XtraReport
    {
        public XtraDocument()
        {
            InitializeComponent();
            Init();
        }

        public XtraDocument(CashModel model)
        {
            InitializeComponent();
            Init();
            Id.Value = model.Id;
            adresseclient.Text = model.Adresse;
            nomclient.Text = model.Nom;
            lineNum.Text = StdCalcul.Spacing(model.Id.ToString(CultureInfo.InvariantCulture));
            var print = DateHelpers.Get(model.Id);
            if (print.Groupe == 9) lettre.Text = @"Arrêtée la présente demande de prix à la somme de: ";
            lettre.Text += StdCalcul.FormatGasy(model.Montant);
            Tache.Text = print.Tache;
            Titre.Text = print.Titre;
        }

        private void Init()
        {
            var owner = PersonHelpers.Get(1);
            nom.Text = owner.Nom;
            adresse.Text = owner.Adresse;
            complement.Text = owner.Complement;
            tel1.Text = owner.Tel1;
            tel2.Text = owner.Tel2;
        }
    }
}