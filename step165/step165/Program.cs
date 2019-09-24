using System;

namespace step165
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            var dobYear = DateTime.Now.AddYears(-userAge);
         
            try
            {
                if (userAge < 1)
                {
                    Console.WriteLine("Please enter a number greater than zero.");
                    Console.ReadLine();
                }
                
            } catch (Exception)
            { 
                Console.WriteLine("Something else went wrong.");
                Console.ReadLine();
            }
            Console.WriteLine(dobYear.Year);
            Console.ReadLine();
        }
    }
}
