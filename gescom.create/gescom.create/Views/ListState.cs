using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.create.Views
{
    public partial class ListState : XtraForm
    {
        private List<OperationItem> _list;
        private string _title;

        public ListState()
        {
            InitializeComponent();
            _title = @"INVENTAIRE GENERALE";
            _list = new List<OperationItem>();
            _list = OperationHelpers.GetList().ToList();
            SetData();
        }

        private void alertItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            _list = OperationHelpers.GetListSeuil().ToList();
            _title = @"ALERTE(SEUIL CRITIQUE)";
            SetData();
        }

        private void comparerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = GetX();
            if (id == 0)
            {
                return;
            }
            // CreateHelpers.DuoRecto(id);
            CreateHelpers.Globalize(id);
        }

        private void créationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateHelpers.NewArticle();
        }

        private void dispoItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            _list = OperationHelpers.GetListDisponible().ToList();
            gridActions.DataSource = _list;
            _title = @"STOCK DISPONIBLE";
            SetData();
        }

        private long GetX()
        {
            if (string.IsNullOrEmpty(myNum.Text))
            {
                return 0;
            }
            if (myNum.Text == @"0")
            {
                return 0;
            }
            var x = long.Parse(myNum.Text);
            return x;
        }

        private void gridActions_DoubleClick(object sender, EventArgs e)
        {
            var text = myNum.Text;
            if (text == null)
            {
                return;
            }
            var id = long.Parse(text);
            if (id == 0)
            {
                return;
            }
            CreateHelpers.Detailler(id);
        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            CreateHelpers.ImprimerStock(_list, _title);
        }

        private void inventItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            _list = OperationHelpers.GetList().ToList();
            _title = @"INVENTAIRE GENERALE";
            SetData();
        }

        private void ruptItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            _list = OperationHelpers.GetListRupt().ToList();
            _title = @"RUPTURE DE STOCK";
            SetData();
        }

        private void SetData()
        {
            gridActions.DataSource = _list;
            myNum.DataBindings.Clear();
            myNum.DataBindings.Add("Text", _list, "Ndx");
        }

        private void stagItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            _list = OperationHelpers.GetListStagne().ToList();
            _title = @"STAGNATION";
            SetData();
        }

        private void comItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            _list = OperationHelpers.GetListCommands().ToList();
            _title = @"COMMANDABLE";
            SetData();
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            CreateHelpers.NewArticle();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}