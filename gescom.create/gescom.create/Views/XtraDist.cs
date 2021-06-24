using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Globalization;

namespace gescom.create.Views
{
    public partial class XtraDist : XtraForm
    {
        private readonly long _id;
        private readonly bool _isRemark;
        private readonly DistItem _item;
        private long _numeroPlace;

        public XtraDist()
        {
            InitializeComponent();
            _item = new DistItem();
        }

        public XtraDist(long id)
        {
            InitializeComponent();
            _item = new DistItem();
            _item = DistHelpers.Get(id);
            Init();
        }

        public XtraDist(long id, bool b)
        {
            InitializeComponent();
            _id = id;
            _isRemark = b;
            _item = new DistItem();
            _item = DistHelpers.Get(id);
            Init();
        }

        public XtraDist(long id, bool b, bool isParticular)
        {
            InitializeComponent();
            _id = id;
            _isRemark = b;
            _item = new DistItem();
            _item = DistHelpers.Get(id);
            Init();
            NoPlacing();
            if (isParticular)
            {
                placement.Enabled = true;
            }
        }

        public void NoPlacing()
        {
            placement.Enabled = false;
        }

        private void Init()
        {
            nombre.Text = StdCalcul.Spacing(_item.Id.ToString(CultureInfo.InvariantCulture));
            ArticleItem article = ArticleHelpers.Get(_item.Id);
            leNom.Text = article.Nom;
            codage.Text = article.Code;
            txtNom.Text = _item.Nom;
            obsEdit.Text = _item.Description;
            remarkEdit.Text = article.Description;
            txtQte.Text = _item.Quantite.ToString();
            if (_item.Numero == null) return;
            var id = (long)_item.Numero;
            _numeroPlace = id;
            PlaceItem place = PlaceHelpers.GetIndex(id);
            labelPlace.Text = place.Nom;
            foreach (string variable in PlaceHelpers.GetListPlaces())
            {
                placement.Items.Add(variable);
            }
            placement.Text = place.Nom;
            Text = @"PLACE-OBSERVATIONS";
            if (!_isRemark) return;
            labelNom.Visible = false;
            txtNom.Visible = false;
            labelSeuil.Visible = false;
            txtQte.Visible = false;
            obsEdit.Visible = false;
            labelObs.Visible = false;
            Text = @"REMARQUE";
            remarkEdit.Focus();
            remarkEdit.SelectAll();
        }

        private void creer_Click(object sender, EventArgs e)
        {
            if (!_isRemark)
            {
                if (string.IsNullOrEmpty(txtNom.Text))
                {
                    ErrorHelpers.ShowError("Le nom ne peut être vide.");
                    txtNom.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtQte.Text))
                {
                    ErrorHelpers.ShowError("Le seuil minimal de vente ne peut être nul.");
                    txtQte.Focus();
                    return;
                }
                _item.Nom = txtNom.Text;
                _item.Quantite = float.Parse(txtQte.Text);
                _item.Description = obsEdit.Text;
            }
            _item.Numero = PlaceHelpers.GetId(newPlace.Text);
            if (_item.Numero == null) return;
            var n = (long)_item.Numero;
            PlaceItem place = PlaceHelpers.Get(n);
            if (place.IsReserved != null)
            {
                var i = (long)place.IsReserved;
                if (i == 1)
                {
                    _item.Numero = _numeroPlace;
                }
            }
            if (DistHelpers.Update(_item))
            {
                // ErrorHelpers.ShowErrorDuplicate();return;
            }
            PlaceHelpers.Fill(n);
            ArticleHelpers.PutDescription(_item.Id, remarkEdit.Text);

            Close();
        }

        private void placement_SelectedValueChanged(object sender, EventArgs e)
        {
            newLabel.Visible = true;
            newPlace.Visible = true;
            newPlace.Text = placement.Text;
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}