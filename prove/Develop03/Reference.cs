public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private bool _multipleVerses;

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _multipleVerses = false;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _multipleVerses = true;
    }

    public void Display()
    {
        if (_multipleVerses)
        {
            Console.Write($"{_book} {_chapter}:{_startVerse}-{_endVerse}    ");
        }
        else if (!_multipleVerses)
        {
            Console.Write($"{_book} {_chapter}:{_startVerse}    ");
        }
        
    }
}