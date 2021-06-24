using gescom.create.Models;
using gescom.data.Models;

namespace gescom.create.Views
{
    public partial class XtraComptable : DevExpress.XtraEditors.XtraForm
    {
        private readonly long _id;

        public XtraComptable()
        {
            InitializeComponent();
        }

        public XtraComptable(long id)
        {
            InitializeComponent();
            _id = id;
            SetData();
        }

        private void SetData()
        {
            var p = CompteHelpers.GetLastItem(_id);
            Noms.Text = p.Nom;
            Adresse.Text = p.Adresse;
            Typage.Text = p.LitteralType;
            if (p.Pid != null)
            {
                var pid = (long)p.Pid;
                Numero.Text = StdCalcul.DoubleToSpaceFormat(pid);
            }
            if (p.Solde == null) return;
            var sold = (long)p.Solde;
            solde.Text = StdCalcul.AfficherPrix(sold);
        }

        private void fermer_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void creer_Click(object sender, System.EventArgs e)
        {
            bool isDebit = debit.Checked;
            var error = CompteHelpers.Create(isDebit, _id, textRefce.Text, textLibelle.Text, textMontant.Text);
            if (!error)
            {
                ErrorHelpers.ShowError("DONNEES INCOMPLETES");
                return;
            }
            Close();
        }
    }
}