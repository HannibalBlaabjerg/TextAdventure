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
            new Location("Skov", "Meget farlig skov."),
            new Location("Grotte", "Meget sort grotte."),
            new Location("Strand", "Meget sandet strand.")
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
