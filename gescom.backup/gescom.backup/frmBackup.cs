using DevExpress.XtraEditors;
using gescom.data.Models;
using System.Data;
using System.IO;

namespace gescom.backup
{
    public partial class FrmBackup : XtraForm
    {
        public FrmBackup()
        {
            InitializeComponent();
            DataHelpers.SaveGeneral();
            DataHelpers.SaveLocal();
        }

        protected void SetData()
        {
            var oDs = new DataSet();
            oDs.ReadXml("Tout.xml");
            grille.DataSource = oDs.Tables[0];
        }

        private void FrmBackup_Activated(object sender, System.EventArgs e)
        {
           
        }

        private void FrmBackup_Load(object sender, System.EventArgs e)
        {
            var file = new FileInfo("Tout.xml");
            if (file.Exists)
            {
                Text += file.LastWriteTime.ToString("F");
                SetData();
                return;
            }
            Text = @"IMPOSSIBLE DE LIRE LE FICHIER";
        }
    }
}