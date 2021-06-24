using DevExpress.XtraEditors;
using gescom.data.Models;
using System;
using System.Globalization;

namespace gescom.create.Views
{
    public partial class XtraFusion : XtraForm
    {
        private readonly long _id;
        private readonly DistItem _item;
        private ActeModel _acte;
        private DuoItem _duo;
        private long _numeroPlace;
        private long _p = 0;
        private long? _t;

        //
        private long _v = 0;

        //
        private VoirItem _voir;

        private long _x;
        private long _y;
        private long _z;

        public XtraFusion()
        {
            InitializeComponent();
            _item = new DistItem();
            _duo = new DuoItem();
            _t = null;
        }

        public XtraFusion(long id)
        {
            InitializeComponent();
            _item = DistHelpers.Get(id);
            _acte = new ActeModel(ActeHelpers.Get(id));
            _voir = VoirHelpers.Get(id);
            var operation = OperationHelpers.Get(id);
            cumDispo.Text = operation.QStock.ToString("#,#");
            _id = id;
            Init();
        }

        private void ActeSave()
        {
            if ((!checkVerif.Checked) && (_v < 0))
            {
                _acte.Verif = 1;
                _voir.VoirVerif = false;
            }
            if ((!checkPlace.Checked) && (_p < 0))
            {
                _acte.Placer = 1;
                _voir.VoirPlace = false;
            }
            ActeHelpers.Update(_acte);
            VoirHelpers.Update(new VoirModel(_voir));
        }

        private void creer_Click(object sender, EventArgs e)
        {
            float quantite = 0;
            if (!checkEntre.Checked && _x == -1)
            {
                _x = 1;
                _voir.VoirEntre = false;
                _acte.Entrer = 1;
            }
            if (!checkPrix.Checked && _y == -1)
            {
                _y = 1;
                _voir.VoirPrix = false;
                _acte.Priter = 1;
            }
            if (!checkPrior.Checked && _z == -1)
            {
                _voir.VoirPrior = false;
                _z = 1;
            }
            if (_t == 1)
            {
                if (!radioMoyen.Checked)
                {
                    _t = null;
                }
            }
            else
            {
                _t = null;
            }

            if (!string.IsNullOrEmpty(q1.Text))
            {
                quantite = float.Parse(q1.Text);
            }
            var message = s1.Text;
            ArticleHelpers.UpdateFusion(_id, "tache", message, b1.Text, b2.Text, _x, _y, quantite, _z, _t);
            _item.Numero = PlaceHelpers.GetId(distNewPlace.Text);
            if (_item.Numero == null) return;
            var n = (long)_item.Numero;
            var place = PlaceHelpers.Get(n);
            if (place.IsReserved != null)
            {
                var i = (long)place.IsReserved;
                if (i == 1)
                {
                    _item.Numero = _numeroPlace;
                }
            }
            ActeSave();
            if (DistHelpers.Update(_item))
            {
                // ErrorHelpers.ShowErrorDuplicate();return;
            }
            PlaceHelpers.Fill(n);
            Close();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Init()
        {
            var item = ProdHelpers.Get(_id);
            leNom.Text = ArticleHelpers.GetName(_id);
            nombre.Text = StdCalcul.Spacing(_id.ToString(CultureInfo.InvariantCulture));
            _duo = ArticleHelpers.GetDuo(_id);
            d1.Text = _duo.D1.ToString("f");
            d2.Text = _duo.D2.ToString("f");
            b1.Text = _duo.B1;
            b2.Text = _duo.B2;
            _x = 0;
            _y = 0;
            _z = 0;
            if (_duo.L == 1)
            {
                _t = 1;
                radioMoyen.Checked = true;
            }
            if (_voir.VoirEntre)
            {
                checkEntre.Checked = true;
                _acte.Entrer = -1;
                _x = -1;
            }
            if (_voir.VoirPrix)
            {
                checkPrix.Checked = true;
                _acte.Priter = -1;
                _y = -1;
            }
            if (_voir.VoirPrior)
            {
                checkPrior.Checked = true;
                _z = -1;
            }
            if (_voir.VoirPlace)
            {
                _p = -1;
                checkPlace.Checked = true;
            }
            if (_voir.VoirVerif)
            {
                _v = -1;
                checkVerif.Checked = true;
            }
            s.Text = _duo.S2;
            q.Text = StdCalcul.DoubleToSpaceFormat(_duo.Q2);
            s1.Text = _duo.S1;
            q1.Value = StdCalcul.DoubleToDecimal(_duo.Q1);

            s.Text = _duo.S1;
            q.Text = StdCalcul.DoubleToSpaceFormat(_duo.Q1);
            s1.Text = _duo.S2;
            q1.Value = StdCalcul.DoubleToDecimal(_duo.Q2);
            //
            nombre.Text = StdCalcul.Spacing(_item.Id.ToString(CultureInfo.InvariantCulture));
            var article = ArticleHelpers.Get(_item.Id);
            leNom.Text = article.Nom;
            int n = article.Code.Length;
            var fcode = article.Code.Substring(n - 1, 1) + article.Code.Substring(0, n - 1);
            codage.Text = fcode;
            if (_item.Numero == null) return;
            var id = (long)_item.Numero;
            _numeroPlace = id;
            var place = PlaceHelpers.GetIndex(id);
            labelPlace.Text = place.Code;
            foreach (var variable in PlaceHelpers.GetList())
            {
                placement.Items.Add(variable);
            }
            placement.Text = place.Code;
            distNewPlace.Text = place.Code;
            secondPlace.Text = place.Nom;
        }

        private void placement_SelectedValueChanged(object sender, EventArgs e)
        {
            newLabel.Visible = true;
            distNewPlace.Visible = true;
            distNewPlace.Text = placement.Text;
        }
    }
}