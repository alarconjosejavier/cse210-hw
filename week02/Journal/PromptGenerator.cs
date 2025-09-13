using System.Xml.XPath;

public class PrompGenerator

{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        // using random object to select randomly from my list of prompts. Using IA to help me write this function.
        Random random = new Random();
        // List of different prompts
        List<string> prompts = new List<string>
        {
            "What was the happines memory this morning?",
            "If there is something that you would like to remember for the rest of your life, which one is it?",
            "Write something that would you like to change today!",
            "Tell me something special that you live today or these days!"
        };
        // use a variable int to select a random index from the new list
        int randomElement = random.Next(prompts.Count);
        // extracting the prompt from the list using the random index from previous int
        string randomPrompt = prompts[randomElement].ToString();
        // returning random prompt
        return randomPrompt;

        // Note: based and taking from google IA "how to print random an element of a list in c#, of course, I adapted the code and ask chatGPT
        // some question to understand the code."
    }
}