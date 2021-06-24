using gescom.data.Models;
using System.Collections.Generic;
using System.Linq;

namespace gescom.create.Views
{
    public partial class XtraMag : DevExpress.XtraEditors.XtraForm
    {
        public XtraMag()
        {
            InitializeComponent();
        }

        public XtraMag(long id)
        {
            InitializeComponent();
            List<DetailMag> list = ActionHelpers.GetEntrees(id).ToList();
            grillage.DataSource = list;
        }
    }
}