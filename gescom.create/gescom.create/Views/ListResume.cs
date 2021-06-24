using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.create.Views
{
    public partial class ListResume : XtraForm
    {
        private readonly XtraPeriode _fPeriode;
        private readonly List<DayItem> _list;
        private int _index;

        public ListResume()
        {
            InitializeComponent();
            _index = -1;
            ListForPrint = new List<DayItem>();
            _list = DiaryHelpers.GetItems().ToList();
            _fPeriode = new XtraPeriode();
            ListForPrint = _list;
            SetData();
        }

        public List<DayItem> ListForPrint { get; set; }

        private void alertItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Indexer(3);
            Text = @"ERREURS COMPTAGE";
        }

        private void comItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Indexer(0);
            Text = @"ENTREES";
        }

        private void dispoItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Indexer(2);
            Text = @"VENTES";
        }

        private DateModel SetDate()
        {
            DateModel date = DateHelpers.Get(_fPeriode.Debut, _fPeriode.Fin, _fPeriode.Showing);
            return date;
        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            CreateHelpers.ImprimerResume(ListForPrint, SetDate());
        }

        private void Indexer(int index)
        {
            Text = @"JOURNAL: TOUS";
            _index = index;
            ListForPrint = DiaryHelpers.GetByGroup(_list, _index).ToList();
            SetData();
        }

        private void SetData()
        {
            gridActions.DataSource = ListForPrint;
            myNum.DataBindings.Clear();
            myNum.DataBindings.Add("Text", ListForPrint, "Id");
        }

        private void inventItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Indexer(5);
            Text = @"REBUTS VOL";
        }

        private void rebComptage_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Indexer(7);
            Text = @"COMPTAGES";
        }

        private void rebDefItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Indexer(4);
            Text = @"REBUTS DEFECTION";
        }

        private void ruptItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Indexer(6);
            Text = @"COMMANDES";
        }

        private void stagItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Indexer(1);
            Text = @"AVOIRS";
        }

        private void gridActions_DoubleClick(object sender, EventArgs e)
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
                _fPeriode.Debut = DateTime.Now;
                _fPeriode.Fin = DateTime.Now;
                détaillerToolStripMenuItem.Text = @"Filtrer";
                Text = @"JOURNAL: TOUS";
                if (_index < 0)
                {
                    ListForPrint = _list;
                    SetData();
                    return;
                }
                {
                    Indexer(_index);
                }
            }
            else
            {
                détaillerToolStripMenuItem.Text = @"Tous";
                _fPeriode.Showing = true;
                _fPeriode.ShowDialog();
            }
        }

        private void ListResume_Activated(object sender, EventArgs e)
        {
            if (!_fPeriode.Showing) return;
            if (!_fPeriode.Norme) return;
            ListForPrint = DiaryHelpers.FilterByDate(_list, _fPeriode.Debut, _fPeriode.Fin).ToList();
            Text = StdCalcul.TitlePeriod(_fPeriode.Debut, _fPeriode.Fin);
            SetData();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}