using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
    public class DepartmentInfo
    {
        private int _departmentID;
        private string _departmentName;
        private string _Note;

        public int DepartmentID { get => _departmentID; set => _departmentID = value; }
        public string DepartmentName { get => _departmentName; set => _departmentName = value; }
        public string Note { get => _Note; set => _Note = value; }
    }
}
