using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public class Items
    {
        public static List<Items> items = new List<Items>
        {
            new Items("Sværd", "Et skarpt sværd du kan bruge til at beskytte dig selv.", 1),
            new Items("Sten", "En sten du kan bruge til BONKE folk.", 4),
            new Items("Sej Pind", "En pind der gør dig til den sejeste på lejepladsen!!!", 8),
            new Items("Drage Klinge", "Det er egentlig meget simpelt, det er det bedste våben", 1000)
        };
        public string Name { get; }
        public string Description { get; }
        public int Damage;

        public Items(string name, string description, int damage)
        {
            Name = name;
            Description = description;
            Damage = damage;
        }

    }
}
