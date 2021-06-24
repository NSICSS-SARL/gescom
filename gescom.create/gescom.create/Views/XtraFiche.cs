using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.create.Views
{
    public partial class XtraFiche : XtraForm
    {
        private readonly XtraPeriode _fPeriode;
        private bool _created;
        private List<SoldeItem> _list;
        private readonly long _pid;

        public XtraFiche()
        {
            InitializeComponent();
            _fPeriode = new XtraPeriode();
            _list = new List<SoldeItem>();
        }

        public XtraFiche(List<SoldeItem> liste)
        {
            InitializeComponent();
            _fPeriode = new XtraPeriode();
            _list = new List<SoldeItem>();
            _list = liste;
            SetData();
        }

        public XtraFiche(List<SoldeItem> liste, long pid)
        {
            InitializeComponent();
            _fPeriode = new XtraPeriode();
            _list = new List<SoldeItem>();
            _list = liste;
            _pid = pid;
            SetData();
        }

        private void creer_Click(object sender, EventArgs e)
        {
            if (_pid <= 0)
            {
                return;
            }
            CreateHelpers.Ecrire(_pid);
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grillage_DoubleClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(myNum.Text))
            {
                return;
            }
            if (myNum.Text == @"0")
            {
                return;
            }
            int id = int.Parse(myNum.Text);
            if (id <= 0)
            {
                return;
            }
            List<RetailModel> list = RetailHelpers.GetRetail(id).ToList();
            if (list.Count == 0)
            {
                return;
            }
            CreateHelpers.DetaillerOperation(id);
        }

        private void SetData()
        {
            grillage.DataSource = _list;
            myNum.DataBindings.Clear();
            myNum.DataBindings.Add("Text", _list, "Numero");
            PersonModel person = PersonHelpers.Get(_pid);
            if (person == null)
            {
                return;
            }
            Text = person.Nom;
        }

        private void filtrage_Click(object sender, EventArgs e)
        {
            if (_fPeriode.Showing)
            {
                _fPeriode.Showing = false;
                filtrage.Text = @"Filtrer";
                _list = CompteHelpers.GetCompteItems(_pid);
                SetData();
            }
            else
            {
                filtrage.Text = @"Tous";
                _fPeriode.Showing = true;
                _fPeriode.ShowDialog();
                _created = true;
            }
        }

        private void XtraFiche_Activated(object sender, EventArgs e)
        {
            if (!_fPeriode.Showing) return;
            if (!_fPeriode.Norme) return;
            _list = CompteHelpers.FilterSoldeByDate(_list, _fPeriode.Debut, _fPeriode.Fin).ToList();
            SetData();
            Text += @": MOUVEMENT DU " + StdCalcul.TitleSimple(_fPeriode.Debut, _fPeriode.Fin);
        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            if (_list.Count == 0)
            {
                ErrorHelpers.ShowError("IMPRESSION NULLE");
                return;
            }
            CreateHelpers.ImprimerCompte(_created, _list, _pid, _fPeriode.Debut, _fPeriode.Fin);
        }
    }
}