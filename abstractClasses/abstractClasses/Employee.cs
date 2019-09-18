using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClasses
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("This game has ended.");
            
        }
        public static bool operator== (Employee employee, Employee employee2)
        {
            
          if (employee.firstName == employee2.firstName && employee.lastName == employee2.lastName)
            {
                return true;
            }
          else if (employee.firstName != employee2.firstName && employee2.lastName == employee2.lastName)
            {
                return false;
            }
          else
            {
                return true;
            }

        }
        public static bool operator!= (Employee employee, Employee employee2)
        {
            if (employee.firstName != employee2.firstName)
            {
                return true;
            }
            else if (employee.firstName == employee2.firstName)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
