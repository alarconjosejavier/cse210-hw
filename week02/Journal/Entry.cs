using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date;
    public string _promptMessage;
    public string _entryMessage;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptMessage}");
        Console.WriteLine(_entryMessage);
    }
}
