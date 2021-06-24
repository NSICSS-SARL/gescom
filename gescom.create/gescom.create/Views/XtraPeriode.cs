using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;

namespace gescom.create.Views
{
    public partial class XtraPeriode : XtraForm
    {
        private readonly int _index;

        public XtraPeriode()
        {
            InitializeComponent();
            Init();
        }

        public XtraPeriode(int index)
        {
            InitializeComponent();
            Init();
            _index = index;
        }

        public DateTime Debut { get; set; }

        public DateTime Fin { get; set; }

        public bool Norme { get; set; }

        public bool Showing { get; set; }

        private void Init()
        {
            debut.Value = DateTime.Now;
            Debut = DateTime.Now;
            Fin = DateTime.Now;
            Showing = false;
            fin.Value = DateTime.Now;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Debut = debut.Value;
            Fin = fin.Value;
            if (_index == 0)
            {
                if (Fin < Debut)
                {
                    ErrorHelpers.ShowError(@"SELECTION INVALIDE");
                    return;
                }
                Norme = true;
            }
            if (_index == 1)
            {
                bool b = StdCalcul.DateValidation(Debut, Fin);
                if (!b)
                {
                    ErrorHelpers.ShowError(@"SELECTION INVALIDE");
                    return;
                }
                Norme = true;
            }
            Close();
        }
    }
}