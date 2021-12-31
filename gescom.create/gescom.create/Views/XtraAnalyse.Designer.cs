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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tache = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ppfrs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dates = new DevExpress.XtraGrid.Columns.GridColumn();
            this.msg = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(620, 150);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tache,
            this.quantite,
            this.ppfrs,
            this.dates,
            this.msg});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // tache
            // 
            this.tache.Caption = "Tâches";
            this.tache.Name = "tache";
            this.tache.Visible = true;
            this.tache.VisibleIndex = 0;
            // 
            // quantite
            // 
            this.quantite.Caption = "Qté";
            this.quantite.Name = "quantite";
            this.quantite.Visible = true;
            this.quantite.VisibleIndex = 1;
            // 
            // ppfrs
            // 
            this.ppfrs.Caption = "P/FRS";
            this.ppfrs.Name = "ppfrs";
            this.ppfrs.Visible = true;
            this.ppfrs.VisibleIndex = 2;
            // 
            // dates
            // 
            this.dates.Caption = "DATE";
            this.dates.Name = "dates";
            this.dates.Visible = true;
            this.dates.VisibleIndex = 3;
            // 
            // msg
            // 
            this.msg.Caption = "MESSAGE";
            this.msg.Name = "msg";
            this.msg.Visible = true;
            this.msg.VisibleIndex = 4;
            // 
            // XtraAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "XtraAnalyse";
            this.Size = new System.Drawing.Size(620, 150);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn tache;
        private DevExpress.XtraGrid.Columns.GridColumn quantite;
        private DevExpress.XtraGrid.Columns.GridColumn ppfrs;
        private DevExpress.XtraGrid.Columns.GridColumn dates;
        private DevExpress.XtraGrid.Columns.GridColumn msg;
    }
}
