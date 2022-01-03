using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;

namespace gescom.create.Views
{
    public partial class XtraEntree : XtraForm
    {
        private readonly PersonModel _person;
        private List<ElementModel> _elements;
        private long _index;
        private List<OperationModel> _myList;
        private long _pid;

        public XtraEntree(PersonModel person)
        {
            InitializeComponent();
            _pid = person.Id;
            _person = new PersonModel();
            _person = person;
            Init();
            _index = 1;
        }

        public XtraEntree()
        {
            InitializeComponent();
        }

        public bool IsValid { get; set; }

        public void SetEntre()
        {
            IsValid = true;
            Text = @"ENTREE";
            _index = 1;
            _myList = new List<OperationModel>();
            _elements = new List<ElementModel>();
            _myList = OperationHelpers.GetEntryList().ToList();
        }

        private void Init()
        {
            IsValid = true;
            Text = @"ENTREE";
            _index = 0;
            _myList = new List<OperationModel>();
            _elements = new List<ElementModel>();
            _myList = OperationHelpers.GetModelList2(_person).ToList();
        }

        private void Add()
        {
            var text = txtCode.Text;
            var quantite = float.Parse(txtQte.Text);
            var item = OperationHelpers.GetShortCode(_myList, text);
            var element = new ElementModel(item.Ndx);
            element.Copy(item);
            element.Pid = (long)item.Pid;
            var newElement = ElementHelpers.Get(_elements, item.Ndx);
            ElementHelpers.Remove(_elements, item.Ndx);
            txtNum.DataBindings.Clear();
            gridActions.DataSource = null;
            if (newElement == null)
            {
                element.Id = item.Ndx;
                //element.Pid = _pid;
                element.Quantite = quantite;
                _elements.Add(element);
                RefreshData();
                txtCode.Text = "";
                return;
            }

            var newQuantite = newElement.Quantite + quantite;
            element.Quantite = newQuantite;
            _elements.Add(element);
            RefreshData();
            txtCode.Text = "";
        }

        private void Ajouter()
        {
            if (txtQte.Visible)
            {
                var quantite = float.Parse(txtQte.Text);
                if (quantite <= 0)
                {
                    if (txtQte.Focused)
                    {
                        ErrorHelpers.ShowError("VALEUR HORS LIMITE");
                        txtQte.SelectAll();
                    }
                    else
                    {
                        txtQte.Focus();
                    }

                    return;
                }

                Add();
                return;
            }

            if (_elements.Count <= 0) return;

            var msg = MessageBox.Show(this, @"ENREGISTRER OPERATION?", @"ENTREE", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (msg != DialogResult.Yes) return;
            Save();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void creer_Click(object sender, EventArgs e)
        {
            Ajouter();
        }

        private void OnCodeChange()
        {
            txtUnite.Visible = false;
            Q4.Visible = false;
            Q6.Visible = false;
            H4.Visible = false;
            H6.Visible = false;
            txtNom.Visible = false;
            txtPrix.Visible = false;
            txtStock.Visible = false;
            txtQte.Visible = false;
            var text = txtCode.Text;
            var item = OperationHelpers.GetShortCode(_myList, text);
            if (item.Designation == null) return;
            Q4.Visible = true;
            Q6.Visible = true;
            H4.Visible = true;
            H6.Visible = true;
            txtUnite.Visible = true;
            txtNom.Visible = true;
            txtPrix.Visible = true;
            txtStock.Visible = true;
            txtQte.Visible = true;
            txtNom.Text = item.Designation;
            txtUnite.Text = item.Unite;
            Q4.Text = item.Q4.ToString();
            Q6.Text = item.Q6.ToString();
            H4.Text = item.H4.ToString();
            H6.Text = item.H6.ToString();
            txtPrix.Text = item.Px.ToString(CultureInfo.InvariantCulture);
            txtStock.Text = item.QStock.ToString();
            //txtQte.Focus();
        }

        private void RefreshData()
        {
            gridActions.DataSource = _elements;
            txtQte.Text = @"0";
            txtCode.Focus();
            if (_elements.Count <= 0) return;
            txtNum.DataBindings.Add("Text", _elements, "Id");
        }

        private void Remove()
        {
            var text = txtNum.Text;
            if (string.IsNullOrEmpty(text)) return;
            if (text == "0") return;
            if (_elements.Count == 0) return;
            var id = long.Parse(text);
            var msg = MessageBox.Show(ElementHelpers.Get(_elements, id).Nom, @"SUPPRIMER ARTICLE?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (msg != DialogResult.OK) return;
            ElementHelpers.Remove(_elements, id);
            gridActions.DataSource = null;
            txtNum.DataBindings.Clear();
            RefreshData();
        }

        private void Save()
        {
            if (_elements.Count == 0) return;

            if (_index > 0)
            {
                foreach (var elementModel in _elements) ActionHelpers.DoBuy2(elementModel);
                Close();
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            OnCodeChange();
        }
    }
}