using System.Runtime.InteropServices;

class Comment
{
    // declaring private variables
    private string _nameComment;
    private string _textComment;

    // declaring constructor to encapsulate the private parameters
    public Comment(string nameComment, string textComment)
    {
        _nameComment = nameComment;
        _textComment = textComment;
    }

    // method to display the comment
    public string GetDisplayComment()
    {
        return $"{_nameComment}, {_textComment}"; 
    }

}