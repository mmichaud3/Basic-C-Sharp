using System;


namespace MathDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            string userNum = Console.ReadLine();
            UInt32 userNumNew = Convert.ToUInt32(userNum);
            UInt32 product = userNumNew * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + product);
            Console.ReadLine();

            Console.WriteLine("Please enter a number");
            string userNum2 = Console.ReadLine();
            UInt32 userNumNew2 = Convert.ToUInt32(userNum2);
            UInt32 total = userNumNew2 + 25;
            Console.WriteLine("Your number plus 25 is:" + total);
            Console.ReadLine();

            Console.WriteLine("Please enter a number");
            string userNum3 = Console.ReadLine();
            decimal userNumNew3 = Convert.ToDecimal(userNum3);
            decimal quotient = userNumNew3 / 12.5m;
            Console.WriteLine("Your number divided by 12.5 is:" + quotient);
            Console.ReadLine();

            Console.WriteLine("Please enter a number");
            string userNum4 = Console.ReadLine();
            int userNumNew4 = Convert.ToInt32(userNum4);
            bool isEqual = userNumNew4 >= 50;
            Console.WriteLine("Is your number >= 50:" + isEqual);
            Console.ReadLine();

            Console.WriteLine("Please enter a number");
            string userNum5 = Console.ReadLine();
            int userNumNew5 = Convert.ToInt32(userNum5);
            int remainder = userNumNew5 % 7;
            Console.WriteLine("The remainder of your number divided by 7:" + remainder);
            Console.ReadLine();





        }
    }
}
