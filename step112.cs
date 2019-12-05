using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   public class Program
    {
        
        static void Main()
        {
            int[] arr2 = new int[]
            {
                2, 7, 6, 9
            };
            int[] arr3 = new int[4];
            int[] arr4 = new int[4];
            int e, j = 0, k = 0;
            for (e = 0; e < 4; e++)
            {
                if (arr2[e] % 2 == 0)
                {
                    arr3[j] = arr2[e];
                    j++;
                }
                else
                {
                    arr4[k] = arr2[e];
                    k++;
                }
            }
            int sum = arr3.Sum();
            Console.WriteLine(sum);
            Console.ReadLine();



            ulong[] arr1 = new ulong[]
           {
                5, 3, 9, 2000000000
           };
            
            ulong tot = 0;
            for (int i = 0; i < arr1.Length; i++)
                tot += arr1[i];
            Console.WriteLine(tot);
            Console.ReadLine();



            string inputString = "one two three four five";

            string resultString = string.Join(" ", inputString
                .Split(' ')
                .Select(x => new string(x.Reverse().ToArray())));

            Console.WriteLine(resultString);
            Console.ReadLine();



            string myStr = "mississippi";
            var newStr = new HashSet<char>(myStr);
            foreach (char c in newStr)
                Console.Write(c);
            Console.Read();


            var numberList = Enumerable.Range(1, 99).ToList();

            foreach (int f in numberList)
            {
                if (f % 3 == 0 && f % 5 == 0)
                {
                    Console.Write("FizzBuzz");
                }
                if (f % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (f % 5 == 0)
                {
                    Console.Write("Buzz");

                }
                Console.Read();
            }
            

            
        }

    }
    }

