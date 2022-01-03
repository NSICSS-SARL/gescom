using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;

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
            var text = myNum.Text;
            if (text == null) return;
            var id = long.Parse(text);
            if (id == 0) return;
            CreateHelpers.DetaillerOperation(id);
        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            if (_id <= 0) return;
            if (_fPeriode.Norme)
            {
                CreateHelpers.ImprimerFiche(_id, SetDate());
                return;
            }

            CreateHelpers.ImprimerFiche(_id);
        }

        private void Init(long id)
        {
            var item = OperationHelpers.Get(id);
            _name = item.Designation;
            Text = _name;
            numero.Text = StdCalcul.AfficherPrix(item.Ndx);
            codes.Text = ArticleHelpers.GetNormalizedCode(id);
            refces.Text = item.Refers;
            var x = (DateTime)item.DateAchat;
            dtachat.Text = x.ToShortDateString();
            labCa.Text = x.ToShortDateString();
            x = (DateTime)item.DateVente;
            dtvente.Text = x.ToShortDateString();
            labVt.Text = x.ToShortTimeString();
            vendor.Text = item.Frs;
            customer.Text = item.Clt;
            pachat.Text = StdCalcul.AfficherPrix((float)item.Pachat);
            revient.Text = StdCalcul.AfficherPrix((float)item.Previent);
            pgros.Text = StdCalcul.AfficherPrix((float)item.PGros);
            pdetail.Text = StdCalcul.AfficherPrix((float)item.PDetail);
            qachat.Text = StdCalcul.AfficherPrix((float)item.Qachat);
            qavoir.Text = StdCalcul.AfficherPrix((float)item.Qavoir);
            qvente.Text = StdCalcul.AfficherPrix((float)item.Qvente);
            qstock.Text = StdCalcul.AfficherPrix((float)item.QStock);
            qrebut.Text = StdCalcul.AfficherPrix((float)item.Qrebut);
            machat.Text = StdCalcul.AfficherPrix((float)item.Vachat);
            mstock.Text = StdCalcul.AfficherPrix((float)item.Vstock);
            mvente.Text = StdCalcul.AfficherPrix((float)item.Vvente);
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
            if (_list.Count == 0) return;
            imprimer.Enabled = true;
        }

        private DateModel SetDate()
        {
            var date = DateHelpers.Get(_fPeriode.Debut, _fPeriode.Fin, _fPeriode.Showing);
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