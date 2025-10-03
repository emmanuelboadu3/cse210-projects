using System;


// Exceeded Requirements:
// - Used inheritance and encapsulation properly
// - Added spinner and countdown animations
// - Ready to extend with logging or additional activities
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflecting Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1") new BreathingActivity().Run();
                else if (choice == "2") new ReflectingActivity().Run();
                else if (choice == "3") new ListingActivity().Run();
                else if (choice == "4") break;
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                    Thread.Sleep(2000);
                }
            }
        }
    }
}