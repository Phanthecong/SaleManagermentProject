using PMQLBH.DAO;
using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.BUS
{
    class HangHoaDVBUS
    {
        HangHoaDVDAO hangHoaDVDAO = new HangHoaDVDAO();
        public DataTable LoadDV()
        {
            return hangHoaDVDAO.LoadDV();
        }
    }
}
