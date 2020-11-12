using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMQLBH.BUS;
using PMQLBH.DTO;

namespace PMQLBH.GUI
{
    public partial class UpdateDonviForm : Form
    {
        public UpdateDonviForm()
        {
            InitializeComponent();
        }
        DonviBUS donviBUS = new DonviBUS();
        public DonViInfo DonViInfo { get; internal set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DonViInfo.Name = txtName.Text;
            DonViInfo.Note = txtNote.Text;
            donviBUS.Update(DonViInfo);
            MessageBox.Show("Update Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void UpdateDonviForm_Load(object sender, EventArgs e)
        {
            txtUnit.Text = DonViInfo.UnitID.ToString();
            txtName.Text = DonViInfo.Name.ToString();
            txtNote.Text = DonViInfo.Note.ToString();
        }
    }
}
