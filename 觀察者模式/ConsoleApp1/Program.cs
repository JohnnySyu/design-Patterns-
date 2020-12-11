using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Secretary
        {
            private IList<Observer> observers = new List<Observer>();
            private string action;
            public void Attach(Observer observer)
            {
                observers.Add(observer);
            }

            public void Detch(Observer observer)
            {
                observers.Remove(observer);
            }

            public void Notify()
            {
                foreach(stockObserver o in observers)
                {
                    o.Update();
                }
            }

            public string SecretaryAction
            {
                get { return action; }
                set { action = value; }
            }
        }
        abstract class Observer
        {
            protected string name;
            protected Secretary sub;

            public Observer(string name, Secretary sub)
            {
                this.name = name;
                this.sub = sub;
            }

            public abstract void Update();
        }

        class stockObserver : Observer
        {
            public stockObserver(string name, Secretary sub) : base(name, sub) { }
            public override void Update()
            {
                Console.WriteLine("{0} {1} 關閉股票繼續工作", sub.SecretaryAction, name);

            }

        }

        class NBAserver : Observer
        {
            public NBAserver(string name, Secretary sub) : base(name, sub)
            {

            }

            public override void Update()
            {
                Console.WriteLine("{0} {1} 關閉NBA繼續工作", sub.SecretaryAction, name);
            }
        }

      
        static void Main(string[] args)
        {
            Secretary Marry = new Secretary();

            stockObserver Marry1 = new stockObserver("瑪莉", Marry);
            stockObserver Marry2 = new stockObserver("強尼", Marry);

            Marry.Attach(Marry1);
            Marry.Attach(Marry2);

            Marry.SecretaryAction = "老闆回來了";

            Marry.Notify();

            Console.Read();
        }
    }

   
}
