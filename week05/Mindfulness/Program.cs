using System;

class Program
{
    static void Main(string[] args)
    {
        int userOption = 0;

        while (userOption != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            userOption = int.Parse(Console.ReadLine());

            if (userOption == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }

            if (userOption == 2)
            {
                ReflectingActivity reflection = new();
                reflection.Run();
            }

            if (userOption == 3)
            {
                ListingActivity listing = new();
                listing.Run();
            }

            // I don't know if count as a extra show creativity but I added an else to force the user enter a correct number of the list
            else
            {
                Console.Clear();
                Console.WriteLine(" --- Please enter a corect number ---");
            }
        }
    }
}