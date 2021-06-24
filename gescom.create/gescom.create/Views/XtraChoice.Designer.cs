namespace gescom.create.Views
{
    partial class XtraChoice
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
            this.nom = new System.Windows.Forms.ComboBox();
            this.creer = new DevExpress.XtraEditors.SimpleButton();
            this.myNum = new DevExpress.XtraEditors.LabelControl();
            this.typage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CLASSEUR";
            // 
            // nom
            // 
            this.nom.DisplayMember = "Code";
            this.nom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nom.FormattingEnabled = true;
            this.nom.Location = new System.Drawing.Point(72, 18);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(306, 21);
            this.nom.TabIndex = 4;
            // 
            // creer
            // 
            this.creer.Location = new System.Drawing.Point(302, 54);
            this.creer.Name = "creer";
            this.creer.Size = new System.Drawing.Size(75, 29);
            this.creer.TabIndex = 5;
            this.creer.Text = "OK";
            this.creer.Click += new System.EventHandler(this.creer_Click);
            // 
            // myNum
            // 
            this.myNum.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.myNum.Location = new System.Drawing.Point(196, 51);
            this.myNum.Name = "myNum";
            this.myNum.Size = new System.Drawing.Size(6, 13);
            this.myNum.TabIndex = 7;
            this.myNum.Text = "0";
            // 
            // typage
            // 
            this.typage.AutoSize = true;
            this.typage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.typage.Location = new System.Drawing.Point(20, 92);
            this.typage.Name = "typage";
            this.typage.Size = new System.Drawing.Size(32, 13);
            this.typage.TabIndex = 8;
            this.typage.Text = "INFO";
            // 
            // XtraChoice
            // 
            this.AcceptButton = this.creer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 114);
            this.Controls.Add(this.typage);
            this.Controls.Add(this.myNum);
            this.Controls.Add(this.creer);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENTREE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox nom;
        private DevExpress.XtraEditors.SimpleButton creer;
        private DevExpress.XtraEditors.LabelControl myNum;
        private System.Windows.Forms.Label typage;
    }
}