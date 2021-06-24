using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.create.Views
{
    public partial class XtraGroup : XtraForm
    {
        private readonly List<OperationItem> _list;
        private string _name;
        private string _text;

        public XtraGroup()
        {
            InitializeComponent();
        }

        public XtraGroup(List<OperationItem> liste)
        {
            InitializeComponent();
            gridActions.DataSource = liste;
            _list = new List<OperationItem>();
            _list = liste;
            myNum.DataBindings.Clear();
            myNum.DataBindings.Add("Text", liste, "Ndx");
            if (liste.ToList().Count > 0)
            {
                imprimer.Enabled = true;
            }
        }

        public void SetTitle(string text, string name)
        {
            Text = text + @": " + name;
            _text = text;
            _name = name;
        }

        private void gridActions_DoubleClick(object sender, EventArgs e)
        {
            string text = myNum.Text;
            if (text == null)
            {
                return;
            }
            long id = long.Parse(text);
            if (id == 0)
            {
                return;
            }
            CreateHelpers.Detailler(id);
        }

        private long GetX()
        {
            if (string.IsNullOrEmpty(myNum.Text))
            {
                return 0;
            }
            if (myNum.Text == @"0")
            {
                return 0;
            }
            long x = long.Parse(myNum.Text);
            return x;
        }

        private void Remark()
        {
            CreateHelpers.Remarquer(GetX(), true);
        }

        private void Displace()
        {
            CreateHelpers.Deplacer(GetX());
        }

        private void RefModif()
        {
            CreateHelpers.ModifyOnVendor(GetX());
        }

        private void Modify()
        {
            CreateHelpers.DetaillerArticle(GetX());
        }

        private void remarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remark();
        }

        private void observationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Displace();
        }

        private void réferenceFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefModif();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modify();
        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            CreateHelpers.ImprimerRegroup(_list, _text, _name);
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}