using PMQLBH.DAO;
using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.BUS
{
    public class Role_FormBUS
    {
        Role_FormDAO role_FormDAO = new Role_FormDAO();

        public List<Role_FormDTO> GetRoleForm(int roldID)
        {
            return role_FormDAO.GetRoleForm(roldID);
        }
    }
}
