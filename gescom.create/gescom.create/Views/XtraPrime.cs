using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using gescom.printer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.create.Views
{
    public partial class XtraPrime : XtraForm
    {
        private readonly XtraPeriode _fPeriode;
        private readonly long _id;
        private List<PersonnelItem> _list;

        public XtraPrime()
        {
            InitializeComponent();
            _id = -1;
            _list = new List<PersonnelItem>();
            _fPeriode = new XtraPeriode(1);
            _list = DateHelpers.GetPrimeItems().ToList();
            SetData();
        }

        public XtraPrime(long id)
        {
            InitializeComponent();
            _id = id;
            _list = new List<PersonnelItem>();
            _fPeriode = new XtraPeriode(1);
            imprimer.Enabled = true;
            _list = DateHelpers.GetPrime(id).ToList();
            SetData();
        }

        private void détaillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fPeriode.Showing)
            {
                _fPeriode.Showing = false;
                détaillerToolStripMenuItem.Text = @"Filtrer";
                Text = @"BONIFICATION";
                _list = _id < 0 ? DateHelpers.GetPrimeItems().ToList() : DateHelpers.GetPrime(_id).ToList();
                SetData();
            }
            else
            {
                détaillerToolStripMenuItem.Text = @"Tous";
                _fPeriode.Showing = true;
                _fPeriode.ShowDialog();
            }
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
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
            CreateHelpers.DetaillerOperation(id);
        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            //CreateHelpers.ImprimerPrimes(_fPeriode.Debut, _fPeriode.Fin);
            PrintHelpers.ImprimerPrime(_list, _fPeriode.Debut, _fPeriode.Fin);
        }

        private void SetData()
        {
            grillage.DataSource = _list;
            myNum.DataBindings.Clear();
            myNum.DataBindings.Add("Text", _list, "Id");
        }

        private void XtraPrime_Activated(object sender, EventArgs e)
        {
            imprimer.Enabled = false;
            if (!_fPeriode.Showing) return;
            if (!_fPeriode.Norme) return;
            imprimer.Enabled = true;
            _list = DateHelpers.FilterPrimes(_list, _fPeriode.Debut, _fPeriode.Fin).ToList();
            Text = @"BONIFICATION DU " + StdCalcul.TitleSimple(_fPeriode.Debut, _fPeriode.Fin);
            SetData();
        }
    }
}