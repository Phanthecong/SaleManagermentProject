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
    public partial class BoPhanForm : Form
    {
        public BoPhanForm()
        {
            InitializeComponent();
        }

        DepartmentBUS departmentBUS = new DepartmentBUS();

        private void BoPhanForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = departmentBUS.LoadAllData();
            GcDepartment.DataSource = dataTable;
        }
    }
}
