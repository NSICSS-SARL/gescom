using gescom.data.Models;

namespace gescom.printer.Reports
{
    public partial class Report58 : DevExpress.XtraReports.UI.XtraReport
    {
        public Report58()
        {
            InitializeComponent();
        }

        public Report58(CashModel model)
        {
            InitializeComponent();
            lineNum.Text = model.Nom;
            NUMERO.Text = StdCalcul.DoubleToSpaceFormat(model.Id);
            VALEUR.Text = StdCalcul.DoubleToSpaceFormat(model.Montant);
        }
    }
}