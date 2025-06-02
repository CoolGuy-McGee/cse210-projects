using System.Formats.Asn1;

public class Word
{
    private bool _isHidden;
    private string _text;

    public Word(string text, bool isHidden)
    {
        _text = text;
        _isHidden = isHidden;
    }

    public bool CheckHidden()
    {
        return _isHidden;
    }

    public void Display()
    {
        if (_text == "," || _text == "." || _text == ";")
        {
            Console.Write($"{_text} ");
        }
        else if (_isHidden)
        {
            Console.Write($"{new string('_', _text.Length)} ");
        }
        else if (!_isHidden)
        {
            Console.Write($"{_text} ");
        }
    }
}