using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step156
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
            Console.WriteLine("enter a number.");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(DateTime.Now.AddHours(X));
            Console.ReadLine();


            
        }
    }
}
