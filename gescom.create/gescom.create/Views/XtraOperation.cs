using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using gescom.create.Models;
using gescom.data.Models;

namespace gescom.create.Views
{
    public partial class XtraOperation : XtraForm
    {
        private readonly List<int> _modifiedRows;
        private List<OperationCommande> _list;

        public XtraOperation()
        {
            InitializeComponent();
            _list = new List<OperationCommande>();
            _modifiedRows = new List<int>();
        }

        private void SetRefresh()
        {
            var text = myNum.Text;
            if (text == null) return;
            var id = long.Parse(text);
            if (id <= 0) return;
            CreateHelpers.Detailler(id);
        }

        private void gridActions_DoubleClick(object sender, EventArgs e)
        {
            SetRefresh();
        }

        private long GetX()
        {
            if (string.IsNullOrEmpty(myNum.Text)) return 0;
            if (myNum.Text == @"0") return 0;
            var x = long.Parse(myNum.Text);
            return x;
        }

        public List<ElementModel> SetInit()
        {
            var actualListe = OperationHelpers.CommandAuto().ToList();
            if (actualListe.Count > 0)
            {
                var msg = MessageBox.Show(this, @"Envoyer les commandes automatiques?", @"COMMANDE",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (msg != DialogResult.Yes) return null;
            }

            var elements = ActionHelpers.GetElements(actualListe);
            ProdHelpers.SetManual(actualListe);
            return elements;
        }

        private void créationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateHelpers.NewArticle();
        }

        private void comparerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = GetX();
            if (id == 0) return;
            CreateHelpers.Globalize(id);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var auto = SetInit();
            var actualListe = _modifiedRows.Select(i => grilleView.GetRowCellValue(i, "Ndx"))
                .Select(value => (long) value).ToList();
            var liste = OperationHelpers.GetQuantified(actualListe);
            var msg = MessageBox.Show(this, @"Enregistrer les modifications?", @"SUPPRESSION",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (msg != DialogResult.Yes) return;
            var elements = ActionHelpers.GetElements(liste);
            if (auto != null) elements.AddRange(auto);
            OperationHelpers.SaveCommandes(elements);
            _modifiedRows.Clear();
        }

        private void XtraOperation_Activated(object sender, EventArgs e)
        {
            _list = OperationHelpers.GetList2().ToList();
            gridActions.DataSource = _list;
            myNum.DataBindings.Clear();
            myNum.DataBindings.Add("Text", _list, "Ndx");
        }

        private void grilleView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!_modifiedRows.Contains(e.RowHandle))
                _modifiedRows.Add(e.RowHandle);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}