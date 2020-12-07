using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 淺複製
{
    class Program
    {


        class WorkExperience
        {
            private string workDate;
            public string WorkDate
            {
                get { return workDate; }
                set { workDate = value; }
            }

            private string company;

            public string Company
            {
                get { return company; }
                set { company = value; }
            }


        }

        class Resume : ICloneable
        {
            private string name;
            private string sex;
            private string age;

            private WorkExperience work;

            public Resume(string name)
            {
                this.name = name;
                work = new WorkExperience();
            }

            public void SetPersonalInfo(string sex, string age)
            {
                this.sex = sex;
                this.age = age;
            }

            public void SetWorkExperience(string workDate, string company)
            {
                work.WorkDate = workDate;
                work.Company = company;
            }

            public void Display()
            {
                Console.WriteLine("{0} {1} {2}", name, sex, age);
                Console.WriteLine("工作經歷:{0} {1}", work.WorkDate, work.Company);
            }

            public object Clone()
            {
                return (Object)this.MemberwiseClone();
            }
        }

        static void Main(string[] args)
        {
            Resume a = new Resume("大鳥");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("1998-2000", "xxx公司");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("1998-2006", "yyy公司");

            Resume c = (Resume)a.Clone();
            c.SetPersonalInfo("男", "24");
            c.SetWorkExperience("1998-2003", "zzz公司");

            a.Display();
            b.Display();
            c.Display();
            Console.Read();
        }
    }
}
