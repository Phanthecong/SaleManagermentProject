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
    public class ProductDAO
    {
        DB dB = new DB();

        public DataTable LoadAllData()
        {
            string sqlStr = string.Format("SELECT * FROM Products");
            return dB.getData(sqlStr);
        }
        public ProductInfo LoadInfo(int id)
        {
            string sqlStr = string.Format("SELECT * FROM Products WHERE ProductID = {0}", id);
            DataTable dt = dB.getData(sqlStr);
            ProductInfo productInfo = new ProductInfo();
            productInfo.ProductID = int.Parse(dt.Rows[0]["ProductID"].ToString());
            productInfo.Name = dt.Rows[0]["Name"].ToString();
            productInfo.Description = dt.Rows[0]["Description"].ToString();
            productInfo.Image = dt.Rows[0]["Image"].ToString();
            productInfo.Quantity= int.Parse(dt.Rows[0]["Quantity"].ToString());
            productInfo.UnitID = int.Parse(dt.Rows[0]["UnitID"].ToString());
            productInfo.Price = int.Parse(dt.Rows[0]["Price"].ToString());
            productInfo.Code = dt.Rows[0]["Code"].ToString();
            productInfo.SupplierID = int.Parse(dt.Rows[0]["SupplierID"].ToString());
            productInfo.WarehouseID = int.Parse(dt.Rows[0]["WarehouseID"].ToString());
            return productInfo;
        }
        public int AddNew(ProductInfo productInfo)
        {
            string strSql = "INSERT INTO Products VALUES(@ProductID,  @Name, @Description, @Image, @Quantity,  @UnitID, @Price, @Code, @SupplierID, @WarehouseID)";
            int nRow = 0;
            try
            {
                nRow = dB.ExecuteNonQuery(CommandType.Text, strSql,
                 new SqlParameter { ParameterName = "@ProductID", Value = productInfo.ProductID},
                 new SqlParameter { ParameterName = "@Name", Value = productInfo.Name },
                 new SqlParameter { ParameterName = "@Description", Value = productInfo.Description },
                 new SqlParameter { ParameterName = "@Image", Value = productInfo.Image },
                 new SqlParameter { ParameterName = "@Quantity", Value = productInfo.Quantity },
                 new SqlParameter { ParameterName = "@UnitID", Value = productInfo.UnitID },
                 new SqlParameter { ParameterName = "@Price", Value = productInfo.Price },
                 new SqlParameter { ParameterName = "@Code", Value = productInfo.Code },
                 new SqlParameter { ParameterName = "@SupplierID", Value = productInfo.SupplierID },
                 new SqlParameter { ParameterName = "@WarehouseID", Value = productInfo.WarehouseID }
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
            string strSQL = "DELETE FROM Products WHERE ProductID = @id";
            int nRow = 0;
            nRow = dB.ExecuteNonQuery(CommandType.Text, strSQL,
                new SqlParameter { ParameterName = "@id", Value = id });
            return nRow;
        }
        public int Update(ProductInfo productInfo)
        {
            string strSQL = "UpdateProduct";
            int nRow = 0;
            try
            {
                nRow = dB.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                 new SqlParameter { ParameterName = "@ProductID", Value = productInfo.ProductID },
                 new SqlParameter { ParameterName = "@Name", Value = productInfo.Name },
                 new SqlParameter { ParameterName = "@Description", Value = productInfo.Description },
                 new SqlParameter { ParameterName = "@Image", Value = productInfo.Image },
                 new SqlParameter { ParameterName = "@Quantity", Value = productInfo.Quantity },
                 new SqlParameter { ParameterName = "@UnitID", Value = productInfo.UnitID },
                 new SqlParameter { ParameterName = "@Price", Value = productInfo.Price },
                 new SqlParameter { ParameterName = "@Code", Value = productInfo.Code },
                 new SqlParameter { ParameterName = "@SupplierID", Value = productInfo.SupplierID },
                 new SqlParameter { ParameterName = "@WarehouseID", Value = productInfo.WarehouseID }
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

