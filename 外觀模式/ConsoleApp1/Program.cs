using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Stock1
        {
            public void sell(){
                Console.WriteLine("股票1賣出");
            }
            public void Buy()
            {
                Console.WriteLine("股票1買入");
            }
        }
        class Stock2
        {
            public void sell()
            {
                Console.WriteLine("股票2賣出");
            }
            public void Buy()
            {
                Console.WriteLine("股票2買入");
            }
        }
        class Stock3
        {
            public void sell()
            {
                Console.WriteLine("股票3賣出");
            }
            public void Buy()
            {
                Console.WriteLine("股票3買入");
            }
        }
        class NationalDebt1
        {
            public void sell()
            {
                Console.WriteLine("公債賣出");
            }
            public void Buy()
            {
                Console.WriteLine("公債買入");
            }
        }
        class Realty{
            public void sell()
            {
                Console.WriteLine("Realty賣出");
            }
            public void Buy()
            {
                Console.WriteLine("Realty買入");
            }
        }


        class Fund
        {
            Stock1 gu1;
            Stock2 gu2;
            Stock3 gu3;

            NationalDebt1 nd1;
            Realty rt1;

            public Fund()
            {
                gu1 = new Stock1();
                gu2 = new Stock2();
                gu3 = new Stock3();

                nd1 = new NationalDebt1();
                rt1 = new Realty();
            }

            public void BuyFund()
            {
                gu1.Buy();
                gu2.Buy();
                gu3.Buy();
                nd1.Buy();
                rt1.Buy();
            }

            public void SellFund()
            {
                gu1.sell();
                gu2.sell();
                gu3.sell();
                nd1.sell();
                rt1.sell();
            }

            
        }



        static void Main(string[] args)
        {
            Fund fund = new Fund();
            fund.BuyFund();
            fund.SellFund();

            Console.Read();
        }
    }
}
