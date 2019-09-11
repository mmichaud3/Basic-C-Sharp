using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill114
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Class2();
            int x = 100;
            int y = 50;
            Console.WriteLine("The sum of 100 and 150 is: " + c.Meth1(x, y));
            Console.ReadLine();

            var e = new Class2();
            decimal a = 2.2m;
            decimal b = 5.5m;
            Console.WriteLine(" The product rounded down is : " + e.Meth1(a, b));
            Console.ReadLine();

            var s = new Class2();
            string j = "20";
            int h = 2;
           
            Console.WriteLine("The Quotient is : " + s.Meth1(j, h));
            Console.ReadLine();


        }

    }
}
