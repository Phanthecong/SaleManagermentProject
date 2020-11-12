namespace PMQLBH.GUI
{
    partial class NhomHangForm
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
            this.GrcGOG = new PMQLBH.GroupControlArea();
            this.GcGroupOfGoods = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGOGID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGOGName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GcGroupOfGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrcGOG
            // 
            this.GrcGOG.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrcGOG.Location = new System.Drawing.Point(0, 0);
            this.GrcGOG.Margin = new System.Windows.Forms.Padding(2);
            this.GrcGOG.Name = "GrcGOG";
            this.GrcGOG.Size = new System.Drawing.Size(800, 28);
            this.GrcGOG.TabIndex = 1;
            // 
            // GcGroupOfGoods
            // 
            this.GcGroupOfGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GcGroupOfGoods.Location = new System.Drawing.Point(0, 28);
            this.GcGroupOfGoods.MainView = this.gridView1;
            this.GcGroupOfGoods.Name = "GcGroupOfGoods";
            this.GcGroupOfGoods.Size = new System.Drawing.Size(800, 422);
            this.GcGroupOfGoods.TabIndex = 2;
            this.GcGroupOfGoods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGOGID,
            this.colGOGName,
            this.colNote});
            this.gridView1.GridControl = this.GcGroupOfGoods;
            this.gridView1.Name = "gridView1";
            // 
            // colGOGID
            // 
            this.colGOGID.FieldName = "GOGID";
            this.colGOGID.Name = "colGOGID";
            this.colGOGID.Visible = true;
            this.colGOGID.VisibleIndex = 0;
            // 
            // colGOGName
            // 
            this.colGOGName.FieldName = "GOGName";
            this.colGOGName.Name = "colGOGName";
            this.colGOGName.Visible = true;
            this.colGOGName.VisibleIndex = 1;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 2;
            // 
            // NhomHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GcGroupOfGoods);
            this.Controls.Add(this.GrcGOG);
            this.Name = "NhomHangForm";
            this.Text = "Nhóm Hàng";
            this.Load += new System.EventHandler(this.NhomHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GcGroupOfGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControlArea GrcGOG;
        private DevExpress.XtraGrid.GridControl GcGroupOfGoods;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colGOGID;
        private DevExpress.XtraGrid.Columns.GridColumn colGOGName;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
    }
}