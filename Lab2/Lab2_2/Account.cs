using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class Account
    {
        private Currency type;
        private double amount;
        private bool active;
        private List<Payment> payment_list = new List<Payment>();
        public Currency Type { get { return type; } set { type = value; } }
        public double Amount { get { return amount; } set { amount = value; } }
        public bool Active { get { return active; } set { active = value; } }
       // public List<Payment> Payment_list { get { return payment_list; } set { payment_list = value; } }
        public Account(Currency type, double amount, bool active)
        {
            this.type = type;
            this.amount = amount;
            this.active = active;
        }
        public override string ToString()
        {
            if (this.active == false) return Type.Name + " не активний ";
            else return Type.Name + " " + Convert.ToString(amount) +  " активний ";
        }
        public static void AccountWrite(List<Account> Account_list)
        {
            foreach(Account ob in Account_list)
            {
                Console.WriteLine(ob.ToString());
            }
        }

        public void CalcAmount()
        {
            this.amount = 0;
            foreach(Payment ob in payment_list)
            {
                this.amount += ob.Sum;
            }
        }
        public void RecievePayment(Payment pay)
        {
            payment_list.Add(pay);
        }
        public List<Payment> GetPay()
        {
            return payment_list;
        }
        public static double FullCryptoCalc(List<Account> acc_list)
        {
            double res = 0;
            for(int i = 0; i < acc_list.Count; i++)
            {
                if (acc_list[i].Type.Name == "UAH") continue;
                res += acc_list[i].Amount * acc_list[i].Type.Rate;
            }
            return res;
        }
    }
}
