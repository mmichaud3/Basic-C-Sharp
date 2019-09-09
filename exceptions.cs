using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
    static void Main(string[] args)
       
    {
        List<int> intList = new List<int>();
        intList.Add(20);
        intList.Add(10);
        intList.Add(35);
        intList.Add(42);
        try
        {
            Console.WriteLine("Pick a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < intList.Count; i++)
            {
                int quotient = intList[i] / userNum;
                Console.WriteLine(intList[i] + " divided by " + " your number " + userNum + " equals " + quotient);
                Console.ReadLine();
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a number.");
            Console.ReadLine();
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please dont divide by zero.");
            Console.ReadLine();
            return;
        }
        finally
        {
            Console.WriteLine("You do not have any errors.");
           
        }
        Console.ReadLine();
            
        












        //try
        //{
        //    Console.WriteLine("Pick a number.");
        //    int number1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Pick a number.");
        //    int number2 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Dividing the two..");
        //    int number3 = number1 / number2;
        //    Console.WriteLine(number1 + " divided " + number2 + " equals " + number3);
        //    Console.ReadLine();
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //    return;
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Please don't divide by zero.");
        //}
        //finally
        //{
        //    Console.ReadLine();
        //}

    }   
}

