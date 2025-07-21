using System.ComponentModel.DataAnnotations;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private int _commentCount = 0;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public int GetCommentCount()
    {
        return _commentCount;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
        _commentCount++;
    }
}