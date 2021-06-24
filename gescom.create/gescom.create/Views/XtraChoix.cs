using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Collections.Generic;

namespace gescom.create.Views
{
    public partial class XtraChoix : XtraForm
    {
        private readonly long _index;
        private List<PersonItem> members;
        private long _group;
        private long _id;
        private long _pid;
        private long _wid;
        private string _tiers;
        private PersonItem _person;

        public XtraChoix()
        {
            InitializeComponent();
            _index = -1;
            _person = new PersonItem();
            members = new List<PersonItem>();
            members = PersonHelpers.GetPersonList();
        }

        public XtraChoix(int index, string text)
        {
            InitializeComponent();
            members = new List<PersonItem>();
            members = PersonHelpers.GetPersonList();
            _index = index;
            Init(text);
            _person = new PersonItem();
        }

        private PersonItem Get(long id)
        {
            var result = new PersonItem();
            foreach (var p in members)
            {
                if (p.Id == id) { result = p; }
            }
            return result;
        }

        private void creer_Click(object sender, EventArgs e)
        {
            Verify();
            if (_group < 0)
            {
                ErrorHelpers.ShowError(@"NUMERO INVALIDE.");
                textNum.Focus();
                textNum.SelectAll();
                return;
            }
            long id = long.Parse(textNum.Text);
            if ((_group == 0) && (_index != 1))
            {
                CreateHelpers.EffectuerEntree(id);
                Close();
            }
            if (_index == 1)
            {
                CreateHelpers.EffectuerAvoir(id, new PersonModel(_person));
                Close();
            }
            if (_index == 2)
            {
                long wid = long.Parse(textRec.Text);
                CreateHelpers.EffectuerVente(id, worker.Text, wid);
                Close();
            }
            if (_index == -9)
            {
                CreateHelpers.EffectuerSimulation(id);
                Close();
            }
            Close();
        }

        private void Init(string text)
        {
            Text = text;
            if (_index != 2)
            {
                return;
            }
            labelRec.Visible = true;
            textRec.Visible = true;
            worker.Visible = true;
        }

        private void OnReceptChange()
        {
            if (!labelRec.Visible)
            {
                return;
            }
            worker.Text = null;
            string s = textRec.Text;
            if (string.IsNullOrEmpty(s))
            {
                return;
            }
            long id;
            try
            {
                id = long.Parse(s);
            }
            catch (Exception)
            {
                return;
            }
            if (id <= 1)
            {
                return;
            }
            _person = Get(id);
            _group = _person.Groupe;
            if (_group == 5)
            {
                _wid = id;
                creer.Enabled = true;
                worker.Text = _person.Nom;
            }
        }

        private void OnChange()
        {
            if (creer.Enabled)
            {
                creer.Enabled = false;
            }
            string s = textNum.Text;
            if (string.IsNullOrEmpty(s))
            {
                return;
            }
            long id;
            try
            {
                id = long.Parse(s);
            }
            catch (Exception)
            {
                return;
            }
            if (id <= 1)
            {
                return;
            }
            _person = Get(id);
            _group = _person.Groupe;
            if ((_index == 1) && (_group == 2))
            {
                Text = @"AVOIR:" + _person.Nom;
                creer.Enabled = true;
                return;
            }
            if ((_index == 0) && (_group == 0))
            {
                Text = _person.Nom;
                labelNum.Text = @"ID FOURNISSEUR";
                creer.Enabled = true;
                return;
            }
            if ((_index == 0) || (_group <= 0)) return;
            if (_index == -9)
            {
                Text = @"DEMANDE PRIX:" + _person.Nom;
                creer.Enabled = true;
                return;
            }
            if (_index != 2) return;
            if ((_group > 4) || (_group <= 0))
            {
                Text = @"FACTURE:";
                return;
            }
            _tiers = _person.Nom;
            _pid = _person.Id;
            Text = @"FACTURE:" + _tiers;
            OnReceptChange();
        }

        private long Verify()
        {
            string s = textRec.Text;
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }
            long id;
            try
            {
                id = long.Parse(s);
            }
            catch (Exception)
            {
                return -1;
            }
            if (id <= 0)
            {
                return -1;
            }
            if (_index == 1)
            {
                return 0;
            }
            _person = Get(id);
            if (_person == null)
            {
                _group = -1;
                return _group;
            }
            _group = _person.Groupe;
            if ((_group > 0) && (_index > 0) && (_group < 5))
            {
                _id = id;
                return _group;
            }
            if ((_group > 0) && (_index == -9))
            {
                _id = id;
                return _group;
            }
            if ((_group != 0) || (_index != 0)) return _group;
            _id = id;
            return _group;
        }

        private void textNum_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void textRec_TextChanged(object sender, EventArgs e)
        {
            OnReceptChange();
        }
    }
}