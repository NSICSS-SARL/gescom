using System.Collections.Generic;
using System.Linq;
using gescom.data.Models;

namespace gescom.create.Views
{
    public partial class XtraDeclaration : DevExpress.XtraEditors.XtraForm
    {
        private List<DeclarationItem> _list;
        private readonly XtraPeriode _fPeriode;
        public XtraDeclaration()
        {
            InitializeComponent();
            _list = new List<DeclarationItem>();
            _fPeriode = new XtraPeriode();
            _list = DateHelpers.GetDeclarationItems().ToList();
            SetData();
        }

        private void SetData()
        {
            grillage.DataSource = _list;
            myNum.DataBindings.Clear();
            myNum.DataBindings.Add("Text", _list, "Id");
        }
    }
}