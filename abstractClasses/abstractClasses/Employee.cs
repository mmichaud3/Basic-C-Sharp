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
        public static Employee operator== (Employee employee, Employee employee2)
        {
            
          if (employee.firstName == employee2.firstName)
            {
                Console.WriteLine(" same ");
            }
          else if (employee.firstName != employee2.firstName)
            {
                Console.WriteLine(" not same ");
            }

        }
        public static Employee operator!= (Employee employee, Employee employee2)
        {
            if (employee.firstName != employee2.firstName)
            {
                Console.WriteLine("not same");
            }
            else if (employee.firstName == employee2.firstName)
            {
                Console.WriteLine("same");
            }
        }
    }
}
