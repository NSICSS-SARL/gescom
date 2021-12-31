namespace gescom.create.Views
{
    partial class XtraAnalyse
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cadreNew = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cadreNew)).BeginInit();
            this.SuspendLayout();
            // 
            // cadreNew
            // 
            this.cadreNew.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cadreNew.Location = new System.Drawing.Point(68, 3);
            this.cadreNew.LookAndFeel.SkinName = "Office 2013";
            this.cadreNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cadreNew.Name = "cadreNew";
            this.cadreNew.Size = new System.Drawing.Size(485, 145);
            this.cadreNew.TabIndex = 12;
            // 
            // XtraAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cadreNew);
            this.Name = "XtraAnalyse";
            this.Size = new System.Drawing.Size(620, 150);
            ((System.ComponentModel.ISupportInitialize)(this.cadreNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl cadreNew;
    }
}
