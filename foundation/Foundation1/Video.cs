public class Video {
    private string _title;
    private string _author;
    private string _length; //_length was made a string to allow the ":" within it's concepts
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, string length) {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public string GetTitle() {
        return _title;
    }

    public string GetAuthor() {
        return _author;
    }

    public string GetLength() {
        return _length;
    }

    public void AddComment(Comment comment) {
        _comments.Add(comment);
    }

    public int GetNumberOfComments() {
        return _comments.Count();
    }

    public List<Comment> GetComments() {
        return _comments;
    }

}