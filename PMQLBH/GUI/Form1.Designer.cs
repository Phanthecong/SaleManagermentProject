namespace PMQLBH
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ketthuc = new System.Windows.Forms.Button();
            this.Tuychon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRememberPass = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Ketthuc
            // 
            this.Ketthuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ketthuc.Location = new System.Drawing.Point(680, 372);
            this.Ketthuc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Ketthuc.Name = "Ketthuc";
            this.Ketthuc.Size = new System.Drawing.Size(150, 44);
            this.Ketthuc.TabIndex = 5;
            this.Ketthuc.Text = "Kết Thúc";
            this.Ketthuc.UseVisualStyleBackColor = false;
            this.Ketthuc.Click += new System.EventHandler(this.Ketthuc_Click);
            // 
            // Tuychon
            // 
            this.Tuychon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tuychon.Location = new System.Drawing.Point(14, 383);
            this.Tuychon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Tuychon.Name = "Tuychon";
            this.Tuychon.Size = new System.Drawing.Size(150, 44);
            this.Tuychon.TabIndex = 6;
            this.Tuychon.Text = "Tùy Chọn";
            this.Tuychon.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // cbRememberPass
            // 
            this.cbRememberPass.AutoSize = true;
            this.cbRememberPass.Location = new System.Drawing.Point(520, 300);
            this.cbRememberPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbRememberPass.Name = "cbRememberPass";
            this.cbRememberPass.Size = new System.Drawing.Size(300, 29);
            this.cbRememberPass.TabIndex = 3;
            this.cbRememberPass.Text = "Nhớ tài khoản và mật khẩu";
            this.cbRememberPass.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "UserName:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(421, 171);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(404, 31);
            this.txtPassword.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(514, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_Loggin);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(421, 108);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(404, 31);
            this.txtUsername.TabIndex = 32;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 439);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ketthuc);
            this.Controls.Add(this.Tuychon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRememberPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Ketthuc;
        private System.Windows.Forms.Button Tuychon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbRememberPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUsername;
    }
}

