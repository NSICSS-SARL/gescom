using DevExpress.XtraReports.UI;
using gescom.data.Models;
using System.Collections.Generic;

namespace gescom.report.Reports
{
    public partial class ReportDetail : XtraReport
    {
        public ReportDetail()
        {
            InitializeComponent();
        }

        public ReportDetail(List<RetailText> liste)
        {
            InitializeComponent();
            DataSource = liste;
        }

        public ReportDetail(long id)
        {
            InitializeComponent();
            var p = PersonHelpers.Get(1);
            noms.Text = p.Nom;
            activite.Text = p.Activite;
            adresse.Text = p.Adresse;
            DiaryText diary = DiaryHelpers.GetDiaryText(id);
            total.Text = RetailHelpers.GetAmountText(id);
            Datum.Text = diary.Datum.ToString("G");
            Tache.Text = StdCalcul.TitleReport(diary.Tache, diary.Id);
            Hote.Text = diary.Hote;
            Nom.Text = diary.Nom;
            var liste = RetailHelpers.GetRetailItems(id);
            DataSource = liste;
            Codes.DataBindings.Add("Text", liste, "Codes");
            Place.DataBindings.Add("Text", liste, "Place");
            Designation.DataBindings.Add("Text", liste, "Designation");
            Price.DataBindings.Add("Text", liste, "Price");
            Unite.DataBindings.Add("Text", liste, "Unite");
            Quantity.DataBindings.Add("Text", liste, "Quantity");
            Produit.DataBindings.Add("Text", liste, "Produit");
        }
    }
}