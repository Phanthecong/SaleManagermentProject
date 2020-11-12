namespace PMQLBH.GUI
{
    partial class UserManagerment
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
        private GroupControlArea grControl;
        private void InitializeComponent()
        {
            this.grControl = new PMQLBH.GroupControlArea();
            this.SuspendLayout();
            // 
            // grControl
            // 
            this.grControl.Location = new System.Drawing.Point(-8, 274);
            this.grControl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grControl.Name = "grControl";
            this.grControl.Size = new System.Drawing.Size(745, 106);
            this.grControl.TabIndex = 0;
            // 
            // UserManagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 390);
            this.Controls.Add(this.grControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserManagerment";
            this.Text = "UserManagerment";
            this.ResumeLayout(false);

        }

        #endregion

        
    }
}