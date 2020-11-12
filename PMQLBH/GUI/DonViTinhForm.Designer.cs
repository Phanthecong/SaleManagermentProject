namespace PMQLBH.GUI
{
    partial class DonViTinhForm
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
            this.GrcExchange = new PMQLBH.GroupControlArea();
            this.GcUnit = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnitID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GcUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrcExchange
            // 
            this.GrcExchange.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrcExchange.Location = new System.Drawing.Point(0, 0);
            this.GrcExchange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrcExchange.Name = "GrcExchange";
            this.GrcExchange.Size = new System.Drawing.Size(1067, 34);
            this.GrcExchange.TabIndex = 0;
            // 
            // GcUnit
            // 
            this.GcUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GcUnit.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GcUnit.Location = new System.Drawing.Point(0, 34);
            this.GcUnit.MainView = this.gridView1;
            this.GcUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GcUnit.Name = "GcUnit";
            this.GcUnit.Size = new System.Drawing.Size(1067, 520);
            this.GcUnit.TabIndex = 1;
            this.GcUnit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUnitID,
            this.colName,
            this.colNote});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.GcUnit;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colUnitID
            // 
            this.colUnitID.FieldName = "UnitID";
            this.colUnitID.MinWidth = 27;
            this.colUnitID.Name = "colUnitID";
            this.colUnitID.Visible = true;
            this.colUnitID.VisibleIndex = 0;
            this.colUnitID.Width = 100;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 27;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 100;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 27;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 2;
            this.colNote.Width = 100;
            // 
            // DonViTinhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.GcUnit);
            this.Controls.Add(this.GrcExchange);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DonViTinhForm";
            this.Text = "Đơn Vị Tính";
            this.Load += new System.EventHandler(this.DonViTinhForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GcUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControlArea GrcExchange;
        private DevExpress.XtraGrid.GridControl GcUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
    }
}