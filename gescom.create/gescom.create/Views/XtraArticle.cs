using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.create.Properties;
using gescom.data.Models;
using System;
using System.Drawing;
using System.Globalization;

namespace gescom.create.Views
{
    public partial class XtraArticle : XtraForm
    {
        private readonly ArticleRepository _articleRepository;
        private readonly TarifModel _model;
        private ArticleItem _item;

        public XtraArticle()
        {
            InitializeComponent();
            _articleRepository = new ArticleRepository();
            _model = new TarifModel();
            _item = new ArticleItem();
            Init();
        }

        public XtraArticle(long id)
        {
            InitializeComponent();
            _articleRepository = new ArticleRepository();
            _model = new TarifModel();
            _item = new ArticleItem();
            Init(id);
        }

        public long Id { get; set; }

        public bool IsValid { get; set; }

        public void VerifierAvantCreation()
        {
            creer.Enabled = false;
            double taux = PriceHelpers.GetTaxe() / 100;
            if (string.IsNullOrEmpty(nom.Text) || string.IsNullOrEmpty(refce.Text) || string.IsNullOrEmpty(prix.Text))
            {
                return;
            }
            pdetail.PositiveColor = Color.Black;
            if (coeff.Value <= 0)
            {
                return;
            }
            double prAch = double.Parse(prix.Text);
            double rate = StdCalcul.DecimalToDouble(coeff.Value);
            double prRevient = StdCalcul.GetPrixComplete(prAch, rate);
            prRevient = StdCalcul.GetSimpleLisse(prRevient);
            revient.Text = StdCalcul.AfficherPrix(prRevient);
            if (prRevient <= 0)
            {
                return;
            }
            rate = StdCalcul.DecimalToDouble(mgros.Value);
            double prGros = StdCalcul.GetPrixComplete(prRevient, rate);
            if (mgros.Value == 0)
            {
                prGros = StdCalcul.GetPrixLisse(prGros) + 100;
            }
            if (taxable.Checked)
            {
                prGros = (1 + taux) * prGros;
            }
            prGros = StdCalcul.GetPrixLisse(prGros);
            pgros.Text = StdCalcul.AfficherPrix(prGros);
            rate = StdCalcul.DecimalToDouble(mdetail.Value);
            double prDetail = StdCalcul.GetPrixComplete(prRevient, rate);
            if (mdetail.Value == 0)
            {
                prDetail = StdCalcul.GetPrixLisse(prDetail) + 100;
            }
            if (taxable.Checked)
            {
                prDetail = (1 + taux) * prDetail;
            }
            prDetail = StdCalcul.GetPrixLisse(prDetail);
            pdetail.Text = StdCalcul.AfficherPrix(prDetail);
            if (prGros > prDetail)
            {
                pdetail.PositiveColor = Color.Crimson;
                return;
            }
            rate = StdCalcul.DecimalToDouble(mSpecial.Value);
            double prSpec = StdCalcul.GetPrixComplete(prRevient, rate);
            if (mSpecial.Value == 0)
            {
                prSpec = StdCalcul.GetPrixLisse(prSpec) + 100;
            }
            if (taxable.Checked)
            {
                prSpec = (1 + taux) * prSpec;
            }
            prSpec = StdCalcul.GetPrixLisse(prSpec);
            pspecial.Text = StdCalcul.AfficherPrix(prSpec);
            rate = StdCalcul.DecimalToDouble(mExtra.Value);
            double prExtra = StdCalcul.GetPrixComplete(prRevient, rate);
            if (mExtra.Value == 0)
            {
                prExtra = StdCalcul.GetPrixLisse(prExtra) + 100;
            }
            if (taxable.Checked)
            {
                prExtra = (1 + taux) * prExtra;
            }
            prExtra = StdCalcul.GetPrixLisse(prExtra);
            pextra.Text = StdCalcul.AfficherPrix(prExtra);
            double prime = prDetail - prRevient;
            double myprime = 0;
            if (prime > 0)
            {
                float primerate = StdCalcul.DecimalToFloat(txPrime.Value) / 100;
                myprime = primerate * prime;
                myprime = StdCalcul.GetPrixLisse(myprime);
            }
            vprime.Text = StdCalcul.AfficherPrix(myprime);
            creer.Enabled = true;
        }

