using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using PMQLBH.BUS;
using PMQLBH.DAO;
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
    public partial class MainForm : Form
    {
        List<Role_FormDTO> role_FormDTOList = new List<Role_FormDTO>();
        private UserInfo userInfo;
        private int roleID;
        Role_FormBUS role_FormBUS = new Role_FormBUS();

        public MainForm(List<Role_FormDTO> role_FormDTOList, UserInfo userInfo, int roleID)
        {
            InitializeComponent();
            this.role_FormDTOList = role_FormDTOList;
            this.userInfo = userInfo;
            this.roleID = roleID;
        }

 

        private void btnEndApp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnInformation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InformationForm information = new InformationForm();
            information.Show();
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

        private void btnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            ChangePasswordForm changePassword = new ChangePasswordForm(userInfo);
            changePassword.Show();
        }

        private void btnChungTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var form = new ChungTuForm();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btbNhaphang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new NhapHangForm();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Role_FormDTO role_FormDTO = new Role_FormDTO();
            role_FormDTOList = role_FormBUS.GetRoleForm(roleID);
            foreach (var i in role_FormDTOList)
            {
                if (i.FormID == 3)
                {
                    role_FormDTO = i;
                    break;
                }
            }
            var form = new BanHangForm(role_FormDTO);
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnChuyenKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new ChuyenKhoForm();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnTonKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new TonKhoForm();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnKhuVuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Role_FormDTO role_FormDTO = new Role_FormDTO();
            role_FormDTOList = role_FormBUS.GetRoleForm(roleID);
            foreach (var i in role_FormDTOList)
            {
                if (i.FormID == 4)
                {
                    role_FormDTO = i;
                    break;
                }
            }
            var form = new KhuVucForm(role_FormDTO);
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Role_FormDTO role_FormDTO = new Role_FormDTO();
            foreach (var i in role_FormDTOList)
            {
                if (i.FormID == 5)
                {
                    role_FormDTO = i;
                    break;
                }
            }
            var form = new CustomerForm(role_FormDTO);
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Role_FormDTO role_FormDTO = new Role_FormDTO();
            foreach (var i in role_FormDTOList)
            {
                if (i.FormID == 6)
                {
                    role_FormDTO = i;
                    break;
                }
            }
            var form = new NhaCungCapForm(role_FormDTO);
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnKhoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Role_FormDTO role_FormDTO = new Role_FormDTO();
            foreach (var i in role_FormDTOList)
            {
                if (i.FormID == 7)
                {
                    role_FormDTO = i;
                    break;
                }
            }
            var form = new KhoHangForm();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnDonViTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Role_FormDTO role_FormDTO = new Role_FormDTO();
            foreach (var i in role_FormDTOList)
            {
                if (i.FormID == 8)
                {
                    role_FormDTO = i;
                    break;
                }
            }
            var form = new DonViTinhForm(role_FormDTO);
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnNhomHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Role_FormDTO role_FormDTO = new Role_FormDTO();
            foreach (var i in role_FormDTOList)
            {
                if (i.FormID == 4)
                {
                    role_FormDTO = i;
                    break;
                }
            }
            var form = new NhomHangForm(role_FormDTO);
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Role_FormDTO role_FormDTO = new Role_FormDTO();
            foreach (var i in role_FormDTOList)
            {
                if (i.FormID == 10)
                {
                    role_FormDTO = i;
                    break;
                }
            }
            var form = new HangHoaForm();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnTyGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Role_FormDTO role_FormDTO = new Role_FormDTO();
            foreach (var i in role_FormDTOList)
            {
                if (i.FormID == 11)
                {
                    role_FormDTO = i;
                    break;
                }
            }
            var form = new TyGiaForm();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnBoPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Role_FormDTO role_FormDTO = new Role_FormDTO();
            foreach (var i in role_FormDTOList)
            {
                if (i.FormID == 12)
                {
                    role_FormDTO = i;
                    break;
                }
            }
            var form = new BoPhanForm();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Role_FormDTO role_FormDTO = new Role_FormDTO();
            foreach (var i in role_FormDTOList)
            {
                if (i.FormID == 13)
                {
                    role_FormDTO = i;
                    break;
                }
            }
            var form = new NhanVienForm();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnThutien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Role_FormDTO role_FormDTO = new Role_FormDTO();
            foreach (var i in role_FormDTOList)
            {
                if (i.FormID == 4)
                {
                    role_FormDTO = i;
                    break;
                }
            }
            var form = new ThuTienForm();
            if (ExistForm(form))
                return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnPhieuthu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Role_FormDTO role_FormDTO = new Role_FormDTO();
            foreach (var i in role_FormDTOList)
            {
                if (i.FormID == 4)
                {
                    role_FormDTO = i;
                    break;
                }
            }
            var form = new TraTienForm();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Role_FormDTO role_FormDTO = new Role_FormDTO();
            foreach (var i in role_FormDTOList)
            {
                if (i.FormID == 14)
                {
                    role_FormDTO = i;
                    break;
                }
            }
            var form = new PhanQuyenForm();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach(Role_FormDTO i in role_FormDTOList)
            {
                switch (i.FormID)
                {
                   
                    case 4:
                        if(i.AllowAccess == false)
                        {
                            btnKhuVuc.Enabled = false;
                        }
                        break;
                    case 5:
                        if (i.AllowAccess == false)
                        {
                            btnKhachHang.Enabled = false;
                        }
                        break;
                    case 6:
                        if (i.AllowAccess == false)
                        {
                            btnNhaCungCap.Enabled = false;
                        }
                        break;
                    case 7:
                        if (i.AllowAccess == false)
                        {
                            btnKhoHang.Enabled = false;
                        }
                        break;
                    case 8:
                        if (i.AllowAccess == false)
                        {
                            btnDonViTinh.Enabled = false;
                        }
                        break;
                    case 9:
                        if (i.AllowAccess == false)
                        {
                            btnNhomHang.Enabled = false;
                        }
                        break;
                    case 10:
                        if (i.AllowAccess == false)
                        {
                            btnHangHoa.Enabled = false;
                        }
                        break;
                    case 11:
                        if (i.AllowAccess == false)
                        {
                            btnTyGia.Enabled = false;
                        }
                        break;
                    case 12:
                        if (i.AllowAccess == false)
                        {
                            btnBoPhan.Enabled = false;
                        }
                        break;
                    case 13:
                        if (i.AllowAccess == false)
                        {
                            btnKhachHang.Enabled = false;
                        }
                        break;
                    case 14:
                        if (i.AllowAccess == false)
                        {
                            btnPhanQuyen.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}


