using PMQLBH.DTO;
using System.Collections.Generic;
using System.Data;

namespace PMQLBH.DAO
{
    public class PhanQuyenDAO
    {
        DB db = new DB();

        public List<PhanQuyenDTO> GetRoleForm(int roldID)
        {
            string sqlStr = string.Format("SELECT * FROM Role_Form join Form on Role_Form.FormID = Form.FormID WHERE RoleId = '{0}'", roldID);
            DataTable dt = db.getData(sqlStr);
            var list = new List<PhanQuyenDTO>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(
                    new PhanQuyenDTO()
                    {
                        FormID = int.Parse(row["FormID"].ToString()),
                        FormName = row["FormName"].ToString(),
                        AllowAccess = bool.Parse(row["AllowAccess"].ToString()),
                        AllowAdd = bool.Parse(row["AllowAdd"].ToString()),
                        AllowDelete = bool.Parse(row["AllowDelete"].ToString()),
                        AllowUpdate = bool.Parse(row["AllowUpdate"].ToString()),
                        AllowImport = bool.Parse(row["AllowImport"].ToString()),
                        AllowExport = bool.Parse(row["AllowExport"].ToString())
                    });
            }
            return list;
        }

        public void SetRoleForm(List<PhanQuyenDTO> phanQuyenDTOs, int RoleID)
        {
            string sql;
            foreach(PhanQuyenDTO i in phanQuyenDTOs)
            {
                sql = string.Format("UPDATE Role_Form SET AllowAccess = '{0}', AllowAdd = '{1}', AllowDelete = '{2}', AllowUpdate = '{3}', AllowImport = '{4}', AllowExport = '{5}' WHERE RoleId = '{6}' AND FormID = '{7}'", i.AllowAccess, i.AllowAdd, i.AllowDelete, i.AllowUpdate, i.AllowImport, i.AllowExport, RoleID, i.FormID);
                db.ExecuteNonQuery(CommandType.Text, sql);
            }
        }

    }
}
