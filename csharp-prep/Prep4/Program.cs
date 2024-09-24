using System;
using System.Collections.Generic;  // Needed for List<T>

class Program
{
    static void Main(string[] args)
    {
        // List to store user-entered numbers
        List<int> numbers = new List<int>();

        int userNumber = -1; // Initialize with a non-zero value to enter the loop
        while (userNumber != 0)
        {
            Console.Write("Enter a number (Use 0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // Add the number to the list if it's not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Calculate the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Calculate the average
        float average = 0;
        if (numbers.Count > 0) // Prevent division by zero
        {
            average = (float)sum / numbers.Count;
        }
        Console.WriteLine($"The average is: {average}");

        // Find the maximum value
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}
