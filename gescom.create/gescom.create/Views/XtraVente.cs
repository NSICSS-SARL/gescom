using gescom.create.Models;
using gescom.data.Models;
using gescom.printer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace gescom.create.Views
{
    public partial class XtraVente : Form
    {
        private List<ElementModel> _elements;
        private OperationModel _item;
        private OperationElem _oper;
        private List<OperationModel> _myList;
        private PersonModel _person;
        private readonly long _wid;

        private long _index;

        private string _title;

        public XtraVente()
        {
            InitializeComponent();
            Initialiser();
            _index = 0;
        }

        private void Initialiser()
        {
            _person = new PersonModel();
            _myList = new List<OperationModel>();
            _elements = new List<ElementModel>();
            _oper = new OperationElem();
            _item = new OperationModel();
        }

        public XtraVente(PersonModel person, long wid, long id)
        {
            InitializeComponent();
            Initialiser();
            _person = person;
            _index = 2;
            _wid = wid;
        }

        public XtraVente(PersonModel person, long index)
        {
            InitializeComponent();
            Initialiser();
            _person = person;
            _index = index;
        }

        public XtraVente(int index)
        {
            _index = index;
            InitializeComponent();
            Initialiser();
            Init();
        }

        public bool IsValid { get; set; }

        public void Init()
        {
            IsValid = true;
            switch (_index)
            {
                case -3:
                    _title = @"REBUT ERREUR COMPTAGE";
                    break;

                case -4:
                    _title = @"REBUT DEFECTION";
                    break;

                case -5:
                    _title = @"REBUT VOL";
                    break;

                case -6:
                    _title = @"COMMANDE";
                    break;

                case -7:
                    _title = @"COMPTAGE";
                    break;

                case -9:
                    _title = @"DEMANDE DE PRIX";
                    break;
            }

            Text = _title;
        }

        public void SetPerson(PersonModel person)
        {
            _myList = OperationHelpers.GetAvoirs();
            _person = person;
            _title = @"AVOIR";
            Text = _title + _person.Nom;
            _index = -1;
        }

        private void Add()
        {
            string text = txtCode.Text;
            float quantite = float.Parse(txtQte.Text);
            _item = OperationHelpers.GetShortCode(_myList, text);
            var element = new ElementModel(_item.Ndx);
            element.Copy(_item);
            ElementModel newElement = ElementHelpers.Get(_elements, _item.Ndx);
            ElementHelpers.Remove(_elements, _item.Ndx);
            txtNum.DataBindings.Clear();
            gridActions.DataSource = null;
            if (newElement == null)
            {
                element.Id = _item.Ndx;
                element.Quantite = quantite;
                if (_person?.Groupe > 0)
                {
                    if (_item.QStock < quantite)
                    {
                        if ((_index > -6) && (_index != -1))
                        {
                            ErrorHelpers.ShowDepassError(quantite, _item.QStock, element.Quantite, element.Nom);
                            _elements.Add(element);
                            txtQte.Focus();
                            txtQte.SelectAll();
                            return;
                        }
                    }
                }

                _elements.Add(element);
                RefreshData();
                txtCode.Text = "";
                return;
            }

            float newQuantite = newElement.Quantite + quantite;
            if (_person?.Groupe > 0)
            {
                if (_index > -6)
                {
                    if (_item.QStock < newQuantite)
                    {
                        element.Quantite = newElement.Quantite;
                        _elements.Add(element);
                        gridActions.DataSource = _elements;
                        txtQte.Focus();
                        txtQte.SelectAll();
                        ErrorHelpers.ShowDepassError(quantite, _item.QStock, newElement.Quantite, element.Nom);
                        return;
                    }
                }
            }

            element.Quantite = newQuantite;
            _elements.Add(element);
            RefreshData();
            txtCode.Text = "";
        }

        private void Ajouter()
        {
            if (txtQte.Visible)
            {
                float quantite = float.Parse(txtQte.Text);
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

                float dispo = float.Parse(txtStock.Text);
                if (_person?.Groupe > 0)
                {
                    if ((_index > -6) && (_index != -1))
                    {
                        if (quantite > dispo)
                        {
                            ErrorHelpers.ShowDepassError(txtQte.Text, txtStock.Text, null, txtNom.Text);
                            txtQte.Focus();
                            txtQte.SelectAll();
                            return;
                        }
                    }
                }

                Add();
                return;
            }

            if (_elements.Count <= 0) return;
            if (string.IsNullOrEmpty(_title))
            {
                _title = Text;
            }

            DialogResult msg = MessageBox.Show(this, @"ENREGISTRER OPERATION?", _title, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (msg != DialogResult.Yes)
            {
                return;
            }

            _title = null;
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
            txtNom.Visible = false;
            txtPrix.Visible = false;
            txtStock.Visible = false;
            txtQte.Visible = false;
            string text = txtCode.Text;
            _item = OperationHelpers.GetShortCode(_myList, text);
            if (_item.Designation == null)
            {
                return;
            }

            txtUnite.Visible = true;
            txtNom.Visible = true;
            txtPrix.Visible = true;
            txtStock.Visible = true;
            txtQte.Visible = true;
            txtNom.Text = _item.Designation;
            txtUnite.Text = _item.Unite;
            txtPrix.Text = _item.Px.ToString(CultureInfo.InvariantCulture);
            txtStock.Text = _item.QStock.ToString(CultureInfo.InvariantCulture);
        }

        private void RefreshData()
        {
            gridActions.DataSource = _elements;
            txtQte.Text = @"0";
            txtCode.Focus();
            if (_elements.Count <= 0)
            {
                return;
            }
            txtNum.DataBindings.Add("Text", _elements, "Id");
        }

        private void Remove()
        {
            string text = txtNum.Text;
            if (string.IsNullOrEmpty(text))
            {
                return;
            }

            if (text == "0")
            {
                return;
            }

            if (_elements.Count == 0)
            {
                return;
            }

            long id = long.Parse(text);
            DialogResult msg = MessageBox.Show(ElementHelpers.Get(_elements, id).Nom, @"SUPPRIMER OPERATION",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (msg != DialogResult.OK)
            {
                return;
            }

            ElementHelpers.Remove(_elements, id);
            gridActions.DataSource = null;
            txtNum.DataBindings.Clear();
            RefreshData();
        }

        private void Save()
        {
            if (_elements.Count == 0)
            {
                return;
            }

            if ((_index >= -7) && (_index <= -3))
            {
                ActionHelpers.DoActions(_elements, _index);
                Close();
            }

            if (_person == null) return;
            if ((_person.Groupe > 0) && (_index != -9) && (_index != -1))
            {
                List<ElementModel> liste = ElementHelpers.ShowInvalidate(_elements);
                if (liste != null)
                {
                    var c = liste.Count;
                    if (c <= 0) return;
                    foreach (ElementModel model in liste)
                    {
                        {
                            var qstock = ArticleHelpers.GetDisponible(model.Id);
                            ErrorHelpers.ShowDepassError(model.Quantite, qstock, model.Nom);
                        }
                    }

                    return;
                }
            }

            var person = new PersonItem();
            person.Copy(_person);
            if (_index > 0)
            {
                if (_person.Groupe == 0)
                {
                    ActionHelpers.DoBuy(_elements, person);
                    Close();
                }

                if ((_person.Groupe > 0) && (_index == 2))
                {
                    CashModel model = ActionHelpers.DoSell(_elements, person);
                    long id = model.Id;
                    CreateHelpers.CompleteInfoCustomer(model);
                    var elems = ElementHelpers.GetElements(_elements);
                    var liste = ReparationHelpers.GetTicketLines(elems);
                    float total = 0;
                    int count = 0;
                    foreach (var elt in liste)
                    {
                        elt.Prix = PriceHelpers.GetPrixItem(elt.Id);
                        elt.Produit = elt.Prix * elt.Quantite;
                        elt.ProduitText = StdCalcul.DoubleToSpaceFormat(elt.Produit);
                        total += elt.Produit;
                        count++;
                    }

                    _oper.Id = id;
                    _oper.Count = count.ToString();
                    _oper.Montant2 = StdCalcul.DoubleToSpaceFormat(total);
                    _oper.Members = liste;
                    PrintHelpers.PrintNewTicket(_oper);
                    Close();
                }

                if (_index == 6)
                {
                    ActionHelpers.DoCmde(_elements, person);
                    Close();
                }
            }

            if ((_index == -1) && (_person.Groupe == 2))
            {
                ActionHelpers.DoReturn(_elements);
                Close();
            }

            if ((_index != -9) || (_person.Groupe <= 0)) return;
            ActionHelpers.DoSimulate(_elements, person);
            Close();
        }

        private void txtCode_ValueChanged(object sender, EventArgs e)
        {
            OnCodeChange();
        }

        private void XtraVente_Load(object sender, EventArgs e)
        {
            if ((_index <= -3) && (_index >= -7))
            {
                _myList = OperationHelpers.GetModelList().ToList();
                return;
            }

            if ((_index <= -1) && (_index != -9) && (_index != 0)) return;

            if (_wid == 0)
            {
                _myList = _person.Groupe > 0
                    ? OperationHelpers.GetCart(_person).ToList()
                    : OperationHelpers.GetModelList().ToList();
                return;
            }

            _myList = OperationHelpers.GetCart(_person, _wid).ToList();
        }

        private void XtraVente_Shown(object sender, EventArgs e)
        {
        }
    }
}