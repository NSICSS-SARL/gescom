namespace gescom.create.Views
{
    partial class XtraGlobal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraGlobal));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.placeBox = new System.Windows.Forms.GroupBox();
            this.reserve = new System.Windows.Forms.RadioButton();
            this.libre = new System.Windows.Forms.RadioButton();
            this.code = new DevExpress.XtraEditors.TextEdit();
            this.labelCode = new DevExpress.XtraEditors.LabelControl();
            this.boutons = new DevExpress.XtraEditors.PanelControl();
            this.annuler = new DevExpress.XtraEditors.SimpleButton();
            this.creer = new DevExpress.XtraEditors.SimpleButton();
            this.cadre = new DevExpress.XtraEditors.PanelControl();
            this.numero = new DevExpress.XtraEditors.LabelControl();
            this.nom = new DevExpress.XtraEditors.TextEdit();
            this.labelNom = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.placeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutons)).BeginInit();
            this.boutons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadre)).BeginInit();
            this.cadre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.placeBox);
            this.panelControl1.Controls.Add(this.code);
            this.panelControl1.Controls.Add(this.labelCode);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 50);
            this.panelControl1.LookAndFeel.SkinName = "Office 2013";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(361, 74);
            this.panelControl1.TabIndex = 6;
            // 
            // placeBox
            // 
            this.placeBox.Controls.Add(this.reserve);
            this.placeBox.Controls.Add(this.libre);
            this.placeBox.Enabled = false;
            this.placeBox.Location = new System.Drawing.Point(35, 30);
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(213, 39);
            this.placeBox.TabIndex = 4;
            this.placeBox.TabStop = false;
            this.placeBox.Visible = false;
            // 
            // reserve
            // 
            this.reserve.AutoSize = true;
            this.reserve.Location = new System.Drawing.Point(120, 14);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(69, 17);
            this.reserve.TabIndex = 1;
            this.reserve.TabStop = true;
            this.reserve.Text = "Résèrver";
            this.reserve.UseVisualStyleBackColor = true;
            // 
            // libre
            // 
            this.libre.AutoSize = true;
            this.libre.Checked = true;
            this.libre.Location = new System.Drawing.Point(27, 13);
            this.libre.Name = "libre";
            this.libre.Size = new System.Drawing.Size(58, 17);
            this.libre.TabIndex = 0;
            this.libre.TabStop = true;
            this.libre.Text = "Libèrer";
            this.libre.UseVisualStyleBackColor = true;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(139, 6);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(214, 20);
            this.code.TabIndex = 3;
            this.code.ToolTip = "Abréviation entité.";
            // 
            // labelCode
            // 
            this.labelCode.Location = new System.Drawing.Point(8, 6);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(25, 13);
            this.labelCode.TabIndex = 2;
            this.labelCode.Text = "Code";
            // 
            // boutons
            // 
            this.boutons.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.boutons.Appearance.Options.UseBackColor = true;
            this.boutons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.boutons.Controls.Add(this.annuler);
            this.boutons.Controls.Add(this.creer);
            this.boutons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.boutons.Location = new System.Drawing.Point(0, 124);
            this.boutons.LookAndFeel.SkinName = "Office 2013";
            this.boutons.LookAndFeel.UseDefaultLookAndFeel = false;
            this.boutons.Name = "boutons";
            this.boutons.Size = new System.Drawing.Size(361, 37);
            this.boutons.TabIndex = 7;
            // 
            // annuler
            // 
            this.annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuler.Location = new System.Drawing.Point(186, 8);
            this.annuler.LookAndFeel.SkinName = "Office 2013";
            this.annuler.LookAndFeel.UseDefaultLookAndFeel = false;
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(64, 23);
            this.annuler.TabIndex = 3;
            this.annuler.Text = "&Annuler";
            this.annuler.ToolTip = "Annule les modifications et ferme la fenêtre";
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // creer
            // 
            this.creer.Location = new System.Drawing.Point(113, 7);
            this.creer.LookAndFeel.SkinName = "Office 2013";
            this.creer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.creer.Name = "creer";
            this.creer.Size = new System.Drawing.Size(64, 23);
            this.creer.TabIndex = 2;
            this.creer.Text = "&Créer";
            this.creer.ToolTip = "Crée l\'entité en cours";
            this.creer.Click += new System.EventHandler(this.creer_Click);
            // 
            // cadre
            // 
            this.cadre.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.cadre.Appearance.Options.UseBackColor = true;
            this.cadre.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cadre.Controls.Add(this.numero);
            this.cadre.Controls.Add(this.nom);
            this.cadre.Controls.Add(this.labelNom);
            this.cadre.Dock = System.Windows.Forms.DockStyle.Top;
            this.cadre.Location = new System.Drawing.Point(0, 0);
            this.cadre.Name = "cadre";
            this.cadre.Size = new System.Drawing.Size(361, 50);
            this.cadre.TabIndex = 5;
            // 
            // numero
            // 
            this.numero.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.numero.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.numero.Location = new System.Drawing.Point(39, 8);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(7, 13);
            this.numero.TabIndex = 4;
            this.numero.Text = "0";
            this.numero.Visible = false;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(139, 27);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(214, 20);
            this.nom.TabIndex = 3;
            this.nom.ToolTip = "Dénomination entité";
            // 
            // labelNom
            // 
            this.labelNom.Location = new System.Drawing.Point(8, 30);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(21, 13);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom";
            // 
            // XtraGlobal
            // 
            this.AcceptButton = this.creer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.annuler;
            this.ClientSize = new System.Drawing.Size(361, 161);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.boutons);
            this.Controls.Add(this.cadre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraGlobal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XtraFamille";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.placeBox.ResumeLayout(false);
            this.placeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutons)).EndInit();
            this.boutons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cadre)).EndInit();
            this.cadre.ResumeLayout(false);
            this.cadre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit code;
        private DevExpress.XtraEditors.LabelControl labelCode;
        private DevExpress.XtraEditors.PanelControl boutons;
        private DevExpress.XtraEditors.PanelControl cadre;
        private DevExpress.XtraEditors.TextEdit nom;
        private DevExpress.XtraEditors.LabelControl labelNom;
        private DevExpress.XtraEditors.SimpleButton annuler;
        private DevExpress.XtraEditors.SimpleButton creer;
        private DevExpress.XtraEditors.LabelControl numero;
        private System.Windows.Forms.GroupBox placeBox;
        private System.Windows.Forms.RadioButton reserve;
        private System.Windows.Forms.RadioButton libre;
        private readonly int _index;
        private long _id;
    }
}