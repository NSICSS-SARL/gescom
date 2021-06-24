namespace gescom.create.Views
{
    partial class CustomerAdress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerAdress));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textAdress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.creer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(78, 10);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(222, 20);
            this.textNom.TabIndex = 2;
            // 
            // textAdress
            // 
            this.textAdress.Location = new System.Drawing.Point(78, 45);
            this.textAdress.Name = "textAdress";
            this.textAdress.Size = new System.Drawing.Size(222, 20);
            this.textAdress.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.creer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 39);
            this.panel1.TabIndex = 4;
            // 
            // creer
            // 
            this.creer.Location = new System.Drawing.Point(225, 6);
            this.creer.Name = "creer";
            this.creer.Size = new System.Drawing.Size(75, 26);
            this.creer.TabIndex = 0;
            this.creer.Text = "OK";
            this.creer.UseVisualStyleBackColor = true;
            this.creer.Click += new System.EventHandler(this.creer_Click);
            // 
            // CustomerAdress
            // 
            this.AcceptButton = this.creer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 110);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textAdress);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerAdress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INFORMATIONS";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textAdress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button creer;
    }
}