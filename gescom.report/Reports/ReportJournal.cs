using gescom.data.Models;

namespace gescom.report.Reports
{
    public partial class ReportJournal : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportJournal()
        {
            InitializeComponent();
        }

        public ReportJournal(long id)
        {
            InitializeComponent();
            var details = ActionHelpers.GetTexts(id);
            DataSource = details;

            Id.DataBindings.Add("Text", details, "Id");
            Tache.DataBindings.Add("Text", details, "Tache");
            Daty.DataBindings.Add("Text", details, "Daty");
            Operateur.DataBindings.Add("Text", details, "Operateur");
            Prix.DataBindings.Add("Text", details, "Prix");
            QEntre.DataBindings.Add("Text", details, "QEntre");
            QSort.DataBindings.Add("Text", details, "QSort");
            Montant.DataBindings.Add("Text", details, "Montant");

            var resume = OperationHelpers.GetText(id);
            Ndx.DataBindings.Add("Text", resume, "Ndx");
            Codage.DataBindings.Add("Text", resume, "Codage");
            Designation.DataBindings.Add("Text", resume, "Designation");
            Refers.DataBindings.Add("Text", resume, "Refers");
            Place.DataBindings.Add("Text", resume, "Place");
            Unite.DataBindings.Add("Text", resume, "Unite");
            DateAchat.DataBindings.Add("Text", resume, "DateAchat");
            Qachat.DataBindings.Add("Text", resume, "Qachat");
            Vachat.DataBindings.Add("Text", resume, "Vachat");
            DateVente.DataBindings.Add("Text", resume, "DateVente");
            Qvente.DataBindings.Add("Text", resume, "Qvente");
            Vvente.DataBindings.Add("Text", resume, "Vvente");
            QStock.DataBindings.Add("Text", resume, "QStock");
            Vstock.DataBindings.Add("Text", resume, "Vstock");
            Qvol.DataBindings.Add("Text", resume, "Qvol");
            Vvol.DataBindings.Add("Text", resume, "Vvol");
            Qdefect.DataBindings.Add("Text", resume, "Qdefect");
            Vdefect.DataBindings.Add("Text", resume, "Vdefect");
        }

        public ReportJournal(long id, DateModel date)
        {
            InitializeComponent();
            var details = ActionHelpers.GetDatedTexts(id, date.Debut, date.Fin);
            DataSource = details;
            Id.DataBindings.Add("Text", details, "Id");
            Tache.DataBindings.Add("Text", details, "Tache");
            Daty.DataBindings.Add("Text", details, "Daty");
            Operateur.DataBindings.Add("Text", details, "Operateur");
            Prix.DataBindings.Add("Text", details, "Prix");
            QEntre.DataBindings.Add("Text", details, "QEntre");
            QSort.DataBindings.Add("Text", details, "QSort");
            Montant.DataBindings.Add("Text", details, "Montant");
            var resume = OperationHelpers.GetText(id);
            Ndx.DataBindings.Add("Text", resume, "Ndx");
            Codage.DataBindings.Add("Text", resume, "Codage");
            Designation.DataBindings.Add("Text", resume, "Designation");
            Refers.DataBindings.Add("Text", resume, "Refers");
            Place.DataBindings.Add("Text", resume, "Place");
            Unite.DataBindings.Add("Text", resume, "Unite");
            DateAchat.DataBindings.Add("Text", resume, "DateAchat");
            Qachat.DataBindings.Add("Text", resume, "Qachat");
            Vachat.DataBindings.Add("Text", resume, "Vachat");
            DateVente.DataBindings.Add("Text", resume, "DateVente");
            Qvente.DataBindings.Add("Text", resume, "Qvente");
            Vvente.DataBindings.Add("Text", resume, "Vvente");
            QStock.DataBindings.Add("Text", resume, "QStock");
            Vstock.DataBindings.Add("Text", resume, "Vstock");
            Qvol.DataBindings.Add("Text", resume, "Qvol");
            Vvol.DataBindings.Add("Text", resume, "Vvol");
            Qdefect.DataBindings.Add("Text", resume, "Qdefect");
            Vdefect.DataBindings.Add("Text", resume, "Vdefect");
            periodeTable.Visible = true;
            dateDebut.Text = date.Debut.ToString("d");
            dateFin.Text = date.Fin.ToString("d");
            titre.Text = StdCalcul.TitleReport("MOUVEMENTS ARTICLE DU ", dateDebut.Text, dateFin.Text);
        }
    }
}