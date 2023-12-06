using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    //Jeg starter med at lave en class til Items kaldet Items
    public class Items
    {
        //Jeg laver derefter en liste til mine Items der hedder items
        public static List<Items> items = new List<Items>
        {
            new Items("Sværd", " du kan bruge til at beskytte dig selv.", 1),
            new Items("Sten", " du kan bruge til BONKE folk.", 4),
            new Items("Sej Pind", " der gør dig til den sejeste på lejepladsen!!!", 8),
            new Items("Drage Klinge", " Det er egentlig meget simpelt, det er det bedste våben", 1000)
        };
        //Jeg laver en string variabel der hedder name
        public string Name;
        //Jeg laver en string der hedder describtion
        public string Description;
        //Jeg laver en int der hedder Damage
        public int Damage;

        //Jeg laver en constructor til klassen Items, hvor jeg bestemmer at items skal have
        //et navn, en describtion og en damage
        public Items(string name, string description, int damage)
        {
            //Her gør jeg så jeg kan bruge mine tidligere variabler i constructoren
            Name = name;
            Description = description;
            Damage = damage;
        }

    }
}
