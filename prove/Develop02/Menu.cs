using System;

class Menu {
    Journal journal = new();
    public void DisplayOptions() {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        }
    
    public void HandleSelection() {
        bool leave = false;
        while (!leave) {
            DisplayOptions();
            string response = Console.ReadLine();
            switch(response) {
                case "1":
                journal.AddEntry();
                break;
                case "2":
                journal.DisplayEntries();
                break;
                case "3":
                journal.LoadFromFile();
                break;
                case "4":
                journal.SaveToFile();                 
                break;
                case "5":
                leave = true;
                break;
                default:
                Console.WriteLine("Please enter a number 1-5 to continue.");
                break;
            }
        }
    }
}

