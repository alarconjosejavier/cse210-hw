using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string userInput = " ";

        Journal generalJournal = new Journal();
        
        // repeting the menu until the user enter 5
        while (userInput != "5")
        {
            
            //Creating the menu
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            PrompGenerator prompt1 = new PrompGenerator();
            string prompt = prompt1.GetRandomPrompt();

            Entry newEntry = new();

            DateTime currentTime = DateTime.Now;

            if (userInput == "1")

            {
                Console.WriteLine($"{prompt}");
                string userAnswer = Console.ReadLine();
                newEntry._date = currentTime.ToShortDateString();
                newEntry._promptMessage = prompt;
                newEntry._entryMessage = userAnswer;

                generalJournal.AddJournal(newEntry);
            }

            if (userInput == "2")
            {
                generalJournal.DisplayJournals();

            }

            if (userInput == "3")
            {
                Console.WriteLine("What is the name of the file? ");
                string fileToLoad = Console.ReadLine();
                generalJournal.LoadToFile(fileToLoad);
                Console.WriteLine("Loading file...");
            }

            if (userInput == "4")
            {
                Console.WriteLine("What is the name of the file? ");
                string fileNamedUser = Console.ReadLine();
                generalJournal.SaveToFile(fileNamedUser);
                Console.WriteLine("Saving file...");
            }

        }

            

    }
}