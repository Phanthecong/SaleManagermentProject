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
    public class FieldBUS
    {
        FieldsDAO fieldDAO = new FieldsDAO();
        public DataTable LoadInfo()
        {
            return fieldDAO.LoadInfo();
        }
        public DataTable LoadDV()
        {
            return fieldDAO.LoadDV();
        }
        public DataTable LoadHH()
        {
            return fieldDAO.LoadHH();

        }
        public DataTable LoadhhDV()
        {
            return fieldDAO.LoadhhDV();
        }
    }
}
