using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть послідовність цілих чисел !");
            string input = Console.ReadLine();
            string[] buff = input.Split(" ");
            List<int> list = new List<int>();
            try
            {
                foreach(string ob in buff)
                {
                   if(ob!=" ") list.Add(Convert.ToInt32(ob));
                }
            }
            catch
            {
                Console.WriteLine("Не правильні дані! ");
            }
            var linq_list = list.Distinct().Where(i => i % 2 == 1) ;
            foreach (int i in linq_list) Console.Write(i + " ");
        }
        
    }
}
