using System;

class Program
{
    static int listingTimes = 0;
    static int reflectionTimes = 0;
    static int breathingTimes = 0;

    static void Main(string[] args)
    {
        string userInput = "";
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("\t1. Start a breathing activity");
            Console.WriteLine("\t2. Start a reflection activity");
            Console.WriteLine("\t3. Start a listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    {
                        Breathing breathing = new Breathing();
                        breathing.breathingActivity();
                        breathingTimes += 1;
                        break;
                    }
                case "2":
                    {
                        Reflection reflection = new Reflection();
                        reflection.reflectionActivity();
                        reflectionTimes += 1;
                        break;
                    }
                case "3":
                    {
                        Listing listing = new Listing();
                        listing.ListingActivity();
                        listingTimes += 1;
                        break;
                    }
                case "4":
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                    }
            }
        } while (userInput != "4");

        Console.WriteLine("Thank you for using the Mindfulness App!");
        Console.WriteLine($"You used the Breathing activity {breathingTimes} times.");
        Console.WriteLine($"You used the Reflection activity {reflectionTimes} times.");
        Console.WriteLine($"You used the Listing activity {listingTimes} times.");
    }
}

// for my stretch goal, I added a counter that displays how many times the user used each activity.