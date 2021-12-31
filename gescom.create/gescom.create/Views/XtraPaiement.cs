using System;
using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using gescom.printer;

namespace gescom.create.Views
{
    public partial class XtraPaiement : XtraForm
    {
        private CasherIn _cash;

        public XtraPaiement()
        {
            InitializeComponent();
            _cash = new CasherIn();
        }

        public void SetData()
        {
            encaisse.Enabled = false;
            var liste = ApiModel.GetNotPaid();
            grillage.DataSource = liste;
            myNum.DataBindings.Clear();
            myNum.DataBindings.Add("Text", liste, "Id");
            Numero.DataBindings.Clear();
            Numero.DataBindings.Add("Text", liste, "Id2");
            Nom.DataBindings.Clear();
            Nom.DataBindings.Add("Text", liste, "Nom");
            Montant.DataBindings.Clear();
            Montant.DataBindings.Add("Text", liste, "Montant2");
            myMontant.DataBindings.Clear();
            myMontant.DataBindings.Add("Text", liste, "Montant");
            Percu.Text = null;
            Percu.SelectAll();
            Percu.Focus();
        }

        private void grillage_DoubleClick(object sender, EventArgs e)
        {
            var text = myNum.Text;
            if (text == null) return;
            var id = long.Parse(text);
            if (id == 0) return;
            CreateHelpers.ConsulteDetailCaisse(id);
        }

        private void rafraiche_Click(object sender, EventArgs e)
        {
            SetData();
        }

        private void Percu_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Percu.Text)) return;
            if (string.IsNullOrEmpty(Montant.Text)) return;
            encaisse.Enabled = false;
            float percu;
            try
            {
                percu = float.Parse(Percu.Text);
            }
            catch (Exception)
            {
                return;
            }

            if (percu <= 0) return;
            var rendu = percu - float.Parse(myMontant.Text);
            if (rendu >= 0)
            {
                Rendu.Text = StdCalcul.DoubleToSpaceFormat(rendu);
                encaisse.Enabled = true;
            }
        }

        private void encaisse_Click(object sender, EventArgs e)
        {
            var id = long.Parse(myNum.Text);
            var percu = float.Parse(Percu.Text);

            _cash = ApiModel.GetCasher(id); //
            _cash.Percu = percu;
            //
            PrintHelpers.PrintReceipt(_cash);
            Numero.Text = null;
            Nom.Text = null;
            Montant.Text = null;
            Rendu.Text = null;
            SetData();
        }

        private void grillage_Click(object sender, EventArgs e)
        {
            var text = myNum.Text;
            if (text == null) return;
            var id = long.Parse(text);
            if (id == 0) return;
        }

        private void XtraPaiement_Activated(object sender, EventArgs e)
        {
            SetData();
        }
    }
}