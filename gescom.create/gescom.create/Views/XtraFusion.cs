using System;
using System.Globalization;
using DevExpress.XtraEditors;
using gescom.data.Models;

namespace gescom.create.Views
{
    public partial class XtraFusion : XtraForm
    {
        private readonly long _id;
        private readonly DistItem _item;
        private GulpItem _gulp;

        private readonly ActeModel _acte;
        private DuoItem _duo;
        private long _numeroPlace;

        private long _p;
        //private long? _t;

        //
        private long _v;

        //
        private readonly VoirItem _voir;

        private long _x;
        private long _y;
        private long _z;

        public XtraFusion()
        {
            InitializeComponent();
            _item = new DistItem();
            _duo = new DuoItem();
            _gulp = new GulpItem();
        }

        public XtraFusion(long id)
        {
            InitializeComponent();
            _item = DistHelpers.Get(id);
            _acte = new ActeModel(ActeHelpers.Get(id));
            _voir = VoirHelpers.Get(id);
            _gulp = GulpHelpers.Get(id);
            var operation = OperationHelpers.Get(id);
            unitCtrl.Text = operation.Unite;
            cumDispo.Text = operation.QStock.ToString();
            _id = id;
            Init();
        }

        private void ActeSave()
        {
            if (!checkVerif.Checked && _v < 0)
            {
                _acte.Verif = 1;
                _voir.VoirVerif = false;
            }

            if (!checkPlace.Checked && _p < 0)
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
            if (!C5.Checked && _x == -1)
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
            var arrivage = 0;
            if (!string.IsNullOrEmpty(Q6.Text)) arrivage= int.Parse(Q6.Text);
            if (!string.IsNullOrEmpty(H6.Text)) quantite = int.Parse(H6.Text);
            var message = s1.Text;
            ArticleHelpers.UpdateFusion(_id, "tache", message, b1.Text, b2.Text, _x, _y, quantite,arrivage, _z);
            var a = 0;
            bool res;
            if (C4.Checked)
            {
                _gulp.D6 = DateTime.Now;
                if (H4.Text.Length > 0)
                {
                    res = int.TryParse(H4.Text, out a);
                    if (!res)
                    {
                        a = 0;
                    }
                }
                else
                {
                    a = 0;
                }
                _gulp.H4 = a;
            }
            if (C5.Checked)
            {
               _gulp.D7 = DateTime.Now;
                if (H6.Text.Length > 0)
                {
                    res = int.TryParse(H6.Text, out a);
                    if (!res)
                    {
                        a = 0;
                    }
                }
                else
                {
                    a = 0;
                }
                _gulp.H6 = a;
                if (a > 0)
                {
                    _gulp.C5 = false;
                }
            }             
            var model = new GulpModel()
            {
                Id = _id
            };
            model.Copy(_gulp);
            if (!string.IsNullOrEmpty(Q4.Text)) arrivage = int.Parse(Q4.Text);
            if (!string.IsNullOrEmpty(H4.Text)) quantite = int.Parse(H4.Text);           
            if (arrivage >= quantite)
            {               
                if(arrivage == quantite)
                {
                    //model.C4=false;
                    
                } 
            }
            GulpHelpers.Update(model);
            _item.Numero = PlaceHelpers.GetId(distNewPlace.Text);
            if (_item.Numero == null) return;
            var n = (long) _item.Numero;
            var place = PlaceHelpers.Get(n);
            if (place.IsReserved != null)
            {
                var i = (long) place.IsReserved;
                if (i == 1) _item.Numero = _numeroPlace;
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
            Q4.Text = _gulp.Q4.ToString("####");
            Q6.Text = _gulp.Q6.ToString("####");
            H4N.Text=_gulp.H4.ToString("####");
            H6N.Text = _gulp.H6.ToString("####");
            C4.Checked = _gulp.C4;
            C5.Checked = _gulp.C5;
            if (_voir.VoirEntre)
            {
               
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
          
            s1.Text = _duo.S1;
         
            s.Text = _duo.S1;
        
            s1.Text = _duo.S2;
          
            //
            nombre.Text = StdCalcul.Spacing(_item.Id.ToString(CultureInfo.InvariantCulture));
            var article = ArticleHelpers.Get(_item.Id);
            leNom.Text = article.Nom;
            var n = article.Code.Length;
            var fcode = article.Code.Substring(n - 1, 1) + article.Code.Substring(0, n - 1);
            codage.Text = fcode;
            if (_item.Numero == null) return;
            var id = (long) _item.Numero;
            _numeroPlace = id;
            var place = PlaceHelpers.GetIndex(id);
            labelPlace.Text = place.Code;
            foreach (var variable in PlaceHelpers.GetList()) placement.Items.Add(variable);
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