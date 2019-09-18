using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            Employee employee2 = new Employee();
            employee.firstName = "Mike";
            employee.lastName = "Michaud";

            


            employee.SayName();
            Console.ReadLine();

            IQuittable quittable = new Employee();
            quittable.Quit();
            Console.ReadLine();

        }
    }
}