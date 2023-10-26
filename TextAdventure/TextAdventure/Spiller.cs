using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Spiller
    {
        public string Name { get; }
        int HP = 10;

        public Spiller(string name)
        {
            Name = name;
        }
    }
}
