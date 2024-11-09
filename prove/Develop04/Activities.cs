using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

class Activities
{
    protected string startingMessage;
    protected string endingMessage;
    protected string description;
    protected string durationMessage = "How long, in seconds, would you like for your session? ";
    protected int duration;

    public void timer()
    {
        int currentLeft = Console.CursorLeft;
        int currentTop = Console.CursorTop;

        for (int i = 5; i > -1; i--)
        {
            Console.SetCursorPosition(currentLeft, currentTop);
            Console.WriteLine($"{i} ");
            Thread.Sleep(1000);
        }
    }

    public void spinner()
    {
        string[] spinnerChars = { "/", "-", "\\", "|" };
        for (int i = 0; i < 10; i++)
        {
            foreach (string spinnerChar in spinnerChars)
            {
                Console.Write(spinnerChar);
                Thread.Sleep(150); // Adjust the delay as needed
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
    }

    public void startOutline()
    {
        Console.Clear();
        Console.WriteLine(startingMessage);
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();
        Console.WriteLine(durationMessage);

        string durationInput = Console.ReadLine();
        this.duration = Int32.Parse(durationInput);

        Console.Clear();
        Console.WriteLine("Get ready...");
        spinner();
    }
}