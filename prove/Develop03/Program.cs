using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        scripture.GetReference();
        bool isFinished = false;

        do
        {
            scripture.Display();
            string response = Console.ReadLine();
            if (response == "quit" || scripture.Status())
            {
                isFinished = true;
            }
        } while (!isFinished);
    }
}