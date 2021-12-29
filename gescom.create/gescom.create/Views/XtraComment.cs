using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.create.Views
{
    public partial class XtraComment : XtraForm
    {
        private List<OperationItem> _list;

        public XtraComment()
        {
            InitializeComponent();
            _list = new List<OperationItem>();
            //ArticleHelpers.RepairDuoFaster();
        }

        private void SetData()
        {
            _list = OperationHelpers.GetAdminList();
            gridActions.DataSource = _list;
            myNum.DataBindings.Clear();
            myNum.DataBindings.Add("Text", _list, "Ndx");
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

        private void créationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateHelpers.NewArticle();
        }

        private void comparerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long id = GetX();
            if (id == 0)
            {
                return;
            }
            CreateHelpers.Globalize(id);
        }

        private void daterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long id = GetX();
            if (id == 0)
            {
                return;
            }
            var item = _list.FirstOrDefault(m => m.Ndx == id);
            CreateHelpers.SeeDate(item);
        }

        private void XtraComment_Activated(object sender, EventArgs e)
        {
            SetData();
        }

        private void gridActions_DoubleClick(object sender, EventArgs e)
        {
            CreateHelpers.Detailler(GetX());
        }

        private void XtraComment_Load(object sender, EventArgs e)
        {
            //SetData();
        }
    }
}