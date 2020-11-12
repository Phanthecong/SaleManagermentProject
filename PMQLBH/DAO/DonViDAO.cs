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
    public class DonViDAO
    {
        DB dB = new DB();
        public DataTable LoadAllData()
        {
            string sqlStr = string.Format("SELECT * FROM Units");
            return dB.getData(sqlStr);
        }

        public DonViInfo LoadInfo(int id)
        {
            string sqlStr = string.Format("SELECT * FROM Units WHERE UnitID = {0}", id);
            DataTable dt = dB.getData(sqlStr);
            DonViInfo donViInfo = new DonViInfo();
            donViInfo.UnitID = int.Parse(dt.Rows[0]["UnitID"].ToString());
            donViInfo.Name = dt.Rows[0]["Name"].ToString();
            donViInfo.Note = dt.Rows[0]["Note"].ToString();

            return donViInfo;
        }
        public int AddNew(DonViInfo donViInfo)
        {
            string strSql = "INSERT INTO Units VALUES(@UnitID, @Name, @Note)";
            int nRow = 0;
            try
            {
                nRow = dB.ExecuteNonQuery(CommandType.Text, strSql,
                 new SqlParameter { ParameterName = "@UnitID", Value = donViInfo.UnitID },
                 new SqlParameter { ParameterName = "@Name", Value = donViInfo.Name },
                 new SqlParameter { ParameterName = "@Note", Value = donViInfo.Note }
                 );
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return nRow;
        }
        public int Delete(int id)
        {
            string strSQL = "DELETE FROM ExchangeRate WHERE UnitID = @id";
            int nRow = 0;
            nRow = dB.ExecuteNonQuery(CommandType.Text, strSQL,
                new SqlParameter { ParameterName = "@id", Value = id });
            return nRow;
        }
        public int Update(DonViInfo donViInfo)
        {
            string strSQL = "UpdateUnits";
            int nRow = 0;
            try
            {
                nRow = dB.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                        new SqlParameter { ParameterName = "@UnitID", Value = donViInfo.UnitID },
                        new SqlParameter { ParameterName = "@Name", Value = donViInfo.Name },
                        new SqlParameter { ParameterName = "@Note", Value = donViInfo.Note }
                     );
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return nRow;
        }
    }
}
