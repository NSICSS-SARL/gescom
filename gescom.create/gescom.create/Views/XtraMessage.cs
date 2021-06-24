using DevExpress.XtraEditors;
using gescom.data.Models;
using System;
using System.Globalization;

namespace gescom.create.Views
{
    public partial class XtraMessage : XtraForm
    {
        private readonly long _id;
        private readonly int _index;
        private long _x;
        private long _y;

        public XtraMessage()
        {
            InitializeComponent();
        }

        public XtraMessage(long id, int index)
        {
            InitializeComponent();
            if (index == 0)
            {
                return;
            }
            _index = index;
            _id = id;
            Init();
            if (index == 1)
            {
                return;
            }
            b1.Visible = false;
            t1.Visible = false;
            d1.Visible = false;
            d2.Visible = false;
            b2.Visible = false;
        }

        private void creer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(s1.Text))
            {
                s1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(q1.Text))
            {
                q1.Focus();
                return;
            }
            string message = s1.Text;
            float quantite = float.Parse(q1.Text);
            if (_index == 1)
            {
                if (string.IsNullOrEmpty(t1.Text))
                {
                    t1.Focus();
                    return;
                }
                if (checkPrix.Checked)
                {
                    _x = 1;
                }
                if (checkEntre.Checked)
                {
                    _y = 1;
                }
                ArticleHelpers.UpdateRecto(_id, t1.Text, message, quantite, b1.Text, b2.Text, _x, _y);
            }
            if (_index == 2)
            {
                ArticleHelpers.UpdateDuo(_id, message, quantite);
            }
            Close();
        }

        private void Init()
        {
            ProdItem item = ProdHelpers.Get(_id);
            leNom.Text = ArticleHelpers.GetName(_id);
            nombre.Text = StdCalcul.Spacing(_id.ToString(CultureInfo.InvariantCulture));
            var fcode = item.Code.Substring(item.Code.Length - 1, 1) + item.Code.Substring(0, item.Code.Length - 1);
            //codage.Text = item.Code;
            codage.Text = fcode;
            DuoItem duo = ArticleHelpers.GetDuo(_id);
            d1.Text = duo.D1.ToString("f");
            d2.Text = duo.D2.ToString("f");
            t1.Text = duo.T1;
            b1.Text = duo.B1;
            b2.Text = duo.B2;
            _x = -1;
            _y = -1;
            if (duo.AEntre != null) _x = (long)duo.AEntre;
            if (duo.APrix != null) _y = (long)duo.APrix;
            if (_x == 0)
            {
                checkEntre.Checked = true;
            }
            if (_y == 0)
            {
                checkPrix.Checked = true;
            }
            if (_index == 1)
            {
                s.Text = duo.S2;
                q.Text = StdCalcul.DoubleToSpaceFormat(duo.Q2);
                s1.Text = duo.S1;
                q1.Value = StdCalcul.DoubleToDecimal(duo.Q1);
                return;
            }
            s.Text = duo.S1;
            q.Text = StdCalcul.DoubleToSpaceFormat(duo.Q1);
            s1.Text = duo.S2;
            q1.Value = StdCalcul.DoubleToDecimal(duo.Q2);
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}