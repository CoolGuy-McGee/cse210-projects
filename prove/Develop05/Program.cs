using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");
        Fileman files = new Fileman();
        List<string> testlist = new List<string>()
        {
            "ChecklistGoal",
            "Attend the temple",
            "Attend and perform any ordinance",
            "50",
            "500",
            "3",
            "0"
        };
        for (int i = 0; i < 7; i++)
        {
            files.Write("test.txt", testlist[i]);
        }
    }
}