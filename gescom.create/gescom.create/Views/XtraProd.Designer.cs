namespace gescom.create.Views
{
    partial class XtraProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraProd));
            this.tete = new DevExpress.XtraEditors.PanelControl();
            this.leNom = new DevExpress.XtraEditors.LabelControl();
            this.codage = new DevExpress.XtraEditors.LabelControl();
            this.codex = new DevExpress.XtraEditors.LabelControl();
            this.nombre = new DevExpress.XtraEditors.LabelControl();
            this.labelNums = new DevExpress.XtraEditors.LabelControl();
            this.dernier = new DevExpress.XtraEditors.PanelControl();
            this.annuler = new DevExpress.XtraEditors.SimpleButton();
            this.creer = new DevExpress.XtraEditors.SimpleButton();
            this.cadre = new DevExpress.XtraEditors.PanelControl();
            this.description = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.vend = new System.Windows.Forms.ComboBox();
            this.labelS = new DevExpress.XtraEditors.LabelControl();
            this.txtPrix = new DevExpress.XtraEditors.TextEdit();
            this.labelAch = new DevExpress.XtraEditors.LabelControl();
            this.labelSeuil = new DevExpress.XtraEditors.LabelControl();
            this.txtQte = new DevExpress.XtraEditors.TextEdit();
            this.unity = new System.Windows.Forms.ComboBox();
            this.txtRefce = new DevExpress.XtraEditors.TextEdit();
            this.txtNom = new DevExpress.XtraEditors.TextEdit();
            this.labelUnite = new DevExpress.XtraEditors.LabelControl();
            this.labelRef = new DevExpress.XtraEditors.LabelControl();
            this.labelNom = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tete)).BeginInit();
            this.tete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dernier)).BeginInit();
            this.dernier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadre)).BeginInit();
            this.cadre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRefce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tete
            // 
            this.tete.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tete.Controls.Add(this.leNom);
            this.tete.Controls.Add(this.codage);
            this.tete.Controls.Add(this.codex);
            this.tete.Controls.Add(this.nombre);
            this.tete.Controls.Add(this.labelNums);
            this.tete.Dock = System.Windows.Forms.DockStyle.Top;
            this.tete.Location = new System.Drawing.Point(0, 0);
            this.tete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tete.Name = "tete";
            this.tete.Size = new System.Drawing.Size(484, 52);
            this.tete.TabIndex = 0;
            // 
            // leNom
            // 
            this.leNom.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.leNom.Appearance.ForeColor = System.Drawing.Color.DarkMagenta;
            this.leNom.Location = new System.Drawing.Point(67, 36);
            this.leNom.Name = "leNom";
            this.leNom.Size = new System.Drawing.Size(7, 13);
            this.leNom.TabIndex = 5;
            this.leNom.Text = "0";
            // 
            // codage
            // 
            this.codage.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.codage.Appearance.ForeColor = System.Drawing.Color.DarkMagenta;
            this.codage.Location = new System.Drawing.Point(178, 7);
            this.codage.Name = "codage";
            this.codage.Size = new System.Drawing.Size(29, 13);
            this.codage.TabIndex = 3;
            this.codage.Text = "CODE";
            // 
            // codex
            // 
            this.codex.Location = new System.Drawing.Point(132, 6);
            this.codex.Name = "codex";
            this.codex.Size = new System.Drawing.Size(25, 13);
            this.codex.TabIndex = 2;
            this.codex.Text = "Code";
            this.codex.ToolTip = "Code produit";
            this.codex.Visible = false;
            // 
            // nombre
            // 
            this.nombre.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nombre.Appearance.ForeColor = System.Drawing.Color.DarkMagenta;
            this.nombre.Location = new System.Drawing.Point(67, 6);
            this.nombre.LookAndFeel.SkinName = "Office 2010 Silver";
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(7, 13);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "0";
            // 
            // labelNums
            // 
            this.labelNums.Location = new System.Drawing.Point(14, 6);
            this.labelNums.Name = "labelNums";
            this.labelNums.Size = new System.Drawing.Size(37, 13);
            this.labelNums.TabIndex = 0;
            this.labelNums.Text = "Numéro";
            this.labelNums.ToolTip = "Identificateur du produit en cours";
            this.labelNums.Visible = false;
            // 
            // dernier
            // 
            this.dernier.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dernier.Controls.Add(this.annuler);
            this.dernier.Controls.Add(this.creer);
            this.dernier.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dernier.Location = new System.Drawing.Point(0, 201);
            this.dernier.Name = "dernier";
            this.dernier.Size = new System.Drawing.Size(484, 31);
            this.dernier.TabIndex = 3;
            // 
            // annuler
            // 
            this.annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuler.Location = new System.Drawing.Point(386, 5);
            this.annuler.LookAndFeel.SkinName = "Office 2013";
            this.annuler.LookAndFeel.UseDefaultLookAndFeel = false;
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 1;
            this.annuler.Text = "&Annuler";
            this.annuler.ToolTip = "Annule les modifications et ferme la fenêtre en cours";
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // creer
            // 
            this.creer.Location = new System.Drawing.Point(307, 5);
            this.creer.LookAndFeel.SkinName = "Office 2013";
            this.creer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.creer.Name = "creer";
            this.creer.Size = new System.Drawing.Size(75, 23);
            this.creer.TabIndex = 0;
            this.creer.Text = "&Modifier";
            this.creer.ToolTip = "Modifier l\'article en cours.";
            this.creer.Click += new System.EventHandler(this.creer_Click);
            // 
            // cadre
            // 
            this.cadre.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cadre.Controls.Add(this.description);
            this.cadre.Controls.Add(this.labelControl1);
            this.cadre.Controls.Add(this.vend);
            this.cadre.Controls.Add(this.labelS);
            this.cadre.Controls.Add(this.txtPrix);
            this.cadre.Controls.Add(this.labelAch);
            this.cadre.Controls.Add(this.labelSeuil);
            this.cadre.Controls.Add(this.txtQte);
            this.cadre.Controls.Add(this.unity);
            this.cadre.Controls.Add(this.txtRefce);
            this.cadre.Controls.Add(this.txtNom);
            this.cadre.Controls.Add(this.labelUnite);
            this.cadre.Controls.Add(this.labelRef);
            this.cadre.Controls.Add(this.labelNom);
            this.cadre.Location = new System.Drawing.Point(0, 51);
            this.cadre.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cadre.Name = "cadre";
            this.cadre.Size = new System.Drawing.Size(484, 151);
            this.cadre.TabIndex = 1;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(263, 102);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(200, 20);
            this.description.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(209, 105);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Autre info";
            // 
            // vend
            // 
            this.vend.DisplayMember = "NOM";
            this.vend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vend.FormattingEnabled = true;
            this.vend.Location = new System.Drawing.Point(128, 77);
            this.vend.Name = "vend";
            this.vend.Size = new System.Drawing.Size(285, 21);
            this.vend.TabIndex = 3;
            // 
            // labelS
            // 
            this.labelS.Location = new System.Drawing.Point(14, 82);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(56, 13);
            this.labelS.TabIndex = 9;
            this.labelS.Text = "Fournisseur";
            // 
            // txtPrix
            // 
            this.txtPrix.EditValue = "0";
            this.txtPrix.Location = new System.Drawing.Point(128, 126);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(71, 20);
            this.txtPrix.TabIndex = 5;
            this.txtPrix.ToolTip = "Prix d\'achat unitaire";
            this.txtPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrix_KeyPress);
            // 
            // labelAch
            // 
            this.labelAch.Location = new System.Drawing.Point(13, 129);
            this.labelAch.Name = "labelAch";
            this.labelAch.Size = new System.Drawing.Size(52, 13);
            this.labelAch.TabIndex = 11;
            this.labelAch.Text = "Prix estimé";
            // 
            // labelSeuil
            // 
            this.labelSeuil.Location = new System.Drawing.Point(13, 105);
            this.labelSeuil.Name = "labelSeuil";
            this.labelSeuil.Size = new System.Drawing.Size(106, 13);
            this.labelSeuil.TabIndex = 10;
            this.labelSeuil.Text = "Quantité si commande";
            // 
            // txtQte
            // 
            this.txtQte.EditValue = "0";
            this.txtQte.Location = new System.Drawing.Point(128, 102);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(71, 20);
            this.txtQte.TabIndex = 4;
            this.txtQte.ToolTip = "Quantité préferentielle de commande.";
            this.txtQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQte_KeyPress);
            // 
            // unity
            // 
            this.unity.DisplayMember = "NOM";
            this.unity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unity.FormattingEnabled = true;
            this.unity.Location = new System.Drawing.Point(128, 52);
            this.unity.Name = "unity";
            this.unity.Size = new System.Drawing.Size(170, 21);
            this.unity.TabIndex = 2;
            // 
            // txtRefce
            // 
            this.txtRefce.Location = new System.Drawing.Point(128, 28);
            this.txtRefce.Name = "txtRefce";
            this.txtRefce.Size = new System.Drawing.Size(285, 20);
            this.txtRefce.TabIndex = 1;
            this.txtRefce.ToolTip = "Référence produit du fournisseur";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(128, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(335, 20);
            this.txtNom.TabIndex = 0;
            this.txtNom.ToolTip = "Nom ou désignation produit chez le fournisseur.";
            // 
            // labelUnite
            // 
            this.labelUnite.Location = new System.Drawing.Point(13, 54);
            this.labelUnite.Name = "labelUnite";
            this.labelUnite.Size = new System.Drawing.Size(25, 13);
            this.labelUnite.TabIndex = 8;
            this.labelUnite.Text = "Unité";
            // 
            // labelRef
            // 
            this.labelRef.Location = new System.Drawing.Point(13, 32);
            this.labelRef.Name = "labelRef";
            this.labelRef.Size = new System.Drawing.Size(50, 13);
            this.labelRef.TabIndex = 7;
            this.labelRef.Text = "Référence";
            // 
            // labelNom
            // 
            this.labelNom.Location = new System.Drawing.Point(13, 6);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(56, 13);
            this.labelNom.TabIndex = 6;
            this.labelNom.Text = "Désignation";
            // 
            // XtraProd
            // 
            this.AcceptButton = this.creer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.annuler;
            this.ClientSize = new System.Drawing.Size(484, 232);
            this.Controls.Add(this.cadre);
            this.Controls.Add(this.dernier);
            this.Controls.Add(this.tete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prod";
            ((System.ComponentModel.ISupportInitialize)(this.tete)).EndInit();
            this.tete.ResumeLayout(false);
            this.tete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dernier)).EndInit();
            this.dernier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cadre)).EndInit();
            this.cadre.ResumeLayout(false);
            this.cadre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRefce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl tete;
        private DevExpress.XtraEditors.LabelControl codage;
        private DevExpress.XtraEditors.LabelControl codex;
        private DevExpress.XtraEditors.LabelControl nombre;
        private DevExpress.XtraEditors.LabelControl labelNums;
        private DevExpress.XtraEditors.PanelControl dernier;
        public DevExpress.XtraEditors.SimpleButton annuler;
        public DevExpress.XtraEditors.SimpleButton creer;
        private DevExpress.XtraEditors.PanelControl cadre;
        private System.Windows.Forms.ComboBox unity;
        private DevExpress.XtraEditors.TextEdit txtRefce;
        private DevExpress.XtraEditors.TextEdit txtNom;
        private DevExpress.XtraEditors.LabelControl labelUnite;
        private DevExpress.XtraEditors.LabelControl labelRef;
        private DevExpress.XtraEditors.LabelControl labelNom;
        private DevExpress.XtraEditors.LabelControl labelSeuil;
        private DevExpress.XtraEditors.TextEdit txtQte;
        private DevExpress.XtraEditors.TextEdit txtPrix;
        private DevExpress.XtraEditors.LabelControl labelAch;
        private DevExpress.XtraEditors.LabelControl labelS;
        private System.Windows.Forms.ComboBox vend;
        private DevExpress.XtraEditors.LabelControl leNom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit description;

    }
}