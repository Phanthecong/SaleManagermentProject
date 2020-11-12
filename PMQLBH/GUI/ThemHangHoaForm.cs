using PMQLBH.BUS;
using PMQLBH.DAO;
using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQLBH.GUI
{
    public partial class ThemHangHoaForm : Form
    {
        public ThemHangHoaForm()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ThemHangHoaForm_Load(object sender, EventArgs e)
        {
            HangHoaDVBUS hangHoaDVBUS = new HangHoaDVBUS();
            cbxLoai.DataSource = hangHoaDVBUS.LoadDV();
            cbxLoai.DisplayMember = "LoaiHangHoa";
            cbxLoai.ValueMember = "IDLoaiHangHoa";

            WarehouseBUS warehouseBUS = new WarehouseBUS();
            cbxKho.DataSource = warehouseBUS.LoadAllData();
            cbxKho.DisplayMember = "Name";
            cbxKho.ValueMember = "WarehouseID";

            GroupOfGoodsBUS groupOfGoodsBUS = new GroupOfGoodsBUS();
            cbxphanLoai.DataSource = groupOfGoodsBUS.LoadAllData();
            cbxphanLoai.DisplayMember = "GOGName";
            cbxphanLoai.ValueMember = "GOGID";

            SupplierBUS supplierBUS = new SupplierBUS();
            cbxNhacungcap.DataSource = supplierBUS.LoadAllData();
            cbxNhacungcap.DisplayMember = "Name";
            cbxNhacungcap.ValueMember = "SupplierID";

            UnitBUS unitBUS = new UnitBUS();
            cbxDonvi.DataSource = unitBUS.LoadAllData();
            cbxDonvi.DisplayMember = "Name";
            cbxDonvi.ValueMember = "UnitID";
        }

        string image= "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var fd = new System.Windows.Forms.OpenFileDialog();
            fd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = Path.GetFileNameWithoutExtension(fd.FileName);
            }
        }

        
        private void save_Click(object sender, EventArgs e)
        {
            ProductInfo product = new ProductInfo();
            product.ProductName = txtTen.Text;
            product.Price = int.Parse(txtGia.Text);
            product.Image = image;
            product.Quantity = int.Parse(txtSoLuong.Text);
            product.UnitID = int.Parse(cbxDonvi.SelectedValue.ToString());
            product.Description = txtMota.Text;
            product.ProductName = txtTen.Text;
            product.SupplierID = int.Parse(cbxNhacungcap.SelectedValue.ToString());
            product.WarehouseID = int.Parse(cbxKho.SelectedValue.ToString());
            product.Code = txtMa.Text;

            ProductBUS productBUS = new ProductBUS();
            productBUS.AddProduct(product);
        }
    }
}
