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
            new Location("Forest", "A dense forest with tall trees and wildlife."),
            new Location("Cave", "A dark and mysterious cave entrance."),
            new Location("Beach", "A sandy beach with waves crashing on the shore.")

        };

        // Initialize the player
        Player player = new Player("Adventurer");

        // Start the game
        Console.WriteLine("Welcome, " + player.Name + "!");
        Console.WriteLine("You are on a quest to find the hidden treasure.");
        Console.WriteLine("Choose your path:");

        // Main game loop
        while (true)
        {
            Console.WriteLine("Locations:");
            for (int i = 0; i < locations.Count; i++)
            {
                Console.WriteLine(i + ". " + locations[i].Name);
            }

            int choice = GetChoice(0, locations.Count - 1);
            Location currentLocation = locations[choice];

            Console.WriteLine("You arrive at the " + currentLocation.Name + ".");
            Console.WriteLine(currentLocation.Description);

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Explore");
            Console.WriteLine("2. Quit");
            int action = GetChoice(1, 2);

            if (action == 2)
            {
                Console.WriteLine("Thanks for playing, " + player.Name + "!");
                break;
            }

            // Explore the location
            Console.WriteLine("You search the " + currentLocation.Name + " but find nothing.");
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