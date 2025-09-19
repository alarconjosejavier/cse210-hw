using System;

class Program
{
    static void Main(string[] args)
    {
        // calling the object reference
        Reference reference1 = new("1 Nephi", 3, 6);
        // creating an object from Word class
        Word word = new("Therefore go, my son, and thou shalt be favored of the Lord, because thou hast not murmured.");
        // creating an object from Scripture class
        Scripture scripture = new(reference1, word.GetDisplayText());

        while (scripture.IsCompletelyHidden() == false)
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();
            // just ask ChatGPT in this part to remember how to make a break in a while
            if (userInput == "quit")
            {
                break;
            }
            Console.Clear();
            scripture.HideRandom(1);
            // received help from ChatGPT because I asked how to show just the line in blanks to then press enter
            // because in my last code when I have a word left and I pressed enter the program ended.
            // I copied from ChatGPT understanding what is doing it. Also, ChatGPT recommended change some order.
            if (scripture.IsCompletelyHidden() == true)
            {
                // by myself I improved the code forcing the user to enter "quit" in the last step
                string lastAnswer = " ";
                while (lastAnswer != "quit")
                {
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.Write("You guessed it, type 'quit' to finish: ");
                    lastAnswer = Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}