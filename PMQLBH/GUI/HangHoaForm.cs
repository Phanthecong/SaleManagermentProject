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
    public partial class HangHoaForm : Form
    {
        public HangHoaForm()
        {
            InitializeComponent();
        }

        ProductBUS productBUS = new ProductBUS();

        private void HangHoaForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = productBUS.LoadAllData();
            GcProduct.DataSource = dataTable;
        }
    }
}
