using System.Diagnostics;

class Activity
{
    // making attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    // constructor
    public Activity()
    {
        
    }

    // creating methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine($"\n{_description}");
        Console.WriteLine($"\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>() { "|", "/", "-", "\\", "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            // Console.Write(i);
            // Thread.Sleep(1000);
            // Console.Write("\b \b");

            // the origirinal is over this one, the next is a feedback of ChatGPT because I discover that when the user enter
            // more than 9 I mean 2 digits the program didn't show correct because it was not delete the 2 digits.
            string x = i.ToString();
            Console.Write(x);
            Thread.Sleep(1000);
            foreach (char v in x)
            {
                Console.Write("\b \b");
            }
        }
    }
}