        internal void Clear()
        {
            nom.Text = "";
            plancher.Text = @"0";
            catalogue.Text = "";
            prix.Text = @"0";
            refce.Text = "";
            taxable.Checked = false;
            family.SelectedIndex = 0;
            unity.SelectedIndex = 0;
            revient.Text = "0";
            pgros.Text = "0";
            pspecial.Text = "0";
            pdetail.Text = "0";
            pextra.Text = "0";
            mgros.Value = 0;
            coeff.Value = 0;
            mdetail.Value = 0;
            mgros.Value = 0;
            mSpecial.Value = 0;
            mExtra.Value = 0;
            creer.Enabled = false;
            nom.Focus();
        }

        protected void CheckChange()
        {
            if (!taxable.Checked) return;
            if (!formel.Checked)
            {
                formel.Checked = true;
            }
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void catalogue_EditValueChanged(object sender, EventArgs e)
        {
            VerifierAvantCreation();
        }

        private void coeff_EditValueChanged(object sender, EventArgs e)
        {
            VerifierAvantCreation();
        }

        private void Create()
        {
            // création des items.**/
            var model = new ArticleModel
            {
                Refce = refce.Text,
                Nom = nom.Text,
                Ig = StdCalcul.GetCategoryId(family.Text),
                Iu = StdCalcul.GetUnityId(unity.Text),
                Catalogue = catalogue.Text,
                Taxable = 0,
                Seuil = 0
            };
            if (!string.IsNullOrEmpty(plancher.Text))
            {
                try
                {
                    model.Seuil = float.Parse(plancher.Text);
                }
                catch (Exception)
                {
                    ErrorHelpers.ShowError("SEUIL INVALIDE");
                    return;
                }
            }
            // rendre l'article taxable ou pas.**/
            if (taxable.Checked)
            {
                model.Taxable = 1;
            }
            if (formel.Checked)
            {
                model.Forme = 1;
            }
            bool isArticleCreated = _articleRepository.CreateWin(model);
            if (!isArticleCreated)
            {
                ErrorHelpers.ShowError("REF ET/OU NOM DEJA EXISTANTE(S)!");
                return;
            }
            float primeRate = StdCalcul.DecimalToFloat(txPrime.Value);
            _model.SetMarge(model.Id, float.Parse(prix.Text), coeff.Value, mgros.Value, mdetail.Value, mSpecial.Value,
                mExtra.Value, taxable.Checked, primeRate);
            _model.Create();
            Clear();
        }

        private void creer_Click(object sender, EventArgs e)
        {
            if (!IsValid)
            {
                Close();
            }
            if (Id == 0)
            {
                Create();
                return;
            }
            // ici modification de tarifs.
            float primeRate = StdCalcul.DecimalToFloat(txPrime.Value);
            _model.UniteFrns = unity.Text;
            _model.SetMarge(_model.Id, float.Parse(prix.Text), coeff.Value, mgros.Value, mdetail.Value, mSpecial.Value,
                mExtra.Value, taxable.Checked, primeRate);
            _model.SafeUpdate();
            _item.Nom = nom.Text;
            _item.Refce = refce.Text;
            _item.Catalogue = catalogue.Text;
            _item.Ig = StdCalcul.GetCategoryId(family.Text);
            _item.Iu = StdCalcul.GetUnityId(unity.Text);
            _item.Taxable = taxable.Checked ? 1 : 0;
            _item.Forme = formel.Checked ? 1 : 0;
            if (!string.IsNullOrEmpty(plancher.Text))
            {
                _item.Seuil = float.Parse(plancher.Text);
            }
            // cf doublon.
            int otherId = DataHelpers.GetArticleIdByName(nom.Text);
            if ((_model.Id != otherId) && (otherId > 0))
            {
                ErrorHelpers.ShowErrorDuplicate();
                nom.Focus();
                nom.SelectAll();
                return;
            }
            bool b = _articleRepository.Update();
            if (!b)
            {
                return;
            }
            // Close();
        }

        private void Disable()
        {
            cadre.Enabled = false;
            tarifBox.Enabled = false;
            IsValid = false;
        }

        private void family_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifierAvantCreation();
        }

        private void formel_CheckedChanged(object sender, EventArgs e)
        {
            if (taxable.Checked)
            {
                formel.Checked = true;
            }
            if ((formel.Checked) && (!taxable.Checked))
            {
                taxable.Checked = true;
            }
        }

