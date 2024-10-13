using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

public class Journal {
    List<Entry> entries = new();
    public void AddEntry() {
        PromptManager promptManager = new();
        string prompt = promptManager.GetRandomJournalEntry();
        Entry entry = new();
        entry.CreateEntry(prompt);
        entries.Add(entry);
    }
    public void DisplayEntries() {
        foreach (Entry entry in entries) {
            Console.WriteLine($"{entry.Date} - Prompt: {entry.journalEntries} \n {entry.Response}");
        }
    }
    public void SaveToFile() {
        Console.WriteLine("What is the filename?");
        Console.WriteLine("Please include .txt at the end of your filename");
        string filename = Console.ReadLine();
        FileHandler fileHandler = new();
    }
    public void LoadFromFile() {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        FileHandler fileHandler = new();
        entries = fileHandler.Read(filename);
        Console.WriteLine("File loaded successfully");
    }
}