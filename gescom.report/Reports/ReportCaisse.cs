using gescom.data.Models;
using System.Collections.Generic;

namespace gescom.report.Reports
{
    public partial class ReportCaisse : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportCaisse()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            var p = PersonHelpers.Get(1);
            noms.Text = p.Nom;
            activite.Text = p.Activite;
            adresse.Text = p.Adresse;
        }

        public ReportCaisse(IEnumerable<InvoiceModel> liste, DateModel date)
        {
            InitializeComponent();
            Init();
            DataSource = liste;
            Rang.DataBindings.Add("Text", liste, "Id");
            Datum.DataBindings.Add("Text", liste, "Datum");
            Hote.DataBindings.Add("Text", liste, "Hote");
            Operateur.DataBindings.Add("Text", liste, "Operateur");
            Nom.DataBindings.Add("Text", liste, "Nom");
            Montant.DataBindings.Add("Text", liste, "Montant2");
            Percu.DataBindings.Add("Text", liste, "Percu2");
            Rendu.DataBindings.Add("Text", liste, "Rendu2");
            total.Text = CashHelpers.GetAmountText(liste);
            if (date.Debut.Date == date.Fin.Date) return;
            periodeTable.Visible = true;
            dateDebut.Text = date.Debut.ToString("d");
            dateFin.Text = date.Fin.ToString("d");
            titre.Text = StdCalcul.TitleReport("CAISSE DU ", dateDebut.Text, dateFin.Text);
        }
    }
}