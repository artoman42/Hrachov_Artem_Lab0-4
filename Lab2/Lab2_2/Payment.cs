using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class Payment
    {
        private double sum;
        private int days;
        private Currency _currency;
        public double Sum { get { return sum; } set { sum = value; } }
        public Currency _Currency { get { return _currency; } set { _currency = value; } }
        public int Days { get { return days; } set { days = value; } }
        
        public Payment(double sum, Currency _currency, int days)
        {
            this.sum = sum;
            this._currency = _currency;
            this.days = days;
        }
    }
}
