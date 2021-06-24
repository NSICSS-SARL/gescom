using System;
using gescom.data.Models;

namespace gescom.create.Views
{
    public partial class XtraRegBonus : DevExpress.XtraEditors.XtraForm
    {
        private long _id;
        private float _montant;
        public XtraRegBonus()
        {
            InitializeComponent();
        }


        public XtraRegBonus(long id)
        {
            InitializeComponent();
            _id = id;
            _montant = DateHelpers.GetAmountPrime(id);
            PersonModel p = PersonHelpers.Get(id);
            Noms.Text = p.Nom;
            Numero.Text = StdCalcul.AfficherPrix(p.Id);
            Montant.Text = StdCalcul.AfficherPrix(_montant);
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Percu_EditValueChanged(object sender, EventArgs e)
        {
            creer.Enabled = false;
            Rendu.Text = @"0";
            if (_id <= 0) { return;}
            if (string.IsNullOrEmpty(Percu.Text)) { return;}
            float percu = 0;
            try
            {
                percu = float.Parse(Percu.Text);
            }
            catch (Exception)
            {
                return;
            }
            if (_montant >= percu)
            {
                float r = _montant - percu;
                Rendu.Text = StdCalcul.AfficherPrix(r);
                creer.Enabled = true;
            }
        }

        private void creer_Click(object sender, EventArgs e)
        {
            float montant = float.Parse(Percu.Text);
            DiaryHelpers.ReglerBonus(_id,montant);
        }
    }
}