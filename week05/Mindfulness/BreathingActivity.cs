class BreathingActivity : Activity
{
    // contructor
    public BreathingActivity() : base() 
    {
        _name = "Breathing";
        _description = "This activity will help you by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
        
    }

    // method to run activity
    public void Run()
    {
        // showing the starting message
        DisplayStartingMessage();

        // Console.WriteLine("How long, in seconds, would you like for your session? ");
        // int userInput = int.Parse(Console.ReadLine());
        // _duration = userInput;

        Console.Clear();

        Console.WriteLine("Get ready");
        ShowSpinner(5);

        Console.WriteLine();

        // declaring the date time to repeat the session
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // bucle to show the breathing session
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            Console.WriteLine();
        }

        // showing the ending message
        DisplayEndingMessage();
    }
}