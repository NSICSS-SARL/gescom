using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.create.Properties;
using gescom.data.Models;
using System;
using System.Globalization;

namespace gescom.create.Views
{
    public partial class XtraPerson : XtraForm
    {
        private readonly long _id;
        private readonly int _index;

        public XtraPerson()
        {
            InitializeComponent();
            _index = 0;
            _id = 1;
            formel.Visible = false;
            ReadOnly();
        }

        public XtraPerson(int index, long id)
        {
            InitializeComponent();
            _index = index;
            _id = id;
            Init();
        }

        private void Clear()
        {
            txtNom.Text = "";
            txtActivite.Text = "";
            txtAdresse.Text = "";
            txtComplement.Text = "";
            txtBanque.Text = "";
            txtMail.Text = "";
            txtFax.Text = "";
            txtNif.Text = "";
            txtStat.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtTel3.Text = "";
            txtVille.Text = "";
            textLocale.Text = "";
            txtNom.Focus();
        }

        private void creer_Click(object sender, EventArgs e)
        {
            if (tvaValue.Visible)
            {
                PriceHelpers.UpdateTaxe(StdCalcul.DecimalToFloat(tvaValue.Value));
            }
            PersonModel p = Initialiser();
            if (p.IsValid)
            {
                Save(p);
            }
        }

        private void Init()
        {
            if (_index == 3)
            {
                formel.Visible = false;
            }
            if (_id < 0)
            {
                switch (_index)
                {
                    case 1:
                        Text = Resources.XtraPerson_Init_Nouveau_fournisseur;
                        break;

                    case 2:

                        Text = Resources.XtraPerson_Init_Nouveau_client;
                        choiceBox.Visible = true;
                        break;

                    case 3:
                        Text = Resources.XtraPerson_Init_NOUVEAU_PERSONNEL;
                        break;

                    default:
                        formel.Visible = false;
                        Text = Resources.XtraPerson_Init_Informations_générales;
                        break;
                }
                return;
            }
            Read();
        }

        private PersonModel Initialiser()
        {
            var model = new PersonModel { IsValid = true };
            if (string.IsNullOrEmpty(txtVille.Text))
            {
                ErrorHelpers.ShowError("VILLE REQUISE.");
                txtVille.Focus();
                model.IsValid = false;
            }
            if (string.IsNullOrEmpty(txtAdresse.Text))
            {
                ErrorHelpers.ShowError("ADRESSE REQUISE.");
                txtAdresse.Focus();
                model.IsValid = false;
            }
            if (string.IsNullOrEmpty(txtNom.Text))
            {
                ErrorHelpers.ShowError("NOM REQUIS.");
                txtNom.Focus();
                model.IsValid = false;
            }
            model.Nom = txtNom.Text;
            model.Localite = textLocale.Text;
            model.Activite = txtActivite.Text;
            model.Adresse = txtAdresse.Text;
            model.Complement = txtComplement.Text;
            model.Compte = txtBanque.Text;
            model.Email = txtMail.Text;
            model.Fax = txtFax.Text;
            model.Nif = txtNif.Text;
            model.Stat = txtStat.Text;
            model.Tel1 = txtTel1.Text;
            model.Tel2 = txtTel2.Text;
            model.Tel3 = txtTel3.Text;
            model.Ville = txtVille.Text;
            return model;
        }

        private void Read()
        {
            creer.Text = Resources.XtraPerson_Read__Modifier;
            var p = new PersonModel();
            PersonModel person = PersonHelpers.Get(_id);
            switch (_index)
            {
                case 1:
                    tetox.Visible = true;
                    numero.Text = StdCalcul.Spacing(_id.ToString(CultureInfo.InvariantCulture));
                    Text = @"FOURNISSEUR: " + person.Nom;
                    break;

                case 2:
                    tetox.Visible = true;
                    numero.Text = StdCalcul.Spacing(_id.ToString(CultureInfo.InvariantCulture));
                    Text = @"CLIENT: " + person.Nom;
                    break;

                case 3:
                    tetox.Visible = true;
                    numero.Text = StdCalcul.Spacing(_id.ToString(CultureInfo.InvariantCulture));
                    Text = @"PERSONNEL: " + person.Nom;
                    break;
            }
            p.Copy(person);
            if (_index == 2)
            {
                choiceBox.Visible = true;
                switch (p.Groupe)
                {
                    case 1:
                        chkGros.Checked = true;
                        break;

                    case 2:
                        chkDetail.Checked = true;
                        break;

                    case 3:
                        chkSpecial.Checked = true;
                        break;

                    case 4:
                        chkExtra.Checked = true;
                        break;
                }
            }
            if (person.Forme == 1)
            {
                formel.Checked = true;
            }
            textLocale.Text = p.Localite;
            txtActivite.Text = p.Activite;
            txtAdresse.Text = p.Adresse;
            txtComplement.Text = p.Complement;
            txtBanque.Text = p.Compte;
            txtMail.Text = p.Email;
            txtFax.Text = p.Fax;
            txtNif.Text = p.Nif;
            txtStat.Text = p.Stat;
            txtTel1.Text = p.Tel1;
            txtTel2.Text = p.Tel2;
            txtTel3.Text = p.Tel3;
            txtVille.Text = p.Ville;
            txtNom.Text = p.Nom;
        }

        private void ReadOnly()
        {
            Text = Resources.XtraPerson_Init_Informations_générales;
            var p = PersonHelpers.Get(1);
            textLocale.Text = p.Localite;
            txtActivite.Text = p.Activite;
            txtAdresse.Text = p.Adresse;
            txtComplement.Text = p.Complement;
            txtBanque.Text = p.Compte;
            txtMail.Text = p.Email;
            txtFax.Text = p.Fax;
            txtNif.Text = p.Nif;
            txtStat.Text = p.Stat;
            txtTel1.Text = p.Tel1;
            txtTel2.Text = p.Tel2;
            txtTel3.Text = p.Tel3;
            txtVille.Text = p.Ville;
            txtNom.Text = p.Nom;
            tvaLabel.Visible = true;
            tvaValue.Visible = true;
            creer.Text = Resources.XtraPerson_Read__Modifier;
            float t = PriceHelpers.GetTaxe();
            tvaValue.Value = StdCalcul.DoubleToDecimal(t);
        }

        private void Save(PersonModel model)
        {
            if (_index == 2)
            {
                if (chkGros.Checked)
                {
                    model.Groupe = 1;
                }
                if (chkDetail.Checked)
                {
                    model.Groupe = 2;
                }
                if (chkSpecial.Checked)
                {
                    model.Groupe = 3;
                }
                if (chkExtra.Checked)
                {
                    model.Groupe = 4;
                }
            }
            if (_index == 3)
            {
                model.Groupe = 5;
            }
            if (_index == 1)
            {
                model.Groupe = 0;
            }
            if (_id < 0)
            {
                switch (_index)
                {
                    case 2:
                        PersonHelpers.Create(model);
                        Clear();
                        return;

                    case 3:
                        PersonHelpers.CreateWorker(model);
                        Clear();
                        return;
                }
                PersonHelpers.CreateVendor(model);
                Clear();
                return;
            }
            if (formel.Visible)
            {
                model.Forme = 0;
                if (formel.Checked)
                {
                    model.Forme = 1;
                }
            }
            model.Id = _id;
            PersonHelpers.Update(model);
            Close();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}