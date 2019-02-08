using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharp
{
    class Program
    {
        static void Main()
        {
            Interface1 A1 = new A();
            Interface2 B1 = new B();
            A1.ToffeeA();
            B1.ToffeeB();
        }
        class A : Interface1
        {
            void Interface1.ToffeeA()
            {
                Console.WriteLine("HELLO WORLD!");
            }
        }
        class B : Interface2
        {
            void Interface2.ToffeeB()
            {
                Console.WriteLine("WELCOME");
            }
        }


    }
}
