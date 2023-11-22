using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using TextAdventure;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Velkommen til Text baseret spil");
        Console.WriteLine("Tryk på en knap for at fortsætte");
        Console.ReadKey(true);
        Console.Clear();

        Console.WriteLine("Skriv dit navn:");
        string navn = Console.ReadLine();
        while(navn.Length <=1 && navn.Length >= 10)
        {
            Console.WriteLine("Dit navn skal være mellem 1 og 10 tegn");
            navn = Console.ReadLine();
        }
        Console.WriteLine("Dit navn er " + navn);
        Console.WriteLine("Tryk på en knap for at fortsætte");
        Console.ReadKey(true);
        Console.Clear();

        Spiller player = new Spiller(navn);
        
        // Create a list of locations
        List<Location> locations = new List<Location>
        {
            new Location("Skoven", "Meget farlig Skov."),
            new Location("Grotten", "Meget sort Grotte."),
            new Location("Stranden", "Meget sandet Strand.")

        };
        List<Location> locations1 = new List<Location>
        {
            new Location("By", "En meget fredelig by"),
            new Location("Flod", "En smuk flod inde i en skov"),
            new Location("Kloake", "Mikkels værelse"),


        };
        locations[0].Avaliblelocations.Add(locations[1]);


        // Start the game
        Console.WriteLine("Velkommen, " + navn + "!");
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
                Console.WriteLine("Ingen skejs til dig nørd, L, " + navn + "!");
                break;
            }
           

            // Explore the location
            Console.WriteLine("Du udforsker " + currentLocation.Name + " og finder en bunke med våben.");
            Console.WriteLine("hvilket våben vælger du");
            Console.WriteLine("1. Et Sværd");
            Console.WriteLine("2. En Sten");
            Console.WriteLine("3. En Sej Pind");
            int våbenvalg = GetChoice(1, 3);

            
            if(våbenvalg == 1)
            {
                Console.WriteLine("Du har valgt et " + Items.items[0].Name);
                Backpack.backpack.Add(Items.items[0]);
            }

            if(våbenvalg == 2)
            {
                Console.WriteLine("Du har valgt en " + Items.items[1].Name);
                Backpack.backpack.Add(Items.items[1]);
            }

            if(våbenvalg == 3)
            {
                Console.WriteLine("Du har valgt en " + Items.items[2].Name);
                Backpack.backpack.Add(Items.items[2]);
            }
           

            Console.WriteLine("Du går videre fra " + currentLocation.Name + " Hvor går du nu hen?");

            
            for (int i = 0; i < locations1.Count; i++)
            {
                Console.WriteLine(i + ". " + locations1[i].Name);
            }

            choice = GetChoice(0, locations1.Count - 1);
            Location currentLocation1 = locations1[choice];


            if(currentLocation1 == locations1[0])
            {
                Console.WriteLine("Du møder en " + Fjender.fjender[1].Name +". Hvad gør du");
            }

            while (true)
            {
                Console.WriteLine("1. Du angriber");
                Console.WriteLine("2. Du undviger");
                int angribsvalg = GetChoice(1, 2);

                if (angribsvalg == 1)
                {
                    player.Angreb(Fjender.fjender[1]);
                }

                if (angribsvalg == 2)
                {
                    player.Evade();
                    Fjender.fjender[1].angreb(player);
                }

                if (Fjender.fjender[1].HP > 0 && angribsvalg == 1)
                {
                    Console.WriteLine("Du angriber men slår ikke fjenden ihjel.");

                    Fjender.fjender[1].angreb(player);
                    Console.WriteLine("Prøv igen");
                }

             

                if (Fjender.fjender[1].HP <= 0)
                {
                    Console.WriteLine("Du slår fjenden ihjel.");
                    Console.ReadKey(true);
                    break;
                }
            }
            

        }
    }

    static int GetChoice(int min, int max)
    {
        int choice;
        while (true)
        {
            if (int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out choice) && choice >= min && choice <= max)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("DU HAR IKKE KORREKT. PRØV IGEN.");
            }
        }
    }
}

