using gescom.data.Models;
using System.Collections.Generic;

namespace gescom.report.Reports
{
    public partial class ReportCustomer : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportCustomer()
        {
            InitializeComponent();
            var p = PersonHelpers.Get(1);
            noms.Text = p.Nom;
            activite.Text = p.Activite;
            adresse.Text = p.Adresse;
        }

        public ReportCustomer(List<InvoiceModel> liste, DateModel date)
        {
            InitializeComponent();
            var p = PersonHelpers.Get(1);
            noms.Text = p.Nom;
            activite.Text = p.Activite;
            adresse.Text = p.Adresse;
            DataSource = liste;
            Rang.DataBindings.Add("Text", liste, "Id");
            Datum.DataBindings.Add("Text", liste, "Datum");
            Nom.DataBindings.Add("Text", liste, "Hote");
            Operateur.DataBindings.Add("Text", liste, "Operateur");
            if (date.Debut.Date == date.Fin.Date) return;
            periodeTable.Visible = true;
            dateDebut.Text = date.Debut.ToString("d");
            dateFin.Text = date.Fin.ToString("d");
            titre.Text = StdCalcul.TitleReport("CAISSE DU ", dateDebut.Text, dateFin.Text);
        }
    }
}