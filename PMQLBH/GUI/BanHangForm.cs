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
    public partial class BanHangForm : Form
    {
        public BanHangForm(Role_FormDTO role_FormDTO)
        {
            InitializeComponent();
            grControl.SetEnabledControl(role_FormDTO);

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
            dgvBanHang.Rows.Add(product.ProductName, unitName, product.Quantity.ToString(), product.Price.ToString(),
                (product.Quantity * product.Price).ToString());
        }

        private void Sale_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ThemHangHoaForm newform = new ThemHangHoaForm();
            newform.Show();
        }

        private void Addnew_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AddCustomerForm newform = new AddCustomerForm();
            newform.Show();
        }

        private void Addkho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AddKhoForm newform = new AddKhoForm();
            newform.Show();
        }

        private void Hanghoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HangHoaForm newform = new HangHoaForm();
            newform.Show();
        }

        private void Chungtu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ChungTuForm newform = new ChungTuForm();
            newform.Show();
        }

        private void BanHangForm_Load(object sender, EventArgs e)
        {
            CustomerBUS customerBUS = new CustomerBUS();
            cbTenKH.DataSource = customerBUS.LoadAllData();
            cbTenKH.DisplayMember = "Name";
            cbTenKH.ValueMember = "CustomerID";

            cbTenKH.SelectedValueChanged += CbTenNCC_SelectedValueChanged;

            WarehouseBUS warehouseBUS = new WarehouseBUS();
            cbKhoXuat.DataSource = warehouseBUS.LoadAllData();
            cbKhoXuat.ValueMember = "WarehouseID";
            cbKhoXuat.DisplayMember = "Name";
        }

        private void CbTenNCC_SelectedValueChanged(object sender, EventArgs e)
        {
            CustomerBUS customerBUS = new CustomerBUS();
            DataTable dt = customerBUS.LoadAllData();
            foreach (DataRow row in dt.Rows)
            {
                if (row["Name"].ToString() == cbTenKH.SelectedValue.ToString())
                {
                    txtMaKH.Text = row["CustomerID"].ToString();
                }
            }
        }

        float tongTien = 0;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhieuBanDTO phieuBan = new PhieuBanDTO();
            phieuBan.MaPB = txtPhieu.Text;
            phieuBan.MaKH = txtMaKH.Text;
            phieuBan.KhoXuat = int.Parse(cbKhoXuat.SelectedValue.ToString());
            phieuBan.Ngay = txtNgay.Text;
            phieuBan.NgayGiao = txtNgayGiao.Text;
            phieuBan.HanThanhToan = txtHanThanhToan.Text;
            phieuBan.GhiChu = txtGhiChu.Text;
            phieuBan.TongTien = tongTien;

            PhieuBanBUS phieuBanBUS = new PhieuBanBUS();
            phieuBanBUS.LuuPhieuBan(phieuBan);

            int i = 0;

            foreach (DataGridViewRow row in dgvBanHang.Rows)
            {
                CT_PhieuBan cT_PhieuBan = new CT_PhieuBan();
                cT_PhieuBan.MaPB = txtPhieu.Text;
                cT_PhieuBan.STT = i;
                cT_PhieuBan.TenHang = row.Cells["TenHang"].Value.ToString();
                cT_PhieuBan.DonVi = 1;
                cT_PhieuBan.DonGia = float.Parse(row.Cells["DonGia"].Value.ToString());
                cT_PhieuBan.ThanhTien = float.Parse(row.Cells["ThanhTien"].Value.ToString());

                phieuBanBUS = new PhieuBanBUS();
                phieuBanBUS.LuuCTPhieuBan(cT_PhieuBan);
            }

            MessageBox.Show("Lưu thành công");
        }
    }
}
