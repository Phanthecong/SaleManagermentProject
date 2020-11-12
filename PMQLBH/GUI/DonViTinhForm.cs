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
using DevExpress.XtraGrid.Views.Grid;
using PMQLBH.DAO;

namespace PMQLBH.GUI
{
    public partial class DonViTinhForm : Form
    {
        public DonViTinhForm(Role_FormDTO role_FormDTO)
        {
            InitializeComponent();
            GrcExchange.SetEnabledControl(role_FormDTO);

            Button Add = GrcExchange.Controls.Find("btnAdd", true).FirstOrDefault() as Button;
            Add.Click += AddNew_Click;

            Button Delete = GrcExchange.Controls.Find("btnDelete", true).FirstOrDefault() as Button;
            Delete.Click += Delete_Click;

            Button Update = GrcExchange.Controls.Find("btnUpdate", true).FirstOrDefault() as Button;
            Update.Click += Update_Click;

            Button Close = GrcExchange.Controls.Find("btnCancel", true).FirstOrDefault() as Button;
            Close.Click += Cancel_Click;

            Button Import = GrcExchange.Controls.Find("btnImport", true).FirstOrDefault() as Button;
            Import.Click += Import_Click;

            Button Export = GrcExchange.Controls.Find("btnExport", true).FirstOrDefault() as Button;
            Export.Click += Export_Click;
        }
        DonviBUS donviBUS = new DonviBUS();
        private void Export_Click(object sender, EventArgs e)
        {
            var screen = new OpenFileDialog();
            screen.ShowDialog();
            GcUnit.ExportToXlsx(screen.FileName);
            MessageBox.Show("Export Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Import_Click(object sender, EventArgs e)
        {
            var screen = new OpenFileDialog();
            screen.ShowDialog();

            GcUnit.DataSource = ExcelDataBase.OpenFile(screen.FileName);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int[] selRow = ((GridView)GcUnit.MainView).GetSelectedRows();
            DataRowView dataRow = (DataRowView)(((GridView)GcUnit.MainView).GetRow(selRow[0]));
            string temp = dataRow["UnitID"].ToString();
            int id = int.Parse(temp);

            UpdateDonviForm updateDonviForm = new UpdateDonviForm();
            updateDonviForm.DonViInfo = donviBUS.LoadInfo(id);
            updateDonviForm.Show(); 
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int[] selRow = ((GridView)GcUnit.MainView).GetSelectedRows();
            DataRowView dataRow = (DataRowView)(((GridView)GcUnit.MainView).GetRow(selRow[0]));
            string temp = dataRow["UnitID"].ToString();
            int id = int.Parse(temp);

            
            MessageBox.Show("Delete Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            AddDonViForm addDonViForm = new AddDonViForm();
            addDonViForm.Show();
        }

        UnitBUS unitBUS = new UnitBUS();

        private void DonViTinhForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = unitBUS.LoadAllData();
            GcUnit.DataSource = dataTable;
        }
    }
}
