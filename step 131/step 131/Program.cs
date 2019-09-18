using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_131
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> issuedGear = new Employee<string>();
            issuedGear.Things = new List<string>();
            issuedGear.Things.Add("ID Badge");
            issuedGear.Things.Add("Laptop");

            Employee<int> DOB = new Employee<int>();
            DOB.Things = new List<int>();
            DOB.Things.Add(37);

            foreach (string Employee in issuedGear.Things)
            {
                foreach (int Employee2 in DOB.Things)
                {


                    Console.WriteLine(Employee, Employee2);
                    Console.ReadLine();
                }
            }
        }
    }
}
