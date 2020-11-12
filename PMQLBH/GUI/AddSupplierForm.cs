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
    public partial class AddSupplierForm : Form
    {
        public AddSupplierForm()
        {
            InitializeComponent();
        }

        private void AddSupplierForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = supplierBUS.LoadAllData();
            if (dataTable.Rows.Count > 0)
            {
                string id = dataTable.Rows[dataTable.Rows.Count - 1]["SupplierID"].ToString();
                int num = int.Parse(id) + 1;
                txtSupplierID.Text = num.ToString();
            }

            cbbArea.DataSource = areasBUS.LoadAllArea();
            cbbArea.DisplayMember = "AreaName";
            cbbArea.ValueMember = "AreaID";
            cbbArea.SelectedValue = supplierInfo.AreaID;
        }

        SupplierBUS supplierBUS = new SupplierBUS();
        SupplierInfo supplierInfo = new SupplierInfo();
        AreaInfo areaInfo = new AreaInfo();
        AreasBUS areasBUS = new AreasBUS();

        private bool checkAdd()
        {
            if (txtSupplierID.Text == "")
            {
                return false;
            }
            if (cbbArea.Text == "")
            {
                return false;
            }
            if (txtName.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (checkAdd())
            {
                //Assign New CustomerInfo
                supplierInfo.SupplierID = int.Parse(txtSupplierID.Text);
                supplierInfo.SupplierName = txtName.Text;
                supplierInfo.Contact = txtContact.Text;
                supplierInfo.PhoneNumber = txtPhoneNumber.Text;
                supplierInfo.Fax = txtFax.Text;
                supplierInfo.Address = txtAddress.Text;
                supplierInfo.AreaID = int.Parse(cbbArea.SelectedValue.ToString());
                supplierInfo.Position = txtPosition.Text;

                //Add new Customer
                supplierBUS.AddNewSupplier(supplierInfo);
                MessageBox.Show("Create Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                if (txtSupplierID.Text == "")
                {
                    MessageBox.Show("Supplier ID can't be blank!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (cbbArea.Text == "")
                {
                    MessageBox.Show("Area can't be blank!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtName.Text == "")
                {
                    MessageBox.Show("Supplier Name can't be blank!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
