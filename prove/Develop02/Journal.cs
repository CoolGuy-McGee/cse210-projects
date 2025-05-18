using System.IO;

public class Journal
{

    public void TempFile(string journalEntry)
    {
        using (StreamWriter outputFile = new StreamWriter("_tempfile.txt"))
        {
            outputFile.WriteLine(journalEntry);
        }
    }

    public void SaveFile(string[] fileOutput, string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string line in fileOutput)
                outputFile.WriteLine(line);
        }
    }

    public string[] LoadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        return lines;
    }

    public void PrintFile(string[] fileOutput)
    {
        foreach (string line in fileOutput)
        {
            Console.WriteLine($"\n{line}");
        }
    }
}