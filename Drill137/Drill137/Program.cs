using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill137
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();//instatiating new number
            number.Amount = 3.5m; // assiging value

            Console.WriteLine(number.Amount);
            Console.ReadLine();

        }
    }
}
