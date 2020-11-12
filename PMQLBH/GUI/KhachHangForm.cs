using DevExpress.XtraGrid.Views.Grid;
using PMQLBH.BUS;
using PMQLBH.DAO;
using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PMQLBH.GUI
{
    public partial class CustomerForm : Form
    {
        public CustomerForm(Role_FormDTO role_FormDTO)
        {
            InitializeComponent();
            GrcCustomer.SetEnabledControl(role_FormDTO);


            Button Add = GrcCustomer.Controls.Find("btnAdd", true).FirstOrDefault() as Button;
            Add.Click += AddNewCustomer_Click;

            Button Delete = GrcCustomer.Controls.Find("btnDelete", true).FirstOrDefault() as Button;
            Delete.Click += DeleteCustomer_Click;

            Button Update = GrcCustomer.Controls.Find("btnUpdate", true).FirstOrDefault() as Button;
            Update.Click += UpdateCustomer_Click;

            Button Close = GrcCustomer.Controls.Find("btnCancel", true).FirstOrDefault() as Button;
            Close.Click += Cancel_Click;

            Button Import = GrcCustomer.Controls.Find("btnImport", true).FirstOrDefault() as Button;
            Import.Click += Import_Click;

            Button Export = GrcCustomer.Controls.Find("btnExport", true).FirstOrDefault() as Button;
            Export.Click += Export_Click;
        }

        private void Export_Click(object sender, EventArgs e)
        {
            //Open dialog to select the file to export
            var screen = new OpenFileDialog();
            screen.ShowDialog();

            //Export
            GcCustomer.ExportToXlsx(screen.FileName);
            MessageBox.Show("Export Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Import_Click(object sender, EventArgs e)
        {
            //Open dialog to select the file to import
            var screen = new OpenFileDialog();
            screen.ShowDialog();

            GcCustomer.DataSource = ExcelDataBase.OpenFile(screen.FileName);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            //Get the selected value
            int[] selRow = ((GridView)GcCustomer.MainView).GetSelectedRows();
            DataRowView dataRow = (DataRowView)(((GridView)GcCustomer.MainView).GetRow(selRow[0]));
            string temp = dataRow["CustomerID"].ToString();
            int id = int.Parse(temp);


            UpdateCustomerForm updateCustomer = new UpdateCustomerForm();
            updateCustomer.CustomerInfo = customerBUS.LoadInfo(id);
            updateCustomer.Show();
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            //Get the selected value
            int[] selRow = ((GridView)GcCustomer.MainView).GetSelectedRows();
            DataRowView dataRow = (DataRowView)(((GridView)GcCustomer.MainView).GetRow(selRow[0]));
            string temp = dataRow["CustomerID"].ToString();
            int id = int.Parse(temp);

            //Delete customer
            customerBUS.DeleteCustomer(id);
            MessageBox.Show("Delete Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        CustomerInfo customerInfo = new CustomerInfo();
        CustomerBUS customerBUS = new CustomerBUS();


        private void AddNewCustomer_Click(object sender, EventArgs e)
        {
            //Show add new customer dialog
            AddCustomerForm addKhachHang = new AddCustomerForm();
            addKhachHang.Show();
        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = customerBUS.LoadAllData();
            GcCustomer.DataSource = dataTable;
        }

        private void GrcCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
