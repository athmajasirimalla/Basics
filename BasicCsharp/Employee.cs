using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsole
{
    class Employee
    {
        ///public, private, protected
        protected string EmployeeName { get; set; }
        protected int Employeeid { get; set; }
        protected string ProjectName { get; set; }

        protected string EmployeeDatabase()
        {
            Employee e = new Employee();
            e.EmployeeName = "test3";
            return "Employee Name";
        }
    }
    class Client : Employee
    {
        public string clientname { get; set; }

        //public static void Main()
        //{
        //    Console.WriteLine("Test");
        //    Client employee = new Client();
        //    employee.Employeeid = 1;
        //    employee.EmployeeName = "Test1";
        //    employee.EmployeeDatabase();
        //    employee.clietname = "";
        //    Customer ss = new Sales();

        //    ss.CustomerDataBase(10, "Main Method");


        //}
    }

    abstract class Customer
    {
        public string CustomerDataBase(int a,string b)
        {
            Console.WriteLine(a+"-"+b);
            return "Non Abstract";
        }

        public abstract int CustomerData();
    }

    class Sales : Customer
    {
        
        public override int CustomerData()
        {
            //string s1 = "sample";
            Console.WriteLine("Abstract Mathod");
            
            return 1;

        }
    }

    class Polygan
    {
        public int polyid = 1;
        public string polyName = "polygan";
        public virtual void PolyganName() {
            Console.WriteLine(polyid +"-"+ polyName);
        }

    }
    class Square: Polygan
    {
        public int polyid1 = 12345;
        public string polyName2 = "Test333";
        public override void PolyganName()
        {
            Console.WriteLine(polyid1 + "-" + polyName2);
        }
    }
    class Ring : Polygan
    {
        public int polyid1=12;
        public string polyName2="Test";
        public override void PolyganName()
        {
            Console.WriteLine(polyid1 + "-" + polyName2);
        }
    }
    class Circle: Polygan
    {
        public static void Main()
        {
            Polygan[] p = new Polygan[3];
            p[0] = new Polygan();
            p[1] = new Square();
            p[2] = new Ring();
            
            foreach(Polygan k in p)
            {
                k.PolyganName();
            }
        }
    }


}
