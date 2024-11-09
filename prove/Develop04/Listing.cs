using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

class Listing : Activities
{
    private List<string> listPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What is something you learned from scripture study this week?",
        "What are some goals you feel the spirit prompting you to set?"
    };

    int listcount = 0;

    public Listing()
    {
        startingMessage = "Welcome to the Listing Activity!";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        endingMessage = "Thank you for using the Listing Activity!";
    }
    
    public void ListingActivity()
    {
        startOutline();

        Random random = new Random();
        int randomIndex = random.Next(listPrompts.Count);
        string selectedPrompt = listPrompts[randomIndex];

        Console.WriteLine($"List as many responses as you can to the following prompt:\n ---{selectedPrompt}---");
        Console.Write("You may begin in: ");
        timer();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            listcount += 1;
        }


        Console.WriteLine("Well done!!");
        spinner();
        Console.WriteLine($"You listed {listcount} items.");
        Console.WriteLine(endingMessage);
        spinner();
        Console.Clear();
    }

}