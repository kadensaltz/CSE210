using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What percent grade did you recieve in the class? ");
        string grade = Console.ReadLine();
        int numberGrade = int.Parse(grade);

        string letter = "";

        if (numberGrade >= 90)
        {
            letter = "A";
        }
        else if (numberGrade >= 80)
        {
            letter = "B";
        }
        else if (numberGrade >= 70)
        {
            letter = "C";
        }
        else if (numberGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You got a(n) {letter}");

        if (numberGrade >= 70)
        {
            Console.WriteLine("You passed, Congrats!!");
        }
        else
        {
            Console.WriteLine("You failed, better luck next time.");
        }
    }
}