using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System.Collections.Generic;
using System.Linq;

namespace gescom.create.Views
{
    public partial class XtraDispatch : XtraForm
    {
        private List<FormelModel> _list;
        private readonly int _index;
        private readonly XtraPeriode _fPeriode;

        public XtraDispatch()
        {
            InitializeComponent();
            _index = -1;
            SetTitle();
            _fPeriode = new XtraPeriode(1);
            _list = new List<FormelModel>();
            _list = FormelHelpers.GetFormalisme().ToList();
            SetData();
        }

        public XtraDispatch(IEnumerable<FormelModel> liste)
        {
            InitializeComponent();
            _index = 0;
            SetTitle();
            _fPeriode = new XtraPeriode(1);
            _list = new List<FormelModel>();
            _list = liste.ToList();
            SetData();
            cocol.FieldName = "Collecte";
            cocol.SummaryItem.FieldName = "Collecte";
            cocol.Caption = @"TVA COLLECTEE";
        }

        private void SetData()
        {
            grillage.DataSource = _list;
            myNum.DataBindings.Clear();
            myNum.DataBindings.Add("Text", _list, "Id");
        }

        private void SetTitle()
        {
            Text = _index >= 0 ? @"REPARTITION TAXE" : @"VENTILATION CA";
        }

        private void fermer_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void grillage_DoubleClick(object sender, System.EventArgs e)
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

        private void détaillerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_fPeriode.Showing)
            {
                _fPeriode.Showing = false;
                _list = _index < 0 ? FormelHelpers.GetFormalisme().ToList() : FormelHelpers.GetOutFormels().ToList();
                détaillerToolStripMenuItem.Text = @"Filtrer";
                SetTitle();
                SetData();
            }
            else
            {
                détaillerToolStripMenuItem.Text = @"Tous";
                _fPeriode.Showing = true;
                _fPeriode.ShowDialog();
            }
        }

        private void XtraDispatch_Activated(object sender, System.EventArgs e)
        {
            imprimer.Enabled = false;
            if (!_fPeriode.Showing) return;
            if (!_fPeriode.Norme) return;
            _list = FormelHelpers.FilterDeclare(_list, _fPeriode.Debut, _fPeriode.Fin).ToList();
            imprimer.Enabled = true;
            SetTitle();
            Text += @" DU " + StdCalcul.TitleSimple(_fPeriode.Debut, _fPeriode.Fin);
            SetData();
        }
    }
}