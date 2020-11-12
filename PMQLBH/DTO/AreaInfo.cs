using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
    public class AreaInfo
    {
        private int _areaID;
        private string _areaName;
        private string _note;

        public int AreaID { get => _areaID; set => _areaID = value; }
        public string AreaName { get => _areaName; set => _areaName = value; }
        public string Note { get => _note; set => _note = value; }
    }
}
