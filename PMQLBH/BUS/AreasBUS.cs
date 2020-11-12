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
    public class AreasBUS
    {
        AreasDAO areaDAO = new AreasDAO();

        public DataTable LoadAllArea()
        {
            return areaDAO.LoadAllData();
        }

        public AreaInfo LoadInfo(int id)
        {
            return areaDAO.LoadInfo(id);
        }

        public int AddNewArea(AreaInfo areasInfo)
        {
            return areaDAO.AddNewArea(areasInfo);
        }

        public int DeleteArea(int id)
        {
            return areaDAO.DeleteArea(id);
        }

        public int UpdateArea(AreaInfo areasInfo)
        {
            return areaDAO.UpdateArea(areasInfo);
        }
    }
}
