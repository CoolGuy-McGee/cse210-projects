using System.Reflection;
using System.Security.Cryptography;

public class Scripture
{
    private string[] _words;
    private List<string> _hiddenWordsList = new List<string>();
    private int _hiddenWordCount;
    private int _symbolsCount;
    private string _userInput = "NULL";

    //List<string> _test;
    Reference _reference;


    public Scripture(string text, string book, int chapter, int startVerse)
    {
        //_reference = new Reference(book, chapter, startVerse);
        _reference = new Reference(book, chapter, startVerse);
        _words = text.Split(' ');
    }

    public Scripture(string text, string book, int chapter, int startVerse, int endVerse)
    {
        _reference = new Reference(book, chapter, startVerse, endVerse);
        _words = text.Split(' ');
    }

    public void Display()
    {
        _reference.Display();
        foreach (var word in _words)
        {
            Console.Write($"{word} ");
        }
    }

    public void HideWords(int count)
    {
        _hiddenWordCount = 0;
        _symbolsCount = 0;
        count = count - 3;
        int repeatsCount = 0;
        List<string> tempWordsList = new List<string>();
        _reference.Display();
        foreach (var word in _words)
        {
            if (word == "," || word == "." || word == ";")
            {
                Word currentWord = new Word(word, false);
                _symbolsCount++;
                _hiddenWordsList.Add(word);
                currentWord.Display();
            }
            else if (tempWordsList.Contains(word))
            {
                Word currentWord = new Word(word, false);
                repeatsCount++;
                currentWord.Display();
            }
            else
            {
                Word currentWord = new Word(word, false);
                currentWord.Display();
            }
            tempWordsList.Add(word);

        }
        Console.Write($"\n\nPress enter to continue or type 'quit' to finish: ");
        while (_words.Count() != (_hiddenWordCount + _symbolsCount + repeatsCount))
        {
            if (count + 3 < (_words.Count() - (_symbolsCount + repeatsCount)))
            {
                count = count + 3;
            }
            else
            {
                count = _words.Count() - (_symbolsCount + repeatsCount);
            }
            _userInput = Console.ReadLine();
            if (_userInput == "quit")
            {
                Environment.Exit(7);
            }
            Console.Clear();
            while (_hiddenWordCount != count)
            {
                Random randomGenerator = new Random();
                if (_hiddenWordCount < count)
                {
                    Console.Clear();
                }
                _reference.Display();
                foreach (var word in _words)
                {
                    int number = randomGenerator.Next(1, 100);
                    if (word == "," || word == "." || word == ";")
                    {
                        Word currentWord = new Word(word, false);
                        currentWord.Display();
                    }
                    else if (_hiddenWordsList.Contains(word))
                    {
                        Word currentWord = new Word(word, true);
                        currentWord.Display();
                    }
                    else if (_hiddenWordCount == count)
                    {
                        Word currentWord = new Word(word, false);
                        currentWord.Display();
                    }
                    else if (number % 2 == 0)
                    {
                        Word currentWord = new Word(word, false);
                        currentWord.Display();
                    }
                    else if (number % 2 != 0)
                    {
                        Word currentWord = new Word(word, true);
                        currentWord.Display();
                        _hiddenWordsList.Add(word);
                        _hiddenWordCount++;
                    }
                }
                Console.Write($"\n\nPress enter to continue or type 'quit' to finish: ");
            }
        }
        Console.Clear();
        Console.Clear();
        Console.Clear();
        _reference.Display();
        foreach (var word in _words)
        {
            Word currentWord = new Word(word, true);
            currentWord.Display();
        }
        Console.Write($"\n\nPress enter to continue or type 'quit' to finish: ");
        _userInput = Console.ReadLine();
            if (_userInput == "quit")
            {
                Environment.Exit(7);
            }
    }
}