using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill115
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Class1();
            Console.WriteLine("Select two numbers one at a time or leave second blank");
            int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of your numbers is: " + x.Add(a ));
            Console.ReadLine();


        }
    }
}
