using System;
using System.Text;

namespace strings
{
    class Program
    {
        static void Main()
        {
            string name = "Michael.";
            string hello = "Hello, my name is ";
            string greeting = " How are you today?\n";

            name = name.ToUpper();

            string full = hello + name + greeting;

            StringBuilder paragraph = new StringBuilder();

            paragraph.Append("I am having a great day myself!\n");
            paragraph.Append("Today is Friday and I am ready for the freekend weekend!\n");
            paragraph.Append("I hope you have a wonderful weekend!\n");

            Console.WriteLine(full + paragraph);
            Console.ReadLine();
        }
    }
}
