using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class Currency
    {
        private string name;
        private double rate; //відносно долара
        public string Name { get { return name; } set { name = value; } }
        public double Rate { get { return rate; } set { rate = value; } }
        public Currency(string name , double rate)
        {
            this.name = name;
            this.rate = rate;
        }

        public override string ToString()
        {
            return this.name + " "+Convert.ToString(rate);
        }
        public static void Currency_write(List<Currency> Currency_list)
        {
            foreach(var ob in Currency_list)
            {
                Console.WriteLine(ob.ToString());
            }
        }
    }
}
