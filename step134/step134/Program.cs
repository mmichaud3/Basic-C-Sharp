using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step134
{
    public enum WeekDay
    {
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Day of week?");
                var day = Console.ReadLine();
                foreach (string dayOfWeek in Enum.GetNames(typeof(WeekDay)))
                {

                    var days = Enum.Parse(typeof(WeekDay), dayOfWeek);
                    if (day == Convert.ToString(days))
                    {


                        Console.WriteLine("Today is " + days);
                        Console.ReadLine();
                    }
                    else if (day != Convert.ToString(days))
                    {
                        Console.WriteLine("Today is not " + day);
                        Console.ReadLine();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }
    }
}
