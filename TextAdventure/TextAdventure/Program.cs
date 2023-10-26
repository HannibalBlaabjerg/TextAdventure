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

        // Initialize the player
        Player player = new Player("Rejsene");

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
            Console.WriteLine("Du udforsker " + currentLocation.Name + " og finder 3 våben.");


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

class Location
{
    public string Name { get; }
    public string Description { get; }

    public Location(string name, string description)
    {
        Name = name;
        Description = description;
    }
}

class Player
{
    public string Name { get; }

    public Player(string name)
    {
        Name = name;
    }
    
}