using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;

namespace gescom.create.Views
{
    public partial class XtraOrder : XtraForm
    {
        public XtraOrder()
        {
            InitializeComponent();
            SetRefresh();
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

        private void SetRefresh()
        {
            var list = OperationHelpers.GetMagList();
            gridActions.DataSource = list;
            myNum.DataBindings.Clear();
            myNum.DataBindings.Add("Text", list, "Ndx");
        }

        private void XtraOrder_Activated(object sender, EventArgs e)
        {
            SetRefresh();
        }

        private void modifStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = GetX();
            if (id == 0)
            {
                return;
            }
            CreateHelpers.Fusion(id);
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
            CreateHelpers.DetaillerEntree(id);
        }

        private void XtraOrder_Load(object sender, EventArgs e)
        {
            //SetRefresh();
        }
    }
}