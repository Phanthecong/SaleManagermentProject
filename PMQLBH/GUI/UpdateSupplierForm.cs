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
    public partial class UpdateSupplierForm : Form
    {
        public UpdateSupplierForm()
        {
            InitializeComponent();
        }

        private void UpdateSupplierForm_Load(object sender, EventArgs e)
        {
            //Get info Customer to review textbox
            txtSupplierID.Text = SupplierInfo.SupplierID.ToString();
            txtName.Text = SupplierInfo.SupplierName.ToString();
            txtContact.Text = SupplierInfo.Contact.ToString();
            txtPhoneNumber.Text = SupplierInfo.PhoneNumber.ToString();
            txtAddress.Text = SupplierInfo.Address.ToString();
            txtFax.Text = SupplierInfo.Fax.ToString();
            txtPosition.Text = SupplierInfo.Position.ToString();

    
        }

        SupplierBUS supplierBUS = new SupplierBUS();
        SupplierInfo supplierInfo;
        AreasBUS areasBUS = new AreasBUS();

        public SupplierInfo SupplierInfo { get => supplierInfo; set => supplierInfo = value; }


        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Get value from textbox
            SupplierInfo supplierInfo = new SupplierInfo();
            supplierInfo.SupplierID = int.Parse(txtSupplierID.Text);
            supplierInfo.SupplierName = txtName.Text;
            supplierInfo.Contact = txtContact.Text;
            supplierInfo.PhoneNumber = txtPhoneNumber.Text;
            supplierInfo.Address = txtAddress.Text;
            supplierInfo.Fax = txtFax.Text;
            supplierInfo.Position = txtPosition.Text;

            

            //Update Customer
            supplierBUS.UpdateSupplier(supplierInfo);
            MessageBox.Show("Update Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
