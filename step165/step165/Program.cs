using System;

namespace step165
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");

            try
            {
                int userAge = Convert.ToInt32(Console.ReadLine());
                var dobYear = DateTime.Now.AddYears(-userAge);



                if (userAge < 1)
                {
                    Console.WriteLine("Please enter a number greater than zero.");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine(dobYear.Year);
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {


                Console.WriteLine("Something else went wrong.");
                Console.ReadLine();


            }
        }
    }
}
