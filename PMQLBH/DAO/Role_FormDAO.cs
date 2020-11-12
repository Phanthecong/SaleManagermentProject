using PMQLBH.DTO;
using System.Collections.Generic;
using System.Data;

namespace PMQLBH.DAO
{
    public class Role_FormDAO
    {
        DB db = new DB();

        public List<Role_FormDTO> GetRoleForm(int roldID)
        {
            string sqlStr = string.Format("SELECT * FROM Role_Form join Form on Role_Form.FormID = Form.FormID WHERE RoleId = '{0}'", roldID);
            DataTable dt = db.getData(sqlStr);
            var list = new List<Role_FormDTO>();
            foreach(DataRow row in dt.Rows)
            {
                list.Add(
                    new Role_FormDTO() {
                        FormName = row["FormName"].ToString(),
                        RoleId = int.Parse(row["RoleId"].ToString()),
                        FormID = int.Parse(row["FormID"].ToString()),
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


    }
}
