using System;
using System.Collections.Generic;




    class Program
    {
        static void Main()
        {
        string[] names = { "Caya", "Blue", "Cooper", "Sally" };

        Console.WriteLine("Select an index.");
        int namesIndex = Convert.ToInt16(Console.ReadLine());
        if (namesIndex > 3)
        {
            Console.WriteLine("That index does not exist.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(names[namesIndex]);
        }
       

        int[] nums = { 11, 5, 30, 9, 4 };

        Console.WriteLine("Select an index.");
        int numsIndex = Convert.ToInt32(Console.ReadLine());
        if (numsIndex > 4)
        {
            Console.WriteLine("That index does not exist.");
            Console.ReadLine();
        }
        else
        {
            
                Console.WriteLine(nums[numsIndex]);
        }

        List<string> cars = new List<string>();
        cars.Add("Honda");
        cars.Add("Range Rover");
        cars.Add("Audi");
        cars.Add("BMW");

        Console.WriteLine("Select an index.");
        int carsIndex = Convert.ToInt16(Console.ReadLine());
        if (carsIndex > 3)
        {
            Console.WriteLine("That index does not exist.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(cars[carsIndex]);
            Console.ReadLine();
        }




        //    List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();


        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
    }
    }

