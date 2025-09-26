using System.Diagnostics;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Video
{
    // declaring the private variables
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    // constructor with parameters
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // method to add comment to a video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // method to get numbers of comments
    public int GetNumberComments()
    {
        return _comments.Count;
    }

    public string GetDisplayVideoText()
    {
        // sugestion of ChatGPT becuase I used to have the x inside the bucle
        int x = GetNumberComments();
        string z = "";
        foreach (Comment v in _comments)
        {
            // suggestion of ChatGPT because I used to have the line without the sum, so, it just print the last item
            z += "  - " + v.GetDisplayComment() + "\n";
        }
        // here I asked ChatGPT how to part my code in different lines.
        return  $"Title of the video: {_title}" +
                $"\nAuthor: {_author}" +
                $"\nDuration: {_length}" +
                $"secons \nNumber of comments: {x} \n{z}";
    }
}