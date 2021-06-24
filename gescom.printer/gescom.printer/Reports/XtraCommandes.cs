using DevExpress.XtraReports.UI;
using gescom.data.Models;

namespace gescom.printer.Reports
{
    public partial class XtraCommandes : XtraReport
    {
        public XtraCommandes()
        {
            InitializeComponent();
            Init();
        }

        public XtraCommandes(long id)
        {
            InitializeComponent();
            Id.Value = id;
            Init();
            DiaryItem diary = DiaryHelpers.Get(id);
            Daty.Text = diary.Datum.ToString();
        }

        private void Init()
        {
            PersonModel p = PersonHelpers.Get(1);
            nom.Text = p.Nom;
            adresse.Text = p.Adresse;
            complement.Text = p.Complement;
            tel1.Text += p.Tel1;
            tel2.Text += p.Tel2;
            stat.Text += p.Stat;
            nif.Text += p.Nif;
        }
    }
}