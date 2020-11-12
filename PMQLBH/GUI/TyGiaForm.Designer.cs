namespace PMQLBH.GUI
{
    partial class TyGiaForm
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
            this.groupControl1 = new PMQLBH.GroupControlArea();
            this.GcExchangeRate = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colExchangeRateID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExchangeRate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GcExchangeRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 28);
            this.groupControl1.TabIndex = 2;
            // 
            // GcExchangeRate
            // 
            this.GcExchangeRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GcExchangeRate.Location = new System.Drawing.Point(0, 28);
            this.GcExchangeRate.MainView = this.gridView1;
            this.GcExchangeRate.Name = "GcExchangeRate";
            this.GcExchangeRate.Size = new System.Drawing.Size(800, 422);
            this.GcExchangeRate.TabIndex = 3;
            this.GcExchangeRate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colExchangeRateID,
            this.colName,
            this.colExchangeRate});
            this.gridView1.GridControl = this.GcExchangeRate;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colExchangeRateID
            // 
            this.colExchangeRateID.FieldName = "ExchangeRateID";
            this.colExchangeRateID.Name = "colExchangeRateID";
            this.colExchangeRateID.Visible = true;
            this.colExchangeRateID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colExchangeRate
            // 
            this.colExchangeRate.FieldName = "ExchangeRate";
            this.colExchangeRate.Name = "colExchangeRate";
            this.colExchangeRate.Visible = true;
            this.colExchangeRate.VisibleIndex = 2;
            // 
            // TyGiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GcExchangeRate);
            this.Controls.Add(this.groupControl1);
            this.Name = "TyGiaForm";
            this.Text = "Tỷ Giá";
            this.Load += new System.EventHandler(this.TyGiaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GcExchangeRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControlArea groupControl1;
        private DevExpress.XtraGrid.GridControl GcExchangeRate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeRateID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeRate;
    }
}