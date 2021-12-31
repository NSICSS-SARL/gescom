using System;
using DevExpress.XtraEditors;
using gescom.data.Models;

namespace gescom.create.Views
{
    public partial class DxDate : XtraForm
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
            achatCtrl.Text = item.Qvente.ToString();
            venteCtrl.Text = item.Qachat.ToString();
            stockCtrl.Text = item.QStock.ToString();
            DateAchat.DateTime = (DateTime) item.DateAchat;
            DateVente.DateTime = (DateTime) item.DateVente;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}