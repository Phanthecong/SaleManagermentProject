namespace PMQLBH.GUI
{
    partial class ProductManagerment
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

        private void InitializeComponent()
        {
            this.grControl = new PMQLBH.GroupControlArea();
            this.SuspendLayout();
            // 
            // grControl
            // 
            this.grControl.Location = new System.Drawing.Point(0, 195);
            this.grControl.Margin = new System.Windows.Forms.Padding(1);
            this.grControl.Name = "grControl";
            this.grControl.Size = new System.Drawing.Size(558, 85);
            this.grControl.TabIndex = 0;
            // 
            // ProductManagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 278);
            this.Controls.Add(this.grControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductManagerment";
            this.Text = "ProductManagerment";
            this.ResumeLayout(false);

        }



        #endregion

        private GroupControlArea grControl;
    }
}