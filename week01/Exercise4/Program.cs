using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<int> userList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        Console.Write("Enter number: ");
        int userInput = int.Parse(Console.ReadLine()); ;

        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            if (userInput != 0)
            {
                userList.Add(userInput);
            }
            userInput = int.Parse(Console.ReadLine());
        }
      
        Console.WriteLine($"The sum is: {userList.Sum()}");
        Console.WriteLine($"The average is: {userList.Average()}");
        Console.WriteLine($"The largest number is: {userList.Max()}");
    }
}