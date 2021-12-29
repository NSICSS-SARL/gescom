using gescom.data.Models;
using System;

namespace gescom.create.Views
{
    public partial class DxDate : DevExpress.XtraEditors.XtraForm
    {
        public DxDate()
        {
            InitializeComponent();
        }

        public DxDate(OperationItem item)
        {
            
            InitializeComponent();
            Text = item.Designation;
            cdf.Text = item.CompleteCode;
            nombre.Text = item.Ndx.ToString();
            DateAchat.DateTime = (DateTime)item.DateAchat;
            DateVente.DateTime = (DateTime)item.DateVente;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}