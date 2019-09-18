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
                
                {

                    var days = Enum.Parse(typeof(WeekDay), day);//parses enum into seperate days
                    if (day == Convert.ToString(days))// checks enum day against user input
                    {


                        Console.WriteLine("Today is " + days);
                        Console.ReadLine();
                    }
                    //else if (day != Convert.ToString(days))
                    //{
                    //    Console.WriteLine("Today is not " + day);
                    //    Console.ReadLine();
                    //}

                    }
                
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }
    }
}
