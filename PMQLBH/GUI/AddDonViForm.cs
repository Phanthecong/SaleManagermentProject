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
    public partial class AddDonViForm : Form
    {
        public AddDonViForm()
        {
            InitializeComponent();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            donViInfo.UnitID = int.Parse(txtUnitID.Text);
            donViInfo.Name = txtName.Text;
            donViInfo.Note = txtNote.Text;
          
            donviBUS.AddNew(donViInfo);
            MessageBox.Show("Add New Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
        DonviBUS donviBUS = new DonviBUS();
        DonViInfo donViInfo = new DonViInfo();
      
        private void AddDonViForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = donviBUS.LoadAllData();
            if (dataTable.Rows.Count > 0)
            {
                string id = dataTable.Rows[dataTable.Rows.Count - 1]["UnitID"].ToString();
                int num = int.Parse(id) + 1;
               txtUnitID.Text = num.ToString();
            }
        }
    }
}
