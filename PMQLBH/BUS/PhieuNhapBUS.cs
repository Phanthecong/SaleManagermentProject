using PMQLBH.DAO;
using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.BUS
{
    public class PhieuNhapBUS
    {
        PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();
        public int LuuPhieuNhap(PhieuNhapDTO p)
        {
            return phieuNhapDAO.LuuPhieuNhap(p);
        }

        public int LuuCTPhieuNhap(CT_PhieuNhap p)
        {
            return phieuNhapDAO.LuuCTPhieuNhap(p);
        }
    }
}
