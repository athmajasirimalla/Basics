using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main()
        {
            ITestInterface1 C1 = new Addition();
            ItestInterface2 C2 = new subtraction();
            C1.sum(38,68);
            C2.sub(75000, 212);
        }
    }
    class Addition : ITestInterface1
    {
        public void sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }
    class subtraction : ItestInterface2
    {
        public void sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }

       }
}
