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
    public partial class AddKhoForm : Form
    {
        public AddKhoForm()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddKhoForm_Load(object sender, EventArgs e)
        {
            EmployeeBUS employeeBUS = new EmployeeBUS();
            cbxQL.DataSource = employeeBUS.LoadAllData();
            cbxQL.DisplayMember = "Name";
            cbxQL.ValueMember = "EmployeeID";
        }

        private void save_Click(object sender, EventArgs e)
        {
            WarehouseInfo warehouseInfo = new WarehouseInfo();
            warehouseInfo.Name = txtTen.Text;
            warehouseInfo.ManagermentStaff = int.Parse(cbxQL.SelectedValue.ToString());
            warehouseInfo.Contact = txtLH.Text;
            warehouseInfo.Address = txtadd.Text;
            warehouseInfo.Status = txtSTT.Text;
            warehouseInfo.Note = txtNote.Text; ;


            WarehouseBUS warehouseBUS = new WarehouseBUS();
            warehouseBUS.Add(warehouseInfo);

        }
    }
    
}
