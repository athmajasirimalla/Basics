using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharp
{

    class A
    {
        int _a;
        int _b;


        public A(int a, int b)
        {
            _a = a;
            _b = b;

        }
        public void Sum()
        {
            Console.WriteLine("Sum={0}", _a+_b);
        }
    }
        class program
        {
            public static void Main()
            {
                A A1 = new A(10, 20);
                A1.Sum();

            }


        }
    
}
    
//Interface

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
