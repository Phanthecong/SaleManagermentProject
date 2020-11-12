using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
   public class DonViInfo
    {
        private int unitID;
        private string name;
        private string note;

        public string Note { get => note; set => note = value; }
        public string Name { get => name; set => name = value; }
        public int UnitID { get => unitID; set => unitID = value; }

        //private int exchangeRateID;
        //private string name;
        //private int exchangeRate;

        //public int ExchangeRateID { get => exchangeRateID; set => exchangeRateID = value; }
        //public string Name { get => name; set => name = value; }
        //public int ExchangeRate { get => exchangeRate; set => exchangeRate = value; }

        
    }
}
