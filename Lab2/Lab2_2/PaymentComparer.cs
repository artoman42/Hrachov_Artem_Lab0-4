using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class PaymentComparer : IComparer<Payment>
    {
        public int Compare(Payment p1, Payment p2)
        {
            if (p1 is null || p2 is null)
                throw new ArgumentException("Не коректне значення!");
            return  -p1.Days  + p2.Days;
        }
    }
}
