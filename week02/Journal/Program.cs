// Journal Project - Program.cs
// Author: Emmanuel Boadu
// Date: 2025-09-11
//
// Exceeding Requirements:
// 1. Added a PromptGenerator class to give random daily prompts 
//    (instead of hardcoding only one).
// 2. Implemented Save/Load functionality using "||" as a delimiter.
// 3. Added error handling when loading files (if date parsing fails).
// 4. Used List<Entry> to store unlimited entries instead of just one.
// 5. Displayed entries with formatted dates for readability.




using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry(prompt, response);
                    myJournal.AddEntry(newEntry);
                    break;
                case "2":
                    myJournal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter the filename to load: ");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilename);
                    break;
                case "4":
                    Console.Write("Enter the filename to save: ");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveToFile(saveFilename);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}