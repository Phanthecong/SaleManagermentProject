namespace PMQLBH.GUI
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.btnCancelCPDialog = new System.Windows.Forms.Button();
            this.btnAcceptCPDialog = new System.Windows.Forms.Button();
            this.txtReNewPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelCPDialog
            // 
            this.btnCancelCPDialog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelCPDialog.BackgroundImage")));
            this.btnCancelCPDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelCPDialog.Location = new System.Drawing.Point(244, 201);
            this.btnCancelCPDialog.Name = "btnCancelCPDialog";
            this.btnCancelCPDialog.Size = new System.Drawing.Size(61, 23);
            this.btnCancelCPDialog.TabIndex = 19;
            this.btnCancelCPDialog.Text = "Thoát";
            this.btnCancelCPDialog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelCPDialog.UseVisualStyleBackColor = true;
            this.btnCancelCPDialog.Click += new System.EventHandler(this.btnCancelCPDialog_Click);
            // 
            // btnAcceptCPDialog
            // 
            this.btnAcceptCPDialog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAcceptCPDialog.BackgroundImage")));
            this.btnAcceptCPDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAcceptCPDialog.Location = new System.Drawing.Point(130, 201);
            this.btnAcceptCPDialog.Name = "btnAcceptCPDialog";
            this.btnAcceptCPDialog.Size = new System.Drawing.Size(72, 23);
            this.btnAcceptCPDialog.TabIndex = 18;
            this.btnAcceptCPDialog.Text = "Đồng Ý";
            this.btnAcceptCPDialog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcceptCPDialog.UseVisualStyleBackColor = true;
            this.btnAcceptCPDialog.Click += new System.EventHandler(this.btnAcceptCPDialog_Click);
            // 
            // txtReNewPass
            // 
            this.txtReNewPass.Location = new System.Drawing.Point(130, 153);
            this.txtReNewPass.Name = "txtReNewPass";
            this.txtReNewPass.Size = new System.Drawing.Size(205, 20);
            this.txtReNewPass.TabIndex = 17;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(130, 121);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(205, 20);
            this.txtNewPass.TabIndex = 16;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(130, 89);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(205, 20);
            this.txtOldPass.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nhập Lại Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mật Khẩu Mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật Khẩu Cũ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thay Đổi Mật Khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 230);
            this.Controls.Add(this.btnCancelCPDialog);
            this.Controls.Add(this.btnAcceptCPDialog);
            this.Controls.Add(this.txtReNewPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelCPDialog;
        private System.Windows.Forms.Button btnAcceptCPDialog;
        private System.Windows.Forms.TextBox txtReNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}