using System.Linq;
using DevExpress.XtraEditors;
using gescom.data.Models;

namespace gescom.create.Views
{
    public partial class XtraMag : XtraForm
    {
        public XtraMag()
        {
            InitializeComponent();
        }

        public XtraMag(long id)
        {
            InitializeComponent();
            var list = ActionHelpers.GetEntrees(id).ToList();
            grillage.DataSource = list;
        }
    }
}