using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            entries.Clear();
            foreach (var line in lines)
            {
                var parts = line.Split(new[] { "||" }, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    var entry = new Entry(parts[1], parts[2]);

                    if (DateTime.TryParse(parts[0], out DateTime parsedDate))
                        entry.Date = parsedDate;
                    else
                        entry.Date = DateTime.Now;

                    entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date.ToShortDateString()}||{entry.Prompt}||{entry.Response}");
            }
        }
    }
}
