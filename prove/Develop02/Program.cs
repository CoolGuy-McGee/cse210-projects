using System;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{

    static void Menu()
    {
        int choice = 0;
        string journalEntry;
        string[] fileOutput;
        Journal journal = new Journal();
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                journalEntry = WriteEntry();
                journal.TempFile(journalEntry);
            }
            else if (choice == 2)
            {
                fileOutput = journal.LoadFile("_tempfile.txt");
                journal.PrintFile(fileOutput);
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename you want to load? ");
                string filename = Console.ReadLine();
                fileOutput = journal.LoadFile(filename);
                journal.PrintFile(fileOutput);
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename you want to save as? ");
                string filename = Console.ReadLine();
                fileOutput = journal.LoadFile("_tempfile.txt");
                journal.SaveFile(fileOutput, filename);
            }
        }
    }

    static string WriteEntry()
    {
        PromptList promptList = new PromptList();
        Entry entry = new Entry();
        string prompt = promptList.GeneratePrompt();
        entry._prompt = prompt;
        string journalEntry = entry.CreateEntry();
        entry.PrintEntry(journalEntry);
        return journalEntry;
    }

    static void Main(string[] args)
    {
        Menu();
    }
}