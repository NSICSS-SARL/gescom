using DevExpress.XtraReports.UI;
using gescom.data.Models;
using System;

namespace gescom.printer.Reports
{
    public partial class XtraBonus : XtraReport
    {
        public XtraBonus()
        {
            InitializeComponent();
            PersonModel p = PersonHelpers.Get(1);
            nom.Text = p.Nom;
            adresse.Text = p.Adresse;
        }

        public XtraBonus(DateTime debut1, DateTime fin1)
        {
            InitializeComponent();
            PersonModel p = PersonHelpers.Get(1);
            nom.Text = p.Nom;
            adresse.Text = p.Adresse;
            DateDebut.Value = debut1.AddDays(-1);
            DateFin.Value = fin1;
            mois.Text = debut1.ToString("Y");
            debut.Text = debut1.ToString("d");
            fin.Text = fin1.ToString("d");
        }
    }
}