public class Comment
{
    public string _CommenterName { get; }
    public string _CommentText { get; }

    public Comment(string name, string text)
    {
        _CommenterName = name;
        _CommentText = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"- {_CommenterName}: {_CommentText}");
    }
}
