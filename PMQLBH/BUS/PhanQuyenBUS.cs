using PMQLBH.DAO;
using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.BUS
{
    public class PhanQuyenBUS
    {
        PhanQuyenDAO phanQuyenDAO = new PhanQuyenDAO();

        public List<PhanQuyenDTO> GetRoleForm(int roldID)
        {
            return phanQuyenDAO.GetRoleForm(roldID);
        }

        public void SetRoleForm(List<PhanQuyenDTO> phanQuyenDTOs, int RoleID)
        {
            phanQuyenDAO.SetRoleForm(phanQuyenDTOs, RoleID);
        }
    }
}
