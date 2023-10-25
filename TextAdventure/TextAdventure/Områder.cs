using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    internal class Location
    {
        public string Name { get; }
        public string Description { get; }

        public Location(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }





}
