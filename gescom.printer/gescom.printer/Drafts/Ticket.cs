using gescom.data.Models;
using System;

namespace gescom.printer.Drafts
{
    public partial class Ticket : DevExpress.XtraReports.UI.XtraReport
    {
        public Ticket()
        {
            InitializeComponent();
        }

        public Ticket(OperationElem item)
        {
            InitializeComponent();
            Init(item);
            DataSource = item.Members;
            count.Text = item.Count;
            somme.Text = item.Montant2;
            quantite.DataBindings.Add("Text", item.Members, "Quantite");
            codevente.DataBindings.Add("Text", item.Members, "LongCode");
            nom.DataBindings.Add("Text", item.Members, "Refce");
            //unite.DataBindings.Add("Text", item.Members, "Unite");
        }

        private void Init(OperationElem item)
        {
            num.Text = StdCalcul.DoubleToSpaceFormat(item.Id);
            vendeur.Text = Environment.MachineName;
            temps.Text = DateTime.Now.ToString();
            operateur.Text = item.Operateur.ToUpper();
        }
    }
}