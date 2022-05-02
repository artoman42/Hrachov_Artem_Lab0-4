using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Phone:ElectronicDevice
    {
        private string color;
        private int ram;
        public Phone(int ram, string color) : base(ram,color) { }

        public override int RAM
        {
            get => ram;
            set => ram = value;
        }
        public override string Color
        {
            get => color;
            set => color = "Error";
        }
        public override void Reboot()
        {
            Console.WriteLine("Phone has done REBOOT!!");
        }
        public override string GetKeyboardColor()
        {
            return "It`s phone! It hasn`t physic keyboard!" ;
        }
    }
}
