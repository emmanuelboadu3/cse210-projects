using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int input;
        Console.Write("Enter list of numbers, type 0 when you finished): ");

        do
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            input = int.Parse(userInput);
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);
        int sum = 0;
        int max = int.MinValue;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
        }
        float average = numbers.Count > 0 ? (float)sum / numbers.Count : 0;

        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }
        numbers.Sort();
        Console.Write("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
            
        }
        
    }
}
