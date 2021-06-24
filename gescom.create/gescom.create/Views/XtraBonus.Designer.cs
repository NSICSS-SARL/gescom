namespace gescom.create.Views
{
    partial class XtraRegBonus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Percu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.creer = new DevExpress.XtraEditors.SimpleButton();
            this.Montant = new DevExpress.XtraEditors.LabelControl();
            this.Rendu = new DevExpress.XtraEditors.LabelControl();
            this.fermer = new DevExpress.XtraEditors.SimpleButton();
            this.Numero = new DevExpress.XtraEditors.LabelControl();
            this.Noms = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Percu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "NUMERO PERSONNEL";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "NOMS";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "MONTANT PRIME";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 121);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "A PAYER";
            // 
            // Percu
            // 
            this.Percu.Location = new System.Drawing.Point(153, 121);
            this.Percu.Name = "Percu";
            this.Percu.Size = new System.Drawing.Size(100, 20);
            this.Percu.TabIndex = 4;
            this.Percu.EditValueChanged += new System.EventHandler(this.Percu_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 161);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "SOLDE";
            // 
            // creer
            // 
            this.creer.Enabled = false;
            this.creer.Location = new System.Drawing.Point(252, 211);
            this.creer.Name = "creer";
            this.creer.Size = new System.Drawing.Size(75, 23);
            this.creer.TabIndex = 6;
            this.creer.Text = "&Reglèr";
            this.creer.Click += new System.EventHandler(this.creer_Click);
            // 
            // Montant
            // 
            this.Montant.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Montant.Location = new System.Drawing.Point(158, 83);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(7, 13);
            this.Montant.TabIndex = 7;
            this.Montant.Text = "0";
            // 
            // Rendu
            // 
            this.Rendu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rendu.Location = new System.Drawing.Point(158, 161);
            this.Rendu.Name = "Rendu";
            this.Rendu.Size = new System.Drawing.Size(7, 13);
            this.Rendu.TabIndex = 8;
            this.Rendu.Text = "0";
            // 
            // fermer
            // 
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fermer.Enabled = false;
            this.fermer.Location = new System.Drawing.Point(337, 211);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 9;
            this.fermer.Text = "&Fermer";
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // Numero
            // 
            this.Numero.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Location = new System.Drawing.Point(158, 12);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(44, 13);
            this.Numero.TabIndex = 10;
            this.Numero.Text = "Numero";
            // 
            // Noms
            // 
            this.Noms.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noms.Location = new System.Drawing.Point(158, 44);
            this.Noms.Name = "Noms";
            this.Noms.Size = new System.Drawing.Size(31, 13);
            this.Noms.TabIndex = 11;
            this.Noms.Text = "Noms";
            // 
            // XtraRegBonus
            // 
            this.AcceptButton = this.creer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fermer;
            this.ClientSize = new System.Drawing.Size(429, 243);
            this.Controls.Add(this.Noms);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.Rendu);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.creer);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.Percu);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraRegBonus";
            this.Text = "PAIEMENT PRIME";
            ((System.ComponentModel.ISupportInitialize)(this.Percu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit Percu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton creer;
        private DevExpress.XtraEditors.LabelControl Montant;
        private DevExpress.XtraEditors.LabelControl Rendu;
        private DevExpress.XtraEditors.SimpleButton fermer;
        private DevExpress.XtraEditors.LabelControl Numero;
        private DevExpress.XtraEditors.LabelControl Noms;
    }
}