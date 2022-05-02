using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2__1
{
    class Petal
    {
        private string color;
        public string Color { get { return color; } set { color = value; } }

        public Petal(string color)
        {
            this.color = color;
        }
    }
}
