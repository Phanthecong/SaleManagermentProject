using PMQLBH.BUS;
using PMQLBH.DAO;
using PMQLBH.DTO;
using PMQLBH.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQLBH
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        LoginBUS login = new LoginBUS();
        Role_FormBUS role_FormBUS = new Role_FormBUS();
     
        private void btn_Loggin(object sender, EventArgs e)
        {
            UserInfo user = login.login(txtUsername.Text, txtPassword.Text);
            //check null
            if (user != null)
            {
                //remember pass
                if(cbRememberPass.CheckState == CheckState.Checked)
                {
                    Properties.Settings.Default.Username = txtUsername.Text;
                    Properties.Settings.Default.Password = txtPassword.Text;
                    Properties.Settings.Default.Save();
                }
                

                List<Role_FormDTO> role_FormDTOList = role_FormBUS.GetRoleForm(user.RoleId);
                MainForm frmMain = new MainForm(role_FormDTOList, user, user.RoleId);
                //this.Hide();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Properties.Settings.Default.Username;
            txtPassword.Text = Properties.Settings.Default.Password;
        }
    }
}
