using System;
using System.Collections.Generic;
using System.IO;

class FileHandler {
    public string Write(string filename, List<Entry> entries) {
        try {
            using (StreamWriter outputFile = new StreamWriter(filename)) {
                foreach (Entry entry in entries) {
                    outputFile.WriteLine($"{entry._date} - Prompt: {entry._journalEntries} \n {entry._response}");
                }
            }
            return "File saved successfully.";
        } catch (Exception ex) {
            return $"An error occurred: {ex.Message}";
        }
    }

    public List<Entry> Read(string filename) {
        List<Entry> entries = new List<Entry>();
        using (StreamReader reader = new StreamReader(filename)) {
            string line;
            while ((line = reader.ReadLine()) != null) {
                string[] parts = line.Split(new[] { " - Prompt: ", "\n" }, StringSplitOptions.None);
                if (parts.Length >= 3) {
                    Entry entry = new Entry {
                        _date = DateTime.Parse(parts[0]),
                        _journalEntries = parts[1],
                        _response = parts[2]
                    };
                    entries.Add(entry);
                }
            }
        }
        return entries;
    }
}