using DevExpress.XtraEditors;
using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.create.Views
{
    public partial class XtraDetail : XtraForm
    {
        private readonly List<RetailModel> _list;
        private bool _hideMove;
        private long _id;

        public XtraDetail()
        {
            InitializeComponent();
        }

        public XtraDetail(long id)
        {
            InitializeComponent();
            _list = new List<RetailModel>();
            _list = RetailHelpers.GetRetail(id).ToList();
            SetTitle(id);
            SetData();
        }

        public void NoPrint()
        {
            imprimer.Enabled = false;
            _hideMove = true;
        }

        private void SetTitle(long id)
        {
            _id = id;
            DiaryItem diary = DiaryHelpers.Get(id);
            Text = diary.Id + @" " + diary.Tache;
        }

        private void grillage_DoubleClick(object sender, EventArgs e)
        {
            if (_hideMove)
            {
                return;
            }
            string text = myNum.Text;
            if (text == null)
            {
                return;
            }
            long id = long.Parse(text);
            if (id == 0)
            {
            }
            // CreateHelpers.Detailler(id);
        }

        private void SetData()
        {
            myNum.DataBindings.Clear();
            grillage.DataSource = _list;
            myNum.DataBindings.Add("Text", _list, "Ndx");
        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                return;
            }
            CreateHelpers.ImprimerDetails(_id);
            Close();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}