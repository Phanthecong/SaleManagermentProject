using DevExpress.XtraGrid.Views.Grid;
using PMQLBH.BUS;
using PMQLBH.DAO;
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
    public partial class NhaCungCapForm : Form
    {
        public NhaCungCapForm(Role_FormDTO role_FormDTO)
        {
            InitializeComponent();

            Button Add = GrcSupplier.Controls.Find("btnAdd", true).FirstOrDefault() as Button;
            Add.Click += AddNewSupplier_Click;

            Button Delete = GrcSupplier.Controls.Find("btnDelete", true).FirstOrDefault() as Button;
            Delete.Click += DeleteSupplier_Click;

            Button Update = GrcSupplier.Controls.Find("btnUpdate", true).FirstOrDefault() as Button;
            Update.Click += UpdateSupplier_Click;

            Button Close = GrcSupplier.Controls.Find("btnCancel", true).FirstOrDefault() as Button;
            Close.Click += Cancel_Click;

            Button Import = GrcSupplier.Controls.Find("btnImport", true).FirstOrDefault() as Button;
            Import.Click += Import_Click;

            Button Export = GrcSupplier.Controls.Find("btnExport", true).FirstOrDefault() as Button;
            Export.Click += Export_Click;
        }
        SupplierBUS supplierBUS = new SupplierBUS();

        private void NhaCungCapForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = supplierBUS.LoadAllData();
            GcSupplier.DataSource = dataTable;
        }
        private void Reload()
        {
            DataTable dataTable = supplierBUS.LoadAllData();
            GcSupplier.DataSource = dataTable;
        }
        private void Export_Click(object sender, EventArgs e)
        {
            //Open dialog to select the file to export
            var screen = new OpenFileDialog();
            screen.ShowDialog();

            //Export
            GcSupplier.ExportToXlsx(screen.FileName);
            MessageBox.Show("Export Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Import_Click(object sender, EventArgs e)
        {
            //Open dialog to select the file to import
            var screen = new OpenFileDialog();
            screen.ShowDialog();

            GcSupplier.DataSource = ExcelDataBase.OpenFile(screen.FileName);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateSupplier_Click(object sender, EventArgs e)
        {
            //Get the selected value
            int[] selRow = ((GridView)GcSupplier.MainView).GetSelectedRows();
            DataRowView dataRow = (DataRowView)(((GridView)GcSupplier.MainView).GetRow(selRow[0]));
            string temp = dataRow["SupplierID"].ToString();
            int id = int.Parse(temp);


            UpdateSupplierForm updateSupplierForm = new UpdateSupplierForm();
            updateSupplierForm.SupplierInfo = supplierBUS.LoadInfo(id);
            updateSupplierForm.Show();
            Reload();
        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            //Get the selected value
            int[] selRow = ((GridView)GcSupplier.MainView).GetSelectedRows();
            DataRowView dataRow = (DataRowView)(((GridView)GcSupplier.MainView).GetRow(selRow[0]));
            string temp = dataRow["SupplierID"].ToString();
            int id = int.Parse(temp);

            //Delete customer
            supplierBUS.DeleteSupplier(id);
            MessageBox.Show("Delete Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //this.Close();
            Reload();
        }

        private void AddNewSupplier_Click(object sender, EventArgs e)
        {
            AddSupplierForm addSupplierForm = new AddSupplierForm();
            if(addSupplierForm.ShowDialog() == DialogResult.OK)
            Reload();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
