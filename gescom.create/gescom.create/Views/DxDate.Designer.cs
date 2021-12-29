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
            this.nombre = new DevExpress.XtraEditors.LabelControl();
            this.DateAchat = new DevExpress.XtraEditors.DateEdit();
            this.DateVente = new DevExpress.XtraEditors.DateEdit();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DateAchat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateAchat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateVente.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateVente.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date de la dérnière vente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
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
            this.cdf.Location = new System.Drawing.Point(145, 4);
            this.cdf.Name = "cdf";
            this.cdf.Size = new System.Drawing.Size(7, 13);
            this.cdf.TabIndex = 5;
            this.cdf.Text = "C";
            // 
            // nombre
            // 
            this.nombre.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nombre.Appearance.ForeColor = System.Drawing.Color.DarkMagenta;
            this.nombre.Appearance.Options.UseFont = true;
            this.nombre.Appearance.Options.UseForeColor = true;
            this.nombre.Location = new System.Drawing.Point(34, 5);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(7, 13);
            this.nombre.TabIndex = 4;
            this.nombre.Text = "0";
            // 
            // DateAchat
            // 
            this.DateAchat.EditValue = null;
            this.DateAchat.Location = new System.Drawing.Point(200, 53);
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
            this.DateVente.Location = new System.Drawing.Point(200, 90);
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
            this.closeButton.Location = new System.Drawing.Point(258, 125);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "OK";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // DxDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 172);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.DateVente);
            this.Controls.Add(this.DateAchat);
            this.Controls.Add(this.cdf);
            this.Controls.Add(this.nombre);
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
        private DevExpress.XtraEditors.LabelControl nombre;
        private DevExpress.XtraEditors.DateEdit DateAchat;
        private DevExpress.XtraEditors.DateEdit DateVente;
        private DevExpress.XtraEditors.SimpleButton closeButton;
    }
}