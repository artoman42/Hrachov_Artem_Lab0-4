using System;
using System.Collections.Generic;

namespace Lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть значення словника !");
            string input = Console.ReadLine();
            string[] buff = input.Split(" ");
            var nums = new Dictionary<int, int>();
            try
            {
                int i = 0;
                foreach (string ob in buff)
                {
                   if(ob!=" ")
                    {
                        nums.Add(i, Convert.ToInt32(ob));
                        i++;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Не правильні дані !");
            }
            int MIN = FindMinInDict(nums);
            int MAX = FindMaxInDict(nums);
            List<int> res = new List<int>();
            if (MIN != -1) res.Add(MIN);
            if (MAX != -1) res.Add(MAX);
            if (res.Count == 0) Console.WriteLine("Список пустий !");
            else
            {
                Console.WriteLine("Список :");
                foreach(int a in res)
                {
                    Console.WriteLine(a + " ");
                }
            }
        }
        static int FindMinInDict(Dictionary<int,int> nums)
        {
            int res = 0xFFFFFF,  val  =0;
            bool fl = false;
            for(int i = 0; i < nums.Count; i++)
            {
               val = nums[i];
                if (res == val)
                {
                    fl = true;
                }
                else if(res> val)
                {
                    fl = false;
                    res = val;
                }
            }

            return fl ? -1 : res ;
        }
        static int FindMaxInDict(Dictionary<int, int> nums)
        {
            int res = -1, val = 0;
            bool fl = false;
            for (int i = 0; i < nums.Count; i++)
            {
                val = nums[i]; 
                if (res == val)
                {
                    fl = true;
                }
                else if (res < val)
                {
                    fl = false;
                    res = val;
                }
            }

            return fl ? -1 : res;
        }
    }
}
