using System;


namespace CarInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int newAge = Convert.ToInt16(age);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? Answer 'true' or 'false'");
            string dui = Console.ReadLine();
            bool duiAnswer = Convert.ToBoolean(dui);
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int totalTickets = Convert.ToInt16(tickets);
            Console.ReadLine();

            Console.WriteLine("Qualafied?");
            bool qualified = (newAge > 15) && (duiAnswer == false) && (totalTickets <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
