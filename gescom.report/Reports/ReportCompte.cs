using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using gescom.data.Models;

namespace gescom.report.Reports
{
    public partial class ReportCompte : XtraReport
    {
        public ReportCompte()
        {
            InitializeComponent();
            SetInfo();
        }

        public ReportCompte(List<SoldeItem> liste, long pid)
        {
            InitializeComponent();
            SetInfo();
            debut.Text = null;
            fin.Text = null;
            tous.Text = @"TOUS";
            SetPerson(pid);
            var listText = CompteHelpers.GetSoldeTexts(liste);
            DataSource = listText;
            Id.DataBindings.Add("Text", listText, "Id");
            Datum.DataBindings.Add("Text", listText, "Daty");
            Refce.DataBindings.Add("Text", listText, "Refce");
            Libelle.DataBindings.Add("Text", listText, "Libelle");
            Debit.DataBindings.Add("Text", listText, "Debit");
            Credit.DataBindings.Add("Text", listText, "Credit");
            float totDebit = 0;
            float totCredit = 0;
            foreach (var item in liste)
            {
                totDebit += item.Debit;
                totCredit += item.Credit;
            }

            var tSolde = totDebit - totCredit;
            totalDebit.Text = StdCalcul.DoubleToSpaceFormat(totDebit);
            totalCredit.Text = StdCalcul.DoubleToSpaceFormat(totCredit);
            solde.Text = StdCalcul.DoubleToSpaceFormat(tSolde);
        }

        public ReportCompte(List<SoldeItem> liste, long pid, DateTime dateDebut, DateTime dateFin)
        {
            InitializeComponent();
            SetInfo();
            debut.Text = dateDebut.ToString("d");
            fin.Text = dateFin.ToString("d");
            SetPerson(pid);
            var listText = CompteHelpers.GetSoldeTexts(liste);
            DataSource = listText;
            Id.DataBindings.Add("Text", listText, "Id");
            Datum.DataBindings.Add("Text", listText, "Daty");
            Refce.DataBindings.Add("Text", listText, "Refce");
            Libelle.DataBindings.Add("Text", listText, "Libelle");
            Debit.DataBindings.Add("Text", listText, "Debit");
            Credit.DataBindings.Add("Text", listText, "Credit");
            float totDebit = 0;
            float totCredit = 0;
            foreach (var item in liste)
            {
                totDebit += item.Debit;
                totCredit += item.Credit;
            }

            var tSolde = totDebit - totCredit;
            totalDebit.Text = StdCalcul.DoubleToSpaceFormat(totDebit);
            totalCredit.Text = StdCalcul.DoubleToSpaceFormat(totCredit);
            solde.Text = StdCalcul.DoubleToSpaceFormat(tSolde);
            var anterior = CompteHelpers.GetAnteriorSolde(liste, dateDebut);
            if (anterior > 0)
            {
                reporting.Visible = true;
                resuming.Visible = true;
                titleNouveau.Text += dateDebut.ToString("d");
                nouveau.Text = StdCalcul.DoubleToSpaceFormat(anterior);
                titleResume.Text += dateFin.ToString("d");
                anterior += tSolde;
                resume.Text = StdCalcul.DoubleToSpaceFormat(anterior);
            }
        }

        private void SetInfo()
        {
            var p = PersonHelpers.Get(1);
            nom.Text = p.Nom;
            adresse.Text = p.Adresse;
        }

        private void SetPerson(long pid)
        {
            var p = PersonHelpers.Get(pid);
            if (p.Groupe == 0) Typage.Text = "FOURNISSEUR";
            if (p.Groupe == 5) Typage.Text = "PERSONNEL";
            if (p.Groupe > 0 && p.Groupe < 5) Typage.Text = "CLIENT";
            Numero.Text = StdCalcul.DoubleToSpaceFormat(p.Id);
            Noms.Text = p.Nom;
            Adresses.Text = p.Adresse;
        }
    }
}