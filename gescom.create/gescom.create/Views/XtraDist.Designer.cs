namespace gescom.create.Views
{
    partial class XtraDist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraDist));
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
            this.obsEdit = new DevExpress.XtraEditors.MemoEdit();
            this.labelObs = new DevExpress.XtraEditors.LabelControl();
            this.remarkEdit = new DevExpress.XtraEditors.MemoEdit();
            this.lambeRk = new DevExpress.XtraEditors.LabelControl();
            this.labelSeuil = new DevExpress.XtraEditors.LabelControl();
            this.txtQte = new DevExpress.XtraEditors.TextEdit();
            this.newPlace = new DevExpress.XtraEditors.LabelControl();
            this.newLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelPlace = new DevExpress.XtraEditors.LabelControl();
            this.placement = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.obsEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQte.Properties)).BeginInit();
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
            this.tete.Size = new System.Drawing.Size(412, 52);
            this.tete.TabIndex = 5;
            // 
            // leNom
            // 
            this.leNom.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.leNom.Appearance.ForeColor = System.Drawing.Color.DarkMagenta;
            this.leNom.Location = new System.Drawing.Point(66, 32);
            this.leNom.Name = "leNom";
            this.leNom.Size = new System.Drawing.Size(7, 13);
            this.leNom.TabIndex = 4;
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
            // 
            // dernier
            // 
            this.dernier.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dernier.Controls.Add(this.annuler);
            this.dernier.Controls.Add(this.creer);
            this.dernier.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dernier.Location = new System.Drawing.Point(0, 276);
            this.dernier.Name = "dernier";
            this.dernier.Size = new System.Drawing.Size(412, 31);
            this.dernier.TabIndex = 4;
            // 
            // annuler
            // 
            this.annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuler.Location = new System.Drawing.Point(319, 4);
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
            this.creer.Location = new System.Drawing.Point(237, 4);
            this.creer.LookAndFeel.SkinName = "Office 2013";
            this.creer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.creer.Name = "creer";
            this.creer.Size = new System.Drawing.Size(75, 23);
            this.creer.TabIndex = 0;
            this.creer.Text = "&Enregistrer";
            this.creer.ToolTip = "Modifier l\'article en cours.";
            this.creer.Click += new System.EventHandler(this.creer_Click);
            // 
            // cadre
            // 
            this.cadre.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cadre.Controls.Add(this.obsEdit);
            this.cadre.Controls.Add(this.labelObs);
            this.cadre.Controls.Add(this.remarkEdit);
            this.cadre.Controls.Add(this.lambeRk);
            this.cadre.Controls.Add(this.labelSeuil);
            this.cadre.Controls.Add(this.txtQte);
            this.cadre.Controls.Add(this.newPlace);
            this.cadre.Controls.Add(this.newLabel);
            this.cadre.Controls.Add(this.labelPlace);
            this.cadre.Controls.Add(this.placement);
            this.cadre.Controls.Add(this.txtNom);
            this.cadre.Controls.Add(this.labelUnite);
            this.cadre.Controls.Add(this.labelRef);
            this.cadre.Controls.Add(this.labelNom);
            this.cadre.Location = new System.Drawing.Point(0, 51);
            this.cadre.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cadre.Name = "cadre";
            this.cadre.Size = new System.Drawing.Size(412, 223);
            this.cadre.TabIndex = 1;
            // 
            // obsEdit
            // 
            this.obsEdit.Location = new System.Drawing.Point(129, 183);
            this.obsEdit.Name = "obsEdit";
            this.obsEdit.Size = new System.Drawing.Size(266, 35);
            this.obsEdit.TabIndex = 20;
            // 
            // labelObs
            // 
            this.labelObs.Location = new System.Drawing.Point(13, 176);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(59, 13);
            this.labelObs.TabIndex = 19;
            this.labelObs.Text = "Observation";
            // 
            // remarkEdit
            // 
            this.remarkEdit.Location = new System.Drawing.Point(130, 136);
            this.remarkEdit.Name = "remarkEdit";
            this.remarkEdit.Size = new System.Drawing.Size(266, 35);
            this.remarkEdit.TabIndex = 18;
            // 
            // lambeRk
            // 
            this.lambeRk.Location = new System.Drawing.Point(14, 134);
            this.lambeRk.Name = "lambeRk";
            this.lambeRk.Size = new System.Drawing.Size(49, 13);
            this.lambeRk.TabIndex = 17;
            this.lambeRk.Text = "Remarque";
            // 
            // labelSeuil
            // 
            this.labelSeuil.Location = new System.Drawing.Point(14, 106);
            this.labelSeuil.Name = "labelSeuil";
            this.labelSeuil.Size = new System.Drawing.Size(68, 13);
            this.labelSeuil.TabIndex = 16;
            this.labelSeuil.Text = "Seuil de vente";
            // 
            // txtQte
            // 
            this.txtQte.EditValue = "0";
            this.txtQte.Location = new System.Drawing.Point(129, 102);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(71, 20);
            this.txtQte.TabIndex = 3;
            this.txtQte.ToolTip = "Quantité minimale pour stock.";
            // 
            // newPlace
            // 
            this.newPlace.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.newPlace.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.newPlace.Location = new System.Drawing.Point(132, 83);
            this.newPlace.Name = "newPlace";
            this.newPlace.Size = new System.Drawing.Size(0, 13);
            this.newPlace.TabIndex = 6;
            this.newPlace.Visible = false;
            // 
            // newLabel
            // 
            this.newLabel.Location = new System.Drawing.Point(13, 81);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(69, 13);
            this.newLabel.TabIndex = 5;
            this.newLabel.Text = "Nouvelle place";
            this.newLabel.Visible = false;
            // 
            // labelPlace
            // 
            this.labelPlace.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelPlace.Appearance.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelPlace.Location = new System.Drawing.Point(132, 31);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(38, 13);
            this.labelPlace.TabIndex = 4;
            this.labelPlace.Text = "AUCUN";
            this.labelPlace.ToolTip = "Emplacement actuel du produit.";
            // 
            // placement
            // 
            this.placement.DisplayMember = "NOM";
            this.placement.FormattingEnabled = true;
            this.placement.Location = new System.Drawing.Point(128, 51);
            this.placement.Name = "placement";
            this.placement.Size = new System.Drawing.Size(170, 21);
            this.placement.TabIndex = 2;
            this.placement.SelectedValueChanged += new System.EventHandler(this.placement_SelectedValueChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(128, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(268, 20);
            this.txtNom.TabIndex = 0;
            this.txtNom.ToolTip = "Nom commun connu du client.";
            // 
            // labelUnite
            // 
            this.labelUnite.Location = new System.Drawing.Point(13, 56);
            this.labelUnite.Name = "labelUnite";
            this.labelUnite.Size = new System.Drawing.Size(78, 13);
            this.labelUnite.TabIndex = 3;
            this.labelUnite.Text = "Place éventuelle";
            // 
            // labelRef
            // 
            this.labelRef.Location = new System.Drawing.Point(13, 31);
            this.labelRef.Name = "labelRef";
            this.labelRef.Size = new System.Drawing.Size(65, 13);
            this.labelRef.TabIndex = 1;
            this.labelRef.Text = "Place actuelle";
            // 
            // labelNom
            // 
            this.labelNom.Location = new System.Drawing.Point(13, 6);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(72, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Co-désignation";
            // 
            // XtraDist
            // 
            this.AcceptButton = this.creer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.annuler;
            this.ClientSize = new System.Drawing.Size(412, 307);
            this.Controls.Add(this.cadre);
            this.Controls.Add(this.dernier);
            this.Controls.Add(this.tete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraDist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XtraDist";
            ((System.ComponentModel.ISupportInitialize)(this.tete)).EndInit();
            this.tete.ResumeLayout(false);
            this.tete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dernier)).EndInit();
            this.dernier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cadre)).EndInit();
            this.cadre.ResumeLayout(false);
            this.cadre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obsEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQte.Properties)).EndInit();
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
        private System.Windows.Forms.ComboBox placement;
        private DevExpress.XtraEditors.TextEdit txtNom;
        private DevExpress.XtraEditors.LabelControl labelUnite;
        private DevExpress.XtraEditors.LabelControl labelRef;
        private DevExpress.XtraEditors.LabelControl labelNom;
        private DevExpress.XtraEditors.LabelControl labelPlace;
        private DevExpress.XtraEditors.LabelControl newLabel;
        private DevExpress.XtraEditors.LabelControl newPlace;
        private DevExpress.XtraEditors.LabelControl labelSeuil;
        private DevExpress.XtraEditors.TextEdit txtQte;
        private DevExpress.XtraEditors.LabelControl lambeRk;
        private DevExpress.XtraEditors.MemoEdit remarkEdit;
        private DevExpress.XtraEditors.LabelControl leNom;
        private DevExpress.XtraEditors.LabelControl labelObs;
        private DevExpress.XtraEditors.MemoEdit obsEdit;
    }
}