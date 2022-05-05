using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer_ex = new Computer(5, "Red");
            PC pc_ex = new PC(16, "Blue");
            Laptop laptop_ex = new Laptop(8,"White");
            Phone phone_ex = new Phone(4, "");
            ListOfElectronicDevice list = new ListOfElectronicDevice();
            list.Add(computer_ex);
            list.Add(pc_ex);
            list.Add(laptop_ex);
            list.Add(phone_ex);
            for(int i = 0; i < list.GetCount(); i++)
            {
                Console.WriteLine(list.GetKeyboard(i));
                list.Reboot(i);
            }
        }
    }
}
