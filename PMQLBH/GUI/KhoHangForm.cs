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
    public partial class KhoHangForm : Form
    {
        public KhoHangForm()
        {
            InitializeComponent();
        }

        WarehouseBUS warehouseBUS = new WarehouseBUS();

        private void KhoHangForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = warehouseBUS.LoadAllData();
            GcWarehouse.DataSource = dataTable;
        }
    }
}
