using System.ComponentModel.DataAnnotations;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public int _commentCount = 0;
    public List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetCommentCount()
    {
        return _commentCount;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
        _commentCount++;
    }
}