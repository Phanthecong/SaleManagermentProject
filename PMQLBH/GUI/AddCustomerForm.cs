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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        CustomerBUS customerBUS = new CustomerBUS();
        CustomerInfo customerInfo = new CustomerInfo();
        AreaInfo areaInfo = new AreaInfo();
        
        

        private void AddKhachHangForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = customerBUS.LoadAllData();
            if (dataTable.Rows.Count > 0)
            {
                string id = dataTable.Rows[dataTable.Rows.Count - 1]["CustomerID"].ToString();
                int num = int.Parse(id) + 1;
                txtCustomerID.Text = num.ToString();                
            }


        }

        private bool checkAdd()
        {
            if (txtName.Text == "")
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
            if(checkAdd())
            {
                //Assign New CustomerInfo
                customerInfo.CustomerID = int.Parse(txtCustomerID.Text);
                customerInfo.Name = txtName.Text;
                customerInfo.Contact = txtContact.Text;
                customerInfo.PhoneNumber = txtPhone.Text;
                customerInfo.Email = txtmail.Text;
                customerInfo.Fax = txtFax.Text;
                customerInfo.Tax = txtTax.Text;
                customerInfo.Address = txtAddress.Text;
                customerInfo.Website = txtWebsite.Text;
                customerInfo.AccountNumber = txtaccnum.Text;
                


                //Add new Customer
                customerBUS.AddNewCustomer(customerInfo);
                MessageBox.Show("Create Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                if(txtName.Text == "")
                {
                    MessageBox.Show("User can't be blank!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                if (txtName.Text == "")
                {
                    MessageBox.Show("Email can't be blank!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
