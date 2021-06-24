using gescom.data.Models;
using System;
using System.Collections.Generic;

namespace gescom.report.Reports
{
    public partial class ReportDeclare : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDeclare()
        {
            InitializeComponent();
            PersonModel p = PersonHelpers.Get(1);
            noms.Text = p.Nom;
            activite.Text = p.Activite;
            domicile.Text = p.Adresse;
            complement.Text = p.Complement;
        }

        protected void SetTotal(List<ImpotItem> liste)
        {
            float totalTaxable = 0;
            float totalExo = 0;
            float totalCa = 0;
            float totalColl = 0;
            float totalDed = 0;
            float solde = 0;
            foreach (var impotItem in liste)
            {
                if (impotItem.VenteTaxable != null)
                {
                    var t1 = (float)impotItem.VenteTaxable;
                    totalTaxable += t1;
                }
                if (impotItem.VenteExo != null)
                {
                    var t2 = (float)impotItem.VenteExo;
                    totalExo += t2;
                }
                if (impotItem.VenteTotal != null)
                {
                    var t3 = (float)impotItem.VenteTotal;
                    totalCa += t3;
                }
                if (impotItem.Collecte != null)
                {
                    var t4 = (float)impotItem.Collecte;
                    totalColl += t4;
                }
                if (impotItem.Deductible != null)
                {
                    var t5 = (float)impotItem.Deductible;
                    totalDed += t5;
                }
                solde += impotItem.Solde;
            }
            totTaxable.Text = StdCalcul.DoubleToSpaceFormat(totalTaxable);
            totExo.Text = StdCalcul.DoubleToSpaceFormat(totalExo);
            totCa.Text = StdCalcul.DoubleToSpaceFormat(totalCa);
            totColl.Text = StdCalcul.DoubleToSpaceFormat(totalColl);
            totDed.Text = StdCalcul.DoubleToSpaceFormat(totalDed);
            totSol.Text = StdCalcul.DoubleToSpaceFormat(solde);
        }

        public ReportDeclare(List<ImpotItem> liste, DateTime debut, DateTime fin)
        {
            InitializeComponent();
            PersonModel p = PersonHelpers.Get(1);
            noms.Text = p.Nom;
            activite.Text = p.Activite;
            domicile.Text = p.Adresse;
            complement.Text = p.Complement;
            dateDebut.Text = debut.ToString("d");
            dateFin.Text = fin.ToString("d");
            titre.Text = @"DETAIL DECLARATION DU " + StdCalcul.TitleSimple(debut, fin);
            SetTotal(liste);
            /*  var listText = DateHelpers.GetImpotTexts(liste);
              DataSource = listText;
              Id.DataBindings.Add("Text", listText, "Id");
              D2.DataBindings.Add("Text", listText, "D2");
              VenteExo.DataBindings.Add("Text", listText, "VenteExo");
              VenteTaxable.DataBindings.Add("Text", listText, "VenteTaxable");
              VenteTotal.DataBindings.Add("Text", listText, "VenteTotal");
              Collecte.DataBindings.Add("Text", listText, "Collecte");
              Deductible.DataBindings.Add("Text", listText, "Deductible");
              Solde.DataBindings.Add("Text", listText, "Solde"); */
        }
    }
}