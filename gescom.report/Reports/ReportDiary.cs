using gescom.data.Models;
using System.Collections.Generic;

namespace gescom.report.Reports
{
    public partial class ReportDiary : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDiary()
        {
            InitializeComponent();
        }

        public ReportDiary(IEnumerable<DayItem> liste, DateModel date)
        {
            InitializeComponent();
            var p = PersonHelpers.Get(1);
            noms.Text = p.Nom;
            activite.Text = p.Activite;
            adresse.Text = p.Adresse;
            DataSource = liste;
            Rang.DataBindings.Add("Text", liste, "Rang");
            Datum.DataBindings.Add("Text", liste, "Datum");
            Tache.DataBindings.Add("Text", liste, "Tache");
            Operateur.DataBindings.Add("Text", liste, "Nom");
            Nom.DataBindings.Add("Text", liste, "PersonName");
            Valeur.DataBindings.Add("Text", liste, "Valeur");
            //total.Text = DiaryHelpers.GetAmountText(liste);
            if (date.Debut.Date == date.Fin.Date) return;
            periodeTable.Visible = true;
            dateDebut.Text = date.Debut.ToString("d");
            dateFin.Text = date.Fin.ToString("d");
            titre.Text = StdCalcul.TitleReport("JOURNAL DU ", dateDebut.Text, dateFin.Text);
        }
    }
}