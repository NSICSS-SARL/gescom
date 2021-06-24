using DevExpress.XtraReports.UI;
using gescom.data.Models;
using System;
using System.Collections.Generic;

namespace gescom.printer.Reports
{
    public partial class ReportBonus : XtraReport
    {
        public ReportBonus()
        {
            InitializeComponent();
            SetApp();
        }

        public ReportBonus(List<PersonnelItem> liste, DateTime debut, DateTime fin)
        {
            InitializeComponent();
            SetApp();
            SetTime(debut, fin);
            SetData(liste);
        }

        public ReportBonus(DateTime debut, DateTime fin)
        {
            InitializeComponent();
            SetApp();
            SetTime(debut, fin);
        }

        private void SetApp()
        {
            PersonModel p = PersonHelpers.Get(1);
            nom.Text = p.Nom;
            adresse.Text = p.Adresse;
        }

        private void SetTime(DateTime debut1, DateTime fin1)
        {
            mois.Text = debut1.ToString("Y");
            debut.Text = debut1.ToString("d");
            fin.Text = fin1.ToString("d");
        }

        private void SetData(List<PersonnelItem> liste)
        {
            if (liste.Count == 0)
            {
                return;
            }
            Noms.Text = liste.Count.ToString("D");
            long id = 0;
            if (liste[0].Wid != null)
            {
                id = (long)liste[0].Wid;
            }
            PersonModel p = PersonHelpers.Get(id);
            Noms.Text = p.Nom;
            Activites.Text = p.Activite;
            Adresses.Text = p.Adresse;
            DataSource = liste;
            Id.DataBindings.Add("Text", liste, "Id");
            Datum.DataBindings.Add("Text", liste, "Daty");
            Operateur.DataBindings.Add("Text", liste, "Operateur");
            Bonif.DataBindings.Add("Text", liste, "Primus");
            float f = DateHelpers.GetAmountPrimeList(liste);
            total.Text = StdCalcul.DoubleToSpaceFormat(f);
        }
    }
}