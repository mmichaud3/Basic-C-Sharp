using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace step154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string num1 = Convert.ToString(Console.ReadLine());
            File.WriteAllText(@"C:\Users\thetechacademy\step154text.txt", num1);
            File.ReadAllText(@"C:\Users\thetechacademy\step154text.txt");
            Console.WriteLine(num1);
            Console.ReadLine();
        }
    }
}
