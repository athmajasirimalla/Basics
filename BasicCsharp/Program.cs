using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation

{

    /* class A
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

 }*/

    //Interface

    class Bank
    {
        public string BankName { get; set; }
        public string Branchname { get; set; }
        public int BranchCode { get; set; }
        public string BankDetails()
        {
            BankName = "Indusind Bank";
            Branchname = "Brookfield";
            BranchCode = 1234;
            Console.WriteLine(BankName + "-" + BranchCode + "-" + Branchname);
            return "";
            
        }
        class Customer
        {
            public string CustomerName { get; set; }
            public int CustomerId { get; set; }
            private UInt32 CustomerAcc { get; set; }
            public int CustomerDetails()
            {
                CustomerName = "scott";
                CustomerId = 234;
                CustomerAcc = 1234567;
                Console.WriteLine(CustomerName + "-" + CustomerId + "-" + CustomerAcc);
                return 1;
            }
        }

        public static void Main()
        {
            Bank B1 = new Bank();
            B1.BankDetails();
            Customer C1 = new Customer();
            C1.CustomerDetails();
            }
    }
}

        /*  class Customer
          {
              public string CustomerName { get; set; }
              public int CustomerId { get; set; }
              public string CustomerDetails()
              {
                  CustomerName = "Scott";
                  CustomerId = 234;
                  return CustomerName;
              }*/

      //
    

        
        