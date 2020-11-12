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
    public partial class PhanQuyenForm : Form
    {
        public PhanQuyenForm()
        {
            InitializeComponent();
            
        }

        private void CbVaiTro_SelectedValueChanged(object sender, EventArgs e)
        {
            
            ReLoad();
        }

        private void PhanQuyenForm_Load(object sender, EventArgs e)
        {
            RolesBUS rolesBUS = new RolesBUS();
            DataTable dt = rolesBUS.LoadAllData();
            cbVaiTro.DataSource = dt;
            cbVaiTro.DisplayMember = "Rolename";
            cbVaiTro.ValueMember = "RoleID";
            ReLoad();
            cbVaiTro.SelectedValueChanged += CbVaiTro_SelectedValueChanged;
        }

        private void ReLoad()
        {
            PhanQuyenBUS phanQuyenBUS = new PhanQuyenBUS();
            List<PhanQuyenDTO> phanQuyenDTOs = phanQuyenBUS.GetRoleForm(int.Parse(cbVaiTro.SelectedValue.ToString()));
            dgvPhanQuyen.DataSource = phanQuyenDTOs;
            dgvPhanQuyen.Columns["FormID"].Visible = false;
            dgvPhanQuyen.Columns["FormName"].HeaderText = "Chức năng";
            dgvPhanQuyen.Columns["AllowAccess"].HeaderText = "Truy cập";
            dgvPhanQuyen.Columns["AllowAdd"].HeaderText = "Thêm";
            dgvPhanQuyen.Columns["AllowDelete"].HeaderText = "Xóa";
            dgvPhanQuyen.Columns["AllowUpdate"].HeaderText = "Cập nhật";
            dgvPhanQuyen.Columns["AllowImport"].HeaderText = "Nhập";
            dgvPhanQuyen.Columns["AllowExport"].HeaderText = "Xuất";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PhanQuyenBUS phanQuyenBUS = new PhanQuyenBUS();
            List<PhanQuyenDTO> phanQuyenDTOs = new List<PhanQuyenDTO>();
            foreach (DataGridViewRow dr in dgvPhanQuyen.Rows)
            {
                PhanQuyenDTO item = new PhanQuyenDTO();
                item.FormName = dr.Cells["FormName"].Value.ToString();
                item.AllowAccess = bool.Parse(dr.Cells["AllowAccess"].Value.ToString());
                item.AllowAdd = bool.Parse(dr.Cells["AllowAdd"].Value.ToString());
                item.AllowDelete = bool.Parse(dr.Cells["AllowDelete"].Value.ToString());
                item.AllowImport = bool.Parse(dr.Cells["AllowImport"].Value.ToString());
                item.AllowUpdate = bool.Parse(dr.Cells["AllowUpdate"].Value.ToString());
                item.AllowExport = bool.Parse(dr.Cells["AllowExport"].Value.ToString());
                item.FormID = int.Parse(dr.Cells["FormID"].Value.ToString());
                
                phanQuyenDTOs.Add(item);
            }
            phanQuyenBUS.SetRoleForm(phanQuyenDTOs, int.Parse(cbVaiTro.SelectedValue.ToString()));
        }
    }
}
