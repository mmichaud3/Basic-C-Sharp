using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step113
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Class1();
            int x = 10;
            int y = 5;
            Console.WriteLine("The product is : " + p.meth1(x, y));
            Console.ReadLine();
        }
    }
}
