using System;

public class Entry {
    public string _journalEntries;
    public string _response;
    public DateTime _date;

    public void CreateEntry(string JournalPrompt) {
        _journalEntries = JournalPrompt;
        Console.WriteLine(JournalPrompt);
        _response = Console.ReadLine();
        _date = DateTime.Now;
    }
}
