public class Comment {
    private string _nameOfCommenter;
    private string _commentText;

    public Comment(string name, string comment) {
        _nameOfCommenter = name;
        _commentText = comment;
    }

    public string GetNameOfCommenter(){
        return _nameOfCommenter;
    }
    public string GetCommentText(){
        return _commentText;
    }

    public string GetComment() {
        return $"{_nameOfCommenter}: \"{_commentText}\"";
    }
}