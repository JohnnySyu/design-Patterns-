using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Nightingale
    {
        public void Sweep(){
            Console.WriteLine("掃地");
        }

        public void Wash()
        {
            Console.WriteLine("洗衣");
        }

        public void BuyRice()
        {
            Console.WriteLine("買米");
        }
    }

    class Undergraduate: Nightingale { }

    class Volunteer : Nightingale { }

    class SimpleFacyory
    {
        public static Nightingale CreatNightingale(string type)
        {
            Nightingale resule = null;
            switch (type)
            {
                case "大學生":
                    resule = new Undergraduate();
                    break;
                case "社區義工":
                    resule = new Volunteer();
                    break;
            }
            return resule;
        }
        
    }
    

    interface IFactory
    {
        Nightingale CreatNightingale();
    }

    class UndergraduateFactory : IFactory
    {
        public Nightingale CreatNightingale()
        {
            return new Undergraduate();
        }
    }

    class VounteerFacory : IFactory
    {
        public Nightingale CreatNightingale()
        {
            return new Volunteer();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new UndergraduateFactory();
            Nightingale student = factory.CreatNightingale();

            Nightingale volunteer = factory.CreatNightingale();

            student.BuyRice();
            student.Sweep();
            student.Wash();

            volunteer.BuyRice();
            volunteer.Sweep();
            volunteer.Wash();

            Console.Read();
        }
    }
}
