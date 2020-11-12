using DevExpress.XtraGrid.Views.Grid;
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
    public partial class UpdateCustomerForm : Form
    {
        public UpdateCustomerForm()
        {
            InitializeComponent();
        }

        CustomerBUS customerBUS = new CustomerBUS();
        CustomerInfo _customerInfo;
        AreasBUS areasBUS = new AreasBUS();

        public CustomerInfo CustomerInfo { get => _customerInfo; set => _customerInfo = value; }

        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            //Get info Customer to review textbox
            txtCustomerID.Text = CustomerInfo.CustomerID.ToString();
            txtName.Text = CustomerInfo.Name.ToString();
            txtContact.Text = CustomerInfo.Contact.ToString();
            txtAcc.Text = CustomerInfo.Email.ToString();
            txtmail.Text = CustomerInfo.PhoneNumber.ToString();
            txtAddress.Text = CustomerInfo.Address.ToString();
            txtaccnum.Text = CustomerInfo.AccountNumber.ToString();
            txtWebsite.Text = CustomerInfo.Website.ToString();
            txtFax.Text = CustomerInfo.Fax.ToString();
            txtPhone.Text = CustomerInfo.Tax.ToString();

          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Get value from textbox
            CustomerInfo customer = new CustomerInfo();
            customer.CustomerID = int.Parse(txtCustomerID.Text);
            customer.Name = txtName.Text;
            customer.Contact = txtContact.Text;
            customer.Email = txtAcc.Text;
            customer.PhoneNumber = txtmail.Text;
            customer.Address = txtAddress.Text;
            customer.Website = txtWebsite.Text;
            customer.AccountNumber = txtaccnum.Text;
            customer.Fax = txtFax.Text;
            customer.Tax = txtPhone.Text;

       

            //Update Customer
            customerBUS.UpdateCustomer(customer);
            MessageBox.Show("Update Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
    }
}
