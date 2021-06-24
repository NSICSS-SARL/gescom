namespace gescom.create.Views
{
    partial class XtraComptable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraComptable));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Typage = new DevExpress.XtraEditors.LabelControl();
            this.sType = new DevExpress.XtraEditors.LabelControl();
            this.solde = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.Noms = new DevExpress.XtraEditors.LabelControl();
            this.Numero = new DevExpress.XtraEditors.LabelControl();
            this.Rendu = new DevExpress.XtraEditors.LabelControl();
            this.Adresse = new DevExpress.XtraEditors.LabelControl();
            this.sSolde = new DevExpress.XtraEditors.LabelControl();
            this.sAdresse = new DevExpress.XtraEditors.LabelControl();
            this.sNoms = new DevExpress.XtraEditors.LabelControl();
            this.sNumero = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.creer = new DevExpress.XtraEditors.SimpleButton();
            this.fermer = new DevExpress.XtraEditors.SimpleButton();
            this.textMontant = new DevExpress.XtraEditors.TextEdit();
            this.textLibelle = new DevExpress.XtraEditors.TextEdit();
            this.textRefce = new DevExpress.XtraEditors.TextEdit();
            this.sMontant = new DevExpress.XtraEditors.LabelControl();
            this.sLibelle = new DevExpress.XtraEditors.LabelControl();
            this.sRefce = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.credit = new System.Windows.Forms.RadioButton();
            this.debit = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solde)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMontant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLibelle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRefce.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Typage);
            this.groupControl1.Controls.Add(this.sType);
            this.groupControl1.Controls.Add(this.solde);
            this.groupControl1.Controls.Add(this.Noms);
            this.groupControl1.Controls.Add(this.Numero);
            this.groupControl1.Controls.Add(this.Rendu);
            this.groupControl1.Controls.Add(this.Adresse);
            this.groupControl1.Controls.Add(this.sSolde);
            this.groupControl1.Controls.Add(this.sAdresse);
            this.groupControl1.Controls.Add(this.sNoms);
            this.groupControl1.Controls.Add(this.sNumero);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(484, 151);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Situation";
            // 
            // Typage
            // 
            this.Typage.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Typage.Location = new System.Drawing.Point(347, 30);
            this.Typage.Name = "Typage";
            this.Typage.Size = new System.Drawing.Size(7, 13);
            this.Typage.TabIndex = 14;
            this.Typage.Text = "3";
            // 
            // sType
            // 
            this.sType.Location = new System.Drawing.Point(284, 30);
            this.sType.Name = "sType";
            this.sType.Size = new System.Drawing.Size(24, 13);
            this.sType.TabIndex = 15;
            this.sType.Text = "TYPE";
            // 
            // solde
            // 
            this.solde.BackGroundColor = System.Drawing.SystemColors.Window;
            this.solde.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.solde.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solde.IntegerValue = ((long)(0));
            this.solde.Location = new System.Drawing.Point(347, 115);
            this.solde.Name = "solde";
            this.solde.NullString = "";
            this.solde.ReadOnly = true;
            this.solde.Size = new System.Drawing.Size(113, 21);
            this.solde.TabIndex = 7;
            this.solde.Text = "0";
            this.solde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Noms
            // 
            this.Noms.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noms.Location = new System.Drawing.Point(190, 60);
            this.Noms.Name = "Noms";
            this.Noms.Size = new System.Drawing.Size(7, 13);
            this.Noms.TabIndex = 2;
            this.Noms.Text = "1";
            // 
            // Numero
            // 
            this.Numero.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Location = new System.Drawing.Point(190, 30);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(7, 13);
            this.Numero.TabIndex = 1;
            this.Numero.Text = "0";
            // 
            // Rendu
            // 
            this.Rendu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rendu.Location = new System.Drawing.Point(220, 176);
            this.Rendu.Name = "Rendu";
            this.Rendu.Size = new System.Drawing.Size(7, 13);
            this.Rendu.TabIndex = 13;
            this.Rendu.Text = "0";
            // 
            // Adresse
            // 
            this.Adresse.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresse.Location = new System.Drawing.Point(190, 90);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(7, 13);
            this.Adresse.TabIndex = 3;
            this.Adresse.Text = "2";
            // 
            // sSolde
            // 
            this.sSolde.Location = new System.Drawing.Point(285, 120);
            this.sSolde.Name = "sSolde";
            this.sSolde.Size = new System.Drawing.Size(32, 13);
            this.sSolde.TabIndex = 6;
            this.sSolde.Text = "SOLDE";
            // 
            // sAdresse
            // 
            this.sAdresse.Location = new System.Drawing.Point(23, 90);
            this.sAdresse.Name = "sAdresse";
            this.sAdresse.Size = new System.Drawing.Size(45, 13);
            this.sAdresse.TabIndex = 5;
            this.sAdresse.Text = "ADRESSE";
            // 
            // sNoms
            // 
            this.sNoms.Location = new System.Drawing.Point(23, 60);
            this.sNoms.Name = "sNoms";
            this.sNoms.Size = new System.Drawing.Size(135, 13);
            this.sNoms.TabIndex = 4;
            this.sNoms.Text = "NOMS OU RAISON SOCIALE";
            // 
            // sNumero
            // 
            this.sNumero.Location = new System.Drawing.Point(23, 30);
            this.sNumero.Name = "sNumero";
            this.sNumero.Size = new System.Drawing.Size(43, 13);
            this.sNumero.TabIndex = 0;
            this.sNumero.Text = "NUMERO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.creer);
            this.panel1.Controls.Add(this.fermer);
            this.panel1.Controls.Add(this.textMontant);
            this.panel1.Controls.Add(this.textLibelle);
            this.panel1.Controls.Add(this.textRefce);
            this.panel1.Controls.Add(this.sMontant);
            this.panel1.Controls.Add(this.sLibelle);
            this.panel1.Controls.Add(this.sRefce);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 136);
            this.panel1.TabIndex = 1;
            // 
            // creer
            // 
            this.creer.Location = new System.Drawing.Point(297, 102);
            this.creer.Name = "creer";
            this.creer.Size = new System.Drawing.Size(75, 23);
            this.creer.TabIndex = 6;
            this.creer.Text = "OK";
            this.creer.Click += new System.EventHandler(this.creer_Click);
            // 
            // fermer
            // 
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fermer.Location = new System.Drawing.Point(383, 102);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 7;
            this.fermer.Text = "&Fermer";
           this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // textMontant
            // 
            this.textMontant.Location = new System.Drawing.Point(99, 74);
            this.textMontant.Name = "textMontant";
            this.textMontant.Size = new System.Drawing.Size(100, 20);
            this.textMontant.TabIndex = 5;
            // 
            // textLibelle
            // 
            this.textLibelle.Location = new System.Drawing.Point(99, 45);
            this.textLibelle.Name = "textLibelle";
            this.textLibelle.Size = new System.Drawing.Size(359, 20);
            this.textLibelle.TabIndex = 4;
            // 
            // textRefce
            // 
            this.textRefce.Location = new System.Drawing.Point(99, 17);
            this.textRefce.Name = "textRefce";
            this.textRefce.Size = new System.Drawing.Size(100, 20);
            this.textRefce.TabIndex = 3;
            // 
            // sMontant
            // 
            this.sMontant.Location = new System.Drawing.Point(23, 78);
            this.sMontant.Name = "sMontant";
            this.sMontant.Size = new System.Drawing.Size(49, 13);
            this.sMontant.TabIndex = 2;
            this.sMontant.Text = "MONTANT";
            // 
            // sLibelle
            // 
            this.sLibelle.Location = new System.Drawing.Point(23, 49);
            this.sLibelle.Name = "sLibelle";
            this.sLibelle.Size = new System.Drawing.Size(37, 13);
            this.sLibelle.TabIndex = 1;
            this.sLibelle.Text = "LIBELLE";
            // 
            // sRefce
            // 
            this.sRefce.Location = new System.Drawing.Point(23, 20);
            this.sRefce.Name = "sRefce";
            this.sRefce.Size = new System.Drawing.Size(58, 13);
            this.sRefce.TabIndex = 0;
            this.sRefce.Text = "REFERENCE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.credit);
            this.groupBox1.Controls.Add(this.debit);
            this.groupBox1.Location = new System.Drawing.Point(3, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opération";
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Location = new System.Drawing.Point(282, 22);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(54, 17);
            this.credit.TabIndex = 1;
            this.credit.Text = "Crédit";
            this.credit.UseVisualStyleBackColor = true;
            // 
            // debit
            // 
            this.debit.AutoSize = true;
            this.debit.Checked = true;
            this.debit.Location = new System.Drawing.Point(96, 24);
            this.debit.Name = "debit";
            this.debit.Size = new System.Drawing.Size(50, 17);
            this.debit.TabIndex = 0;
            this.debit.TabStop = true;
            this.debit.Text = "Débit";
            this.debit.UseVisualStyleBackColor = true;
            // 
            // XtraComptable
            // 
            this.AcceptButton = this.creer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fermer;
            this.ClientSize = new System.Drawing.Size(484, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraComptable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SAISIE";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solde)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMontant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLibelle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRefce.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl sNumero;
        private DevExpress.XtraEditors.LabelControl sAdresse;
        private DevExpress.XtraEditors.LabelControl sNoms;
        private DevExpress.XtraEditors.LabelControl sSolde;
        private DevExpress.XtraEditors.LabelControl Noms;
        private DevExpress.XtraEditors.LabelControl Numero;
        private DevExpress.XtraEditors.LabelControl Rendu;
        private DevExpress.XtraEditors.LabelControl Adresse;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox solde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton credit;
        private System.Windows.Forms.RadioButton debit;
        private DevExpress.XtraEditors.LabelControl sMontant;
        private DevExpress.XtraEditors.LabelControl sLibelle;
        private DevExpress.XtraEditors.LabelControl sRefce;
        private DevExpress.XtraEditors.TextEdit textRefce;
        private DevExpress.XtraEditors.SimpleButton fermer;
        private DevExpress.XtraEditors.TextEdit textMontant;
        private DevExpress.XtraEditors.TextEdit textLibelle;
        private DevExpress.XtraEditors.SimpleButton creer;
        private DevExpress.XtraEditors.LabelControl Typage;
        private DevExpress.XtraEditors.LabelControl sType;

    }
}