using System.Drawing;
using System.IO.Compression;

abstract class Shape
{
    // attributes
    private string _color;

    // creating methods
    // just received some help from ChatGPT because I didn't understand the request of the activity.
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public Shape(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 2.2;
    }

}