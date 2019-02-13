using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee
    {
        private string EmployeeName { get; set; }
        private int EmployeeId { get; set; }
        private string ProjectName { get; set; }
        private string EmployeeDetails(string Name,string clientName, string Project, int employeeid)
        {
            Employee E = new Employee();
            Console.WriteLine(Name+" "+clientName+ " " + Project + " " + employeeid);
            return "";
        }


        public static void Main()
        {
            Client employee = new Client();
            
            employee.ClientName = "Smith";
            employee.EmployeeDetails("Scott",employee.ClientName,"SampleProject", 443);
        }
    }

    class Client : Employee
    {
        public string ClientName { get; set; }
    }
}

