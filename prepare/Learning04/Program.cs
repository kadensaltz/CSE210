using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("John", "History");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("7.3", "8-19", "John", "Math");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("The Causes of World War II by Mary Waters", "John", "English");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}