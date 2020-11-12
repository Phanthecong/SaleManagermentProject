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
    public partial class UpdateGOGForm : Form
    {
        public UpdateGOGForm()
        {
            InitializeComponent();
        }

        GroupOfGoodsBUS groupBUS = new GroupOfGoodsBUS();
        GroupOfGoodsInfo group;

        public GroupOfGoodsInfo Group { get => group; set => group = value; }

        private void UpdateGOGForm_Load(object sender, EventArgs e)
        {
            txtGOGID.Text = Group.GOGID.ToString();
            txtName.Text = Group.GOGName.ToString();
            txtNote.Text = Group.Note.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkupdate())
            {

                Group.GOGName = txtName.Text;
                Group.Note = txtNote.Text;

                groupBUS.UpdateGroupOfGoods(Group);
                MessageBox.Show("Update Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Area name can't be blank!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool checkupdate()
        {
            if (txtName.Text == "")
            {
                return false;
            }
            return true;
        }
    }
}
