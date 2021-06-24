using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.create.Views
{
    public partial class XtraJournal : XtraForm
    {
        private readonly XtraPeriode _fPeriode;
        private long _id;
        private List<Detail2> _list;
        private string _name;

        public XtraJournal()
        {
            InitializeComponent();
            _fPeriode = new XtraPeriode();
        }

        public XtraJournal(long id)
        {
            InitializeComponent();
            _list = new List<Detail2>();
            _fPeriode = new XtraPeriode();
            Init(id);
        }

        private void détaillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fPeriode.Showing)
            {
                _fPeriode.Showing = false;
                Text = _name;
                détaillerToolStripMenuItem.Text = @"Filtrer";
                _list = ActionHelpers.GetDetails2(_id).ToList();
                SetData();
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
            if (_id <= 0)
            {
                return;
            }
            if (_fPeriode.Norme)
            {
                CreateHelpers.ImprimerFiche(_id, SetDate());
                return;
            }
            CreateHelpers.ImprimerFiche(_id);
        }

        private void Init(long id)
        {
            OperationModel item = OperationHelpers.Get(id);
            _name = item.Designation;
            Text = _name;
            numero.Text = StdCalcul.AfficherPrix(item.Ndx);
            codes.Text = ArticleHelpers.GetNormalizedCode(id);
            refces.Text = item.Refers;
            dtachat.Text = item.DateAchat.ToShortDateString();
            labCa.Text = item.DateAchat.ToShortTimeString();
            dtvente.Text = item.DateVente.ToShortDateString();
            labVt.Text = item.DateVente.ToShortTimeString();
            vendor.Text = item.Frs;
            customer.Text = item.Clt;
            pachat.Text = StdCalcul.AfficherPrix(item.Pachat);
            revient.Text = StdCalcul.AfficherPrix(item.Previent);
            pgros.Text = StdCalcul.AfficherPrix(item.PGros);
            pdetail.Text = StdCalcul.AfficherPrix(item.PDetail);
            qachat.Text = StdCalcul.AfficherPrix(item.Qachat);
            qavoir.Text = StdCalcul.AfficherPrix(item.Qavoir);
            qvente.Text = StdCalcul.AfficherPrix(item.Qvente);
            qstock.Text = StdCalcul.AfficherPrix(item.QStock);
            qrebut.Text = StdCalcul.AfficherPrix(item.Qrebut);
            machat.Text = StdCalcul.AfficherPrix(item.Vachat);
            mstock.Text = StdCalcul.AfficherPrix(item.Vstock);
            mvente.Text = StdCalcul.AfficherPrix(item.Vvente);
            unit.Text = item.Unite;
            _id = id;
            _list = ActionHelpers.GetDetails2(_id).ToList();
            SetData();
        }

        private void SetData()
        {
            grillage.DataSource = _list;
            myNum.DataBindings.Clear();
            myNum.DataBindings.Add("Text", _list, "Rang");
            imprimer.Enabled = false;
            if (_list.Count == 0)
            {
                return;
            }
            imprimer.Enabled = true;
        }

        private DateModel SetDate()
        {
            DateModel date = DateHelpers.Get(_fPeriode.Debut, _fPeriode.Fin, _fPeriode.Showing);
            return date;
        }

        private void XtraJournal_Activated(object sender, EventArgs e)
        {
            if (!_fPeriode.Showing) return;
            if (!_fPeriode.Norme) return;
            _list = ActionHelpers.FilterByDate(_list, _fPeriode.Debut, _fPeriode.Fin).ToList();
            Text = _name + StdCalcul.TitleSimple(_fPeriode.Debut, _fPeriode.Fin);
            SetData();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}