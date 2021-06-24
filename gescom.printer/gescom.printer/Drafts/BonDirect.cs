using DevExpress.XtraReports.UI;
using gescom.data.Models;
using System;

namespace gescom.printer.Drafts
{
    public partial class BonDirect : XtraReport
    {
        public BonDirect()
        {
            InitializeComponent();
            Init();
        }

        public BonDirect(long id)
        {
            InitializeComponent();
            Ndx.Text = id.ToString("#,#");
            Init();
            Daty.Text = DateTime.Now.ToString("g");
        }

        private void Init()
        {
            PersonModel p = PersonHelpers.Get(1);
            nom.Text = p.Nom;
            adresse.Text = p.Adresse;
            complement.Text = p.Complement;
            tel1.Text += p.Tel1;
            tel2.Text += p.Tel2;
            stat.Text += p.Stat;
            nif.Text += p.Nif;
        }
    }
}