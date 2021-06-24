using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Collections.Generic;

namespace gescom.create.Views
{
    public partial class ListGlobal : XtraForm
    {
        private readonly int _index;

        public ListGlobal()
        {
            InitializeComponent();
            _index = -1;
        }

        public ListGlobal(int index)
        {
            InitializeComponent();
            _index = index;
            Init();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void globalGrid_DoubleClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numero.Text))
            {
                return;
            }
            if (numero.Text == @"0")
            {
                return;
            }
            int id = int.Parse(numero.Text);
            CreateHelpers.DetaillerGlobal(_index, id);
        }

        private void Init()
        {
            switch (_index)
            {
                case 0:
                    Text = @"LISTE DE CATEGORIES";
                    List<FamilleItem> fList = FamilleHelpers.GetList();
                    colUnique.Visible = false;
                    globalView.OptionsView.ColumnAutoWidth = true;
                    globalGrid.DataSource = fList;
                    numero.DataBindings.Add("Text", fList, "Id");
                    break;

                case 1:
                    Text = @"LISTE D'UNITES";
                    colUnique.Visible = false;
                    globalView.OptionsView.ColumnAutoWidth = true;
                    List<UniteItem> uList = UniteHelpers.GetList();
                    globalGrid.DataSource = uList;
                    numero.DataBindings.Add("Text", uList, "Id");
                    break;

                default:
                    Text = @"LISTE D'EMPLACEMENTS";
                    colCode.Caption = "PREMIERE PLACE";
                    colTitle.Caption = "SECONDE PLACE";
                    List<PlaceItem> pList = PlaceHelpers.GetList();
                    globalGrid.DataSource = pList;
                    numero.DataBindings.Add("Text", pList, "Id");
                    break;
            }
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            var frmGlobal = new XtraGlobal(_index);
            frmGlobal.ShowDialog();
        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            CreateHelpers.ImprimerGlobal(_index);
        }

        private void détailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numero.Text))
            {
                return;
            }
            if (numero.Text == @"0")
            {
                if ((_index == 0) || (_index == 1))
                {
                    return;
                }
            }
            long id = long.Parse(numero.Text);
            CreateHelpers.RegroupArticle(_index, id);
        }
    }
}