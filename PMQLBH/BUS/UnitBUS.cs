using PMQLBH.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.BUS
{
    public class UnitBUS
    {
        UnitDAO unitDAO = new UnitDAO();

        public DataTable LoadAllData()
        {
            return unitDAO.LoadAllData();
        }
    }
}
