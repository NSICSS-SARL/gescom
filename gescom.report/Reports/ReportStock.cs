using gescom.data.Models;
using System.Collections.Generic;

namespace gescom.report.Reports
{
    public partial class ReportStock : DevExpress.XtraReports.UI.XtraReport
    {
        private int _count;

        public ReportStock()
        {
            InitializeComponent();
        }

        public ReportStock(List<OperationItem> liste)
        {
            InitializeComponent();
            _count = liste.Count;
            var p = PersonHelpers.Get(1);
            noms.Text = p.Nom;
            activite.Text = p.Activite;
            adresse.Text = p.Adresse;
            complement.Text = p.Complement;
            var textes = OperationHelpers.SetTexts(liste);
            DataSource = textes;
            code.DataBindings.Add("Text", textes, "Codage");
            designation.DataBindings.Add("Text", textes, "Designation");
            pgros.DataBindings.Add("Text", textes, "PGros");
            pdetail.DataBindings.Add("Text", textes, "PDetail");
            quantite.DataBindings.Add("Text", textes, "Qte");
            unite.DataBindings.Add("Text", textes, "Unite");
            place.DataBindings.Add("Text", textes, "Place");
        }

        public ReportStock(List<OperationItem> liste, string title)
        {
            InitializeComponent();
            _count = liste.Count;
            var p = PersonHelpers.Get(1);
            noms.Text = p.Nom;
            activite.Text = p.Activite;
            adresse.Text = p.Adresse;
            complement.Text = p.Complement;
            var textes = OperationHelpers.SetTexts(liste);
            DataSource = textes;
            code.DataBindings.Add("Text", textes, "Codage");
            designation.DataBindings.Add("Text", textes, "Designation");
            pgros.DataBindings.Add("Text", textes, "PGros");
            pdetail.DataBindings.Add("Text", textes, "PDetail");
            quantite.DataBindings.Add("Text", textes, "Qte");
            unite.DataBindings.Add("Text", textes, "Unite");
            place.DataBindings.Add("Text", textes, "Place");
            titre.Text = title;
        }

        public void SetTitle(string title, string name)
        {
            titre.Text = title;
            tableGroup.Visible = true;
            nomGroupe.Text = name;
            nombre.Text = StdCalcul.DoubleToSpaceFormat(_count);
        }
    }
}