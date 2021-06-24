namespace gescom.create.Views
{
    partial class XtraPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraPrint));
            this.placeBox = new System.Windows.Forms.GroupBox();
            this.facture = new System.Windows.Forms.RadioButton();
            this.ticket = new System.Windows.Forms.RadioButton();
            this.imprimer = new DevExpress.XtraEditors.SimpleButton();
            this.annuler = new DevExpress.XtraEditors.SimpleButton();
            this.placeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // placeBox
            // 
            this.placeBox.Controls.Add(this.facture);
            this.placeBox.Controls.Add(this.ticket);
            this.placeBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.placeBox.Location = new System.Drawing.Point(0, 0);
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(250, 89);
            this.placeBox.TabIndex = 5;
            this.placeBox.TabStop = false;
            // 
            // facture
            // 
            this.facture.AutoSize = true;
            this.facture.Location = new System.Drawing.Point(27, 55);
            this.facture.Name = "facture";
            this.facture.Size = new System.Drawing.Size(62, 17);
            this.facture.TabIndex = 1;
            this.facture.TabStop = true;
            this.facture.Text = "Facture";
            this.facture.UseVisualStyleBackColor = true;
            // 
            // ticket
            // 
            this.ticket.AutoSize = true;
            this.ticket.Checked = true;
            this.ticket.Location = new System.Drawing.Point(27, 13);
            this.ticket.Name = "ticket";
            this.ticket.Size = new System.Drawing.Size(53, 17);
            this.ticket.TabIndex = 0;
            this.ticket.TabStop = true;
            this.ticket.Text = "Ticket";
            this.ticket.UseVisualStyleBackColor = true;
            // 
            // imprimer
            // 
            this.imprimer.Location = new System.Drawing.Point(13, 98);
            this.imprimer.LookAndFeel.SkinName = "Office 2013";
            this.imprimer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(104, 34);
            this.imprimer.TabIndex = 6;
            this.imprimer.Text = "Im&primer";
            this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
            // 
            // annuler
            // 
            this.annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuler.Location = new System.Drawing.Point(132, 98);
            this.annuler.LookAndFeel.SkinName = "Office 2013";
            this.annuler.LookAndFeel.UseDefaultLookAndFeel = false;
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(104, 34);
            this.annuler.TabIndex = 7;
            this.annuler.Text = "&Annuler";
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // XtraPrint
            // 
            this.AcceptButton = this.imprimer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.annuler;
            this.ClientSize = new System.Drawing.Size(250, 144);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.imprimer);
            this.Controls.Add(this.placeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMPRESSION FACTURE";
            this.placeBox.ResumeLayout(false);
            this.placeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox placeBox;
        private System.Windows.Forms.RadioButton facture;
        private System.Windows.Forms.RadioButton ticket;
        private DevExpress.XtraEditors.SimpleButton imprimer;
        private DevExpress.XtraEditors.SimpleButton annuler;
    }
}