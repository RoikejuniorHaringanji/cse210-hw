using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        List<int> numbers = new List<int>();

        int input;

        do
        {
            Console.Write("Enter number: ");
            
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            if (input != 0) 
            {
                numbers.Add(input);
            }

        } while (input != 0);

        int sum = numbers.Sum();

        double average = numbers.Count > 0 ? numbers.Average() : 0;

        int max = numbers.Count > 0 ? numbers.Max() : 0;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}