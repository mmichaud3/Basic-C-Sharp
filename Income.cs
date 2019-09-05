using System;


namespace Income
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly rate?");
            string hourly = Console.ReadLine();
            int hourlyPer1 = Convert.ToInt32(hourly);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            string hours = Console.ReadLine();
            int hoursPer1 = Convert.ToInt32(hours);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            string hourly2 = Console.ReadLine();
            int hourlyPer2 = Convert.ToInt32(hourly2);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            string hours2 = Console.ReadLine();
            int hoursPer2 = Convert.ToInt32(hours2);
            Console.ReadLine();

            Console.WriteLine("Weekly salary of person 1:");
            int salaryPer1 = hourlyPer1 * hoursPer1;
            Console.WriteLine(salaryPer1);
            Console.ReadLine();

            Console.WriteLine("Weekly salary of person 2:");
            int salaryPer2 = hourlyPer2 * hoursPer2;
            Console.WriteLine(salaryPer2);
            Console.ReadLine();

            Console.WriteLine("Does person 1 make more money than person 2?");
            bool bigSalary = salaryPer1 > salaryPer2;
            Console.WriteLine(bigSalary);
            Console.ReadLine();



        }
    }
}
