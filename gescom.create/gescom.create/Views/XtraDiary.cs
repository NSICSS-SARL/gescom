using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.create.Views
{
    public partial class XtraDiary : XtraForm
    {
        private readonly XtraPeriode _fPeriode;
        private readonly long _id;
        private List<DayItem> _list;

        public XtraDiary()
        {
            InitializeComponent();
            _id = -1;
            _list = new List<DayItem>();
            _fPeriode = new XtraPeriode();
            Init();
        }

        public XtraDiary(long id)
        {
            InitializeComponent();
            _id = id;
            _list = new List<DayItem>();
            _fPeriode = new XtraPeriode();
            Init();
        }

        private void détaillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fPeriode.Showing)
            {
                _fPeriode.Showing = false;
                détaillerToolStripMenuItem.Text = @"Filtrer";
                Init();
            }
            else
            {
                détaillerToolStripMenuItem.Text = @"Tous";
                _fPeriode.Showing = true;
                _fPeriode.ShowDialog();
            }
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
            CreateHelpers.ImprimerResume(_list, SetDate());
        }

        private void Init()
        {
            _list = _id < 0 ? DiaryHelpers.GetItems().ToList() : DiaryHelpers.GetByPid(_id).ToList();
            Text = @"JOURNAL: TOUS";
            SetData();
        }

        private void SetData()
        {
            myNum.DataBindings.Clear();
            grillage.DataSource = _list;
            myNum.DataBindings.Add("Text", _list, "Id");
        }

        private DateModel SetDate()
        {
            DateModel date = DateHelpers.Get(_fPeriode.Debut, _fPeriode.Fin, _fPeriode.Showing);
            return date;
        }

        private void XtraDiary_Activated(object sender, EventArgs e)
        {
            if (!_fPeriode.Showing) return;
            if (!_fPeriode.Norme) return;
            _list = DiaryHelpers.FilterByDate(_list, _fPeriode.Debut, _fPeriode.Fin).ToList();
            Text = StdCalcul.TitlePeriod(_fPeriode.Debut, _fPeriode.Fin);
            SetData();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}