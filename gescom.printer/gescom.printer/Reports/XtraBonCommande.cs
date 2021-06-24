using DevExpress.XtraReports.UI;
using gescom.data.Models;

namespace gescom.printer.Reports
{
    public partial class XtraBonCommande : XtraReport
    {
        public XtraBonCommande()
        {
            InitializeComponent();
        }

        public XtraBonCommande(long id)
        {
            InitializeComponent();
            Init(id);
        }

        private void Init(long id)
        {
            title.Text = id.ToString("#,#");
            // get operation information
            var d = DiaryHelpers.Get(id);
            nom.Text = d.Nom;
            daty.Text = d.Datum.ToString();
            // get seller name
            // personnel.Text = ActionHelpers.GetSellerName(id);
            if (d.Pid == null) return;
            var j = (long)d.Pid;
            var p = PersonHelpers.Get(j);
            nomclient.Text = p.Nom;
            adrclient.Text = p.Adresse;
        }

        public XtraBonCommande(CashModel model)
        {
            InitializeComponent();
            Init(model.Id);
        }
    }
}