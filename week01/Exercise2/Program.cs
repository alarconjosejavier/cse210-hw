using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade porcentage (0-100)? ");
        int grade = int.Parse(Console.ReadLine());
        string letter;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade <= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your scores is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrutalions, you passed the class");
        }
        else
        {
            Console.WriteLine("Sorry, you needed at least 70 to pass the class");
        }
    }
}