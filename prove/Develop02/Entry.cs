using System;

public class Entry {
    public string journalEntries;
    public string Response;
    public DateTime Date;

    public void CreateEntry(string JournalPrompt) {
        journalEntries = JournalPrompt;
        Console.WriteLine(JournalPrompt);
        Response = Console.ReadLine();
        Date = DateTime.Now;
    }
}
