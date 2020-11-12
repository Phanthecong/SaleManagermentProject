using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
    public class ExchangeRateInfo
    {
        private int _exchangeRateID;
        private string _exchangeRateName;
        private float _exchangeRate;

        public float ExchangeRate { get => _exchangeRate; set => _exchangeRate = value; }
        public string ExchangeRateName { get => _exchangeRateName; set => _exchangeRateName = value; }
        public int ExchangeRateID { get => _exchangeRateID; set => _exchangeRateID = value; }
    }
}
