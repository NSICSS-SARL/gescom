using System.Collections.Generic;
using gescom.data.Models;

namespace gescom.@public
{
    public partial class FrmPublic : DevExpress.XtraEditors.XtraForm
    {
        public FrmPublic()
        {
            InitializeComponent();
            IEnumerable<OperationItem> list = OperationHelpers.GetPublicList();
            gridActions.DataSource = list;
        }
    }
}
