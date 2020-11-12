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
    public class AreasDAO
    {
        DB dB = new DB();

        public DataTable LoadAllData()
        {
            string sqlStr = string.Format("SELECT * FROM Areas");
            return dB.getData(sqlStr);
        }

        public AreaInfo LoadInfo(int id)
        {
            string sqlStr = string.Format("SELECT * FROM Areas WHERE AreaID = {0}", id);
            DataTable dt = dB.getData(sqlStr);
            AreaInfo areasInfo = new AreaInfo
            {
                AreaID = int.Parse(dt.Rows[0]["AreaID"].ToString()),
                AreaName = dt.Rows[0]["AreaName"].ToString(),
                Note = dt.Rows[0]["Note"].ToString(),
            };
            return areasInfo;
        }

        public int AddNewArea(AreaInfo areaInfo)
        {
            string strSQL = "INSERT INTO Areas VALUES(@AreaID, @AreaName, @Note)";
            int nRow = 0;
            try
            {
                nRow = dB.ExecuteNonQuery(CommandType.Text, strSQL,
                new SqlParameter { ParameterName = "@AreaID", Value = areaInfo.AreaID },
                new SqlParameter { ParameterName = "@AreaName", Value = areaInfo.AreaName },
                new SqlParameter { ParameterName = "@Note", Value = areaInfo.Note }
                );
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            return nRow;
        }

        public int DeleteArea(int id)
        {
            string strSQL = "DELETE FROM Areas WHERE AreaID = @id";
            int nRow = 0;
            nRow = dB.ExecuteNonQuery(CommandType.Text, strSQL,
                new SqlParameter { ParameterName = "@id", Value = id });
            return nRow;
        }

        public int UpdateArea(AreaInfo areasInfo)
        {
            string strSQL = "UpdateArea";
            int nRow = 0;
            nRow = dB.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                new SqlParameter { ParameterName = "@AreaID", Value = areasInfo.AreaID },
                new SqlParameter { ParameterName = "@AreaName", Value = areasInfo.AreaName },
                new SqlParameter { ParameterName = "@Note", Value = areasInfo.Note }
                );
            return nRow;
        }
    }
}
