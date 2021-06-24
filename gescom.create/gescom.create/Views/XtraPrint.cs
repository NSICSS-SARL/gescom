using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;

namespace gescom.create.Views
{
    public partial class XtraPrint : XtraForm
    {
        private readonly long _id;

        public XtraPrint()
        {
            InitializeComponent();
            _id = 0;
        }

        public XtraPrint(long id)
        {
            InitializeComponent();
            _id = id;
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            if (ticket.Checked)
            {
                CashModel model = CashHelpers.GetModel(_id);
                DateHelpers.CreatePrinting(model);
                Close();
            }
            if (!facture.Checked)
            {
                Close();
            }
            if (!ticket.Checked)
            { CreateHelpers.ImprimerFacture(_id); }
            Close();
        }
    }
}