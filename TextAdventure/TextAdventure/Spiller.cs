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
        public int HP = 10;

        public Spiller(string name)
        {
            Name = name;
        }
        public void Angreb (Fjender enemy, Items våben)
        {
            Console.WriteLine("Du bruger dit våben til at slå ud efter " + enemy.Name);
            Console.WriteLine("Du rammer og gør " + våben.Damage +" skade");
            enemy.HP -= våben.Damage;

        }


    }
}
