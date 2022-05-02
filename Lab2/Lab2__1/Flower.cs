using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2__1
{
    class Flower
    {
        private Bud flBud;
        private List<Petal> petal_list;
        private int petal_Amount;
        public int Petal_Amount { get { return petal_Amount; } set { petal_Amount = value; } }
        public Bud FlBud { get { return flBud; } set { flBud = value; } }
        public List<Petal> Petal_list { get { return petal_list; } set { petal_list = value; } }

        public Flower(Bud flBud, List<Petal> petal_list, int petal_Amount)
        {
            this.flBud = flBud;
            this.petal_list = petal_list;
            this.petal_Amount = petal_Amount;
        }
        public void Blossom()
        {
            Console.WriteLine("Квiтка розквiтла!");
        }
        public void Fade()
        {
            Console.WriteLine("Квiтка зiв'яла!");
        }
        public override string ToString()
        {
            return "Квiтка має " + petal_Amount + " лепесткiв " + flBud.Color + " кольору!";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Flower)) return false;
            return (this.petal_Amount == ((Flower)obj).petal_Amount) && (this.flBud.Color == ((Flower)obj).flBud.Color);

        }

        public override int GetHashCode()
        {

            return petal_Amount.GetHashCode() ^ flBud.Color.GetHashCode();
        }
    }
}
