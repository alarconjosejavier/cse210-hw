using System.Reflection.Metadata.Ecma335;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {

    }

    public void ShowInformation()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job j in _jobs)
        {
            // In this line ChatGTP helps me rewrite the line above and explained why it didn't work 
            // because I supposed not to call Console.Write because already the method did it!!
            // Algo gave me some hints to help me because I couldn't obtain the information inside the lists.
            //  Console.WriteLine(j.DisplayJobDetails()); (<-- the one that didn't work)
            j.DisplayJobDetails();
        }
    }
}

