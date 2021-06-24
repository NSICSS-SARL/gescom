using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;

namespace gescom.create.Views
{
    public partial class ListPerson : XtraForm
    {
        private readonly int _index;

        public ListPerson()
        {
            InitializeComponent();
            _index = 0;
        }

        public ListPerson(int index)
        {
            InitializeComponent();
            _index = index;
        }

        private void Init()
        {
            switch (_index)
            {
                case 1:
                    Text = @"LISTE DE FOUNISSEURS";
                    var uList = ReparationHelpers.VendorList();
                    colGros.Visible = false;
                    personGrid.DataSource = uList;
                    numero.DataBindings.Clear();
                    numero.DataBindings.Add("Text", uList, "Id");
                    break;

                case 2:
                    Text = @"LISTE DE CLIENTS";
                    var pList = ReparationHelpers.CustomerList();
                    personGrid.DataSource = pList;
                    numero.DataBindings.Clear();
                    numero.DataBindings.Add("Text", pList, "Id");
                    break;

                case 3:
                    Text = @"LISTE DU PERSONNEL";
                    var wList = ReparationHelpers.WorkerList();
                    colGros.FieldName = "Prime";
                    colGros.Caption = @"PRIME";
                    FML.Visible = false;
                    personGrid.DataSource = wList;
                    numero.DataBindings.Clear();
                    numero.DataBindings.Add("Text", wList, "Id");
                    break;
            }
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            CreateHelpers.NewPerson(_index);
        }

        private void personGrid_DoubleClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numero.Text))
            {
                return;
            }
            if (numero.Text == @"0")
            {
                return;
            }
            int id = int.Parse(numero.Text);
            CreateHelpers.DetaillerPerson(_index, id);
        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            if (_index <= 0)
            {
                return;
            }
            CreateHelpers.ImprimerPerson(_index);
        }

        private void détailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numero.Text))
            {
                return;
            }
            if (numero.Text == @"0")
            {
                return;
            }
            int id = int.Parse(numero.Text);
            PersonModel p = PersonHelpers.Get(id);
            if (p == null)
            {
                return;
            }
            if (p.Groupe <= 0)
            {
                CreateHelpers.DetaillerVendorCompte(id, id);
                return;
            }
            if (p.Groupe < 5)
            {
                CreateHelpers.DetaillerCustomerCompte(id, p.Nom);
                return;
            }
            CreateHelpers.DetaillerPrimeCompte(id);
        }

        private void règlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_index < 3) { return; }
            if (string.IsNullOrEmpty(numero.Text))
            {
                return;
            }
            if (numero.Text == @"0")
            {
                return;
            }
            int id = int.Parse(numero.Text);
            float amount = DateHelpers.GetAmountPrime(id);
            PersonModel p = PersonHelpers.Get(id);
            if (p.Groupe < 5) { return; }
            if (amount <= 0) { ErrorHelpers.ShowError("AUCUN BONUS!"); return; }
            CreateHelpers.ReglerBonus(id);
        }

        private void ListPerson_Activated(object sender, EventArgs e)
        {
            Init();
        }
    }
}