using DevExpress.XtraReports.UI;
using gescom.data.Models;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace gescom.report.Reports
{
    public partial class ReportFacture : XtraReport
    {
        public ReportFacture()
        {
            InitializeComponent();
        }

        public ReportFacture(long id)
        {
            InitializeComponent();
            PersonModel p = PersonHelpers.Get(1);
            nom.Text = p.Nom;
            activite.Text = p.Activite;
            adresse.Text = p.Adresse;
            complement.Text = p.Complement;
            telephone.Text = p.Tel1;
            stat.Text = p.Stat;
            nif.Text = p.Nif;
            rc.Text = p.Fax;
            mail.Text = p.Email;
            DiaryText diary = DiaryHelpers.GetDiaryText(id);
            Operateur.Text = diary.Nom;
            numero.Text = StdCalcul.Spacing(id.ToString(CultureInfo.InvariantCulture));
            RetailModel retail = RetailHelpers.GetModel(id);
            Taxe.Text = StdCalcul.Spacing(RetailHelpers.GetTaxAmount(id).ToString(CultureInfo.InvariantCulture));
            NomKil.Text = retail.NomKil;
            AdrKil.Text = retail.AdrKil;
            float tot = retail.Total;
            lettre.Text += StdCalcul.FormatGasy(tot);
            total.Text = StdCalcul.Spacing(tot.ToString(CultureInfo.InvariantCulture));
            du.Text = total.Text;
            Datum.Text = diary.Datum.ToString("G");
            List<RetailText> liste = RetailHelpers.GetRetailItems(id).ToList();
            DataSource = liste;
            Codes.DataBindings.Add("Text", liste, "Codes");
            Designation.DataBindings.Add("Text", liste, "Designation");
            Price.DataBindings.Add("Text", liste, "Price");
            Unite.DataBindings.Add("Text", liste, "Unite");
            Quantity.DataBindings.Add("Text", liste, "Quantity");
            Produit.DataBindings.Add("Text", liste, "Produit");
            Tva.DataBindings.Add("Text", liste, "Tva");
            BoxItem box = CashHelpers.GetBoxItem(id);
            if (box == null)
            {
                return;
            }
            percu.Text = StdCalcul.Spacing(box.Percu.ToString());
            rendu.Text = StdCalcul.Spacing(box.Rendu.ToString());
        }

        public void SetVisible()
        {
            tablePaie.Visible = true;
        }
    }
}