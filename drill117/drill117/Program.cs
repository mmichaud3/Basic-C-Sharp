using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill117
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Class1();
            Console.WriteLine("Select a number:");
            int z = Convert.ToInt32(Console.ReadLine());
            x.Meth1(z);

            Console.ReadLine();
        
     
        



            OutParamaters d = new OutParamaters();
            int a, b;
            d.getNums(out a, out b);

            Console.WriteLine("value of a : {0}", a);
            Console.WriteLine("value of b : {0}", b);
            Console.ReadLine();
        }
    }



           
        }
    

