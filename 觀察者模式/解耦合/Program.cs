using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 解耦合
{
    
        class Program
        {

            interface Subject
            {
                void Attach(Observer observer);
                void Detach(Observer observer);
                void Notify();
                string SubjectState
                {
                    get;
                    set;
                }
            }

            class Boss : Subject
            {
                private IList<Observer> observers = new List<Observer>();
                private string action;
                public void Attach(Observer observer)
                {
                    observers.Add(observer);
                }

                public void Detach(Observer observer)
                {
                    observers.Remove(observer);
                }

                public void Notify()
                {
                    foreach (Observer o in observers)
                    {
                        o.Update();
                    }
                }

         

            public string SubjectState 
            {
                get { return action; }
                set { action = value; }
            }
        }
            class Secretary : Subject
            {
                private IList<Observer> observers = new List<Observer>();
                private string action;
                public void Attach(Observer observer)
                {
                    observers.Add(observer);
                }

                public void Detach(Observer observer)
                {
                    observers.Remove(observer);
                }

                public void Notify()
                {
                    foreach (stockObserver o in observers)
                    {
                        o.Update();
                    }
                }

            public string SubjectState
            {
                get { return action; }
                set { action = value; }
            }
        }
            abstract class Observer
            {
                protected string name;
                protected Subject sub;

                public Observer(string name, Subject sub)
                {
                    this.name = name;
                    this.sub = sub;
                }

                public abstract void Update();
            }

            class stockObserver : Observer
            {
                public stockObserver(string name, Subject sub) : base(name, sub) { }
                public override void Update()
                {
                    Console.WriteLine("{0} {1} 關閉股票繼續工作", sub.SubjectState, name);

                }

            }

            class NBAObserver : Observer
            {
                public NBAObserver(string name, Subject sub) : base(name, sub)
                {

                }

                public override void Update()
                {
                    Console.WriteLine("{0} {1} 關閉NBA繼續工作", sub.SubjectState, name);
                }
            }


            static void Main(string[] args)
            {
               
                 Boss boss = new Boss();

                stockObserver Marry1 = new stockObserver("瑪莉", boss);
                NBAObserver Marry2 = new NBAObserver("強尼", boss);

                boss.Attach(Marry1);
                boss.Attach(Marry2);

                boss.Detach(Marry1);
                boss.SubjectState=("老闆我回來啦");

                boss.Notify();

                Console.Read();
            }
        }
    
}
