using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello Develop03 World!");
        string text = "For God so loved the world , that he gave his only begotten Son , that whosoever believeth in him should not perish , but have everlasting life .";
        string[] words = text.Split(' ');
        Console.WriteLine(words);
        Random randomGenerator = new Random();

        foreach (var word in words)
        {
            int number = randomGenerator.Next(1, 10);
            if (word == "," || word == ".")
            {
                Console.Write(word + " ");
            }
            else if (number < 5)
            {
                Console.Write($"{word} ");
            }
            else if (number >= 5)
            {
                Console.Write($"{new string('_', word.Length)} ");
            }
        }
        */
        Reference reference1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture("For God so loved the world , that he gave his only begotten Son , that whosoever believeth in him should not perish , but have everlasting life .", "John", 3, 16);
        //reference1.Display();
        Console.Clear();
        scripture1.HideWords(3);
        Scripture scripture2 = new Scripture("Trust in the Lord with all thine heart ; and lean not unto thine own understanding . In all thy ways acknowledge him , and he shall direct thy paths .", "Proverbs", 3, 5, 6);
        Console.Clear();
        scripture2.HideWords(3);
        //Console.ReadLine();
        //Console.Clear();
    }
}