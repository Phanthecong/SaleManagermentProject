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
    public partial class AddGOGForm : Form
    {
        public AddGOGForm()
        {
            InitializeComponent();
        }

        GroupOfGoodsBUS group = new GroupOfGoodsBUS();
        GroupOfGoodsInfo goodsInfo = new GroupOfGoodsInfo();

        private void AddGOGForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = group.LoadAllData();
            if (dataTable.Rows.Count > 0)
            {
                string id = dataTable.Rows[dataTable.Rows.Count - 1]["GOGID"].ToString();
                int num = int.Parse(id) + 1;
                txtGOGID.Text = num.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkAdd())
            {
                goodsInfo.GOGID = int.Parse(txtGOGID.Text);
                goodsInfo.GOGName = txtName.Text;
                goodsInfo.Note = txtNote.Text;

                group.AddNewGroupOfGoods(goodsInfo);
                MessageBox.Show("Add New Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                if (txtGOGID.Text == "")
                {
                    MessageBox.Show("Group of goods ID can't be blank!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtName.Text == "")
                {
                    MessageBox.Show("Group of goods Name can't be blank!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool checkAdd()
        {
            if (txtGOGID.Text == "")
            {
                return false;
            }
            if (txtName.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
