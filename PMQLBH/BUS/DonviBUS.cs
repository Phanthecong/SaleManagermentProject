using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMQLBH.DAO;
using PMQLBH.DTO;

namespace PMQLBH.BUS
{
    public class DonviBUS
    {
        DonViDAO donViDAO = new DonViDAO();

        public DataTable LoadAllData()
        {
            return donViDAO.LoadAllData();
        }

        public int AddNew(DonViInfo donViInfo)
        {
            return donViDAO.AddNew(donViInfo);
        }

        public DonViInfo LoadInfo(int id)
        {
            return donViDAO.LoadInfo(id);
        }

        public int Delete(int id)
        {
            return donViDAO.Delete(id);
        }

        public int Update(DonViInfo donViInfo)
        {
            return donViDAO.Update(donViInfo);
        }
    }
}
