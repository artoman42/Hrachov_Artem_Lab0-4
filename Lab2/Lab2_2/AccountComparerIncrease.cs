using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class AccountComparerIncrease: IComparer<Account>
    {
        public int Compare(Account p1, Account p2)
        {
            if (p1 is null || p2 is null)
                throw new ArgumentException("Не коректне значення!");
            return Convert.ToInt32(p1.Type.Rate* p1.Amount) - Convert.ToInt32(p2.Type.Rate*p2.Amount);
        }
    }
}
