namespace gescom.create.Views
{
    partial class XtraPeriode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraPeriode));
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelFin = new DevExpress.XtraEditors.LabelControl();
            this.labelDebut = new DevExpress.XtraEditors.LabelControl();
            this.debut = new System.Windows.Forms.DateTimePicker();
            this.fin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(170, 79);
            this.saveButton.LookAndFeel.SkinName = "Office 2013";
            this.saveButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "&OK";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // labelFin
            // 
            this.labelFin.Location = new System.Drawing.Point(12, 52);
            this.labelFin.LookAndFeel.SkinName = "Office 2013";
            this.labelFin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(38, 13);
            this.labelFin.TabIndex = 8;
            this.labelFin.Text = "Date fin";
            this.labelFin.Visible = false;
            // 
            // labelDebut
            // 
            this.labelDebut.Location = new System.Drawing.Point(12, 15);
            this.labelDebut.LookAndFeel.SkinName = "Office 2013";
            this.labelDebut.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelDebut.Name = "labelDebut";
            this.labelDebut.Size = new System.Drawing.Size(54, 13);
            this.labelDebut.TabIndex = 7;
            this.labelDebut.Text = "Date début";
            this.labelDebut.Visible = false;
            // 
            // debut
            // 
            this.debut.Location = new System.Drawing.Point(78, 12);
            this.debut.Name = "debut";
            this.debut.Size = new System.Drawing.Size(173, 21);
            this.debut.TabIndex = 10;
            // 
            // fin
            // 
            this.fin.Location = new System.Drawing.Point(78, 46);
            this.fin.Name = "fin";
            this.fin.Size = new System.Drawing.Size(173, 21);
            this.fin.TabIndex = 11;
            // 
            // XtraPeriode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 114);
            this.Controls.Add(this.fin);
            this.Controls.Add(this.debut);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.labelFin);
            this.Controls.Add(this.labelDebut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraPeriode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SELECTION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.LabelControl labelFin;
        private DevExpress.XtraEditors.LabelControl labelDebut;
        private System.Windows.Forms.DateTimePicker debut;
        private System.Windows.Forms.DateTimePicker fin;


    }
}