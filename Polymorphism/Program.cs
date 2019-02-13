using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Project
    {
        int ProjectId = 467;
        string ProjectName = "Yamani Travels";
        string ProjectDeadLine = "30-03-2019";
        public virtual string ProjectDetails()
        {
            Console.WriteLine(ProjectId + "-" + ProjectName + "-" + ProjectDeadLine);
            Console.WriteLine();
            Console.WriteLine("Members In Team");
            Console.WriteLine("----------------");
            Console.WriteLine();

            return "";

        }
    }
    class Employee1 : Project
    {
        string Employee1Name = "Scott";
        string Employee1Id = "ADC234";

        public override string ProjectDetails()
        {
            Console.WriteLine(Employee1Name + "-" + Employee1Id);
            return "";

        }

    }
    class Employee2 : Project
    {
        string Employee2Name = "Smith";
        string Employee2Id = "ACD276";

        public override string ProjectDetails()
        {
            Console.WriteLine(Employee2Name + "-" + Employee2Id);
            return "";

        }

    }
    class Employee3 : Project
    {
        string Employee3Name = "Mark";
        string Employee3Id = "ADC234";

        public override string ProjectDetails()
        {
            Console.WriteLine(Employee3Name + "-" + Employee3Id);
            return "";

        }


        public static void Main()
        {
            Project[] p = new Project[4];
            p[0] = new Project();
            p[1] = new Employee1();
            p[2] = new Employee2();
            p[3] = new Employee3();
            foreach(Project A in p)
            {
                A.ProjectDetails();
            }
        }
    }
}
