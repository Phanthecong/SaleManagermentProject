using PMQLBH.BUS;
using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQLBH.GUI
{
    public partial class ChangePasswordForm : Form
    {
        private UserInfo userInfo = new UserInfo();
        ChangePassword changePassword = new ChangePassword();

        public ChangePasswordForm(UserInfo userInfo)
        {
            InitializeComponent();
            this.userInfo = userInfo;
        }

        private void btnAcceptCPDialog_Click(object sender, EventArgs e)
        {
            if(string.Equals(txtOldPass.Text, userInfo.Password))
            {
                if (string.Equals(txtNewPass.Text, txtReNewPass.Text))
                {
                    UserInfo newPass = new UserInfo
                    {
                        UserName = userInfo.UserName,
                        Password = txtNewPass.Text
                    };
                    changePassword.ChangePass(newPass);
                    MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không khớp!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtReNewPass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReNewPass.Focus();
            }
            
        }

        private void btnCancelCPDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
