﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{

    class Fjender
    {
        public string Name;
        public int HP;
        public int Skade;


        public static List<Fjender> fjender = new List<Fjender>
        {
            new Fjender("Rotte", 2, 1), //I kloak
            new Fjender("Bandit", 5, 3), //I by
            new Fjender("Krokodille",7,5), //I flod
            new Fjender("Drage", 15, 8) //I Borg

        };
        public Fjender (string name, int hp, int skade)
        {
            Name = name;
            HP = hp;
            Skade = skade;
        }
        public void angreb(Spiller target)
        {
            if (target.evade == false)
            {
                Console.WriteLine(Name + " angriber dig og gør " + Skade + " skade");
                target.HP -= Skade;
            }

            if(target.evade == true)
            {
                Console.WriteLine("Monsteret prøver at ramme dig, men ramte ikke");
                target.evade = false;
            }

        }



    }
}
