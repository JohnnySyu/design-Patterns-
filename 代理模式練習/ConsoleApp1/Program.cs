using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IGiveGift
    {
        void GiveDolls();
        void GiveFlowers();
        void GiveChocolate();

    }

    class SchoolGirl
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Pursuit : IGiveGift
    {
        SchoolGirl mm;

        public Pursuit(SchoolGirl SchoolGirl)
        {
            this.mm = SchoolGirl;
        }

        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + "送巧克力");
        }

        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + "送娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + "送你花");
        }
    }

    class proxy : IGiveGift
    {
        Pursuit gg;
        public proxy(SchoolGirl schoolGirl)
        {
            gg = new Pursuit(schoolGirl);
        }
        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl Marry = new SchoolGirl();
            Marry.Name = "馬力";
            proxy toolMan = new proxy(Marry);
            toolMan.GiveFlowers();
            toolMan.GiveChocolate();
            toolMan.GiveDolls();

            Console.Read();
        }
    }
}
