using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class PC:ElectronicDevice
    {
        private string color;
        private int ram;
        public PC(int ram, string color) : base(ram, color) { }

        public override int RAM
        {
            get => ram;
            set => ram = value;
        }
        public override string Color
        {
            get => color;
            set => color = value;
        }
        public override void Reboot()
        {
            Console.WriteLine("PC has done REBOOT!!");
        }
        public override string GetKeyboardColor()
        {
            return Color;
        }
    }
}
