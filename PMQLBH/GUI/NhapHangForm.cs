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
    public partial class NhapHangForm : Form
    {
        public NhapHangForm()
        {
            InitializeComponent();
            

            Button Add = grControl.Controls.Find("btnAdd", true).FirstOrDefault() as Button;
            Add.Click += AddNewArea_Click;

            Button Delete = grControl.Controls.Find("btnDelete", true).FirstOrDefault() as Button;
            Delete.Click += DeleteArea_Click;

            Button Update = grControl.Controls.Find("btnUpdate", true).FirstOrDefault() as Button;
            Update.Click += UpdateArea_Click;

            Button Close = grControl.Controls.Find("btnCancel", true).FirstOrDefault() as Button;
            Close.Click += Cancel_Click;

            Button Import = grControl.Controls.Find("btnImport", true).FirstOrDefault() as Button;
            Import.Click += Import_Click;

            Button Export = grControl.Controls.Find("btnExport", true).FirstOrDefault() as Button;
            Export.Click += Export_Click;
        }

        private void Export_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Import_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateArea_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteArea_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewArea_Click(object sender, EventArgs e)
        {
            ThemChiTietSanPham themChiTietSanPham = new ThemChiTietSanPham();
            themChiTietSanPham.SendProduct = AddProductToGrid;
            themChiTietSanPham.Show();
        }

        
        private void AddProductToGrid(ProductInfo product, string unitName)
        {
            dgvNhapHang.Rows.Add(product.ProductName, unitName, product.Quantity.ToString(), product.Price.ToString(), 
                (product.Quantity*product.Price).ToString());
        }

        private bool ExistForm(Form form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void LinkNHTheoCT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var form = new BangKeTongHopForm();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void HangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ThemHangHoaForm newform = new ThemHangHoaForm();
            newform.Show();
        }

        private void KhachHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AddCustomerForm newform = new AddCustomerForm();
            newform.Show();
        }

        private void Kho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AddKhoForm newform = new AddKhoForm();
            newform.Show();
        }

        private void NhapHangForm_Load(object sender, EventArgs e)
        {
            SupplierBUS supplierBUS = new SupplierBUS();
            cbTenNCC.DataSource = supplierBUS.LoadAllData();
            cbTenNCC.DisplayMember = "Name";
            cbTenNCC.ValueMember = "SupplierID";

            cbTenNCC.SelectedValueChanged += CbTenNCC_SelectedValueChanged;

            WarehouseBUS warehouseBUS = new WarehouseBUS();
            cbKhoXuat.DataSource = warehouseBUS.LoadAllData();
            cbKhoXuat.ValueMember = "WarehouseID";
            cbKhoXuat.DisplayMember = "Name";
        }

        private void CbTenNCC_SelectedValueChanged(object sender, EventArgs e)
        {
            SupplierBUS supplierBUS = new SupplierBUS();
            DataTable dt = supplierBUS.LoadAllData();
            foreach(DataRow row in dt.Rows)
            {
                if(row["SupplierID"].ToString() == cbTenNCC.SelectedValue.ToString())
                {
                    txtMaNCC.Text = row["Code"].ToString();
                }
            }
            
        }

        float tongTien = 0;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhieuNhapDTO phieuNhap = new PhieuNhapDTO();
            phieuNhap.MaPN = txtPhieu.Text;
            phieuNhap.NCC = txtMaNCC.Text;
            phieuNhap.KhoXuat = int.Parse(cbKhoXuat.SelectedValue.ToString());
            phieuNhap.Ngay = txtNgay.Text;
            phieuNhap.NgayGiao = txtNgayGiao.Text;
            phieuNhap.HanThanhToan = txtHanThanhToan.Text;
            phieuNhap.GhiChu = txtGhiChu.Text;
            phieuNhap.TongTien = tongTien;

            PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
            phieuNhapBUS.LuuPhieuNhap(phieuNhap);

            int i = 0;
            
            foreach (DataGridViewRow row in dgvNhapHang.Rows)
            {
                CT_PhieuNhap cT_PhieuNhap = new CT_PhieuNhap();
                cT_PhieuNhap.MaPN = txtPhieu.Text;
                cT_PhieuNhap.STT = i;
                cT_PhieuNhap.TenHang = row.Cells["TenHang"].Value.ToString();
                cT_PhieuNhap.DonVi = 1;
                cT_PhieuNhap.DonGia = float.Parse(row.Cells["DonGia"].Value.ToString());
                cT_PhieuNhap.ThanhTien = float.Parse(row.Cells["ThanhTien"].Value.ToString());

                phieuNhapBUS = new PhieuNhapBUS();
                phieuNhapBUS.LuuCTPhieuNhap(cT_PhieuNhap);
            }

            MessageBox.Show("Lưu thành công");
        }
    }
}
