public class Comment
{
    private string _username;
    private string _commentText;

    public Comment(string name, string text)
    {
        _username = name;
        _commentText = text;
    }

    public string GetUsername()
    {
        return _username;
    }

    public string GetText()
    {
        return _commentText;
    }
}