using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbersList = new List<float>();
        float sum = 0;
        float average = 0;
        float largestNumber = 0;
        float input = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (input != 0)
        {
            Console.Write("Enter number: ");
            input = float.Parse(Console.ReadLine());
            if (input == 0)
            {
                break;
            }
            else
            {
                numbersList.Add(input);
            }
        }
        foreach (float number in numbersList)
        {
            sum = sum + number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
            else
            {
                continue;
            }
        }
        average = sum / numbersList.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}