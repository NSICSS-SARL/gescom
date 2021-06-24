using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.create.Views
{
    public partial class XtraDeclaration : XtraForm
    {
        private readonly XtraPeriode _fPeriode;
        private List<ImpotItem> _list;

        public XtraDeclaration()
        {
            InitializeComponent();
            _list = new List<ImpotItem>();
            _fPeriode = new XtraPeriode(1);
            _list = DateHelpers.GetImpots().ToList();
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
            CreateHelpers.DetaillerOperation(id);
        }

        private void détaillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fPeriode.Showing)
            {
                _fPeriode.Showing = false;
                détaillerToolStripMenuItem.Text = @"Filtrer";
                Text = @"DECLARATION";
                _list = DateHelpers.GetImpots().ToList();
                SetData();
            }
            else
            {
                détaillerToolStripMenuItem.Text = @"Tous";
                _fPeriode.Showing = true;
                _fPeriode.ShowDialog();
            }
        }

        private void XtraDeclaration_Activated(object sender, EventArgs e)
        {
            imprimer.Enabled = false;
            if (!_fPeriode.Showing) return;
            if (!_fPeriode.Norme) return;
            _list = DateHelpers.FilterImpots(_list, _fPeriode.Debut, _fPeriode.Fin).ToList();
            imprimer.Enabled = true;
            Text = @"DECLARATION DU " + StdCalcul.TitleSimple(_fPeriode.Debut, _fPeriode.Fin);
            SetData();
        }
    }
}