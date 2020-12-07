using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Resume : ICloneable
        {
            private string name;
            private string sex;
            private string age;
            private string timeArea;
            private string compnamy;

            public Resume(string name)
            {
                this.name = name;
            }

            public void SetPersonInfo(string sex, string age)
            {
                this.sex = sex;
                this.age = age;
            }

            public void SetWorkExperience(string timeArea, string company)
            {
                this.timeArea = timeArea;
                this.compnamy = compnamy;
            }

            public void Display()
            {
                Console.WriteLine("{0} {1} {2}", name, sex, age);
                Console.WriteLine("工作經歷:{0} {1}", timeArea, compnamy);
            }

           
            

            public object Clone()
            {
                return (Object)this.MemberwiseClone();
            }
        }

        static void Main(string[] args)
        {
            Resume a = new Resume("大鳥");
            a.SetPersonInfo("男", "29");
            a.SetWorkExperience("1998-2000", "xxx公司");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("1998-2006", "yyy公司");

            Resume c = (Resume)a.Clone();
            c.SetPersonInfo("男", "24");

            a.Display();
            b.Display();
            c.Display();
            Console.Read();
        }
    }
}
