using gescom.data.Models;
using DevExpress.XtraReports.UI;
using System;
using System.Globalization;

namespace gescom.printer.Reports
{
    public partial class TicketDirect : XtraReport
    {
        public TicketDirect()
        {
            InitializeComponent();
        }

        public TicketDirect(OperationElem item)
        {
            InitializeComponent();
            Init(item);
            DataSource = item.Members;
            count.Text = item.Count;
            quantite.DataBindings.Add("Text", item.Members, "Quantite");
            codevente.DataBindings.Add("Text", item.Members, "LongCode");
            nom.DataBindings.Add("Text", item.Members, "Refce");
        }

        private void Init(OperationElem item)
        {
            num.Text = StdCalcul.DoubleToSpaceFormat(item.Id);
            vendeur.Text = Environment.MachineName;
            temps.Text = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            operateur.Text = item.Operateur.ToUpper();
        }
    }
}