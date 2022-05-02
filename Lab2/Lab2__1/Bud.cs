using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2__1
{
    class Bud
    {
        private string color;
        public string Color { get { return color; } set { color = value; } }
        public Bud(string color)
        {
            this.color = color;
        }
        public string GetBudColor()
        {
            return this.color;
        }
    }
}
