using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DAO
{
    class FieldsDAO
    {
        DB dB = new DB();

        public DataTable LoadInfo()
        {
            string sqlStr = string.Format("Select * from Fields");
            DataTable dt = dB.getData(sqlStr);
            return dt;
        }
        public DataTable LoadDV()
        {
            string sqlStr = string.Format("SELECT * FROM GROUPOFGOODS");
            DataTable dt = dB.getData(sqlStr);
            return dt;
        }
        public DataTable LoadHH()
        {
            string sqlStr = string.Format("SELECT *FROM COMPANY");
            DataTable dt = dB.getData(sqlStr);
            return dt;
        }
        public DataTable LoadhhDV()
        {
            string sqlStr = string.Format("SELECT * FROM WAREHOUSE");
            DataTable dt = dB.getData(sqlStr);
            return dt;
        }
    }
}
