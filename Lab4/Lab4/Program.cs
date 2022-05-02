using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Computer computer_ex = new Computer(5, "Red");
            Console.WriteLine(computer_ex.GetKeyboardColor());
            computer_ex.Reboot();
            PC pc_ex = new PC(16, "Blue");
            Console.WriteLine(pc_ex.GetKeyboardColor());
            pc_ex.Reboot();
            Laptop laptop_ex = new Laptop(8,"White");
            Console.WriteLine(laptop_ex.GetKeyboardColor());
            laptop_ex.Reboot();
            Phone phone_ex = new Phone(4, "");
            Console.WriteLine(phone_ex.GetKeyboardColor());
            phone_ex.Reboot();
        }
    }
}
