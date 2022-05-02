using System;
using System.Collections.Generic;

namespace Lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Console.WriteLine("Введiть список :");
            string input = Console.ReadLine();
            string[] buff = input.Split(" ");
            try
            {
                foreach (string ob in buff)
                {
                    if(ob!= " ") a.Add(Convert.ToInt32(ob));

                }
            }
            catch
            {
                Console.WriteLine("Не правильнi данi!");
            }
            int res = Calc(a);
            Console.WriteLine("Результат : " + res);
        }
        static int Calc(List<int> a)
        {
            int res = 0;
            int[] f = new int[10000];
            for(int i = 0; i < a.Count; i++) f[a[i]]++;
            for (int i = 0; i < 10000; i++) res += f[i] / 2;
            return res;
        }
    }
}
