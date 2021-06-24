using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace gescom.create.Views
{
    public partial class XtraProd : XtraForm
    {
        private readonly long _id;

        public XtraProd()
        {
            InitializeComponent();
        }

        public XtraProd(long id)
        {
            InitializeComponent();
            _id = id;
            Init();
        }

        private void Save()
        {
            var model = new ProdModel { Id = _id };
            if (string.IsNullOrEmpty(txtNom.Text))
            {
                ErrorHelpers.ShowError("Le nom ne peut être vide.");
                return;
            }
            if (string.IsNullOrEmpty(txtQte.Text))
            {
                ErrorHelpers.ShowError("La quantité ne peut être nulle.");
                return;
            }
            if (string.IsNullOrEmpty(txtPrix.Text))
            {
                ErrorHelpers.ShowError("Le prix ne peut être nul.");
                return;
            }
            if (string.IsNullOrEmpty(vend.Text))
            {
                ErrorHelpers.ShowError("Le fournisseur de préférence doit être renseigné.");
                return;
            }
            model.Code = codage.Text;
            model.Description = description.Text;
            model.Nom = txtNom.Text;
            model.Refce = txtRefce.Text;
            model.Quantite = float.Parse(txtQte.Text);
            model.Prix = float.Parse(txtPrix.Text);
            model.Iu = StdCalcul.GetUnityId(unity.Text);
            model.Pid = StdCalcul.GetVendorId(vend.Text);
            ProdHelpers.Update(model);
            Close();
        }

        private void Init()
        {
            ProdItem item = ProdHelpers.Get(_id);
            Text = @"REFERENCES FOURNISSEUR";
            leNom.Text = ArticleHelpers.GetName(_id);
            nombre.Text = StdCalcul.Spacing(_id.ToString(CultureInfo.InvariantCulture));
            codage.Text = item.Code;
            txtNom.Text = item.Nom;
            txtRefce.Text = item.Refce;
            txtQte.Text = item.Quantite.ToString();
            txtPrix.Text = item.Prix.ToString();
            description.Text = item.Description;
            if (item.Iu == null) return;
            var i = (long)item.Iu;
            string name = UniteHelpers.GetName(i);
            int index = 0;
            int count = 0;
            foreach (string variable in UniteHelpers.GetListUnites())
            {
                unity.Items.Add(variable);
                count++;
                if (variable == name)
                {
                    index = count;
                }
            }
            unity.SelectedIndex = index - 1;
            txtNom.Focus();
            if (item.Pid != null)
            {
                var j = (long)item.Pid;
                name = PersonHelpers.GetName(j);
            }
            if (name == null)
            {
                foreach (PersonModel person in PersonHelpers.GetVendors())
                {
                    vend.Items.Add(person.Nom);
                    count++;
                }
                vend.SelectedIndex = 0;
                return;
            }
            index = 0;
            count = 0;
            foreach (PersonModel person in PersonHelpers.GetVendors())
            {
                vend.Items.Add(person.Nom);
                count++;
                if (person.Nom == name)
                {
                    index = count;
                }
            }
            if (count > 0)
            {
                vend.SelectedIndex = index - 1;
            }
        }

        private void creer_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((Char.IsDigit(c) || Char.IsControl(c)) == false)
            {
                e.Handled = true;
            }
        }

        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((Char.IsDigit(c) || Char.IsControl(c)) == false)
            {
                e.Handled = true;
            }
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}