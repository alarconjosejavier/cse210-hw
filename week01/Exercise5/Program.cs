using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Function to print the welcome message
        DisplayWelcome();
        // Function to print the result
        DisplayResult(PromptUserName(), PromptUserNumber());

        // Function to print a welcome message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // Function to ask and return name of the user.
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        // Function to ask and return the number of the user
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        // function to return a square of the parameter number
        static int SquareNumber(int number)
        {
            int result = number * number;
            return result;
        }

        // Function to print the last message.
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {SquareNumber(number)}");
        }
    }
   
}