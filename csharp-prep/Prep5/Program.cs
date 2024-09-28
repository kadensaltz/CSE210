using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        double squared = PromptUserNumber();

        double squaredNumber = SquareNumber(squared);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static double PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number");
        double number = int.Parse(Console.ReadLine());

        return number;
    }

    static double SquareNumber(double number)
    {
        double squared = number * number;
        return squared;
    }

    static void DisplayResult(string name, double number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }

}