using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
     class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Select a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            var f = new Numbers();
            Console.WriteLine("The Factorial of your number is: " + f.Factorial(num));
            Console.ReadLine();

            var s = new Numbers();
            int a = num;
            int b = 5;
            Console.WriteLine("The sum of your number and 5 is: " + s.Sum(num, b));
            Console.ReadLine();

            var p = new Numbers();
            int d = num;
            int e = 5;
            Console.WriteLine("The product of your number and 5 is: " + p.Product(num, e));
            Console.ReadLine();
        }
    }
}
