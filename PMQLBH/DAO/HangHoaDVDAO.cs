using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DAO
{
    class HangHoaDVDAO
    {
        DB db = new DB();
        public DataTable LoadDV()
        {
            string sqlStr = string.Format("SELECT * FROM LoaiHangHoa");
            DataTable dt = db.getData(sqlStr);
            return dt;
        }
    }
}