        private void Init(long id)
        {
            Id = id;
            IsValid = true;
            if (id <= 0)
            {
                Disable();
                ErrorHelpers.ShowError("ERREUR GENERAL.");
                return;
            }

            _item = _articleRepository.Get(id);
            if (_item.Ig == null)
            {
                return;
            }
            int index = -1;
            int count = 0;
            var i = (long)_item.Ig;
            string name = FamilleHelpers.GetName(i);
            foreach (string variable in FamilleHelpers.GetListFamilles())
            {
                family.Items.Add(variable);
                count++;
                if (variable == name)
                {
                    index = count;
                }
            }
            family.SelectedIndex = index - 1;
            if (_item.Iu == null)
            {
                return;
            }
            i = (long)_item.Iu;
            name = UniteHelpers.GetName(i);
            index = -1;
            count = 0;
            foreach (string variable in UniteHelpers.GetListUnites())
            {
                unity.Items.Add(variable);
                count++;
                if (variable == name)
                {
                    index = count;
                }
            }
            if (_item.Forme == 1)
            {
                formel.Checked = true;
            }
            unity.SelectedIndex = index - 1;
            Text = @"MODIFICATION ARTICLE";
            nom.Text = _item.Nom;
            refce.Text = _item.Refce;
            catalogue.Text = _item.Catalogue;
            taxable.Checked = _item.Taxable == 1;
            plancher.Text = _item.Seuil.ToString();
            _model.ReadFast(id);
            prix.Text = Math.Round(_model.Exonere.Achat).ToString(CultureInfo.InvariantCulture);
            coeff.Value = StdCalcul.DoubleToDecimal(_model.Marge.Revient);
            mgros.Value = StdCalcul.DoubleToDecimal(_model.Marge.Gros);
            mdetail.Value = StdCalcul.DoubleToDecimal(_model.Marge.Detail);
            mSpecial.Value = StdCalcul.DoubleToDecimal(_model.Marge.Special);
            mExtra.Value = StdCalcul.DoubleToDecimal(_model.Marge.Extra);
            txPrime.Value = StdCalcul.DoubleToDecimal(_model.Prime.Achat);
            VerifierAvantCreation();
            creer.Text = Resources.XtraArticle_Init__Modifier;
            creer.ToolTip = Resources.XtraArticle_Init_Modifier_l_article_en_cours_;
            creer.Enabled = false;
        }

        private void Init()
        {
            Id = 0;
            IsValid = true;
            var familleRepository = new FamilleRepository();
            if (familleRepository.Count() == 0)
            {
                Disable();
                ErrorHelpers.ShowError("AUCUNE FAMILLE EXISTANTE.");
                return;
            }
            foreach (string variable in FamilleHelpers.GetListFamilles())
            {
                family.Items.Add(variable);
            }
            family.SelectedIndex = 0;
            var uniteRepository = new UniteRepository();
            if (uniteRepository.Count() == 0)
            {
                Disable();
                ErrorHelpers.ShowError("AUCUNE UNITE EXISTANTE.");
                return;
            }
            foreach (string variable in UniteHelpers.GetListUnites())
            {
                unity.Items.Add(variable);
            }
            unity.SelectedIndex = 0;
            Text = @"NOUVEAU ARTICLE";
        }

        private void mdetail_EditValueChanged(object sender, EventArgs e)
        {
            VerifierAvantCreation();
        }

        private void mExtra_EditValueChanged(object sender, EventArgs e)
        {
            VerifierAvantCreation();
        }

        private void mgros_EditValueChanged(object sender, EventArgs e)
        {
            VerifierAvantCreation();
        }

        private void mspecial_EditValueChanged(object sender, EventArgs e)
        {
            VerifierAvantCreation();
        }

        private void nom_EditValueChanged(object sender, EventArgs e)
        {
            VerifierAvantCreation();
        }

        private void plancher_EditValueChanged(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                VerifierAvantCreation();
            }
        }

        private void prix_EditValueChanged(object sender, EventArgs e)
        {
            VerifierAvantCreation();
        }

        private void refce_EditValueChanged(object sender, EventArgs e)
        {
            VerifierAvantCreation();
        }

        private void taxable_CheckedChanged(object sender, EventArgs e)
        {
            CheckChange();
        }

        private void taxable_EditValueChanged(object sender, EventArgs e)
        {
            VerifierAvantCreation();
        }

        private void txPrime_EditValueChanged(object sender, EventArgs e)
        {
            VerifierAvantCreation();
        }

        private void unity_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifierAvantCreation();
        }
    }
}