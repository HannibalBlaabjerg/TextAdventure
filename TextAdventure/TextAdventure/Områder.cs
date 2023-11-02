using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    
     class Location
    {
        public List<Location> Avaliblelocations = new List<Location>();
         
        public string Name { get; }
        public string Description { get; }

        public Location(string name, string description)
        {
            Name = name;
            Description = description;



        }
    }





}
