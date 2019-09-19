using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill140
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee1 = new Employee()
            {
                fName = "Mike",
                lName = "Michaud",
                ID = 3
            };
            Employee employee2 = new Employee()
            {
                fName = "Joe",
                lName = "Sorraco",
                ID = 6
            };
            Employee employee3 = new Employee()
            {
                fName = "Joe",
                lName = "Smith",
                ID = 7
            };
            Employee employee4 = new Employee()
            {
                fName = "Bob",
                lName = "Smith",
                ID = 8
            };
            Employee employee5 = new Employee()
            {
                fName = "Dan",
                lName = "Bennis",
                ID = 9
            };
            Employee employee6 = new Employee()
            {
                fName = "Chris",
                lName = "Smith",
                ID = 10
            };
            Employee employee7 = new Employee()
            {
                fName = "Jake",
                lName = "Smith",
                ID = 11
            };
            Employee employee8 = new Employee()
            {
                fName = "Kyle",
                lName = "Smith",
                ID = 12
            };
            Employee employee9 = new Employee()
            {
                fName = "Joe",
                lName = "Trump",
                ID = 13
            };
            Employee employee10 = new Employee()
            {
                fName = "Joe",
                lName = "Grand",
                ID = 14
            };
            List<Employee> employees = new List<Employee>(); // adding employess to list
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);
            employees.Add(employee10);



            foreach (Employee employee in employees) // conventional method to create new list with only Joes
            {
                if (employee.fName == "Joe")
                {
                    List<Employee> Joes = new List<Employee>();
                    Joes.Add(employee);

                    Console.WriteLine(employee.fName);
                    Console.ReadLine();


                }

            }
            List<Employee> joeList = employees.Where(x => x.fName == Convert.ToString("Joe")).ToList(); // lambda expression
            foreach (Employee employee in joeList)
            {
                Console.WriteLine(employee.fName);
                Console.ReadLine();
            }

            List<Employee> idList = employees.Where(x => x.ID > Convert.ToInt32(5)).ToList();//lambda expression
            foreach (Employee employee in idList)
            {
                Console.WriteLine(employee.ID);
                Console.ReadLine();
            }
            

            
            




        }
    }
}
