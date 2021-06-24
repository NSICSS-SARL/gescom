using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.create.Views
{
    public partial class XtraCompte : XtraForm
    {
        private readonly XtraPeriode _fPeriode;
        private readonly long _id;
        private List<InvoiceModel> _list;

        public XtraCompte()
        {
            InitializeComponent();
            _list = new List<InvoiceModel>();
            _fPeriode = new XtraPeriode();
        }

        public XtraCompte(long id, string text)
        {
            InitializeComponent();
            _list = new List<InvoiceModel>();
            _fPeriode = new XtraPeriode();
            _id = id;
            _list = CashHelpers.GetInvoices(_id);
            SetData();
            Count = _list.Count;
            Init(text);
        }

        public XtraCompte(long id, long pid)
        {
            InitializeComponent();
            _list = new List<InvoiceModel>();
            _fPeriode = new XtraPeriode();
            _id = id;
            _list = CashHelpers.GetBills(_id);
            SetData();
            Count = _list.Count;
            Init(pid);
        }

        public int Count { get; set; }

        private DateModel SetDate()
        {
            DateModel date = DateHelpers.Get(_fPeriode.Debut, _fPeriode.Fin, _fPeriode.Showing);
            return date;
        }

        private void SetData()
        {
            grillage.DataSource = _list;
            myNum.DataBindings.Clear();
            myNum.DataBindings.Add("Text", _list, "Id");
            imprimer.Enabled = false;
            if (_list.Count == 0)
            {
                return;
            }
            imprimer.Enabled = true;
        }

        private void Init(long pid)
        {
            PersonModel p = PersonHelpers.Get(pid);
            Text = p.Nom;
        }

        private void Init(string title)
        {
            Text = title;
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
            CreateHelpers.ImprimerDebiteurs(_list, SetDate());
        }

        private void détaillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fPeriode.Showing)
            {
                _fPeriode.Showing = false;
                détaillerToolStripMenuItem.Text = @"Filtrer";
                Text = @"COMPTE";
                _list = CashHelpers.GetInvoices(_id);
                SetData();
            }
            else
            {
                détaillerToolStripMenuItem.Text = @"Tous";
                _fPeriode.Showing = true;
                _fPeriode.ShowDialog();
            }
        }

        private void XtraCompte_Activated(object sender, EventArgs e)
        {
            if (!_fPeriode.Showing) return;
            if (!_fPeriode.Norme) return;
            _list = CashHelpers.FilterByDate(_list, _fPeriode.Debut, _fPeriode.Fin).ToList();
            Text = @"DETAILS DU " + StdCalcul.TitleSimple(_fPeriode.Debut, _fPeriode.Fin);
            SetData();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}