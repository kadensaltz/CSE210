using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

public class Journal {
    List<Entry> _entries = new();
    public void AddEntry() {
        PromptManager promptManager = new();
        string prompt = promptManager.GetRandomJournalEntry();
        Entry entry = new();
        entry.CreateEntry(prompt);
        _entries.Add(entry);
    }
    public void DisplayEntries() {
        foreach (Entry entry in _entries) {
            Console.WriteLine($"{entry._date} - Prompt: {entry._journalEntries} \n {entry._response}");
        }
    }
    public void SaveToFile() {
        Console.WriteLine("What is the filename?");
        Console.WriteLine("Please include .txt at the end of your filename");
        string filename = Console.ReadLine();
        FileHandler fileHandler = new();
        string result = fileHandler.Write(filename, _entries);
        Console.WriteLine(result);
    }
    public void LoadFromFile() {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        FileHandler fileHandler = new();
        _entries = fileHandler.Read(filename);
        Console.WriteLine("File loaded successfully");
    }
}