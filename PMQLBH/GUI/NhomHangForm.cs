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
    public partial class NhomHangForm : Form
    {
        public NhomHangForm(Role_FormDTO role_FormDTO)
        {
            InitializeComponent();

            Button Add = GrcGOG.Controls.Find("btnAdd", true).FirstOrDefault() as Button;
            Add.Click += AddNewGroupOfGoods_Click;

            Button Delete = GrcGOG.Controls.Find("btnDelete", true).FirstOrDefault() as Button;
            Delete.Click += DeleteGroupOfGoods_Click;

            Button Update = GrcGOG.Controls.Find("btnUpdate", true).FirstOrDefault() as Button;
            Update.Click += UpdateGroupOfGoods_Click;

            Button Close = GrcGOG.Controls.Find("btnCancel", true).FirstOrDefault() as Button;
            Close.Click += Cancel_Click;

            Button Import = GrcGOG.Controls.Find("btnImport", true).FirstOrDefault() as Button;
            Import.Click += Import_Click;

            Button Export = GrcGOG.Controls.Find("btnExport", true).FirstOrDefault() as Button;
            Export.Click += Export_Click;
        }

        GroupOfGoodsBUS groupOfGoodsBUS = new GroupOfGoodsBUS();

        private void NhomHangForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = groupOfGoodsBUS.LoadAllData();
            GcGroupOfGoods.DataSource = dataTable;
        }

        private void Export_Click(object sender, EventArgs e)
        {
            //Open dialog to select the file to export
            var screen = new OpenFileDialog();
            screen.ShowDialog();

            //Export
            GcGroupOfGoods.ExportToXlsx(screen.FileName);
            MessageBox.Show("Export Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Import_Click(object sender, EventArgs e)
        {
            //Open dialog to select the file to import
            var screen = new OpenFileDialog();
            screen.ShowDialog();

            GcGroupOfGoods.DataSource = ExcelDataBase.OpenFile(screen.FileName);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateGroupOfGoods_Click(object sender, EventArgs e)
        {
            //Get the selected value
            int[] selRow = ((GridView)GcGroupOfGoods.MainView).GetSelectedRows();
            DataRowView dataRow = (DataRowView)(((GridView)GcGroupOfGoods.MainView).GetRow(selRow[0]));
            string temp = dataRow["GOGID"].ToString();
            int id = int.Parse(temp);


            UpdateGOGForm updateGOGForm = new UpdateGOGForm();
            updateGOGForm.Group = groupOfGoodsBUS.LoadInfo(id);
            updateGOGForm.Show();
        }

        private void DeleteGroupOfGoods_Click(object sender, EventArgs e)
        {
            //Get the selected value
            int[] selRow = ((GridView)GcGroupOfGoods.MainView).GetSelectedRows();
            DataRowView dataRow = (DataRowView)(((GridView)GcGroupOfGoods.MainView).GetRow(selRow[0]));
            string temp = dataRow["GOGID"].ToString();
            int id = int.Parse(temp);

            //Delete customer
            groupOfGoodsBUS.DeleteGroupOfGoods(id);
            MessageBox.Show("Delete Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void AddNewGroupOfGoods_Click(object sender, EventArgs e)
        {
            AddGOGForm addGOGForm = new AddGOGForm();
            addGOGForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
