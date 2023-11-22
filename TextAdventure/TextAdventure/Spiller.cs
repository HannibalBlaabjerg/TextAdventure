using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventure;

namespace TextAdventure
{
    class Spiller
    {
        public string Name { get; }
        public int HP = 10;
        
        public bool evade = false;

        public Spiller(string name)
        {
            Name = name;
        }
        public void Angreb (Fjender enemy)
        {
            Console.WriteLine("Du bruger dit våben til at slå ud efter " + enemy.Name);
            Console.WriteLine("Du rammer og gør "+ Backpack.backpack[0].Damage +" skade");
            enemy.HP -= Backpack.backpack[0].Damage;
            
        }

        public void Evade()
        {
            Console.WriteLine("Du undviger");
            evade = true;
        }

    }
}
