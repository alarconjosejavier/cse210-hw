using System.Threading.Tasks.Dataflow;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _journals = new List<Entry>();

    public void AddJournal(Entry newEntry)
    {
        _journals.Add(newEntry);
        
    }

    public void DisplayJournals()
    {

        // printing of the elements of the list
        foreach (Entry e in _journals)
        {
            e.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        // note: I asked ChatGPT several time to fix issues becuase I used to have different issues with repiting
        // the same code because my error was put this foreach in the main.
        string filename = file;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _journals)
            {
                outputFile.WriteLine($"{e._date}~~{e._promptMessage}~~{e._entryMessage}");
            }
        }

    }

    public void LoadToFile(string file)
    {        
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        // At the beginning it was difficult to understand why it didn't run it becuase I was trying to use another foreach
        // to put everything in the list, so I asked ChatGPT for some ideas, finally, ChatGPT told me that I needed to
        // create a new objtech and then enter that information, I created the new variable and I remember that I had a function
        // to enter an object in the list, and it works.
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            string dateEntered = parts[0];
            string promptEntered = parts[1];
            string journalEntered = parts[2];

            Entry prompt1 = new();
            prompt1._date = dateEntered;
            prompt1._entryMessage = journalEntered;
            prompt1._promptMessage = promptEntered;

            AddJournal(prompt1);
        }
    }
}

