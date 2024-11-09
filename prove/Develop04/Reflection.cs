using System;

class Reflection : Activities
{
    private List<string> ponderPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you experienced great joy.",
        "Think of a time when you made a positive impact on someone's life."
    };

    private List<string> reflectionPrompts = new List<string>
    {
        "What did you learn from this experience?",
        "How did you feel during this experience?",
        "How did you feel after this experience?",
        "What did you learn about yourself from this experience?",
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public Reflection()
    {
        startingMessage = "Welcome to the Reflection Activity!";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        endingMessage = "Thank you for using the Reflection Activity!";
    }

    public void reflectionActivity()
    {
        startOutline();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();

        Random randomponder = new Random();
        int randomponderIndex = randomponder.Next(ponderPrompts.Count);
        string selectedponderPrompt = ponderPrompts[randomponderIndex];
        Console.WriteLine(selectedponderPrompt);
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        timer();

        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Random randomreflection = new Random();
        while (DateTime.Now < endTime)
        {
            int randomreflectionIndex = randomreflection.Next(reflectionPrompts.Count);
            string selectedreflectionPrompt = reflectionPrompts[randomreflectionIndex];
            Console.WriteLine($"> {selectedreflectionPrompt}");
            spinner();
            reflectionPrompts.RemoveAt(randomreflectionIndex);
        }
        Console.WriteLine("Well done!!");
        spinner();
        Console.WriteLine(endingMessage);
        spinner();
        Console.Clear();
    }
}