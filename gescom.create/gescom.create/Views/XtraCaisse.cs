using DevExpress.XtraEditors;
using gescom.data.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gescom.create.Views
{
    public partial class XtraCaisse : XtraForm
    {
        private readonly XtraPeriode _fPeriode;
        private List<InvoiceModern> _list;

        public XtraCaisse()
        {
            InitializeComponent();
            _list = new List<InvoiceModern>();
            _fPeriode = new XtraPeriode();
            _list = CashHelpers.GetPaiementState();
            SetData();
        }

        private void SetData()
        {
            grillage.DataSource = _list;
            myNum.DataBindings.Clear();
            myNum.DataBindings.Add("Text", _list, "Id");
        }

        private void grillage_DoubleClick(object sender, EventArgs e)
        {
            string text = myNum.Text;
            if (text == null)
            {
                return;
            }
            long id = long.Parse(text);
            if (id == 0)
            {
                return;
            }
        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            DateModel date = DateHelpers.Get(_fPeriode.Debut, _fPeriode.Fin, _fPeriode.Showing);
            // CreateHelpers.ImprimerCaisse(_list, date);
        }

        private void détaillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fPeriode.Showing)
            {
                _fPeriode.Showing = false;
                détaillerToolStripMenuItem.Text = @"Filtrer";
                Text = @"CAISSE";
                SetData();
            }
            else
            {
                détaillerToolStripMenuItem.Text = @"Tous";
                _fPeriode.Showing = true;
                _fPeriode.ShowDialog();
            }
        }

        private void XtraCaisse_Activated(object sender, EventArgs e)
        {
            if (!_fPeriode.Showing) return;
            if (!_fPeriode.Norme) return;
            // _list = CashHelpers.FilterByDate(_list, _fPeriode.Debut, _fPeriode.Fin).ToList();
            Text = @"CAISSE DU " + StdCalcul.TitleSimple(_fPeriode.Debut, _fPeriode.Fin);
            SetData();
        }

        private void annulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = myNum.Text;
            if (text == null)
            {
                return;
            }
            long id = long.Parse(text);
            if (id == 0)
            {
                return;
            }
            CashModel model = CashHelpers.GetModel(id);
            //BoxItem model = CashHelpers.GetBoxItem(id);
            if (model.Percu > 0)
            {
                return;
            }
            DialogResult msg = MessageBox.Show(this, @"ANNULER OPERATION?", @"SUPPRESSION", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (msg != DialogResult.Yes)
            {
                return;
            }
            DiaryHelpers.Cancel(id);
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}