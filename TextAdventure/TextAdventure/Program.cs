using System;
using System.Collections.Generic;
using TextAdventure;

class Program
{
    static void Main(string[] args)
    {
        
        // Create a list of locations
        List<Location> locations = new List<Location>
        {
            new Location("Skov", "Meget farlig Skov."),
            new Location("Grotte", "Meget sort Grotte."),
            new Location("Strand", "Meget sandet Strand.")

        };
        locations[0].Avaliblelocations.Add(locations[1]);

        // Initialize the player
        Spiller player = new Spiller("Rejsene");

        // Start the game
        Console.WriteLine("Velkommen, " + player.Name + "!");
        Console.WriteLine("Du er på en rejse for at få skejs.");
        Console.WriteLine("Vælg din vej:");

        // Main game loop
        while (true)
        {
            Console.WriteLine("Områder:");
            for (int i = 0; i < locations.Count; i++)
            {
                Console.WriteLine(i + ". " + locations[i].Name);
            }

            int choice = GetChoice(0, locations.Count - 1);
            Location currentLocation = locations[choice];

            Console.WriteLine("Du ankommer til " + currentLocation.Name + ".");
            Console.WriteLine(currentLocation.Description);

            Console.WriteLine("Hvad vil du?");
            Console.WriteLine("1. Udforske");
            Console.WriteLine("2. Forlade spillet");
            int action = GetChoice(1, 2);

            if (action == 2)
            {
                Console.WriteLine("Ingen skejs til dig nørd, L, " + player.Name + "!");
                break;
            }

            // Explore the location
            Console.WriteLine("Du udforsker " + currentLocation.Name + " og finder en bunke med våben.");
            Console.WriteLine("hvilket våben vælger du");
            Console.WriteLine("1. Et Sværd");
            Console.WriteLine("2. En Sten");
            Console.WriteLine("3. En Sej Pind");
            int våbenvalg = GetChoice(1, 3);
            


        }
    }

    static int GetChoice(int min, int max)
    {
        int choice;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= min && choice <= max)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
        }
    }
}

