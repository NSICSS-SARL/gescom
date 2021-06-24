using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.create.Properties;
using gescom.data.Models;
using System;
using System.Globalization;

namespace gescom.create.Views
{
    public partial class XtraGlobal : XtraForm
    {
        public XtraGlobal()
        {
            InitializeComponent();
            Init();
        }

        public XtraGlobal(int index)
        {
            InitializeComponent();
            _index = index;
            Init();
        }

        public XtraGlobal(int index, long id)
        {
            InitializeComponent();
            _index = index;
            _id = id;
            Init();
        }

        private void Save()
        {
            string mycode = code.Text;
            string name = nom.Text;
            if (string.IsNullOrEmpty(name))
            {
                ErrorHelpers.ShowNameError();
                nom.Focus();
                return;
            }
            if (string.IsNullOrEmpty(mycode))
            {
                if (_index < 2)
                {
                    ErrorHelpers.ShowCodeError();
                    code.Focus();
                    return;
                }
            }
            int reserved = 0;
            if (_id == 0)
            {
                if (_index == 0)
                {
                    FamilleHelpers.Create(mycode, name);
                    code.Text = "";
                    nom.Text = "";
                    nom.Focus();
                    return;
                }
                if (_index == 1)
                {
                    UniteHelpers.Create(mycode, name);
                    code.Text = "";
                    nom.Text = "";
                    nom.Focus();
                    return;
                }
                reserved = 0;
                if (reserve.Checked)
                {
                    reserved = 1;
                }
                PlaceHelpers.Create(name, mycode, reserved);
                code.Text = "";
                nom.Text = "";
                nom.Focus();
                return;
            }
            bool testError = true;
            if (_index == 0)
            {
                testError = FamilleHelpers.Update(_id, mycode, name);
            }
            if (_index == 1)
            {
                testError = UniteHelpers.Update(_id, mycode, name);
            }
            if (reserve.Checked)
            {
                reserved = 1;
            }
            if (_index == 2)
            {
                testError = PlaceHelpers.Update(_id, name, mycode, reserved);
            }
            if (!testError)
            {
                ErrorHelpers.ShowErrorDuplicate();
                return;
            }
            Close();
        }

        private void Init()
        {
            if (_id == 0)
            {
                switch (_index)
                {
                    case 1:
                        Text = Resources.XtraGlobal_Init_Nouvelle_unité;
                        break;

                    case 2:
                        Text = Resources.XtraGlobal_Init_Nouveau_emplacement;
                        placeBox.Visible = true;
                        placeBox.Enabled = true;
                        break;

                    default:
                        Text = Resources.XtraGlobal_Init_Nouvelle_catégorie;
                        break;
                }
                return;
            }
            creer.Text = Resources.XtraGlobal_Init__Modifier;
            creer.ToolTip = Resources.XtraGlobal_Init_Modifier_l_entité_en_cours;
            numero.Visible = true;
            numero.Text = _id.ToString(CultureInfo.InvariantCulture);
            switch (_index)
            {
                case 1:
                    UniteItem unite = UniteHelpers.Get(_id);
                    code.Text = unite.Code;
                    nom.Text = unite.Nom;
                    Text = @"UNITE: " + nom.Text;
                    nom.Focus();
                    break;

                case 2:
                    placeBox.Visible = true;
                    PlaceItem place = PlaceHelpers.Get(_id);
                    labelNom.Text = "Prémière place";
                    labelCode.Text = "Séconde place";
                    code.Text = place.Nom;
                    nom.Text = place.Code;
                    Text = @"EMPLACEMENT: " + nom.Text;
                    nom.Focus();
                    placeBox.Enabled = true;
                    if (place.IsReserved > 0)
                    {
                        reserve.Checked = true;
                    }
                    else
                    {
                        libre.Checked = true;
                    }
                    break;

                default:
                    FamilleItem famille = FamilleHelpers.Get(_id);
                    code.Text = famille.Code;
                    nom.Text = famille.Nom;
                    Text = @"FAMILLE: " + nom.Text;
                    nom.Focus();
                    break;
            }
        }

        private void creer_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}