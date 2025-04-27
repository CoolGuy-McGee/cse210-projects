using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        int gradePercent = int.Parse(Console.ReadLine());
        string letter = "TBD";

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else if (gradePercent < 60)
        {
            letter = "F";
        }
        else
        {
            letter = "?";
        }

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine($"\nCongratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine($"\nAww... That's too bad. You should have studied harder or something. Better luck next time!");
        }

        Console.WriteLine($"\nGrade: {letter}");
    }
}