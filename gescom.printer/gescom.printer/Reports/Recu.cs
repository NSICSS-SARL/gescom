using System;
using DevExpress.XtraReports.UI;
using gescom.data.Models;

namespace gescom.printer.Reports
{
    public partial class Recu : XtraReport
    {
        public Recu()
        {
            InitializeComponent();
        }

        public Recu(TiroirModel tiroir)
        {
            InitializeComponent();
            tiret.Visible = false;
            nomPro.Text = "RECAPITULATION";
            arendre.Text = "Rendu";
            //footer.Text = "AU REVOIR";

            receveur.Text = Environment.UserName;
            hote.Text = Environment.MachineName;
            num.Text = tiroir.Count;
            percu.Text = tiroir.PercuTotal;
            valeur.Text = tiroir.MontantTotal;
            somme.Text = tiroir.MontantTotal;
            rendu.Text = tiroir.RenduTotal;
            DataSource = tiroir.Items;
            quantite.DataBindings.Add("Text", tiroir.Items, "Id");
            code.DataBindings.Add("Text", tiroir.Items, "Operateur");
            refce.DataBindings.Add("Text", tiroir.Items, "Nom");
            produit.DataBindings.Add("Text", tiroir.Items, "Montant2");
            heure.Text = DateTime.Now.ToString();
        }

        public Recu(CasherIn info)
        {
            InitializeComponent();
            //hote.Text = info.Hote;
            hote.Text = Environment.MachineName;
            operateur.Text = info.Operateur;
            receveur.Text = info.Receveur;
            nomkil.Text = info.Nom;
            adressekil.Text = info.Adresse;
            num.Text = "N° " + StdCalcul.DoubleToSpaceFormat(info.Id);
            double x = 0;
            if (info.Rendu != null) x = (double) info.Rendu;
            rendu.Text = StdCalcul.DoubleToSpaceFormat(x);
            if (info.Montant != null) x = (double) info.Montant;
            valeur.Text = info.Montant2;
            somme.Text = info.Montant2;
            if (info.Percu != null) x = (double) info.Percu;
            percu.Text = StdCalcul.DoubleToSpaceFormat(x);
            //
            DataSource = info.ListElem;
            quantite.DataBindings.Add("Text", info.ListElem, "Quantite");
            code.DataBindings.Add("Text", info.ListElem, "Code");
            refce.DataBindings.Add("Text", info.ListElem, "Refce");
            produit.DataBindings.Add("Text", info.ListElem, "Pdt");
            heure.Text = DateTime.Now.ToString();
        }
    }
}