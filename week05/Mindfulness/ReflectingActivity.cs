using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class ReflectingActivity : Activity
{
    // atributtes
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    // constructor
    public ReflectingActivity() : base()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        // adding information de to prompts list.
        // I used to have this inside the GetRandomPrompt but when I asked ChatGPT for feedback, it explained that is better to moved this to the constructor because it is easier for the program build the list once.
        _prompts.Add("--- Think of a time when you did something really difficult.---");
        _prompts.Add("--- What was the most difficult time in your. ---");
        _prompts.Add("--- Bring to your mind one of the most happiness time in your life. ---");
        _prompts.Add("--- What was to best time in your childhood, think about it. ---");

        // adding information to the questions list
        _questions.Add("Did you find a solution? ");
        _questions.Add("Was that the last experience in your life? ");
        _questions.Add("How was your experience? ");
        _questions.Add("Do you feel it was neccesary? ");
        _questions.Add("Are you feeling better now? ");

    }

    //method to run
    public void Run()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int userInput = int.Parse(Console.ReadLine());
        _duration = userInput;



        // showing the initial phrase
        Console.WriteLine("Get ready...");

        // showing the spinner for the time that the user enter
        ShowSpinner(3);

        // printing a space
        Console.WriteLine();

        DisplayPrompt();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");

        Console.Write("You may begin in: ");
        // showing the countdown
        ShowCountDown(5);

        // clearing the screen
        Console.Clear();

        // displaying questions
        DisplayQuestions();

        // display a space
        Console.WriteLine();

        DisplayEndingMessage();
    }

    // method to get random prompt
    public string GetRandomPrompt()
    {
        // copied from ChatGPT I didn't remember how to take a random prompt
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string promptRandom = _prompts[index];

        return promptRandom;
    }

    // method to get random question
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string randomQuestion = _questions[index];

        return randomQuestion;
    }

    // method de display prompt
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        // show the prompt
        Console.WriteLine(GetRandomPrompt());

        // printing the continue form
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    // method to display question
    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(GetRandomQuestion());
            // this was my original but ChatGPT suggested me to stablish a constant duration to give the user a time
            // ShowSpinner(_duration / 2);
            // finally I combined my solution with the ChatGPT suggestion to create my own version thinking in the case the user enter a lower value 
            int spinnerTime = Math.Min(15, _duration);
            ShowSpinner(spinnerTime);
            Console.WriteLine();

        }
    }
}