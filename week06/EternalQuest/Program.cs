
// Creative Features Added:
// - Leveling system based on score thresholds
// - Badge unlocks for completing 5 goals
// - Streak tracking for daily goals

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}