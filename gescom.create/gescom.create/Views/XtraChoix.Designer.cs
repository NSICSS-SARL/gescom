namespace gescom.create.Views
{
    partial class XtraChoix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraChoix));
            this.labelNum = new DevExpress.XtraEditors.LabelControl();
            this.creer = new DevExpress.XtraEditors.SimpleButton();
            this.textNum = new System.Windows.Forms.TextBox();
            this.textRec = new System.Windows.Forms.TextBox();
            this.labelRec = new DevExpress.XtraEditors.LabelControl();
            this.infoStrip = new System.Windows.Forms.StatusStrip();
            this.worker = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNum
            // 
            this.labelNum.Location = new System.Drawing.Point(83, 14);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(81, 13);
            this.labelNum.TabIndex = 2;
            this.labelNum.Text = "NUMERO CLIENT";
            // 
            // creer
            // 
            this.creer.Enabled = false;
            this.creer.Location = new System.Drawing.Point(223, 82);
            this.creer.LookAndFeel.SkinName = "Office 2013";
            this.creer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.creer.Name = "creer";
            this.creer.Size = new System.Drawing.Size(70, 26);
            this.creer.TabIndex = 3;
            this.creer.Text = "OK";
            this.creer.Click += new System.EventHandler(this.creer_Click);
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(223, 11);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(70, 21);
            this.textNum.TabIndex = 1;
            this.textNum.TextChanged += new System.EventHandler(this.textNum_TextChanged);
            // 
            // textRec
            // 
            this.textRec.Location = new System.Drawing.Point(223, 43);
            this.textRec.Name = "textRec";
            this.textRec.Size = new System.Drawing.Size(70, 21);
            this.textRec.TabIndex = 12;
            this.textRec.Visible = false;
            this.textRec.TextChanged += new System.EventHandler(this.textRec_TextChanged);
            // 
            // labelRec
            // 
            this.labelRec.Location = new System.Drawing.Point(83, 46);
            this.labelRec.Name = "labelRec";
            this.labelRec.Size = new System.Drawing.Size(103, 13);
            this.labelRec.TabIndex = 13;
            this.labelRec.Text = "NUMERO RECEPTION";
            this.labelRec.Visible = false;
            // 
            // infoStrip
            // 
            this.infoStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.worker});
            this.infoStrip.Location = new System.Drawing.Point(0, 111);
            this.infoStrip.Name = "infoStrip";
            this.infoStrip.Size = new System.Drawing.Size(313, 22);
            this.infoStrip.TabIndex = 15;
            this.infoStrip.Text = "statusStrip1";
            // 
            // worker
            // 
            this.worker.Name = "worker";
            this.worker.Size = new System.Drawing.Size(0, 17);
            this.worker.Visible = false;
            // 
            // XtraChoix
            // 
            this.AcceptButton = this.creer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 133);
            this.Controls.Add(this.infoStrip);
            this.Controls.Add(this.textRec);
            this.Controls.Add(this.labelRec);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.creer);
            this.Controls.Add(this.labelNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraChoix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTE";
            this.infoStrip.ResumeLayout(false);
            this.infoStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelNum;
        private DevExpress.XtraEditors.SimpleButton creer;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.TextBox textRec;
        private DevExpress.XtraEditors.LabelControl labelRec;
        private System.Windows.Forms.StatusStrip infoStrip;
        private System.Windows.Forms.ToolStripStatusLabel worker;
    }
}