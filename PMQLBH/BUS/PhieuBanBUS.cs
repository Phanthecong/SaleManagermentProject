using PMQLBH.DAO;
using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.BUS
{
    public class PhieuBanBUS
    {
        PhieuBanDAO phieuBanDAO = new PhieuBanDAO();
        public int LuuPhieuBan(PhieuBanDTO p)
        {
            return phieuBanDAO.LuuPhieuNhap(p);
        }

        public int LuuCTPhieuBan(CT_PhieuBan p)
        {
            return phieuBanDAO.LuuCTPhieuNhap(p);
        }
    }
}
