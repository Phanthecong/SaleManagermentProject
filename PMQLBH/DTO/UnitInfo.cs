using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
    public class UnitInfo
    {
        private int _unitID;
        private string _unitName;
        private string _note;

        public int UnitID { get => _unitID; set => _unitID = value; }
        public string UnitName { get => _unitName; set => _unitName = value; }
        public string Note { get => _note; set => _note = value; }
    }
}
