using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class TestPaperA
        {
            public void TestQustion1()
            {
                Console.WriteLine("楊過得到，後來給郭伯伯製成倚天劍與屠龍的玄鐵材質能為[ ]a.球磨鑄鐵" +
                    "b.馬蹄鐵c.高速合金鋼d.碳素纖維");
                Console.WriteLine("Ans:b");
            }

            public void TestQustion2()
            {
                Console.WriteLine("絕情谷情花草被剷除造成[ ]a.沒有情花毒了" +
                    "b.物種滅絕c.生態圈破壞d.沙漠化");
                Console.WriteLine("Ans:a");
            }

            public void TestQustion3()
            {
                Console.WriteLine("南院大王蕭峰成名武功[ ]a.打狗棍法" +
                    "b.六脈神劍c.降龍二十八掌d.風神腿");
                Console.WriteLine("Ans:c");
            }
        }

        class TestPaperB
        {
            public void TestQustion1()
            {
                Console.WriteLine("楊過得到，後來給郭伯伯製成倚天劍與屠龍的玄鐵材質能為[ ]a.球磨鑄鐵" +
                    "b.馬蹄鐵c.高速合金鋼d.碳素纖維");
                Console.WriteLine("Ans:c");
            }

            public void TestQustion2()
            {
                Console.WriteLine("絕情谷情花草被剷除造成[ ]a.沒有情花毒了" +
                    "b.物種滅絕c.生態圈破壞d.沙漠化");
                Console.WriteLine("Ans:b");
            }

            public void TestQustion3()
            {
                Console.WriteLine("南院大王蕭峰成名武功[ ]a.打狗棍法" +
                    "b.六脈神劍c.降龍二十八掌d.風神腿");
                Console.WriteLine("Ans:a");
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("學生甲的試卷");
            TestPaperA studentA = new TestPaperA();
            studentA.TestQustion1();
            studentA.TestQustion2();
            studentA.TestQustion3();

            Console.WriteLine("學生乙的試卷");
            TestPaperB studentB = new TestPaperB();
            studentB.TestQustion1();
            studentB.TestQustion2();
            studentB.TestQustion3();

            Console.Read();
        }
    }
}
