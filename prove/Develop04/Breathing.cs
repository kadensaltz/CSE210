class Breathing : Activities 
{
    public Breathing()
    {
        startingMessage = "Welcome to the Breathing Activity!";
        description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        endingMessage = "Thank you for using the Breathing Activity!";
    }

    public void breathingActivity()
    {
        startOutline();

        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            timer();
            Console.Write("Now breathe out...");
            timer();
            Console.WriteLine();
        }

        Console.WriteLine("Well done!!");
        spinner();
        Console.WriteLine(endingMessage);
        spinner();
        Console.Clear();
    }
}