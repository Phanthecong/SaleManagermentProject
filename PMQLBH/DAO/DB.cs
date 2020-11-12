using System.Data;
using System.Data.SqlClient;

namespace PMQLBH.DAO
{
    public class DB
    {
        string connectionStr = @"Data Source=DESKTOP-1T607EI\SQLEXPRESS;Initial Catalog=SalesManagermentSoftwareDB;Integrated Security=True";
        SqlConnection connection { get; set; }

        public DataTable getData(string sqlStr)
        {
            connection = new SqlConnection(connectionStr);
            connection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStr, connectionStr);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            connection.Close();
            return dt;
        }

        public int ExecuteNonQuery(CommandType cmtType, string strSql,
                            params SqlParameter[] parameters)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmtType;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                int nRow = command.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
