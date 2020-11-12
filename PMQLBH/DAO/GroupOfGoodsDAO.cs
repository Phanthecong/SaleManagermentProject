using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DAO
{
    public class GroupOfGoodsDAO
    {
        DB dB = new DB();

        public DataTable LoadAllData()
        {
            string sqlStr = string.Format("SELECT * FROM GroupOfGoods");
            return dB.getData(sqlStr);
        }

        public GroupOfGoodsInfo LoadInfo(int id)
        {
            string sqlStr = string.Format("SELECT * FROM GroupOfGoods WHERE GOGID = {0}", id);
            DataTable dt = dB.getData(sqlStr);
            GroupOfGoodsInfo groupOfGoodsInfo = new GroupOfGoodsInfo
            {
                GOGID = int.Parse(dt.Rows[0]["GOGID"].ToString()),
                GOGName = dt.Rows[0]["GOGName"].ToString(),
                Note = dt.Rows[0]["Note"].ToString(),
            };
            return groupOfGoodsInfo;
        }

        public int AddNewGroupOfGoods(GroupOfGoodsInfo groupOfGoodsInfo)
        {
            string strSQL = "INSERT INTO GroupOfGoods VALUES(@GOGID, @GOGName, @Note)";
            int nRow = 0;
            try
            {
                nRow = dB.ExecuteNonQuery(CommandType.Text, strSQL,
                new SqlParameter { ParameterName = "@GOGID", Value = groupOfGoodsInfo.GOGID },
                new SqlParameter { ParameterName = "@GOGName", Value = groupOfGoodsInfo.GOGName },
                new SqlParameter { ParameterName = "@Note", Value = groupOfGoodsInfo.Note }
                );
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return nRow;
        }

        public int DeleteGroupOfGoods(int id)
        {
            string strSQL = "DELETE FROM GroupOfGoods WHERE GOGID = @id";
            int nRow = 0;
            nRow = dB.ExecuteNonQuery(CommandType.Text, strSQL,
                new SqlParameter { ParameterName = "@id", Value = id });
            return nRow;
        }

        public int UpdateGroupOfGoods(GroupOfGoodsInfo groupOfGoodsInfo)
        {
            string strSQL = "UpdateGroupOfGoods";
            int nRow = 0;
            nRow = dB.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                new SqlParameter { ParameterName = "@GOGID", Value = groupOfGoodsInfo.GOGID },
                new SqlParameter { ParameterName = "@GOGName", Value = groupOfGoodsInfo.GOGName },
                new SqlParameter { ParameterName = "@Note", Value = groupOfGoodsInfo.Note }
                );
            return nRow;
        }
    }
}
