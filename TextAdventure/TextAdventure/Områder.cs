using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    
     class Location
    {
       public static List<Location> locations = new List<Location>
        {
            new Location("Forest", "A dense forest with tall trees and wildlife."),
            new Location("Cave", "A dark and mysterious cave entrance."),
            new Location("Beach", "A sandy beach with waves crashing on the shore.")
        };
        public string Name { get; }
        public string Description { get; }

        public Location(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }





}
