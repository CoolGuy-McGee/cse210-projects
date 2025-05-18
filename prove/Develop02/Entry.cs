using System.Runtime.InteropServices;

public class Entry
{
    public string _prompt;
    string _text;
    string _date = DateTime.Now.ToShortDateString();

    public string CreateEntry()
    {
        Console.WriteLine(_prompt);
        _text = Console.ReadLine();
        return $"{_date}\n{_prompt}\n{_text}";
    }

    public void PrintEntry(string entry)
    {
        Console.WriteLine($"\n{entry}");
    }
}