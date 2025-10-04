class ListingActivity : Activity
{
    // I received feedback for ChatGPT because I didn't understand so good the constructor
    // creating attributes
    private int _count;
    private List<string> _prompts = new List<string>();

    // constructor
    public ListingActivity() : base()
    {
        // declaring parameters
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        // adding prompts
        _prompts.Add("--- When have you felt the Holy Ghost this month? ---");
        _prompts.Add("--- When have you served other this month? ---");
        _prompts.Add("--- When did you started feeling good this weeek? ---");
        _prompts.Add("--- When have you felt the love of others? ---");
        _prompts.Add("--- How do you serve others this month? ---");
    }

    public void Run()
    {
        // // asking the user the duration of the activity.
        // Console.WriteLine("How long, in seconds, would you like for your session? ");
        // int answerUser = int.Parse(Console.ReadLine());
        // _duration = answerUser;

        // I discovered that is better to add everything to the welcome message.
        DisplayStartingMessage();

        // printing initial instruccions
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        // getting the prompt
        GetRandomPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();

        // getting feedback from ChatGPT issues with getting the good respond, some lines copied from ChatGPT
        List<string> listsample = GetListFromUser();
        _count = listsample.Count();
        Console.WriteLine("You listed" + " " + _count);

        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count());
        string randomPrompt = _prompts[index];
        Console.WriteLine(randomPrompt);
    }

    public List<string> GetListFromUser()
    {
        // This was my original one but I couldn't completed because I didn't know that I could use datetime in while so, 
        // I copied from ChatGPT the while understanding what it is doing
        // // creating list of answer
        // List<string> answers = new List<string>();

        // DateTime startTime = DateTime.Now;
        // DateTime futureTime = startTime.AddSeconds(_duration);

        // for (int x = 0; x > 0; x++)
        // {
        //     string answer = Console.ReadLine();
        //     answers.Add(answer);
        // }

        // // returning the new list
        // return answers;

        // creating list of answer
        List<string> answers = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            answers.Add(answer);
        }

        // returning the new list
        return answers;
    }
}
