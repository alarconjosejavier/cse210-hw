using System.IO.Compression;

public class Fraction
{
    private int _top;

    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string top = _top.ToString();
        string bottom = _bottom.ToString();
        return top + "/" + bottom;
    }
    // I received some help from ChatGPT because I was doing operations with int instead double
    public double GetDecimalValue()
    {
        double top = _top;
        double bottom = _bottom;
        double result = top / bottom;
        return result;
    }
}