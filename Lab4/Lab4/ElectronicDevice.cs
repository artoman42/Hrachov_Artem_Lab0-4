using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class ElectronicDevice
    {
        public abstract int RAM { get; set; }
        public abstract string Color { get; set; }
        public ElectronicDevice(int ram, string color)
        {
            RAM = ram;
            Color = color;
        }

        public abstract string GetKeyboardColor();
        public abstract void Reboot();

    }
}
