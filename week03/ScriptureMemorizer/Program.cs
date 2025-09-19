/* Exceeding Requirements:
    1. The program hides only words that are not already hidden (no duplicates wasted).
    2. Scripture supports single verse (John 3:16) or verse range (Proverbs 3:5-6).
    3. Program is designed with full Encapsulation (private variables + getters/setters/methods).
    4. Clear screen on each loop for a clean memorization effect.
    5. Expandable: You can easily add a library of scriptures or load from a file 
    */


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        {
            Reference reference = new Reference("Proverbs", 3, 5, 6);
            string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
            Scripture scripture = new Scripture(reference, text);

            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                scripture.HideRandomWords(3);
            }

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words are hidden. Program ended.");
        }
    }
}
