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
    public partial class ThemChiTietSanPham : Form
    {
        public delegate void Sender(ProductInfo product, string unitName);
        public Sender SendProduct;

        public ThemChiTietSanPham()
        {
            InitializeComponent();
        }

        private void ThemChiTietSanPham_Load(object sender, EventArgs e)
        {
            ProductBUS productBUS = new ProductBUS();
            cbTenHang.DataSource = productBUS.LoadAllData();
            cbTenHang.DisplayMember = "Name";
            cbTenHang.ValueMember = "ProductID";

            UnitBUS unitBUS = new UnitBUS();
            cbDonVi.DataSource = unitBUS.LoadAllData();
            cbDonVi.ValueMember = "UnitID";
            cbDonVi.DisplayMember = "Name";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ProductInfo product = new ProductInfo();
            string UnitName = cbDonVi.Text;
            product.ProductName = cbTenHang.Text;
            product.ProductID = int.Parse(cbTenHang.SelectedValue.ToString());
            product.UnitID = int.Parse(cbDonVi.SelectedValue.ToString());
            product.Quantity = int.Parse(txtSoLuong.Value.ToString());
            product.Price = int.Parse(txtDonGia.Value.ToString());
            SendProduct.Invoke(product, UnitName);
        }
    }
}
