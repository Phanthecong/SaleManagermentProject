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
    public partial class ThemMoiKhuVucForm : Form
    {

        public ThemMoiKhuVucForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        AreaInfo areaInfo = new AreaInfo();
        AreasBUS areasBUS = new AreasBUS();
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(checkAdd())
            {
                areaInfo.AreaID = int.Parse(txtAreaID.Text);
                areaInfo.AreaName = txtAreaName.Text;
                areaInfo.Note = txtNote.Text;

                areasBUS.AddNewArea(areaInfo);
                MessageBox.Show("Add New Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                if(txtAreaID.Text == "")
                {
                    MessageBox.Show("Area ID can't be blank!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtAreaName.Text == "")
                {
                    MessageBox.Show("Area Name can't be blank!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool checkAdd()
        {
            if(txtAreaID.Text == "")
            {
                return false;
            }
            if(txtAreaName.Text == "")
            {
                return false;
            }
            return true;
        }

        private void ThemMoiKhuVucForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = areasBUS.LoadAllArea();
            if(dataTable.Rows.Count > 0)
            {
                string id = dataTable.Rows[dataTable.Rows.Count - 1]["AreaID"].ToString();
                int num = int.Parse(id) + 1;
                txtAreaID.Text = num.ToString();
            }

        }
    }
}
