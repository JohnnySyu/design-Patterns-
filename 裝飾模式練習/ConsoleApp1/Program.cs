using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   

    class Person
    {
        public Person()
        {

        }
        private string name;
        public Person(string name)
        {
            this.name = name;
        }
        public virtual void Show()
        {
            Console.WriteLine("裝扮的{0}", name);
        }
    }

    class Finery : Person
    {
        protected Person component;
        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }

    class Tshirts : Finery
    {
        public override void Show()
        {
            Console.Write("大Tshirt ");
            base.Show();
        }
    }

    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("垮褲 ");
            base.Show();
        }
    }

    class Sneakers : Finery
    {
        public override void Show()
        {
            Console.Write("破球鞋 ");
            base.Show();
        }
    }

    class Suit : Finery
    {
        public override void Show()
        {
            Console.Write("西裝 ");
            base.Show();
        }
    }

    class Tie : Finery
    {
        public override void Show()
        {
            Console.Write("領帶 ");
            base.Show();
        }
    }

    class LeatherShoes : Finery
    {
        public override void Show()
        {
            Console.Write("皮鞋 ");
            base.Show();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");
            Console.WriteLine("\n 第一種裝扮: ");

            Sneakers pqx = new Sneakers();
            BigTrouser kk = new BigTrouser();
            Tshirts dtx = new Tshirts();

            pqx.Decorate(xc);
            kk.Decorate(pqx);
            dtx.Decorate(kk);
            dtx.Show();

           

            Console.WriteLine("\n 第二種裝扮:");
            LeatherShoes px = new LeatherShoes();
            Tie ld = new Tie();
            Suit xz = new Suit();

            px.Decorate(xc);
            ld.Decorate(px);
            xz.Decorate(ld);
            xz.Show();

            Console.Read();
        }
    }

}
