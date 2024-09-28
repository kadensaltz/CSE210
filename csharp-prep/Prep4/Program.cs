using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //list setup
        List<int> numbers_list = new List<int>();
        int number = -1;

        //giving user information
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //loop to collect numbers
        while (number != 0)
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input); 
            
            //check to see if user wants to end input
            if (number != 0)
            {
                numbers_list.Add(number);
            }
        }
        //calculations
        int sum = numbers_list.Sum();
        double average = numbers_list.Average();
        int highest = numbers_list.Max();

        //output
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {highest}");
    }
}