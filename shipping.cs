using System;


namespace shipping
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt16(Console.ReadLine());
            Console.ReadLine();
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
             
            else 
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt16(Console.ReadLine());
                Console.ReadLine();

                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt16(Console.ReadLine());
                Console.ReadLine();

                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt16(Console.ReadLine());
                Console.ReadLine();

                int totalDimension = (width + height + length);
            if (totalDimension > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }
            else
                {
                    decimal quote = totalDimension * weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                    Console.WriteLine("Thank You.");
                    Console.ReadLine();
                }
                
            }
           


        }
    }
}
