using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        class USer
        {
            private int _id;
            public int ID
            {
                get { return _id; }
                set { _id = value; }
            }

            private string _name;
            private string Name
            {
                get { return _name; }
                set { _name = value; }
            }
        }

        class Department
        {
            private int _id;
            public int ID
            {
                get { return _id; }
                set { _id = value; }
            }

            private string _deptName;

            public string DeptName
            {
                get { return _deptName; }
                set { _deptName = value; }
            }
        }
        interface IUser
        {
            void Insert(USer user);
            USer GetUser(int id);
        }

        interface IDepartment
        {
            void Insert(Department department);
            Department GetDepartment(int id);
        }

        class SqlserverUser : IUser
        {
            public USer GetUser(int id)
            {
                Console.WriteLine("在SQL Server中根據ID得到User表一條紀錄");
                return null;
            }

            public void Insert(USer user)
            {
                Console.WriteLine("在SQL Server中給User增加一條紀錄");
            }
        }

        class AccessUser : IUser
        {
            public USer GetUser(int id)
            {
                Console.WriteLine("在Access中根據ID得到User表一條紀錄");
                return null;
            }

            public void Insert(USer user)
            {
                Console.WriteLine("在Access中給User增加一條紀錄");
            }
        }

        class SqlserverDepartment : IDepartment
        {
            public Department GetDepartment(int id)
            {
                Console.WriteLine("在SQL Server中根據ID得到Department表一條紀錄");
                return null;
            }

            public void Insert(Department department)
            {
                Console.WriteLine("在SQL Server中給Department增加一條紀錄");
            }
        }

        class AccessDepartment : IDepartment
        {
            public Department GetDepartment(int id)
            {
                Console.WriteLine("在Access中根據ID得到Department表一條紀錄");
                return null;
            }

            public void Insert(Department department)
            {
                Console.WriteLine("在Access中給Department增加一條紀錄");
            }
        }

        //interface Ifactory
        //{
        //    IUser CreateUser();
        //    IDepartment CreatDepartment();
        //}

        //class sqlServerFactory : Ifactory
        //{
        //    public IDepartment CreatDepartment()
        //    {
        //        return new SqlserverDepartment();
        //    }

        //    public IUser CreateUser()
        //    {
        //        return new SqlserverUser();
        //    }
        //}

        //class AccessFactory : Ifactory
        //{
        //    public IDepartment CreatDepartment()
        //    {
        //        return new AcessDepartment();
        //    }

        //    public IUser CreateUser()
        //    {
        //        return new AccessUser();
        //    }
        //}

        //class DataAccess
        //{
        //    private static readonly string db = "Sqlserver";

        //    public static IUser CreateUser()
        //    {
        //        IUser result = null;
        //        switch (db)
        //        {
        //            case "Sqlserver":
        //                result = new SqlserverUser();
        //                break;
        //            case "Access":
        //                result = new AccessUser();
        //                break;
        //        }
        //        return result;
        //    }

        //    public static IDepartment CreateDepartment()
        //    {
        //        IDepartment result = null;
        //        switch (db)
        //        {
        //            case "Sqlserver":
        //                result = new SqlserverDepartment();
        //                break;
        //            case "Access":
        //                result = new AcessDepartment();
        //                break;
        //        }
        //        return result;

        //    }

        //}

        class DataAccess
        {
            private static readonly string AssemblyName = "ConsoleApp1";
            private static readonly string db = "Sqlserver";

            public static IUser CreateUser()
            {
                string className = AssemblyName + "." + db + "User";
                return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
            }

            public static IDepartment CreateDepartment()
            {
                string className = AssemblyName + "." + db + "Department";
                return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
            }
        }

        static void Main(string[] args)
        {

            USer uSer = new USer();
            Department department = new Department();
            //Ifactory factory = new sqlServerFactory();

            //IUser iu = factory.CreateUser();

            IUser iu = DataAccess.CreateUser();

            iu.Insert(uSer);
            iu.GetUser(1);

            //IDepartment id = factory.CreatDepartment();

            IDepartment id = DataAccess.CreateDepartment();
            id.Insert(department);
            id.GetDepartment(1);

            Console.Read();
        }
    }
}
