using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        Console.WriteLine("Welcome to Magic number, please guess a number from 1-50 until you get it right!");
        
        int number_guess = 0;
        
        while (number_guess != number)
        {
            string guess = Console.ReadLine();
            number_guess = int.Parse(guess);
            
            if (number_guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (number_guess < number)
            {
                Console.WriteLine("Higher");
            }
        }
        
        Console.WriteLine("Congrats, you guessed it right!");
    }
}