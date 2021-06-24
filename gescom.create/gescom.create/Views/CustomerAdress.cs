//using DevExpress.XtraReports.UI;
using gescom.data.Models;
using System;
using System.Windows.Forms;

//using gescom.report.Reports;

namespace gescom.create.Views
{
    public partial class CustomerAdress : Form
    {
        private readonly CashModel _model;

        public CustomerAdress()
        {
            _model = new CashModel();
            InitializeComponent();
        }

        public CustomerAdress(CashModel model)
        {
            _model = new CashModel();
            InitializeComponent();
            _model = model;
            Init();
        }

        private void creer_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Init()
        {
            textNom.Text = _model.Nom;
            textAdress.Text = _model.Adresse;
            textNom.Focus();
        }

        private void Save()
        {
            InvoiceItem retail = CashHelpers.Get(_model.Id);
            string nom = string.IsNullOrEmpty(textNom.Text) ? retail.Nom : textNom.Text;
            string adresse = string.IsNullOrEmpty(textAdress.Text) ? retail.Adresse : textAdress.Text;
            CashHelpers.UpdateInfo(_model.Id, nom, adresse);
            Close();
        }
    }
}