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
    public partial class UpdateAreaForm : Form
    {
        public UpdateAreaForm()
        {
            InitializeComponent();
        }
        AreaInfo areaInfo;
        AreasBUS areasBUS = new AreasBUS();

        public AreaInfo AreaInfo { get => areaInfo; set => areaInfo = value; }

        private void UpdateAreaForm_Load(object sender, EventArgs e)
        {
            txtAreaID.Text = AreaInfo.AreaID.ToString();
            txtName.Text = AreaInfo.AreaName.ToString();
            txtNote.Text = AreaInfo.Note.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(checkupdate())
            {

                AreaInfo.AreaName = txtName.Text;
                AreaInfo.Note = txtNote.Text;

                areasBUS.UpdateArea(AreaInfo);
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
            if(txtName.Text == "")
            {
                return false;
            }
            return true;
        }
    }
}
