namespace PMQLBH.GUI
{
    partial class Main
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
            this.btnProductManagerment = new System.Windows.Forms.Button();
            this.btnUserManagerment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductManagerment
            // 
            this.btnProductManagerment.Location = new System.Drawing.Point(258, 129);
            this.btnProductManagerment.Name = "btnProductManagerment";
            this.btnProductManagerment.Size = new System.Drawing.Size(250, 61);
            this.btnProductManagerment.TabIndex = 0;
            this.btnProductManagerment.Text = "Product Managerment";
            this.btnProductManagerment.UseVisualStyleBackColor = true;
            this.btnProductManagerment.Click += new System.EventHandler(this.btnProductManagerment_Click);
            // 
            // btnUserManagerment
            // 
            this.btnUserManagerment.Location = new System.Drawing.Point(258, 224);
            this.btnUserManagerment.Name = "btnUserManagerment";
            this.btnUserManagerment.Size = new System.Drawing.Size(250, 61);
            this.btnUserManagerment.TabIndex = 1;
            this.btnUserManagerment.Text = "User Managerment";
            this.btnUserManagerment.UseVisualStyleBackColor = true;
            this.btnUserManagerment.Click += new System.EventHandler(this.btnUserManagerment_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserManagerment);
            this.Controls.Add(this.btnProductManagerment);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductManagerment;
        private System.Windows.Forms.Button btnUserManagerment;
    }
}