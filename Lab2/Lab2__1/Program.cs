using System;
using System.Collections.Generic;

namespace Lab2__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Створення квiтки! Введiть кiлькiсть пелюсток i колiр бутону через пробiл!");
            string input = Console.ReadLine();
            string[] buff = input.Split(" ");
            int Petal_amount = 0; string col = "";
            try
            {
                Petal_amount = Convert.ToInt32(buff[0]);
                col = buff[1];
            }
            catch
            {
                Console.WriteLine("Введенi не коректнi данi!");
            }
            Bud bud_ex = new Bud(col);
            List<Petal> Petal_list = new List<Petal>();
            for(int i = 0; i < Petal_amount; i++)
            {
                Petal petal_ex = new Petal(bud_ex.Color);
                Petal_list.Add(petal_ex);
            }
            Flower flower_ex = new Flower(bud_ex, Petal_list, Petal_amount);
            Console.WriteLine(flower_ex.ToString());
            Console.WriteLine("Перевiрка Equals!");
            List<Petal> Petal_list_test = new List<Petal>();
            Bud bud_test = new Bud("red");
            for(int i = 0; i < 5; i++)
            {
                Petal petal_test = new Petal(bud_test.Color);
                Petal_list_test.Add(petal_test);
            }
            Flower flower_test = new Flower(bud_test, Petal_list_test, 5);
            Console.WriteLine(flower_test.ToString());
            Console.WriteLine(flower_ex.Equals(flower_test));
            Console.WriteLine("Перевiрку завершено!");
            flower_ex.Blossom();
            Console.WriteLine("Чи хочете побачити колiр бутона!(0 - так, 1 - нi)");
            input = Console.ReadLine();
            int t = 0;
            try
            {
                t = Convert.ToInt32(input);
            }
            catch
            {
                Console.WriteLine("Введенi не коректнi данi!");
            }
            if (t == 0) Console.WriteLine(flower_ex.FlBud.GetBudColor());
            flower_ex.Fade();
        }
    }
}
