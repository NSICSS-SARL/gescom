using DevExpress.XtraReports.UI;
using gescom.data.Models;
using System.Globalization;

namespace gescom.printer.Reports
{
    public partial class XtraRecu : XtraReport
    {
        public XtraRecu()
        {
            InitializeComponent();
            Init();
        }

        public XtraRecu(CashModel model)
        {
            InitializeComponent();
            Init();
            Id.Value = model.Id;
            adresseclient.Text = model.Adresse;
            nomclient.Text = model.Nom;
            Personnel.Text = DateHelpers.GetNamePrimed(model.Id);
            lineNum.Text = StdCalcul.Spacing(model.Id.ToString(CultureInfo.InvariantCulture));
            lettre.Text += StdCalcul.FormatGasy(model.Montant);
        }

        private void Init()
        {
            PersonModel owner = PersonHelpers.Get(1);
            nom.Text = owner.Nom;
            adresse.Text = owner.Adresse;
            complement.Text = owner.Complement;
            tel1.Text = owner.Tel1;
            tel2.Text = owner.Tel2;
        }
    }
}