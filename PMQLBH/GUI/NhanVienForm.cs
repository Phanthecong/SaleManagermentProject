using PMQLBH.BUS;
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
    public partial class NhanVienForm : Form
    {
        public NhanVienForm()
        {
            InitializeComponent();
        }

        EmployeeBUS employeeBUS = new EmployeeBUS();

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = employeeBUS.LoadAllData();
            GcEmployee.DataSource = dataTable;
        }
    }
}
