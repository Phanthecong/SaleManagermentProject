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
    public partial class KhuVucForm : Form
    {
        public KhuVucForm(Role_FormDTO role_FormDTO)
        {
            InitializeComponent();
            GrcArea.SetEnabledControl(role_FormDTO);

            Button Add = GrcArea.Controls.Find("btnAdd", true).FirstOrDefault() as Button;
            Add.Click += AddNewArea_Click;

            Button Delete = GrcArea.Controls.Find("btnDelete", true).FirstOrDefault() as Button;
            Delete.Click += DeleteArea_Click;

            Button Update = GrcArea.Controls.Find("btnUpdate", true).FirstOrDefault() as Button;
            Update.Click += UpdateArea_Click;

            Button Close = GrcArea.Controls.Find("btnCancel", true).FirstOrDefault() as Button;
            Close.Click += Cancel_Click;

            Button Import = GrcArea.Controls.Find("btnImport", true).FirstOrDefault() as Button;
            Import.Click += Import_Click;

            Button Export = GrcArea.Controls.Find("btnExport", true).FirstOrDefault() as Button;
            Export.Click += Export_Click;
        }
        AreasBUS areasBUS = new AreasBUS();
        private void KhuVucForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = areasBUS.LoadAllArea();
            GcArea.DataSource = dataTable;
           
        }

        private void Export_Click(object sender, EventArgs e)
        {
            //Open dialog to select the file to export
            var screen = new OpenFileDialog();
            screen.ShowDialog();

            //Export
            GcArea.ExportToXlsx(screen.FileName);
            MessageBox.Show("Export Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Import_Click(object sender, EventArgs e)
        {
            //Open dialog to select the file to import
            var screen = new OpenFileDialog();
            screen.ShowDialog();

            GcArea.DataSource = ExcelDataBase.OpenFile(screen.FileName);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateArea_Click(object sender, EventArgs e)
        {
            //Get the selected value
            int[] selRow = ((GridView)GcArea.MainView).GetSelectedRows();
            DataRowView dataRow = (DataRowView)(((GridView)GcArea.MainView).GetRow(selRow[0]));
            string temp = dataRow["AreaID"].ToString();
            int id = int.Parse(temp);


            UpdateAreaForm updateAreaForm = new UpdateAreaForm();
            updateAreaForm.AreaInfo = areasBUS.LoadInfo(id);
            updateAreaForm.Show();
        }

        private void DeleteArea_Click(object sender, EventArgs e)
        {
            //Get the selected value
            int[] selRow = ((GridView)GcArea.MainView).GetSelectedRows();
            DataRowView dataRow = (DataRowView)(((GridView)GcArea.MainView).GetRow(selRow[0]));
            string temp = dataRow["AreaID"].ToString();
            int id = int.Parse(temp);

            //Delete customer
            areasBUS.DeleteArea(id);
            MessageBox.Show("Delete Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void AddNewArea_Click(object sender, EventArgs e)
        {
            ThemMoiKhuVucForm themMoi = new ThemMoiKhuVucForm();
            themMoi.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
