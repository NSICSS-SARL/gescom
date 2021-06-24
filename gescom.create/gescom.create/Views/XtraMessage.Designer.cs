using System.Windows.Forms;

namespace gescom.create.Views
{
    partial class XtraMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraMessage));
            this.groupe1 = new DevExpress.XtraEditors.GroupControl();
            this.b2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.b1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.t1 = new DevExpress.XtraEditors.TextEdit();
            this.q1 = new DevExpress.XtraEditors.SpinEdit();
            this.s1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tete = new DevExpress.XtraEditors.PanelControl();
            this.d2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.d1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.leNom = new DevExpress.XtraEditors.LabelControl();
            this.codage = new DevExpress.XtraEditors.LabelControl();
            this.codex = new DevExpress.XtraEditors.LabelControl();
            this.nombre = new DevExpress.XtraEditors.LabelControl();
            this.labelNums = new DevExpress.XtraEditors.LabelControl();
            this.dernier = new DevExpress.XtraEditors.PanelControl();
            this.checkEntre = new DevExpress.XtraEditors.CheckEdit();
            this.checkPrix = new DevExpress.XtraEditors.CheckEdit();
            this.fermer = new DevExpress.XtraEditors.SimpleButton();
            this.creer = new DevExpress.XtraEditors.SimpleButton();
            this.ultraGroupBox1 = new System.Windows.Forms.GroupBox();
            this.q = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.s = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupe1)).BeginInit();
            this.groupe1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tete)).BeginInit();
            this.tete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dernier)).BeginInit();
            this.dernier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEntre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPrix.Properties)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupe1
            // 
            this.groupe1.Controls.Add(this.b2);
            this.groupe1.Controls.Add(this.labelControl8);
            this.groupe1.Controls.Add(this.b1);
            this.groupe1.Controls.Add(this.labelControl3);
            this.groupe1.Controls.Add(this.t1);
            this.groupe1.Controls.Add(this.q1);
            this.groupe1.Controls.Add(this.s1);
            this.groupe1.Controls.Add(this.labelControl2);
            this.groupe1.Controls.Add(this.labelControl1);
            this.groupe1.Location = new System.Drawing.Point(5, 139);
            this.groupe1.Name = "groupe1";
            this.groupe1.Size = new System.Drawing.Size(512, 103);
            this.groupe1.TabIndex = 0;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(272, 74);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(222, 20);
            this.b2.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(198, 79);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(63, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Transporteur";
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(272, 21);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(222, 20);
            this.b1.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Date-Facture";
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(122, 21);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(139, 20);
            this.t1.TabIndex = 0;
            // 
            // q1
            // 
            this.q1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.q1.Location = new System.Drawing.Point(122, 74);
            this.q1.Name = "q1";
            this.q1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.q1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.q1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.q1.Properties.IsFloatValue = false;
            this.q1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.q1.Properties.Mask.EditMask = "N00";
            this.q1.Size = new System.Drawing.Size(62, 20);
            this.q1.TabIndex = 3;
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(122, 47);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(250, 20);
            this.s1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Quantité dénombrable";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Message";
            // 
            // tete
            // 
            this.tete.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tete.Controls.Add(this.d2);
            this.tete.Controls.Add(this.labelControl6);
            this.tete.Controls.Add(this.d1);
            this.tete.Controls.Add(this.labelControl5);
            this.tete.Controls.Add(this.leNom);
            this.tete.Controls.Add(this.codage);
            this.tete.Controls.Add(this.codex);
            this.tete.Controls.Add(this.nombre);
            this.tete.Controls.Add(this.labelNums);
            this.tete.Dock = System.Windows.Forms.DockStyle.Top;
            this.tete.Location = new System.Drawing.Point(0, 0);
            this.tete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tete.Name = "tete";
            this.tete.Size = new System.Drawing.Size(532, 84);
            this.tete.TabIndex = 1;
            // 
            // d2
            // 
            this.d2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.d2.Appearance.Options.UseFont = true;
            this.d2.Appearance.Options.UseForeColor = true;
            this.d2.Location = new System.Drawing.Point(326, 60);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(7, 13);
            this.d2.TabIndex = 9;
            this.d2.Text = "0";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(237, 60);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Date comptage";
            // 
            // d1
            // 
            this.d1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1.Appearance.ForeColor = System.Drawing.Color.SlateBlue;
            this.d1.Appearance.Options.UseFont = true;
            this.d1.Appearance.Options.UseForeColor = true;
            this.d1.Location = new System.Drawing.Point(72, 60);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(7, 13);
            this.d1.TabIndex = 7;
            this.d1.Text = "0";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 60);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Date ordre";
            // 
            // leNom
            // 
            this.leNom.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.leNom.Appearance.ForeColor = System.Drawing.Color.DarkMagenta;
            this.leNom.Appearance.Options.UseFont = true;
            this.leNom.Appearance.Options.UseForeColor = true;
            this.leNom.Location = new System.Drawing.Point(72, 34);
            this.leNom.Name = "leNom";
            this.leNom.Size = new System.Drawing.Size(7, 13);
            this.leNom.TabIndex = 5;
            this.leNom.Text = "0";
            // 
            // codage
            // 
            this.codage.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.codage.Appearance.ForeColor = System.Drawing.Color.DarkMagenta;
            this.codage.Appearance.Options.UseFont = true;
            this.codage.Appearance.Options.UseForeColor = true;
            this.codage.Location = new System.Drawing.Point(188, 7);
            this.codage.Name = "codage";
            this.codage.Size = new System.Drawing.Size(29, 13);
            this.codage.TabIndex = 3;
            this.codage.Text = "CODE";
            // 
            // codex
            // 
            this.codex.Location = new System.Drawing.Point(120, 6);
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
            this.nombre.Appearance.Options.UseFont = true;
            this.nombre.Appearance.Options.UseForeColor = true;
            this.nombre.Location = new System.Drawing.Point(72, 6);
            this.nombre.LookAndFeel.SkinName = "Office 2010 Silver";
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(7, 13);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "0";
            // 
            // labelNums
            // 
            this.labelNums.Location = new System.Drawing.Point(16, 6);
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
            this.dernier.Controls.Add(this.checkEntre);
            this.dernier.Controls.Add(this.checkPrix);
            this.dernier.Controls.Add(this.fermer);
            this.dernier.Controls.Add(this.creer);
            this.dernier.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dernier.Location = new System.Drawing.Point(0, 245);
            this.dernier.Name = "dernier";
            this.dernier.Size = new System.Drawing.Size(532, 31);
            this.dernier.TabIndex = 4;
            // 
            // checkEntre
            // 
            this.checkEntre.Location = new System.Drawing.Point(88, 6);
            this.checkEntre.Name = "checkEntre";
            this.checkEntre.Properties.Caption = "Entrer";
            this.checkEntre.Size = new System.Drawing.Size(68, 19);
            this.checkEntre.TabIndex = 22;
            // 
            // checkPrix
            // 
            this.checkPrix.Location = new System.Drawing.Point(15, 6);
            this.checkPrix.Name = "checkPrix";
            this.checkPrix.Properties.Caption = "Prix";
            this.checkPrix.Size = new System.Drawing.Size(98, 19);
            this.checkPrix.TabIndex = 21;
            // 
            // fermer
            // 
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fermer.Location = new System.Drawing.Point(421, 5);
            this.fermer.LookAndFeel.SkinName = "Office 2013";
            this.fermer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 1;
            this.fermer.Text = "&Fermer";
            this.fermer.ToolTip = "Modifier l\'article en cours.";
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // creer
            // 
            this.creer.Location = new System.Drawing.Point(162, 4);
            this.creer.LookAndFeel.SkinName = "Office 2013";
            this.creer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.creer.Name = "creer";
            this.creer.Size = new System.Drawing.Size(75, 23);
            this.creer.TabIndex = 0;
            this.creer.Text = "&OK";
            this.creer.ToolTip = "Modifier l\'article en cours.";
            this.creer.Click += new System.EventHandler(this.creer_Click);
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.q);
            this.ultraGroupBox1.Controls.Add(this.labelControl7);
            this.ultraGroupBox1.Controls.Add(this.s);
            this.ultraGroupBox1.Controls.Add(this.labelControl4);
            this.ultraGroupBox1.Location = new System.Drawing.Point(5, 85);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(512, 58);
            this.ultraGroupBox1.TabIndex = 5;
            this.ultraGroupBox1.TabStop = false;
            this.ultraGroupBox1.Text = "Informations";
            // 
            // q
            // 
            this.q.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q.Appearance.Options.UseFont = true;
            this.q.Location = new System.Drawing.Point(448, 24);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(7, 13);
            this.q.TabIndex = 4;
            this.q.Text = "q";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(328, 24);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(107, 13);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "Quantité dénombrable";
            // 
            // s
            // 
            this.s.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Appearance.Options.UseFont = true;
            this.s.Location = new System.Drawing.Point(115, 24);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(6, 13);
            this.s.TabIndex = 2;
            this.s.Text = "s";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(67, 24);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(23, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Note";
            // 
            // XtraMessage
            // 
            this.AcceptButton = this.creer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fermer;
            this.ClientSize = new System.Drawing.Size(532, 276);
            this.Controls.Add(this.ultraGroupBox1);
            this.Controls.Add(this.dernier);
            this.Controls.Add(this.tete);
            this.Controls.Add(this.groupe1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTAIRE-COMPTAGE";
            ((System.ComponentModel.ISupportInitialize)(this.groupe1)).EndInit();
            this.groupe1.ResumeLayout(false);
            this.groupe1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tete)).EndInit();
            this.tete.ResumeLayout(false);
            this.tete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dernier)).EndInit();
            this.dernier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEntre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPrix.Properties)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupe1;
        private DevExpress.XtraEditors.PanelControl tete;
        private DevExpress.XtraEditors.LabelControl leNom;
        private DevExpress.XtraEditors.LabelControl codage;
        private DevExpress.XtraEditors.LabelControl codex;
        private DevExpress.XtraEditors.LabelControl nombre;
        private DevExpress.XtraEditors.LabelControl labelNums;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl dernier;
        public DevExpress.XtraEditors.SimpleButton creer;
        private DevExpress.XtraEditors.TextEdit s1;
        private DevExpress.XtraEditors.SpinEdit q1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl d1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl d2;
        private System.Windows.Forms.GroupBox ultraGroupBox1;
        private DevExpress.XtraEditors.TextEdit t1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl s;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl q;
        private DevExpress.XtraEditors.TextEdit b1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit b2;
        public DevExpress.XtraEditors.SimpleButton fermer;
        private DevExpress.XtraEditors.CheckEdit checkEntre;
        private DevExpress.XtraEditors.CheckEdit checkPrix;
    }
}