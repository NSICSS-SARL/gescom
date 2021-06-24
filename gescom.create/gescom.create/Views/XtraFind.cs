using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.create.Views
{
    public partial class XtraFind : XtraForm
    {
        private readonly long _index;
        private bool _isAdmin;

        public XtraFind()
        {
            InitializeComponent();
            SetRefresh();
        }

        public XtraFind(long index)
        {
            InitializeComponent();
            _index = index;
            IEnumerable<OperationItem> list = OperationHelpers.GetListActif().ToList();
            gridActions.DataSource = list;
            myNum.DataBindings.Add("Text", list, "Ndx");
        }

        public void SetPublic()
        {
            myNum.Visible = false;
            nouveau.Visible = false;
        }

        public void SetParticular()
        {
            remarqueToolStripMenuItem.Enabled = false;
            _isAdmin = false;
            clicDroit.Enabled = false;
            nouveau.Visible = false;
        }

        public void SetProtect()
        {
            _isAdmin = true;
            nouveau.Enabled = true;
            remarqueToolStripMenuItem.Enabled = true;
            clicDroit.Enabled = true;
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
            long x = long.Parse(myNum.Text);
            return x;
        }

        private void gridActions_DoubleClick(object sender, EventArgs e)
        {
            if (_isAdmin)
            {
                CreateHelpers.Detailler(GetX());
                return;
            }
            if (_index != 0) return;
            CreateHelpers.Remarquer(GetX(), false);
        }

        private void Remark()
        {
            CreateHelpers.Remarquer(GetX(), true);
        }

        private void remarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remark();
        }

        private void SetRefresh()
        {
            IEnumerable<OperationItem> list = OperationHelpers.GetListActif().ToList();
            gridActions.DataSource = list;
            myNum.DataBindings.Clear();
            myNum.DataBindings.Add("Text", list, "Ndx");
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