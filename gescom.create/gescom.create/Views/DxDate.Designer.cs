namespace gescom.create.Views
{
    partial class DxDate
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cdf = new DevExpress.XtraEditors.LabelControl();
            this.DateAchat = new DevExpress.XtraEditors.DateEdit();
            this.DateVente = new DevExpress.XtraEditors.DateEdit();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            this.achatCtrl = new DevExpress.XtraEditors.LabelControl();
            this.venteCtrl = new DevExpress.XtraEditors.LabelControl();
            this.stockCtrl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.DateAchat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateAchat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateVente.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateVente.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date de la dérnière vente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date du dernier achat";
            // 
            // cdf
            // 
            this.cdf.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cdf.Appearance.ForeColor = System.Drawing.Color.DarkMagenta;
            this.cdf.Appearance.Options.UseFont = true;
            this.cdf.Appearance.Options.UseForeColor = true;
            this.cdf.Location = new System.Drawing.Point(34, 2);
            this.cdf.Name = "cdf";
            this.cdf.Size = new System.Drawing.Size(7, 13);
            this.cdf.TabIndex = 5;
            this.cdf.Text = "C";
            // 
            // DateAchat
            // 
            this.DateAchat.EditValue = null;
            this.DateAchat.Location = new System.Drawing.Point(200, 68);
            this.DateAchat.Name = "DateAchat";
            this.DateAchat.Properties.AllowFocused = false;
            this.DateAchat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateAchat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateAchat.Size = new System.Drawing.Size(163, 20);
            this.DateAchat.TabIndex = 7;
            // 
            // DateVente
            // 
            this.DateVente.EditValue = null;
            this.DateVente.Location = new System.Drawing.Point(200, 105);
            this.DateVente.Name = "DateVente";
            this.DateVente.Properties.AllowFocused = false;
            this.DateVente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateVente.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateVente.Size = new System.Drawing.Size(163, 20);
            this.DateVente.TabIndex = 8;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(258, 140);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "OK";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // achatCtrl
            // 
            this.achatCtrl.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.achatCtrl.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.achatCtrl.Appearance.Options.UseFont = true;
            this.achatCtrl.Appearance.Options.UseForeColor = true;
            this.achatCtrl.Location = new System.Drawing.Point(78, 25);
            this.achatCtrl.Name = "achatCtrl";
            this.achatCtrl.Size = new System.Drawing.Size(7, 13);
            this.achatCtrl.TabIndex = 10;
            this.achatCtrl.Text = "0";
            // 
            // venteCtrl
            // 
            this.venteCtrl.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.venteCtrl.Appearance.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.venteCtrl.Appearance.Options.UseFont = true;
            this.venteCtrl.Appearance.Options.UseForeColor = true;
            this.venteCtrl.Location = new System.Drawing.Point(169, 25);
            this.venteCtrl.Name = "venteCtrl";
            this.venteCtrl.Size = new System.Drawing.Size(7, 13);
            this.venteCtrl.TabIndex = 11;
            this.venteCtrl.Text = "0";
            // 
            // stockCtrl
            // 
            this.stockCtrl.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.stockCtrl.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.stockCtrl.Appearance.Options.UseFont = true;
            this.stockCtrl.Appearance.Options.UseForeColor = true;
            this.stockCtrl.Location = new System.Drawing.Point(258, 25);
            this.stockCtrl.Name = "stockCtrl";
            this.stockCtrl.Size = new System.Drawing.Size(7, 13);
            this.stockCtrl.TabIndex = 12;
            this.stockCtrl.Text = "0";
            // 
            // DxDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 172);
            this.Controls.Add(this.stockCtrl);
            this.Controls.Add(this.venteCtrl);
            this.Controls.Add(this.achatCtrl);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.DateVente);
            this.Controls.Add(this.DateAchat);
            this.Controls.Add(this.cdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DxDate";
            this.Text = "DxDate";
            ((System.ComponentModel.ISupportInitialize)(this.DateAchat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateAchat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateVente.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateVente.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl cdf;
        private DevExpress.XtraEditors.DateEdit DateAchat;
        private DevExpress.XtraEditors.DateEdit DateVente;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraEditors.LabelControl achatCtrl;
        private DevExpress.XtraEditors.LabelControl venteCtrl;
        private DevExpress.XtraEditors.LabelControl stockCtrl;
    }
}