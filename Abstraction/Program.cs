using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Bank
    {
        public string BankDetails(int BranchCode, string BankName, string Branch)
        {
            Console.WriteLine(BranchCode + "-" + BankName + "-" + "-"+Branch);

            return "";
        }
        public abstract int BankDataBase();
    }

    class Customer:Bank
    {
        public override int BankDataBase()
        {
            Console.WriteLine("Abstract Method");
            return 1;
        }

       

        static void Main()
        {
            Bank C1 = new Customer();
            C1.BankDataBase();
            C1.BankDetails(122,"IndusInd Bank","BrookeField");

            }
    }
}
