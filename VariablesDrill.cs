using System;


namespace VariablesDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine(currentCourse);

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'");
            string needHelp = Console.ReadLine();
            bool helpNeeded = Convert.ToBoolean(needHelp);
            Console.WriteLine(helpNeeded);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();
            Console.WriteLine(positiveExperience);

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine(feedback);

            Console.WriteLine("How many hours did you work today?");
            string hoursWorked = Console.ReadLine();
            byte hours = Convert.ToByte(hoursWorked);
            Console.WriteLine(hours);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly.  Have a great day!");
            Console.ReadLine();
        }
    }
}
