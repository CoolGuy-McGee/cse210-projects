public class Fileman
{
    public void Write(string filename, string data)
    {
        //using System.IO; 
        using (StreamWriter outputFile = new StreamWriter(filename, append:true))
        {
            // You can add text to the file with the WriteLine method
            outputFile.Write($"{data}|");

            // You can use the $ and include variables just like with Console.WriteLine
            //string color = "Blue";
            //outputFile.WriteLine($"My favorite color is {color}");
        }
    }

    public string[] Read(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            string firstName = parts[0];
            string lastName = parts[1];
        }
        return lines;
    }

    public string GetFilename()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        return filename;
    }
}