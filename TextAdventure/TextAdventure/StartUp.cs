using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    internal class StartUp
    {
        string heroName;
        public StartUp(string heroName)
        {
            this.heroName = heroName;
        }

        public void Start()
        {
            Console.WriteLine("Dit navn er " + heroName);
        }
    }


}
