using gescom.create.Models;
using gescom.data.Models;
using System;
using System.Linq;

namespace gescom.create.Views
{
    public partial class XtraChoice : DevExpress.XtraEditors.XtraForm
    {
        public XtraChoice()
        {
            InitializeComponent();
            var liste = PersonHelpers.GetNoBlankName().ToList();
            nom.DataSource = liste;
            myNum.DataBindings.Add("Text", liste, "Id");
            typage.DataBindings.Add("Text", liste, "Nom");
        }

        private void creer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(myNum.Text))
            {
                return;
            }
            long id = long.Parse(myNum.Text);
            if (id <= 0)
            {
                return;
            }
            CreateHelpers.EffectuerEntree(id);
        }
    }
}