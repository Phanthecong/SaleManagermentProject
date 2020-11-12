using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
    public class GroupOfGoodsInfo
    {
        private int _gOGID;
        private string _gOGName;
        private string _note;

        public int GOGID { get => _gOGID; set => _gOGID = value; }
        public string GOGName { get => _gOGName; set => _gOGName = value; }
        public string Note { get => _note; set => _note = value; }
    }
}
